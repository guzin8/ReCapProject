--create table Colors(ColorId int identity(1,1), ColorName varchar(25),constraint pk_sira2 primary key(ColorId));

--create table Brands(BrandId int identity(1,1), BrandName varchar(25),constraint pk_sira primary key(BrandId));

--create table Cars(Id int identity(1,1),
--BrandId int,
--ColorId int,
--ModelYear int,
--Dailyprice decimal,
--Description varchar(30),
--constraint pk_sira3 primary key(Id),
--foreign key(BrandId) references Brands,
--foreign key(ColorId) references Colors);

--insert into Colors(ColorName) values
--('Kirmizi'),
--('Sari');

--insert into Brands(BrandName) values
--('Alfa Romeo'),
--('Audi');

--insert into Cars(BrandId,ColorId,ModelYear,Dailyprice,Description) values
--(1,1,2020,'200','Otomatik'),
--(2,2,2019,'100','Manuel');

--create table Users(UserId int identity(1,1),
--FirstName varchar(25),
--LastName varchar(25),
--Email varcHar(35),
--Password varchar(15),
--constraint pk_sira4 primary key(UserId));

--create table Customers(CustomerId int identity(1,1),
--UserId int,
--CustomerName varchar(35),
--foreign key(UserId) references Users(UserId),
--constraint pk_sira5 primary key(CustomerId));

--INSERT INTO Users(FirstName,LastName,Email,Password) VALUES
--	('Ali','Şahin','alisahin@email.com','ali2021'),
--	('Büşra','Yelkenli','busrayelkenli@gmail.com','busra2021'),
--	('Temel','Dursun','temeldursun@gmail.com','temel2021');

	--insert into Customers(UserId,CustomerName) values
	--(1,'Güzin'),
	--(2,'Nursima');

--	CREATE TABLE [dbo].[Rentals] (
--    [Id]         INT      IDENTITY (1, 1) NOT NULL,
--    [CarId]      INT      NULL,
--    [CustomerId] INT      NULL,
--    [RentDate]   DATETIME NULL,
--    [ReturnDate] DATETIME NULL,
--    PRIMARY KEY CLUSTERED ([Id] ASC),
--    FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([Id]),
--    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
--);

	insert into Rentals(CarId,CustomerId,RentDate,ReturnDate) values
	(1,1,'2021-01-15','2021-01-17'),
	(2,2,'2020-10-20','2020-10-21');