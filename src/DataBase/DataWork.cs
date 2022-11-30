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
            UserList = new Dictionary<int, Users>();
            var user1 = new Users("Artem","ІАТЕ");
            var rew1 = new Rewards("Почесне звання Заслужений діяч науки і техніки України", "Artem"); // подумать над кавычками
            UserList.Add(Adduser(user1), user1);
            AddReward(rew1);
        }*/

        public static void RunDB()
        {
            string connectionString = @"Data Source=C:\Users\Артём\RiderProjects\ConsoleApplication1\ConsoleApplication1\Rewards;Version=3";
            //string path = Directory.GetCurrentDirectory() +Path.DirectorySeparatorChar+"Rewards";

            Connection = new SQLiteConnection(connectionString);
            try
            {
                Connection.Open();
                Console.WriteLine("Підключення відкрито");
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int Adduser(Users user)
        {
            string name = user.Name;
            int fac = GetIdFac(user.Fac);
            string sqlExpression = "INSERT INTO Users (UserName, Fac) VALUES ("  + "'" + name +"','" + fac.ToString() + "'" + ")";
            var command = new SQLiteCommand(sqlExpression, Connection);
            
            
            return GetIdUser(name);
        }

        public static void AddReward(Rewards reward)
        {
            int name = GetIdReward(reward.Name);
            int user = GetIdUser(reward.Id);
            string sqlExpression = "INSERT INTO Rewards (Id, NameRew) VALUES ("  + "'" + user.ToString() +"','" + name.ToString() + "'" + ")";
            var command = new SQLiteCommand(sqlExpression, Connection);
            
        }

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

        public static int GetIdReward(string rew)
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
        }
    }
}
