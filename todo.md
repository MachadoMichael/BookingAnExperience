## todo


### Structs

[] owner { Id, Name, Email, Password }
[] customer { Id, Name, Email }
[] home { Id, Name, Localization, Bedroom, Guests, Price, CheckOutHour, CheckInHour, Description, Photos}
[] appointment { Id, HomeId, CreateAt, CheckIn, CheckOut, CustomerId, PaymentId }
[] payment {Id, Method, Status }
[] paymentMethod { Id, Owner, CPF }
[] paymentStatus { WAITING, PROCESSING, CONCLUDES } 
