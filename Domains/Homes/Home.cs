namespace BookingAnExperience.Domains.Homes
{
    public class Home
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid Localization { get; set; }
        public int Bedrooms { get; set; }
        public int Guests { get; set; }
        public double PricePerDay { get; set; }
        public string CheckOutHour { get; set; }
        public string CheckInHour { get; set; }
        public string Description { get; set; }
        public List<string> Photos { get; set; }

        public Home(
            string name,
            Guid localization,
            int bedrooms,
            int guests,
            double pricePerDay,
            string checkOutHour,
            string checkInHour,
            string description
        )
        {
            Id = new Guid();
            Name = name;
            Localization = localization;
            Bedrooms = bedrooms;
            Guests = guests;
            PricePerDay = pricePerDay;
            CheckInHour = checkInHour;
            CheckOutHour = checkOutHour;
            Description = description;
            Photos = new();
        }

        public void AddOnePhoto(string base64Photo)
        {
            Photos.Add(base64Photo);
        }
    }
}
