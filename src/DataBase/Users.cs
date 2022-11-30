namespace Program.DataBase
{
    public struct Users
    {
        public string Name { get; set; }
        public string Fac { get; set; }

        public Users(string name, string fac)
        {
            Name = name;
            Fac = fac;
        }
    }
}