CREATE DATABASE DB_Blog --створення 
GO

drop DATABASE DB_Blog
drop table Article
drop table Users

USE DB_Blog
GO


select * from Users

CREATE TABLE Users(
	ID_User INT IDENTITY(1,1) PRIMARY KEY,
	Logins VARCHAR(25) NOT NULL,
	Fist_name VARCHAR(50),
	Surname VARCHAR(50),
	Passwords CHAR(12) NOT NULL,
	Date_of_birth DATE,
	IsAdmin bit DEFAULT 0,
	Gender varchar(10) NOT NULL CHECK (Gender IN('female', 'male')),
	Date_of_registration DATE NOT NULL,
	IsEnable bit DEFAULT 1
)

CREATE TABLE Article(
	Id int not null IDENTITY (1,1) PRIMARY KEY,
	AuthoreId int not null foreign key REFERENCES Users(ID_User),
	Title nvarchar(255) not null,
	CreationTime dateTime null,
	Content nvarchar(max) null,
	Published bit not null,
	Comment bit not null
)

CREATE TABLE Comment(
	Id int not null IDENTITY (1,1) PRIMARY KEY,
	AuthoreId int not null foreign key REFERENCES Users(ID_User),
	ArticleID int not null foreign key REFERENCES Article(Id),
	CreationTime dateTime null,
	Content nvarchar(max) null,
)
select * from Article
