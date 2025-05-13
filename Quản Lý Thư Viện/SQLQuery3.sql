CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Staff'))
)
GO

-- Bảng Books (Sách)
CREATE TABLE Books (
    BookID INT IDENTITY(1,1) PRIMARY KEY,
    BookCode NVARCHAR(20) NOT NULL UNIQUE,
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    PublishYear INT NOT NULL,
    Publisher NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL DEFAULT 0
)
GO

-- Bảng Readers (Độc giả)
CREATE TABLE Readers (
    ReaderID INT IDENTITY(1,1) PRIMARY KEY,
    ReaderCode NVARCHAR(20) NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Class NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(15) NOT NULL,
    ReaderType NVARCHAR(20) NOT NULL CHECK (ReaderType IN ('Student', 'Teacher', 'Staff'))
)
GO

-- Bảng Borrowings (Phiếu mượn)
CREATE TABLE Borrowings (
    BorrowingID INT IDENTITY(1,1) PRIMARY KEY,
    ReaderID INT NOT NULL,
    BookID INT NOT NULL,
    BorrowDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Borrowed' CHECK (Status IN ('Borrowed', 'Returned', 'Overdue')),
    FOREIGN KEY (ReaderID) REFERENCES Readers(ReaderID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
)
GO

-- Insert default admin user
INSERT INTO Users (Username, Password, FullName, Role)
VALUES ('admin', 'admin123', 'Administrator', 'Admin')
GO

-- Insert default staff user
INSERT INTO Users (Username, Password, FullName, Role)
VALUES ('staff', 'staff123', 'Staff Member', 'Staff')
GO