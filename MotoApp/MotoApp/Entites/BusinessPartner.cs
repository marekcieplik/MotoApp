namespace MotoApp.Entites
{
    public class BusinessPartner : EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Partner Id: {Id}, Name: {Name}";
    }
}
