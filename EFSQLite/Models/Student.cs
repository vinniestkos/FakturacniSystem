namespace EFSQLite.Models
{
    public class Student
    {
        public int Id { get; set; } // PK pro databázovou tabulku

        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";   
        }
    }
}
