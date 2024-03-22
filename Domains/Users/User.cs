namespace BookingAnExperience.Domains.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Cpf { get; set; }
        public TypeOfUser Type { get; set; }

        public User(
            string name,
            string email,
            string password,
            string phone,
            string address,
            string cpf,
            TypeOfUser type
        )
        {
            Id = new Guid();
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            Cpf = cpf;
            Type = type;
        }
    }
}
