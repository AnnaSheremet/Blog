USE DB_Blog
GO

INSERT INTO Users
VALUES ('Sher', 'Anna', 'Sheremet', '123456', NULL, 'admin', 'female', '27-06-2015' ),
	   ('AA', 'AAA', 'AAAAA', '123456', '26-07-1990', 'user', 'male', '28-06-2015' ),
	   ('BB', 'BBB', 'BBBBB', '123456', '02-09-1980', 'user', 'male', '28-06-2015' );

INSERT INTO Aticle
VALUES ( 1, 'Sport', GETDATE(), NULL, 1, 1),
	   ( 2, 'Food', GETDATE(), NULL, 0, 1),
	   ( 2, 'Погода', GETDATE(), NULL, 1, 1),
	   ( 3, 'Моє місто', GETDATE(), NULL, 1, 1);
