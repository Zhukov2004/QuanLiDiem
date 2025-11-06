-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2025 at 05:57 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qldiemsinhvien`
--

-- --------------------------------------------------------

--
-- Table structure for table `canhbaohoctap`
--

CREATE TABLE `canhbaohoctap` (
  `MaSV` varchar(10) NOT NULL,
  `NamHoc` varchar(20) NOT NULL,
  `HocKy` varchar(10) NOT NULL,
  `LyDo` varchar(255) DEFAULT NULL,
  `NgayCanhBao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `canhbaohoctap`
--

INSERT INTO `canhbaohoctap` (`MaSV`, `NamHoc`, `HocKy`, `LyDo`, `NgayCanhBao`) VALUES
('SV001', '2024-2025', '1', 'GPA dưới 2.0', '2025-06-01'),
('SV003', '2024-2025', '2', 'Thi lại quá 3 lần', '2025-07-10'),
('SV005', '2024-2025', '1', 'Vắng thi không phép', '2025-06-20');

-- --------------------------------------------------------

--
-- Table structure for table `dangkyhocphan`
--

CREATE TABLE `dangkyhocphan` (
  `MaSV` varchar(10) NOT NULL,
  `MaLHP` varchar(10) NOT NULL,
  `HocKy` varchar(10) DEFAULT NULL,
  `NamHoc` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dangkyhocphan`
--

INSERT INTO `dangkyhocphan` (`MaSV`, `MaLHP`, `HocKy`, `NamHoc`) VALUES
('SV001', 'LHP01', 'HK4', '2024-2025'),
('SV002', 'LHP02', 'HK1', '2024-2025'),
('SV003', 'LHP01', 'HK1', '2024-2025');

-- --------------------------------------------------------

--
-- Table structure for table `diem`
--

CREATE TABLE `diem` (
  `MaSV` varchar(10) NOT NULL,
  `MaLHP` varchar(10) NOT NULL,
  `DiemThi` decimal(4,2) DEFAULT NULL,
  `DiemTBHK` decimal(4,2) DEFAULT NULL,
  `XepLoai` varchar(20) DEFAULT NULL,
  `DuocXetHocBong` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `diem`
--

INSERT INTO `diem` (`MaSV`, `MaLHP`, `DiemThi`, `DiemTBHK`, `XepLoai`, `DuocXetHocBong`) VALUES
('SV001', 'LHP01', 8.50, 8.00, 'Gioi', 1),
('SV002', 'LHP02', 6.00, 6.00, 'Trung binh', 0),
('SV003', 'LHP01', 4.50, 5.00, 'Yeu', 0),
('SV005', 'LHP02', 10.00, 10.00, 'Xuất sắc', 1);

-- --------------------------------------------------------

--
-- Table structure for table `giangvien`
--

CREATE TABLE `giangvien` (
  `MaGV` varchar(10) NOT NULL,
  `HoTen` varchar(100) DEFAULT NULL,
  `TrinhDo` varchar(50) DEFAULT NULL,
  `NgaySinh` datetime DEFAULT NULL,
  `GioiTinh` varchar(10) DEFAULT NULL,
  `BoMon` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `giangvien`
--

INSERT INTO `giangvien` (`MaGV`, `HoTen`, `TrinhDo`, `NgaySinh`, `GioiTinh`, `BoMon`) VALUES
('GV001', 'Nguyễn Văn Hùng', 'Thạc sĩ', '2025-06-18 00:00:00', 'Nam', 'Lập trình cơ bản'),
('GV002', 'Le Thi Minh', 'Thạc sĩ', '2025-06-18 00:00:00', 'Nữ', 'Công nghệ phần mềm');

-- --------------------------------------------------------

--
-- Table structure for table `hoclai`
--

CREATE TABLE `hoclai` (
  `MaSV` varchar(10) NOT NULL,
  `MaLHP` varchar(10) NOT NULL,
  `LyDo` varchar(100) DEFAULT NULL,
  `LanHoc` int(11) DEFAULT NULL,
  `NgayDangKy` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hoclai`
--

INSERT INTO `hoclai` (`MaSV`, `MaLHP`, `LyDo`, `LanHoc`, `NgayDangKy`) VALUES
('SV001', 'LHP01', 'Rớt môn', 2, '2025-07-01'),
('SV002', 'LHP02', 'Cải thiện điểm', 2, '2025-07-02'),
('SV003', 'LHP02', 'Vắng thi', 1, '2025-06-30');

-- --------------------------------------------------------

--
-- Table structure for table `hocphan`
--

CREATE TABLE `hocphan` (
  `MaHP` varchar(10) NOT NULL,
  `TenHP` varchar(100) DEFAULT NULL,
  `SoTinChi` int(11) DEFAULT NULL,
  `HocKy` int(11) NOT NULL,
  `MaNganh` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `hocphan`
--

INSERT INTO `hocphan` (`MaHP`, `TenHP`, `SoTinChi`, `HocKy`, `MaNganh`) VALUES
('HP001', 'Co so du lieu', 3, 3, 'CNTT'),
('HP002', 'Tri tue nhan tao', 3, 4, 'CNTT'),
('HP003', 'Thuong mai dien tu can ban', 2, 5, 'TMDT');

-- --------------------------------------------------------

--
-- Table structure for table `khoa`
--

CREATE TABLE `khoa` (
  `MaKhoa` varchar(10) NOT NULL,
  `TenKhoa` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `khoa`
--

INSERT INTO `khoa` (`MaKhoa`, `TenKhoa`) VALUES
('KHMT', 'Khoa học máy tính'),
('QTKD', 'Quản trị kinh doanh');

-- --------------------------------------------------------

--
-- Table structure for table `lop`
--

CREATE TABLE `lop` (
  `MaLop` varchar(10) NOT NULL,
  `TenLop` varchar(100) DEFAULT NULL,
  `CoVanHocTap` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lop`
--

INSERT INTO `lop` (`MaLop`, `TenLop`, `CoVanHocTap`) VALUES
('CT01', 'Lop Cong nghe 01', 'TS. Nguyen Van Long'),
('TM01', 'Lop Thuong mai 01', 'TS. Pham Thi Mai');

-- --------------------------------------------------------

--
-- Table structure for table `lophocphan`
--

CREATE TABLE `lophocphan` (
  `MaLHP` varchar(10) NOT NULL,
  `TenLHP` varchar(100) DEFAULT NULL,
  `MaHP` varchar(10) DEFAULT NULL,
  `MaGV` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lophocphan`
--

INSERT INTO `lophocphan` (`MaLHP`, `TenLHP`, `MaHP`, `MaGV`) VALUES
('LHP01', 'LHP CSDL - CT01', 'HP002', 'GV001'),
('LHP02', 'LHP AI - CT01', 'HP002', 'GV002');

-- --------------------------------------------------------

--
-- Table structure for table `nganh`
--

CREATE TABLE `nganh` (
  `MaNganh` varchar(10) NOT NULL,
  `TenNganh` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `nganh`
--

INSERT INTO `nganh` (`MaNganh`, `TenNganh`) VALUES
('CNTT', 'Cong nghe thong tin'),
('QLNH', 'Quan ly ngan hang'),
('TMDT', 'Thuong mai dien tu');

-- --------------------------------------------------------

--
-- Table structure for table `sinhvien`
--

CREATE TABLE `sinhvien` (
  `MaSV` varchar(10) NOT NULL,
  `HoTen` varchar(100) DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `GioiTinh` char(1) DEFAULT NULL,
  `QueQuan` varchar(100) DEFAULT NULL,
  `CheDoUuTien` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sinhvien`
--

INSERT INTO `sinhvien` (`MaSV`, `HoTen`, `NgaySinh`, `GioiTinh`, `QueQuan`, `CheDoUuTien`) VALUES
('SV001', 'Nguyen Van A', '2003-09-15', 'M', 'Ha Noi', 'Khong'),
('SV002', 'Le Thi B', '2002-04-20', 'F', 'Nghe An', 'Con thuong binh'),
('SV003', 'Tran Van C', '2003-07-12', 'M', 'Bac Ninh', 'Khong'),
('SV004', 'Pham Thi D', '2001-11-30', 'F', 'Quang Nam', 'Ho ngheo'),
('SV005', 'Hoang Van E', '2002-02-28', 'M', 'Thai Binh', 'Khong');

-- --------------------------------------------------------

--
-- Table structure for table `taikhoan`
--

CREATE TABLE `taikhoan` (
  `TenDangNhap` varchar(50) NOT NULL,
  `MatKhau` varchar(50) DEFAULT NULL,
  `VaiTro` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `taikhoan`
--

INSERT INTO `taikhoan` (`TenDangNhap`, `MatKhau`, `VaiTro`) VALUES
('admin', '123', 'Admin'),
('gv001', '123', 'User');

-- --------------------------------------------------------

--
-- Table structure for table `totnghiep`
--

CREATE TABLE `totnghiep` (
  `MaSV` varchar(10) NOT NULL,
  `NgayTotNghiep` date DEFAULT NULL,
  `XepLoai` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `totnghiep`
--

INSERT INTO `totnghiep` (`MaSV`, `NgayTotNghiep`, `XepLoai`) VALUES
('SV001', '2025-07-10', 'Xuất sắc'),
('SV002', '2025-07-10', 'Khá'),
('SV003', '2025-07-10', 'Giỏi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `canhbaohoctap`
--
ALTER TABLE `canhbaohoctap`
  ADD PRIMARY KEY (`MaSV`,`NamHoc`,`HocKy`);

--
-- Indexes for table `dangkyhocphan`
--
ALTER TABLE `dangkyhocphan`
  ADD PRIMARY KEY (`MaSV`,`MaLHP`),
  ADD KEY `MaLHP` (`MaLHP`);

--
-- Indexes for table `diem`
--
ALTER TABLE `diem`
  ADD PRIMARY KEY (`MaSV`,`MaLHP`),
  ADD KEY `MaLHP` (`MaLHP`);

--
-- Indexes for table `giangvien`
--
ALTER TABLE `giangvien`
  ADD PRIMARY KEY (`MaGV`);

--
-- Indexes for table `hoclai`
--
ALTER TABLE `hoclai`
  ADD PRIMARY KEY (`MaSV`,`MaLHP`),
  ADD KEY `MaLHP` (`MaLHP`);

--
-- Indexes for table `hocphan`
--
ALTER TABLE `hocphan`
  ADD PRIMARY KEY (`MaHP`),
  ADD KEY `fk_MaNganh` (`MaNganh`);

--
-- Indexes for table `khoa`
--
ALTER TABLE `khoa`
  ADD PRIMARY KEY (`MaKhoa`);

--
-- Indexes for table `lop`
--
ALTER TABLE `lop`
  ADD PRIMARY KEY (`MaLop`);

--
-- Indexes for table `lophocphan`
--
ALTER TABLE `lophocphan`
  ADD PRIMARY KEY (`MaLHP`),
  ADD KEY `MaHP` (`MaHP`),
  ADD KEY `MaGV` (`MaGV`);

--
-- Indexes for table `nganh`
--
ALTER TABLE `nganh`
  ADD PRIMARY KEY (`MaNganh`);

--
-- Indexes for table `sinhvien`
--
ALTER TABLE `sinhvien`
  ADD PRIMARY KEY (`MaSV`);

--
-- Indexes for table `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD PRIMARY KEY (`TenDangNhap`);

--
-- Indexes for table `totnghiep`
--
ALTER TABLE `totnghiep`
  ADD PRIMARY KEY (`MaSV`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `canhbaohoctap`
--
ALTER TABLE `canhbaohoctap`
  ADD CONSTRAINT `canhbaohoctap_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`);

--
-- Constraints for table `dangkyhocphan`
--
ALTER TABLE `dangkyhocphan`
  ADD CONSTRAINT `dangkyhocphan_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`),
  ADD CONSTRAINT `dangkyhocphan_ibfk_2` FOREIGN KEY (`MaLHP`) REFERENCES `lophocphan` (`MaLHP`);

--
-- Constraints for table `diem`
--
ALTER TABLE `diem`
  ADD CONSTRAINT `diem_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`),
  ADD CONSTRAINT `diem_ibfk_2` FOREIGN KEY (`MaLHP`) REFERENCES `lophocphan` (`MaLHP`);

--
-- Constraints for table `hoclai`
--
ALTER TABLE `hoclai`
  ADD CONSTRAINT `hoclai_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`),
  ADD CONSTRAINT `hoclai_ibfk_2` FOREIGN KEY (`MaLHP`) REFERENCES `lophocphan` (`MaLHP`);

--
-- Constraints for table `hocphan`
--
ALTER TABLE `hocphan`
  ADD CONSTRAINT `fk_MaNganh` FOREIGN KEY (`MaNganh`) REFERENCES `nganh` (`MaNganh`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `lophocphan`
--
ALTER TABLE `lophocphan`
  ADD CONSTRAINT `lophocphan_ibfk_1` FOREIGN KEY (`MaHP`) REFERENCES `hocphan` (`MaHP`),
  ADD CONSTRAINT `lophocphan_ibfk_2` FOREIGN KEY (`MaGV`) REFERENCES `giangvien` (`MaGV`);

--
-- Constraints for table `totnghiep`
--
ALTER TABLE `totnghiep`
  ADD CONSTRAINT `totnghiep_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
