namespace BookingAnExperience.Domains.Appointments
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Guid HomeId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Guid CustomerId { get; set; }
        public Guid PaymentId { get; set; }

        public Appointment(
            Guid homeId,
            DateTime createAt,
            DateTime checkIn,
            DateTime checkOut,
            Guid customerId,
            Guid paymentId
        )
        {
            Id = new Guid();
            HomeId = homeId;
            CreateAt = createAt;
            CheckOut = checkOut;
            CheckIn = checkIn;
            CustomerId = customerId;
            PaymentId = paymentId;
        }
    }
}
