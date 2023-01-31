namespace Domain.Entites
{
    public class Capgemini
    {

        public Guid Id { get; set; }
        string Name { get; set; }
        string Country { get; set; }
        string City { get; set; }
        DateTime DateCreation { get; set; }

        public Capgemini()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Country= string.Empty;
            City = string.Empty;
            DateCreation = DateTime.Now;
        }

    }
}

