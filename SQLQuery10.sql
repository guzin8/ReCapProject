--create table Rentals(RentId int identity(1,1),
--CarId int,
--CustomerId int,
--RentDate datetime,
--ReturnDate datetime,
--constraint pk_sira8 primary key(RentId),
--foreign key(CarId) references Cars(Id),
--foreign key(CustomerId)references Customers(CustomerId));

insert into Rentals(CarId,CustomerId,RentDate,ReturnDate) values
	(1,1,'2020-10-05','2020-10-06'),
	(2,2,'2021-01-28','2021-01-30');