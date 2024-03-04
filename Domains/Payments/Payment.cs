namespace BookingAnExperience.Payments
{
    public class Payment
    {
        public Guid Id { get; set; }
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }

        public Payment(PaymentMethod method, PaymentStatus status)
        {
            Id = new Guid();
            Method = method;
            Status = status;
        }
    }
}
