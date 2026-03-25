
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Students')
CREATE TABLE Students (
    StudentID   INT PRIMARY KEY IDENTITY(1,1),
    FullName    NVARCHAR(100) NOT NULL,
    Age         INT,
    Gender      NVARCHAR(10),
    ClassName   NVARCHAR(20),
    Phone       NVARCHAR(15),
    CreatedAt   DATETIME DEFAULT GETDATE()
);

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Attendance')
CREATE TABLE Attendance (
    AttendanceID  INT PRIMARY KEY IDENTITY(1,1),
    StudentID     INT FOREIGN KEY REFERENCES Students(StudentID),
    AttDate       DATE NOT NULL,
    Status        NVARCHAR(10) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Marks')
CREATE TABLE Marks (
    MarkID      INT PRIMARY KEY IDENTITY(1,1),
    StudentID   INT FOREIGN KEY REFERENCES Students(StudentID),
    Subject     NVARCHAR(50),
    Score       FLOAT,
    ExamType    NVARCHAR(20)
);