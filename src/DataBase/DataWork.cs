﻿using System.IO;

namespace Program.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.Data.SQLite;


    internal class DataWork
    {
        private static SQLiteConnection Connection;
        private static Dictionary<int, Users> UserList;
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
            string path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Rewards";
            string connectionString = @"Data Source=" + path + ";Version=3";

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

        public static void StopDB()
        {
            Connection.Close();
        }

        public static void ClearDB()
        {
            string sqlExpression = "DELETE FROM Users";
            var command = new SQLiteCommand(sqlExpression, Connection);
            command.ExecuteNonQuery();
            sqlExpression = "DELETE FROM RewardsAllNames";
            command.CommandText = sqlExpression;
            command.ExecuteNonQuery();
            sqlExpression = "DELETE FROM BadUsers";
            command.CommandText = sqlExpression;
            command.ExecuteNonQuery();
        }
        public static int Adduser(Users user)
        {
            int id = 0;
            string name = user.Name;
            int fac = user.Fac;

            string sqlExpression = "INSERT INTO Users (UserName, Fac) VALUES (" + "'" + name + "','" + fac.ToString() +
                                   "'" + ")";
            var command = new SQLiteCommand(sqlExpression, Connection);
            command.ExecuteNonQuery();
            //Console.WriteLine("Додано користувачів: {0}", number);

            sqlExpression = "SELECT MAX(Id) FROM  Users";
            command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
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
        public static void AddReward(Rewards reward1, Rewards reward2)
        {
            int id = 0;
            int id1 = 0;
            int c = 0;
            int y = 0;
            string rew = "";
            string year = "";
            string pred = "";
            string  prot2=" ";
            string sqlExpression;
            string sqlExpression1;
            int name1 = reward1.Name;
            int user = reward1.Id;
            int year1 = reward1.Year;
            string prot1 = reward1.Prot;
            int name2 = reward2.Name;
            int year2 = reward2.Year;
            if (name2 == 9)
            {
                prot2 = reward2.Prot;
            }
            
            else prot2 ="-";
            //Перевіряємо, чи є вже такий юзер в основній таблиці
            sqlExpression1 = "SELECT COUNT(User) FROM GoodUsers WHERE User=" + user.ToString();
            var command1 = new SQLiteCommand(sqlExpression1, Connection);
            SQLiteDataReader reader1 = command1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    c = reader1.GetInt32(0);
                }
            }
            command1.Cancel();
            reader1.Close();
            
            //Рахуємо скількм вже рядків є в основній таблиці
            sqlExpression = "SELECT COUNT(Id) FROM RewardsAllNames";
            var command = new SQLiteCommand(sqlExpression, Connection);
            command1 = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            id++;
            reader.Close();
            command.Cancel();
            
            //Рахуємо кількість рядків в иаблиці юзерів, котрі не підходять під умови
            sqlExpression = "SELECT COUNT(Id) FROM BadUsers";
            command = new SQLiteCommand(sqlExpression, Connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id1 = reader.GetInt32(0);
                }
            }
            id1++;
            reader.Close();
            command.Cancel();

            sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                            "'" + id.ToString() + "','" + user.ToString() + "','" +
                            name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() + "','" +
                            year2.ToString() + "','" + prot2 +"')";
            
            command.CommandText = sqlExpression;
            command = new SQLiteCommand(sqlExpression, Connection);
            
            //Первіряємо чи дві нагороди мають назву
            if (name1 != 0 && name2 != 0)
            {
                sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() + "','" +
                                year2.ToString() + "','" + prot2 +"')";
            }
            if ((year1 == 0 && year2 == 0) || (year1 != 0 && year2 != 0))
            {
                sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() + "','" +
                                year2.ToString() + "','" + prot2 +"')";
            }
            //Перевіряємо чи є назва у державної нагороди
            else if (name1 != 0 && year1!=0 && year2==0)
            {
                int lvl1 = name1 + 1;
                sqlExpression = "SELECT RewName FROM Rewards WHERE Id=" + lvl1.ToString();
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rew = reader.GetString(0);
                    }
                }
                reader.Close();
                command.Cancel();
                
                int yea = year1 + 1;
                sqlExpression = "SELECT Year FROM Years WHERE Id=" + yea.ToString();
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        year = reader.GetString(0);
                    }
                }
                reader.Close();
                command.Cancel();

                pred = "В " + year + " отримає " + rew;
                if (name1 == 7)
                {
                    pred = "Вже отримав найвищу гагороду";
                }
                if (year1 == 33)
                {
                    pred = "Вже не отримає нагороди у 2022 році";
                }
                sqlExpression =
                    "SELECT Reward FROM RewardsAllnames WHERE id=(SELECT max(Id) FROM RewardsAllNames WHERE (Reward <>" +0.ToString()+ " OR KPI<>"+0.ToString() +
                     ") AND User =" + user.ToString() + ")";
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int lvl2=0;
                        sqlExpression1 = "SELECT COUNT(Id) FROM RewardsAllNames WHERE User=" + user.ToString() +
                                         " AND (YRew=" + year1.ToString() + " OR YKPI=" + year1.ToString() + ")";
                        command1.CommandText = sqlExpression1;
                        command1 = new SQLiteCommand(sqlExpression1, Connection);
                        reader1 = command1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            while (reader1.Read())
                            {
                                y = reader1.GetInt32(0);
                            }
                        }

                        command1.Cancel();
                        reader1.Close();

                        if (y != 0)
                        {
                            sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                            "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                            name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                            "','" +
                                            year2.ToString() + "','" + prot2 + "')";
                            break;
                        }

                        var sqlExpression2 = "SELECT MAX(KPI) FROM RewardsAllNames WHERE User="+user.ToString();
                        var command2 = new SQLiteCommand(sqlExpression2, Connection);
                        object lvly=DBNull.Value;
                        SQLiteDataReader reader2 = command2.ExecuteReader();
                        {
                            if (reader2.HasRows)
                            {
                                while (reader2.Read())
                                {
                                    lvly = reader2.GetValue(0);
                                    if (lvly != DBNull.Value)
                                    {
                                        lvl2 = Convert.ToInt32(lvly); 
                                    }
                                }

                            }

                            object lvlt = reader.GetValue(0);
                            if (lvlt == DBNull.Value && lvly == DBNull.Value)
                            {
                                sqlExpression =
                                    "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                    "'" + id.ToString() + "','" + user.ToString() + "','" +
                                    name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                    "','" +
                                    year2.ToString() + "','" + prot2 + "','" + pred + "')";
                                if (c == 0)
                                {
                                    sqlExpression1 = "INSERT INTO GoodUsers(User) VALUES (" + user.ToString() + ")";
                                    command1 = new SQLiteCommand(sqlExpression1, Connection);
                                    command1.ExecuteNonQuery();
                                    command1.Cancel();
                                }

                                break;
                            }

                            int lvl = Convert.ToInt32(lvlt);
                            if (reward1.Name - lvl > 1 || lvl2!=11)
                            {
                                sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                                "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                                name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                                "','" +
                                                year2.ToString() + "','" + prot2 + "')";
                                break;
                            }

                            if (lvl2 == 11)
                            {
                                sqlExpression =
                                    "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                    "'" + id.ToString() + "','" + user.ToString() + "','" +
                                    name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                    "','" +
                                    year2.ToString() + "','" + prot2 + "','" + pred + "')";
                                break;
                            }
                            sqlExpression =
                                "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                "'" + id.ToString() + "','" + user.ToString() + "','" +
                                name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                "','" +
                                year2.ToString() + "','" + prot2 + "','" + pred + "')";
                        }
                    }
                }
                else
                {
                    sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                    "'" + id.ToString() + "','" + user.ToString() + "','" +
                                    name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                    "','" +
                                    year2.ToString() + "','" + prot2 + "','"+ pred +"')";
                    sqlExpression1 = "SELECT COUNT(Id) FROM RewardsAllNames WHERE User=" + user.ToString() +
                                     " AND (YRew=" + year1.ToString() + " OR YKPI=" + year1.ToString() + ")";
                    command1.CommandText = sqlExpression1;
                    command1 = new SQLiteCommand(sqlExpression1, Connection);
                    reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            y = reader1.GetInt32(0);
                        }
                    }

                    command1.Cancel();
                    reader1.Close();
                    if (y != 0)
                    {
                        sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                        "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                        name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                        "','" +
                                        year2.ToString() + "','" + prot2 + "')";
                    }
                    if (c == 0)
                    {
                        sqlExpression1 = "INSERT INTO GoodUsers(User) VALUES (" + user.ToString() + ")";
                        command1 = new SQLiteCommand(sqlExpression1, Connection);
                        command1.ExecuteNonQuery();
                        command1.Cancel();
                    }
                }
                
                reader.Close();
                command.Cancel();
            }
            //Перевіряємо чи є назва у нагороди виданою КПІ
            else if (name2 != 0 && year2!=0 && year1==0)
            {
                int lvl1 = name2 + 1;
                sqlExpression = "SELECT KPIName FROM KPI WHERE Id=" + lvl1.ToString();
                if (name2 == 11)
                {
                    sqlExpression = "SELECT RewName FROM Rewards WHERE Id=" + 1.ToString();
                }
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rew = reader.GetString(0);
                    }
                }
                reader.Close();
                command.Cancel();

                int yea = year2 + 1;
                sqlExpression = "SELECT Year FROM Years WHERE Id=" + yea.ToString();
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        year = reader.GetString(0);
                    }
                }
                reader.Close();
                command.Cancel();
                
                pred = "В " + year + " отримає " + rew;
                if (year2 == 33)
                {
                    pred = "Вже не отримає нагороди у 2022 році";
                }
                
                
                sqlExpression =
                    "SELECT KPI FROM RewardsAllnames WHERE id=(SELECT max(Id) FROM RewardsAllNames WHERE KPI <>" +
                    0.ToString() + " AND User =" + user.ToString() + ")";
                command.CommandText = sqlExpression;
                command = new SQLiteCommand(sqlExpression, Connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sqlExpression1 = "SELECT COUNT(Id) FROM RewardsAllNames WHERE User=" + user.ToString() +
                                         " AND (YRew=" + year2.ToString() + " OR YKPI=" + year2.ToString() + ")";
                        command1.CommandText = sqlExpression1;
                        command1 = new SQLiteCommand(sqlExpression1, Connection);
                        reader1 = command1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            while (reader1.Read())
                            {
                                y = reader1.GetInt32(0);
                            }
                        }

                        command1.Cancel();
                        reader1.Close();
                        if (y != 0)
                        {
                            sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                            "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                            name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                            "','" +
                                            year2.ToString() + "','" + prot2 + "')";
                            break;
                        }

                        object lvlt = reader.GetValue(0);
                        if (lvlt == DBNull.Value)
                        {
                            sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                            "'" + id.ToString() + "','" + user.ToString() + "','" +
                                            name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                            "','" +
                                            year2.ToString() + "','" + prot2 + "','" + pred +"')";
                            if (c == 0)
                            {
                                sqlExpression1 = "INSERT INTO GoodUsers(User) VALUES (" + user.ToString() + ")";
                                command1 = new SQLiteCommand(sqlExpression1, Connection);
                                command1.ExecuteNonQuery();
                                command1.Cancel();
                                c++;
                            }

                            break;
                        }

                        int lvl = Convert.ToInt32(lvlt);
                        if (reward2.Name - lvl > 1)
                        {
                            sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                            "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                            name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                            "','" +
                                            year2.ToString() + "','" + prot2 + "')";
                            break;
                        }

                        sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                        "'" + id.ToString() + "','" + user.ToString() + "','" +
                                        name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                        "','" +
                                        year2.ToString() + "','" + prot2 + "','" + pred + "')";
                    }
                }
                else
                {
                    sqlExpression = "INSERT INTO RewardsAllNames (Id,User,Reward,KPI,YRew,YKPI,Prot,Prediction) VALUES (" +
                                    "'" + id.ToString() + "','" + user.ToString() + "','" +
                                    name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                    "','" +
                                    year2.ToString() + "','" + prot2 + "','" + pred + "')";
                    sqlExpression1 = "SELECT COUNT(Id) FROM RewardsAllNames WHERE User=" + user.ToString() +
                                     " AND (YRew=" + year2.ToString() + " OR YKPI=" + year2.ToString() + ")";
                    command1.CommandText = sqlExpression1;
                    command1 = new SQLiteCommand(sqlExpression1, Connection);
                    reader1 = command1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            y = reader1.GetInt32(0);
                        }
                    }

                    command1.Cancel();
                    reader1.Close();
                    if (y != 0)
                    {
                        sqlExpression = "INSERT INTO BadUsers (Id,User,Reward,KPI,YRew,YKPI,Prot) VALUES (" +
                                        "'" + id1.ToString() + "','" + user.ToString() + "','" +
                                        name1.ToString() + "','" + name2.ToString() + "','" + year1.ToString() +
                                        "','" +
                                        year2.ToString() + "','" + prot2 + "')";
                    }
                    if (c == 0)
                    {
                        sqlExpression1 = "INSERT INTO GoodUsers(User) VALUES (" + user.ToString() + ")";
                        command1 = new SQLiteCommand(sqlExpression1, Connection);
                        command1.ExecuteNonQuery();
                        command1.Cancel();
                    }
                }

                reader.Close();
                command.Cancel();
            }


            command.CommandText = sqlExpression;
            command = new SQLiteCommand(sqlExpression, Connection);
            command.ExecuteNonQuery();
            //int number = command.ExecuteNonQuery();
            //RewardList.Add(reward);
            //Console.WriteLine("Добавлено нагород: {0}", number);
        }

        /*
         * Метод GetUsers використовується для виводу імені користувача та його факультету.
         */
        public static List<string[]> GetUsers()
        {
            List<string[]> list = new List<string[]>();
            string[] row = new string[2];
            string sqlExpression = "SELECT U.UserName, F.Fac FROM GoodUsers RE " +
                                   "INNER JOIN Users U ON RE.User=U.Id " +
                                   "INNER JOIN Facultets F ON U.Fac=F.Id";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
                while (reader.Read())
                {
                    row = new string[2];
                    string name = reader.GetString(0);
                    row[0] = name;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    list.Add(row);
                    //Console.WriteLine("{0}\t{1}",name,fac);
                }
            }

            return list;
        }

        /*
         * Меод GetusRewards використовується для повернення масиву в котрому знаходяться всі
         * поля для заповнювання таблиці з бази данних. int id - айді користовуча,
         * n - номер строки. Метод повертає одновимірний масив типу string довжиною в 6 символів. 
         */
        public static string[] GetUsRewards(int n)
        {
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.Id=" + n.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",user,fac,reward,kpi,yearR,yearK);
                }
            }

            return row;
        }
        
        
        
        public static string[] GetBadRewards(int n)
        {
            string[] row = new string[7];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot FROM BadUsers RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.Id=" + n.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
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
            if (reader.HasRows)
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
            if (reader.HasRows)
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
            string sqlExpression = "SELECT Fac FROM Facultets WHERE Id=" + "'" + id.ToString() + "'";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
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

        /*
         * Всі методи наведені далі шукають та зберігають в список одновимірних масивів
         * типу string інформацію по заданим полям та їх значенням
         */
        public static List<string[]> FindNum(string id)
        {
            var NumInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.Id=" + id;

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    NumInfo.Add(row);
                }
            }

            return NumInfo;
        }
        
        public static List<string[]> FindUser(int id)
        {
            var UserInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.User=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    UserInfo.Add(row);
                }
            }

            return UserInfo;
        }

        public static List<string[]> FindFac(int id)
        {
            var FacInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE U.Fac=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    FacInfo.Add(row);
                }
            }

            return FacInfo;
        }

        public static List<string[]> FindRew(int id)
        {
            var RewInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.Reward=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    RewInfo.Add(row);
                }
            }

            return RewInfo;
        }

        public static  List<string[]> FindKPI(int id)
        {
            var KPIInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.KPI=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    KPIInfo.Add(row);
                }
            }

            return KPIInfo;
        }
        
        public static List<string[]> FindProt(string protoc)
        {
            var ProtInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.Prot=" + protoc;

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    ProtInfo.Add(row);
                }
            }

            return ProtInfo;
        }
        public static List<string[]> FindYRew(int id)
        {
            var YrewInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.YRew=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    YrewInfo.Add(row);
                }
            }

            return YrewInfo;
        }
        public static List<string[]> FindYKPI(int id)
        {
            var YKPIInfo = new List<string[]>();
            string[] row = new string[8];
            string sqlExpression =
                "SELECT U.Username,F.Fac,R.RewName,Y.Year,K.KPIName,Y1.Year,RE.Prot,RE.Prediction FROM RewardsAllNames RE " +
                "INNER JOIN Users U ON U.Id=RE.User " +
                "INNER JOIN Facultets F ON U.Fac=F.Id " +
                "LEFT JOIN Years Y ON RE.YRew=Y.Id " +
                "LEFT JOIN Years Y1 ON RE.YKPI=Y1.Id " +
                "LEFT JOIN Rewards R ON RE.Reward=R.Id " +
                "LEFT JOIN KPI K ON RE.KPI=K.Id " +
                "WHERE RE.YKPI=" + id.ToString();

            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = new string[8];
                    string user = reader.GetString(0);
                    row[0] = user;
                    string fac = reader.GetString(1);
                    row[1] = fac;
                    string reward = reader.GetString(2);
                    row[3] = reward;
                    string yearR = reader.GetString(3);
                    row[6] = yearR;
                    string yearK = reader.GetString(5);
                    row[5] = yearK;
                    string kpi = reader.GetString(4);
                    row[2] = kpi;
                    string prot = reader.GetString(6);
                    row[4] = prot;
                    string pred = reader.GetString(7);
                    row[7] = pred;
                    YKPIInfo.Add(row);
                }
            }

            return YKPIInfo;
        }
        

        public static int GetBadNum()
        {
            int n = 0;
            string sqlExpression = "SELECT COUNT(Id) FROM BadUsers ";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    n = reader.GetInt32(0);
                }
            }

            return n;
        }

        public static int GetRewdNum()
        {
            int n = 0;
            string sqlExpression = "SELECT COUNT(Id) FROM RewardsAllNames ";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    n = reader.GetInt32(0);
                }
            }

            return n;
        }

        public static List<string> GetFacs()
        {
            var Facs = new List<string>();
            string sqlExpression = "SELECT Fac FROM Facultets";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string fac = reader.GetString(0);
                    Facs.Add(fac);
                }
            }
            return Facs;
        }
        
        public static List<string> GetYears()
        {
            var Years = new List<string>();
            string sqlExpression = "SELECT Year FROM Years";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string year = reader.GetString(0);
                    Years.Add(year);
                }
            }
            return Years;
        }
        
        public static List<string> GetRews()
        {
            var Rews = new List<string>();
            string sqlExpression = "SELECT RewName FROM Rewards";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string rew = reader.GetString(0);
                    Rews.Add(rew);
                }
            }
            return Rews;
        }
        
        public static List<string> GetKPI()
        {
            var KPI = new List<string>();
            string sqlExpression = "SELECT KPIName FROM KPI";
            var command = new SQLiteCommand(sqlExpression, Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string kpi = reader.GetString(0);
                    KPI.Add(kpi);
                }
            }
            return KPI;
        }
        
    }
}
        
