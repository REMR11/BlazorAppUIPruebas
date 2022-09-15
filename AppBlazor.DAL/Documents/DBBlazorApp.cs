//DROP DATABASE BlazorApp
//GO

//CREATE DATABASE BlazorApp
//GO

//CREATE TABLE Category(
//	IdCategory INT NOT NULL PRIMARY KEY IDENTITY(1,1),
//	NameCategory NVARCHAR(50)
//)
//GO

//CREATE TABLE Expenses(
//	IdExpen INT NOT NULL PRIMARY KEY IDENTITY(1,1),
//	Amount DECIMAL(18,0) NOT NULL,
//	IdCategory INT NOT NULL,
//	ExpenseType NVARCHAR(30),
//	TransactionDate Date NOT NULL
//)
//GO

//ALTER TABLE Expenses
//ADD CONSTRAINT FK_EX_CATE
//FOREIGN KEY (IdCategory)
//REFERENCES Category(IdCategory)
//GO