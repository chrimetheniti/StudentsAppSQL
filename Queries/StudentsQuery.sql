USE StudentsAppSQL;
GO

CREATE TABLE Students (
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)
GO

INSERT INTO Students (FirstName, LastName) VALUES 
('John', 'Doe'),
('Jane', 'Smith'),
('Michael', 'Johnson')
