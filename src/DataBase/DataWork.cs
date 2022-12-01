using System.IO;

namespace Program.DataBase
{ 
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;

    
    internal class DataWork
    {
        private static SQLiteConnection Connection;
        private static Dictionary<int,Users> UserList;
        private static Dictionary<int, Rewards> RewardList;

            /*public static void Main(string[] args)
        {
            RunDB();
            UserCodeList = new Dictionary<int, Users>();
            RewardList = new List<Rewards>();
            var user1 = new Users("Artem",1);
            var rew1 = new Rewards(18); // подумать над кавычками
            rew1.Name = 5;
            rew1.Prot = 2345;
            rew1.Year = 11;
            var rew2 = new Rewards(18); 
            
            UserCodeList.Add(Adduser(user1), user1);
            AddReward(rew1,rew2,2);
            //AddReward(rew1);
            //GetUsers();
            //GetFac(1);
            GetUsRewards(18, 1);
        }*/

        public static void RunDB()
                {
                    //string connectionString = @"Data Source=C:\Users\Артём\RiderProjects\ConsoleApplication1\ConsoleApplication1\Rewards;Version=3";
                    string path = Directory.GetCurrentDirectory() +Path.DirectorySeparatorChar+"Rewards";
                    string connectionString = @"Data Source="+path +";Version=3";
        
                    Connection = new SQLiteConnection(connectionString);
                    try
                    {
                        Connection.Open();
                        //Console.WriteLine("Підключення відкрито");
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
        
                public static int Adduser(Users user)
                {
                    int id = 0;
                    string name = user.Name;
                    int fac = user.Fac;
                    
                    string sqlExpression = "INSERT INTO Users (UserName, Fac) VALUES ("  + "'" + name +"','" + fac.ToString() + "'" + ")";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    int number = command.ExecuteNonQuery();
                    //Console.WriteLine("Додано користувачів: {0}", number);
                    
                    sqlExpression = "SELECT MAX(Id) FROM  Users";
                    command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        while (reader.Read()) 
                        {
                            id = reader.GetInt32(0);
                            //Console.WriteLine(id);
                        }
                    }
                    
                    return id;
                }
        
                /*
                 * Метод AddReward використовується для додавання однієї або декількох нагород
                 * вже створеному ккористувачу. Rewards - структура для збереження даних про нагороди.
                 * reward1 - державна нагорода, reward2 - нагорода КПІ. int id - айді користувача котрому
                 * додаються нагороди.
                 */
                public static void AddReward(Rewards reward1,Rewards reward2,int id)
                {
                    int name1 = reward1.Name;
                    int user = reward1.Id;
                    int year1 = reward1.Year;
                    int prot1 = reward1.Prot;
                    
                    int name2 = reward2.Name;
                    int year2 = reward2.Year;
                    int prot2 = reward2.Prot;
                    
                    string sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI) VALUES ("  + 
                                           "'" + id.ToString() +"','" + user.ToString() + "','" +
                                           name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() + "','" + year2.ToString() + "'" + ")";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    int number = command.ExecuteNonQuery();
                    //RewardList.Add(reward);
                    //Console.WriteLine("Добавлено нагород: {0}", number);
                }
                /*
                 * Метод GetUsers використовується для виводу всіх користувачів.
                 */
                public static void GetUsers()
                {
                    string sqlExpression = "SELECT U.Username,F.Fac FROM Users U INNER JOIN Facultets F ON U.Fac=F.ID";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string fac = reader.GetString(1);
                            //Console.WriteLine("{0}\t{1}",name,fac);
                        }
                    }
                }
        
                /*
                 * Меод GetusRewards використовується для повернення масиву в котрому знаходяться всі
                 * поля для заповнювання таблиці з бази данних. int id - айді користовуча,
                 * n - номер строки. Метод повертає одновимірний масив типу string довжиною в 6 символів. 
                 */
                public static string[] GetUsRewards(int id,int n)
                {
                    string[] row = new string[6];
                    string sqlExpression = "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year FROM RewardsAllNames RE " +
                                           "INNER JOIN Users U ON U.Id=RE.User " +
                                           "INNER JOIN Facultets F ON U.Fac=F.Id " +
                                           "LEFT JOIN Years Y ON RE.YRew=Y.Id "+
                                           "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                                           "LEFT JOIN Rewards R ON RE.Reward=R.Id "+
                                           "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                                           "WHERE RE.Id=" + n.ToString()  + " AND RE.User=" + id.ToString() ;
                    
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            string user = reader.GetString(0);
                            row[0] = user;
                            string fac = reader.GetString(1);
                            row[1] = fac;
                            string reward = reader.GetString(2);
                            row[2] = reward;
                            string yearR = reader.GetString(3);
                            row[3] = yearR;
                            string yearK = reader.GetString(4);
                            row[4] = yearK;
                            string kpi = reader.GetString(5);
                            row[5] = kpi;
                            //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",user,fac,reward,kpi,yearR,yearK);
                        }
                    }
        
                    return row;
                }
                
                /*
                 * Метод GetIdFac використовується для пошуку id факультету по назві.
                 */
                public static int GetIdFac(string facul)
                {
                    int id = 0;
                    string sqlExpression = "SELECT * FROM Facultets WHERE Fac=" + "'" + facul + "'";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        //Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read()) 
                        { 
                            id = reader.GetInt32(0);
                                //Console.WriteLine("{0}", id);
                        }
                    }
        
                    return id;
                }
                /*
                 * Метод GetIdUser використовується для пошуку id користувача по назві.
                 */
                public static int GetIdUser(string name)
                {
                    int id = 0;
                    string sqlExpression = "SELECT * FROM Users WHERE Username=" + "'" + name + "'";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        while (reader.Read()) 
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                    
                    return id;
                }
        
                /* public static int GetIdReward(string rew)
                {
                    int id = 0;
                    string sqlExpression = "SELECT * FROM RewardsAllNames WHERE Name=" + "'" + rew + "'";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        while (reader.Read()) 
                        {
                            id = reader.GetInt32(0);
                        }
                    }
                    
                    return id;
                }*/
                
                /*
                 * Метод GetFac використовується для пошуку назви факультета за його id.
                 */
                public static string GetFac(int id)
                {
                    string fac = "";
                    string sqlExpression = "SELECT Fac FROM Facultets WHERE Id="+"'"+id.ToString()+"'";
                    var command = new SQLiteCommand(sqlExpression, Connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if(reader.HasRows) 
                    {
                        //Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                        while (reader.Read()) 
                        { 
                             fac = reader.GetString(0);
                            //Console.WriteLine("{0}", fac);
                        }
                    }
        
                    return fac;
                }
    }
}
