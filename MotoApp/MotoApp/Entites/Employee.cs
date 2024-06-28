namespace MotoApp.Entites
{
    public class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public Employee(string firstname)
        {
            FirstName = firstname;
        }

        public override string ToString() => $"Employee Id: {Id}, FirstName: {FirstName}";
    }
}
