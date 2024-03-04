using BookingAnExperience.Localizations;

namespace BookingAnExperience.Homes
{
    public class Home
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Localization Address { get; set; }
        public int Bedrooms { get; set; }
        public int Guests { get; set; }
        public double PricePerDay { get; set; }
        public string CheckOutHour { get; set; }
        public string CheckInHour { get; set; }
        public string Description { get; set; }
        public List<string> Photos { get; set; }

        public Home(
            string name,
            Localization address,
            int bedrooms,
            int guests,
            double pricePerDay,
            string checkedOutHour,
            string checkInHour,
            string description
            )
        {
            Id = new Guid();
            Name = name;
            Address = address;
            Bedrooms = bedrooms;
            Guests = guests;
            PricePerDay = pricePerDay;
            CheckInHour = checkInHour;
            CheckOutHour = checkedOutHour;
            Description = description;
            Photos = new();
        }

        public void AddOnePhoto(string base64Photo)
        {
            Photos.Add(base64Photo);
        }
    }
}
