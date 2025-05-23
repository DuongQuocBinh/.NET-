-- Xóa bảng Borrowings trước do có khóa ngoại
DROP TABLE Borrowings;
DROP TABLE Readers;
DROP TABLE Books;
DROP TABLE Users;
-- Bảng NgườiDung (Users)
CREATE TABLE NguoiDung (
    MaNguoiDung INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE,
    MatKhau NVARCHAR(100) NOT NULL,
    HoTen NVARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL CHECK (VaiTro IN (N'Admin', N'Nhân viên'))
)
GO

-- Bảng Sach (Books)
CREATE TABLE Sach (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    MaSoSach NVARCHAR(20) NOT NULL UNIQUE,
    TieuDe NVARCHAR(200) NOT NULL,
    TacGia NVARCHAR(100) NOT NULL,
    TheLoai NVARCHAR(50) NOT NULL,
    NamXuatBan INT NOT NULL,
    NhaXuatBan NVARCHAR(100) NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0
)
GO

-- Bảng DocGia (Readers)
CREATE TABLE DocGia (
    MaDocGia INT IDENTITY(1,1) PRIMARY KEY,
    MaSoDocGia NVARCHAR(20) NOT NULL UNIQUE,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    Lop NVARCHAR(50) NOT NULL,
    SoDienThoai NVARCHAR(15) NOT NULL,
    LoaiDocGia NVARCHAR(20) NOT NULL CHECK (LoaiDocGia IN (N'Sinh Viên', N'Giáo Viên'))
)
GO

-- Bảng PhieuMuon (Borrowings)
CREATE TABLE PhieuMuon (
    MaPhieuMuon INT IDENTITY(1,1) PRIMARY KEY,
    MaDocGia INT NOT NULL,
    MaSach INT NOT NULL,
    NgayMuon DATE NOT NULL,
    HanTra DATE NOT NULL,
    NgayTra DATE NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đang Mượn' CHECK (TrangThai IN (N'Đang Mượn', N'Đã Trả', N'Quá Hạn')),
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
)
GO

-- Thêm tài khoản Admin mặc định
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, VaiTro)
VALUES ('admin', 'admin123', N'Quản trị viên', N'Admin')
GO

-- Thêm tài khoản Nhân viên mặc định
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, VaiTro)
VALUES ('staff', 'staff123', N'Nhân viên thư viện', N'Nhân viên')
GO
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES
('admin1', 'admin123', N'Quản trị viên', N'Admin'),
('staff1', 'staff123', N'Nguyễn Văn A', N'Nhân viên'),
('staff2', 'staff456', N'Lê Thị B', N'Nhân viên'),
('admin2', 'admin456', N'Trần Quốc Cường', N'Admin'),
('nv3', '123456', N'Phạm Hữu Dũng', N'Nhân viên');
INSERT INTO Sach (MaSoSach, TieuDe, TacGia, TheLoai, NamXuatBan, NhaXuatBan, SoLuong) VALUES
('S001', N'Lập trình C# cơ bản', N'Nguyễn Văn Khoa', N'Giáo trình', 2020, N'NXB Giáo Dục', 10),
('S002', N'Thiết kế Web', N'Phạm Thị Mai', N'Tin học', 2019, N'NXB Trẻ', 8),
('S003', N'Cấu trúc dữ liệu', N'Lê Văn Hùng', N'Kỹ thuật', 2021, N'NXB Khoa Học', 5),
('S004', N'Toán cao cấp', N'Hoàng Thị Thu', N'Toán học', 2018, N'NXB Giáo Dục', 7),
('S005', N'Tiếng Anh giao tiếp', N'Nguyễn Thị Lan', N'Ngoại ngữ', 2022, N'NXB Tổng Hợp', 6);
INSERT INTO DocGia (MaSoDocGia, HoTen, NgaySinh, GioiTinh, Lop, SoDienThoai, LoaiDocGia) VALUES
('DG001', N'Trần Minh Khoa', '2002-05-20', N'Nam', 'CNTT1', '0912345678', N'Sinh Viên'),
('DG002', N'Lê Thị Hoa', '2001-11-10', N'Nữ', 'QTKD2', '0987654321', N'Sinh Viên'),
('DG003', N'Nguyễn Văn An', '1980-04-25', N'Nam', 'GV Khoa CNTT', '0909090909', N'Giáo Viên'),
('DG004', N'Phạm Thị Mai', '1995-09-12', N'Nữ', 'Kế toán', '0933333333', N'Giáo Viên'),
('DG005', N'Bùi Văn Nam', '2003-03-15', N'Nam', 'CNTT3', '0966666666', N'Sinh Viên');
INSERT INTO PhieuMuon (MaDocGia, MaSach, NgayMuon, HanTra, NgayTra, TrangThai) VALUES
(1, 1, '2024-05-01', '2024-05-15', NULL, N'Đang Mượn'),
(2, 2, '2024-04-10', '2024-04-24', '2024-04-22', N'Đã Trả'),
(3, 3, '2024-04-01', '2024-04-15', NULL, N'Quá Hạn'),
(4, 4, '2024-03-20', '2024-04-05', '2024-04-01', N'Đã Trả'),
(5, 5, '2024-05-05', '2024-05-19', NULL, N'Đang Mượn');