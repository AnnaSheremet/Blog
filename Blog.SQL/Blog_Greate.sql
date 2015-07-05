CREATE DATABASE DB_Blog --створення 
GO

USE DB_Blog
GO

--Створення таблиць

CREATE TABLE Users(
	ID_User INT IDENTITY(1,1) PRIMARY KEY,
	Logins VARCHAR(25) NOT NULL,
	Fist_name VARCHAR(50),
	Surname VARCHAR(50),
	Passwords CHAR(12) NOT NULL,
	Date_of_birth DATE,
	roles VARCHAR(6) NOT NULL CHECK (roles IN('guest','user','admin')) DEFAULT 'user',
	Gender varchar(10) NOT NULL CHECK (Gender IN('female', 'male')),
	Date_of_registration DATE NOT NULL		)

