USE DB_Blog
GO

INSERT INTO Users
VALUES ('Sher', 'Anna', 'Sheremet', '123456', NULL, 1, 'female', '27-06-2015', 1 ),
	   ('AA', 'AAA', 'AAAAA', '123456', '26-07-1990', 0, 'male', '28-06-2015', null ),
	   ('BB', 'BBB', 'BBBBB', '123456', '02-09-1980', null, 'male', '28-06-2015', null );

INSERT INTO Article
VALUES ( 1, 'Sport', GETDATE(), NULL, 1, 1),
	   ( 2, 'Food', GETDATE(), NULL, 0, 1),
	   ( 2, 'Погода', GETDATE(), NULL, 1, 1),
	   ( 3, 'Моє місто', GETDATE(), NULL, 1, 1);


INSERT INTO Article
VALUES ( 1, 'Sport', GETDATE(), 'ljhvjhvljhvljhvljhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhvly hvviv', 1, 1),
	   ( 2, 'Food', GETDATE(), 'bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb bbjhbjjjjjjjjjjjjjjjjjjjj', 0, 1);
	