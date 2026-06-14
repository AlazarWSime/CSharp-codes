CREATE table Student(
FirstName VARCHAR(15) NOT NULL,
LastName VARCHAR(15) NOT NULL,
Email VARCHAR(50) UNIQUE,
EnrolmentDate DATE
);
SELECT * FROM Student

INSERT INTO Student(FirstName, LastName, Email) VALUES ('John', 'Doe', 'john@example.com');


ALTER TABLE Student
ADD StudentID INT  NOT NULL
CONSTRAINT PK_Student PRIMARY KEY (StudentID)

ALTER TABLE Student
ADD StudentID INT

UPDATE Student SET StudentID = 1



UPDATE Student SET Email = 'newemail@gamil.com' WHERE StudentID = 1;


