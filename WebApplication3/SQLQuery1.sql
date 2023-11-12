CREATE DATABASE MyProductDB

GO
USE MyProductDB
GO

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Title NVARCHAR(50) NOT NULL
)

GO

CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	Price MONEY NOT NULL DEFAULT(0)
)

INSERT INTO Categories(Title)
VALUES('Category1');
INSERT INTO Categories(Title)
VALUES('Category2');
INSERT INTO Categories(Title)
VALUES('Category3');
INSERT INTO Categories(Title)
VALUES('Category4');

INSERT INTO Products([Name],Price)
VALUES('Product1',10);
INSERT INTO Products([Name],Price)
VALUES('Product2',20);
INSERT INTO Products([Name],Price)
VALUES('Product3',30);
INSERT INTO Products([Name],Price)
VALUES('Product4',40);