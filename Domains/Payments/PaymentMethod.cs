namespace BookingAnExperience.Payments
{
    public class PaymentMethod
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Cpf { get; set; }

        public PaymentMethod(Guid userId, string cpf)
        {
            Id = new Guid();
            UserId = userId;
            Cpf = cpf;
        }
    }
}
