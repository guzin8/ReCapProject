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

insert into Cars(BrandId,ColorId,ModelYear,Dailyprice,Description) values
(1,1,2020,'200','Otomatik'),
(2,2,2019,'100','Manuel');