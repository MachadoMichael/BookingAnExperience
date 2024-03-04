## todo


### Structs

[x] user { Id, Name, Email, Password, Phone, Address, Cpf, Type }
[x] home { Id, Name, Localization, Bedroom, Guests, Price, CheckOutHour, CheckInHour, Description, Photos}
[x] appointment { Id, HomeId, CreateAt, CheckIn, CheckOut, CustomerId, PaymentId }
[x] payment {Id, Method, Status }
[x] paymentMethod { Id, UserId, CPF }
[x] paymentStatus { WAITING, PROCESSING, CONCLUDES } 
