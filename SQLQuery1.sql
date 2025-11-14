
CREATE DATABASE QLSanPham
GO
USE QLSanPham
GO
CREATE TABLE DMChatLieu
(
    MaChatLieu NVARCHAR(10) PRIMARY KEY NOT NULL,
    TenChatLieu NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE DMHang
(
    MaHang NVARCHAR(10) PRIMARY KEY NOT NULL,
    TenHang NVARCHAR(100) NOT NULL,
    MaChatLieu NVARCHAR(10), 
    SoLuong FLOAT NOT NULL,
    DonGiaNhap FLOAT NOT NULL,
    DonGiaBan FLOAT NOT NULL,
    Hinh NVARCHAR(255), 
    GhiChu NVARCHAR(200) 
)
GO
ALTER TABLE DMHang 
ADD CONSTRAINT FK_Hang_ChatLieu 
FOREIGN KEY (MaChatLieu) 
REFERENCES DMChatLieu(MaChatLieu)
GO

INSERT INTO DMChatLieu (MaChatLieu, TenChatLieu)
VALUES
('CL01', N'Vải cotton'),
('CL02', N'Gỗ sồi'),
('CL03', N'Nhựa ABS'),
('CL04', N'Sắt'),
('CL05', N'Gốm sứ')
GO
INSERT INTO DMHang (MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Hinh, GhiChu)
VALUES
('H01', N'Áo sơ mi nam', 'CL01', 150, 180000, 250000, '', N'Hàng mới về'),
('H02', N'Bàn làm việc', 'CL02', 50, 1200000, 1800000, '', N'Gỗ sồi tự nhiên'),
('H03', N'Lego Siêu nhân', 'CL03', 200, 350000, 500000, '', N'An toàn cho trẻ em'),
('H04', N'Chảo chống dính', 'CL04', 100, 220000, 300000, '', N'Phủ 3 lớp'),
('H05', N'Bộ ấm trà', 'CL05', 80, 400000, 650000, '', N'Hàng Bát Tràng')
GO

PRINT N'Tạo CSDL, Bảng và chèn dữ liệu mẫu thành công!'