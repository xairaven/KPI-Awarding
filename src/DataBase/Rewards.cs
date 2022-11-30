namespace Program.DataBase
{ 
    public struct Rewards
        {
            public string Id{ get; set; }
            public string Name{ get; set; }
        
            public Rewards(string name, string id)
            {
                Name = name;
                Id = id;
            }
        }
}