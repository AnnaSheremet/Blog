CREATE DATABASE DB_Blog --створення 
GO

USE DB_Blog
GO

CREATE TABLE Users(
	ID_User INT IDENTITY(1,1) PRIMARY KEY,
	Logins VARCHAR(25) NOT NULL,
	Fist_name VARCHAR(50),
	Surname VARCHAR(50),
	Passwords CHAR(12) NOT NULL,
	Date_of_birth DATE,
	roles VARCHAR(6) NOT NULL CHECK (roles IN('user','admin')) DEFAULT 'user',
	Gender varchar(10) NOT NULL CHECK (Gender IN('female', 'male')),
	Date_of_registration DATE NOT NULL	
)

CREATE TABLE Aticle(
	Id int not null IDENTITY (1,1) PRIMARY KEY,
	AuthoreId int not null foreign key REFERENCES Users(ID_User),
	Title nvarchar(255) not null,
	CreationTime dateTime null,
	Content nvarchar(max) null,
	Published bit not null,
	Comment bit not null
)