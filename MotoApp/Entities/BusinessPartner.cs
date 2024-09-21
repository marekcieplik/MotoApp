namespace MotoApp.Entities
{
    public class BusinessPartner : EntityBase
    {
        public string? FirstName { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, First name: {FirstName}";
        }
    }
}
