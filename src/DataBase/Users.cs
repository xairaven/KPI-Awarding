namespace Program.DataBase
{
    public struct Users
    {
        public string Name { get; set; }
        public int Fac { get; set; }

        public Users(string name, int fac)
        {
            Name = name;
            Fac = fac;
        }
    }
}