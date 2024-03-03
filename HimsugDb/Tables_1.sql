Create Database HimsugDB
use HimsugDB
select * from Person
select * from Accounts

update Person set AccountsID = '1' where PersonID = '1'

delete from Person where PersonID = '2'

Create table Person (
	PersonID int identity (1,1) Primary Key,
	Fname varchar(50),
	Mname varchar(50),
	Lname varchar(50),
	Email varchar(60),
	Gender varchar(50),
	[Address]  varchar(50),
	Contact_Num varchar(50),
	Bdate date,
	AccountsID int Foreign Key references Accounts(AccountsID)

);

CREATE TABLE Accounts (
AccountsID int identity (1,1),
Username varchar (50),
[Password] varchar(MAX),
Access_Level varchar (10),
constraint AccountsPK primary key(AccountsID)
);


CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY identity (001130, 1),
    SupplierName VARCHAR(255),
	[Address] VARCHAR(255), 
	ContactNumber VARCHAR(20),
	ItemName VARCHAR(255),
	Price Decimal(10,2),
	TotalOrderItems INT,
	TotalCost INT,
	DateAdded date,
	PackageDeliveredDate Date,
	is_deleted BIT NOT NULL DEFAULT 0
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY identity (002230, 1),
    ProductName VARCHAR(255),
	Unit VARCHAR(255),
    UnitPrice DECIMAL(10, 2),
    QuantityInStock INT,
	ArrivalDate DATE,
    ExpirationDate DATE,
    SupplierID INT,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
	is_deleted BIT NOT NULL DEFAULT 0
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY identity (003330, 1),
    CustomerName VARCHAR(255),
    Cus_Address VARCHAR(255),
    Phone VARCHAR(20),
	Unit VARCHAR(255),
	UnitPrice DECIMAL(10, 2),
	TotalCost INT,
	TotalOrderItems INT,
	DateOrdered date,
	PlannedDelivery Date,
	ProductID INT,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	is_deleted BIT NOT NULL DEFAULT 0

);

CREATE TABLE Drivers (
    PlateNo INT PRIMARY KEY,
    DriverName VARCHAR(255),
    ContactNumber VARCHAR(20),
	DeliveryDate date,
	CustomerID INT,
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
	ProductID INT,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	is_deleted BIT NOT NULL DEFAULT 0

);




