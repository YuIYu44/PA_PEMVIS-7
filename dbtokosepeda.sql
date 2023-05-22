-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2023 at 07:24 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtokosepeda`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `id_akun` int(12) NOT NULL,
  `Username` varchar(12) NOT NULL,
  `Password` varchar(9) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id_akun`, `Username`, `Password`, `Nama`, `Email`, `Status`) VALUES
(1101, 'VYN', 'WOLFCUT', 'ARVIN', 'arvinskr@gmail.com', 'PENJUAL'),
(1102, 'DIMAS', 'DAAY10', 'DIMAS ABDI YUDHA', 'day1@gmail.com', 'PENJUAL'),
(1103, 'ADMIN12', '67890A', 'ADMIN', 'admin@gmail.com', 'ADMIN'),
(1104, 'AYU', 'HURUHARA', 'AYU GUNAWAN', 'ayu@gmail.com', 'PEMBELI'),
(1106, 'YUANITA', 'YUANITA', 'YUANITA RAHMAN', 'yuanita@gmail.com', 'PENJUAL'),
(1113, 'WANDA', 'WANDA1', 'WANDA', 'wanda', 'PENJUAL');

-- --------------------------------------------------------

--
-- Table structure for table `sepeda`
--

CREATE TABLE `sepeda` (
  `id_sepeda` int(10) NOT NULL,
  `nama_sepeda` varchar(60) NOT NULL,
  `harga` int(10) NOT NULL,
  `total` int(3) NOT NULL,
  `id_penjual` int(12) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sepeda`
--

INSERT INTO `sepeda` (`id_sepeda`, `nama_sepeda`, `harga`, `total`, `id_penjual`, `gambar`) VALUES
(100, 'MTB 26', 1520000, 7, 1101, 'MTB 261101.jpeg'),
(101, 'MTB 24', 1169000, 9, 1102, 'MTB 241102.jpeg'),
(102, 'FOSTER 5522', 1300000, 3, 1106, 'FOSTER 55221106.jpeg'),
(109, 'SEPEDA MINI PHEONIX 99', 1650000, 5, 1113, 'SEPEDA MINI PHEONIX 991113.jpeg'),
(111, 'DETROIT SV', 3000000, 3, 1113, 'DETROIT SV1113.jpeg'),
(112, 'POLYGON CASCADE 3', 3400000, 6, 1106, 'POLYGON CASCADE 31106.jpeg'),
(113, 'GT AGGRESOR', 10000000, 5, 1113, 'GT AGGRESOR1113.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `terbeli`
--

CREATE TABLE `terbeli` (
  `id_terbeli` int(15) NOT NULL,
  `nama_barang` varchar(60) NOT NULL,
  `jumlah_barang` int(3) NOT NULL,
  `pembeli` varchar(60) NOT NULL,
  `penjual` varchar(60) NOT NULL,
  `total` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `terbeli`
--

INSERT INTO `terbeli` (`id_terbeli`, `nama_barang`, `jumlah_barang`, `pembeli`, `penjual`, `total`) VALUES
(1, 'MTB 24', 2, '1104', '1102', 2338000),
(2, 'MTB 26', 1, '1104', '1101', 7875000),
(3, 'MTB 24', 1, '1100', '1102', 1169000),
(4, 'FOSTER 5522', 1, '1104', '1106', 1300000),
(5, 'MTB 24', 1, '1104', '1102', 1169000),
(6, 'FOSTER 5522', 2, '1104', '1106', 2600000),
(7, 'MTB 24', 2, '1100', '1102', 2338000),
(8, 'MTB 26', 1, '1100', '1101', 7875000),
(12, 'SEPEDA MINI PHEONIX 99', 1, '1104', '1113', 1600000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id_akun`);

--
-- Indexes for table `sepeda`
--
ALTER TABLE `sepeda`
  ADD PRIMARY KEY (`id_sepeda`);

--
-- Indexes for table `terbeli`
--
ALTER TABLE `terbeli`
  ADD PRIMARY KEY (`id_terbeli`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `id_akun` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1114;

--
-- AUTO_INCREMENT for table `sepeda`
--
ALTER TABLE `sepeda`
  MODIFY `id_sepeda` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=114;

--
-- AUTO_INCREMENT for table `terbeli`
--
ALTER TABLE `terbeli`
  MODIFY `id_terbeli` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
