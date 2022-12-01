namespace Program.DataBase
{ 
    public struct Rewards
        {
            public int Id{ get; set; }
            public int Name{ get; set; }
            public int Year { get; set; }
            public int Prot { get; set; }
            public Rewards(int id)
            {
                Name = 0;
                //Id = id;
                //Year = year;
                // Prot = protocol;
                Id = id;
                Year = 0;
                Prot = 0;
            }
        }
}