using BookingAnExperience.Context;
using BookingAnExperience.Domains.Appointments;
using BookingAnExperience.Domains.Homes;
using BookingAnExperience.Domains.Localizations;
using BookingAnExperience.Domains.Payments;
using BookingAnExperience.Domains.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<ILocalizationService, LocalizationService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder
    .Services.AddEntityFrameworkNpgsql()
    .AddDbContext<BookingAnExperienceContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DatabaseConnection"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
