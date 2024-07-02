namespace MotoApp.Entites
{
    public class Employee : EntityBase
    {
        // removed to base class
        // public int Id { get; set; }

        public string? FirstName { get; set; }
        
        public Employee()
        {

        }

        public Employee(string firstname)
        {
            FirstName = firstname;
        }

        public override string ToString() => $"Employee Id: {Id}, FirstName: {FirstName}";
    }
}
