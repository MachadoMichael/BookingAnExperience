namespace BookingAnExperience.Localizations
{
    public class Localization
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Details { get; set; }
        public string Country { get; set; }
        public string District { get; set; }

        public Localization(string street, int number, string details, string country, string district)
        {
            Id = new Guid();
            Street = street;
            Number = number;
            Details = details;
            Country = country;
            District = district;
        }
    }
}
