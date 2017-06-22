-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 14 Jul 2016 pada 22.49
-- Versi Server: 10.1.10-MariaDB
-- PHP Version: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_sph`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin_sph`
--

CREATE TABLE `admin_sph` (
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin_sph`
--

INSERT INTO `admin_sph` (`username`, `password`) VALUES
('utif', 'utiflinux'),
('admin', 'sisfo123');

-- --------------------------------------------------------

--
-- Struktur dari tabel `cuti_karyawan`
--

CREATE TABLE `cuti_karyawan` (
  `no` int(5) NOT NULL,
  `nama` varchar(45) NOT NULL,
  `cuti` varchar(25) NOT NULL,
  `periode` varchar(35) NOT NULL,
  `sisa` varchar(25) NOT NULL,
  `ambil` varchar(25) NOT NULL,
  `kembali` varchar(25) NOT NULL,
  `batas` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `cuti_karyawan`
--

INSERT INTO `cuti_karyawan` (`no`, `nama`, `cuti`, `periode`, `sisa`, `ambil`, `kembali`, `batas`) VALUES
(1, 'Suryadi putra', '20-Jun-2016', '01-Jun-2016', '12 hari', '10-Jun-2016', '', '24-Jun-2016'),
(2, 'Taufik hidayat', '21-Jun-2016', '01-Jun-2016', '9 hari', '10-Jun-2016', '01-Sep-2016', '24-Jun-2016'),
(3, 'Utif milkedori', '14-Jun-2016', '16-Jun-2016', '6 hari', '03-Jun-2016', '12-Apr-2016', '06-Jun-2016');

-- --------------------------------------------------------

--
-- Struktur dari tabel `ip_unit`
--

CREATE TABLE `ip_unit` (
  `id` int(5) NOT NULL,
  `nm_unt` varchar(40) NOT NULL,
  `ip_unt` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ip_unit`
--

INSERT INTO `ip_unit` (`id`, `nm_unt`, `ip_unt`) VALUES
(1, 'SISFO', '33444');

-- --------------------------------------------------------

--
-- Struktur dari tabel `telp_unit`
--

CREATE TABLE `telp_unit` (
  `id` int(5) NOT NULL,
  `nm_unt` varchar(40) NOT NULL,
  `tlp_unt` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `telp_unit`
--

INSERT INTO `telp_unit` (`id`, `nm_unt`, `tlp_unt`) VALUES
(1, 'OPERATOR', '0'),
(2, 'ADMISION', '5149'),
(3, 'ADMISION /asuransi', '5159'),
(4, 'ADMISION FAX', '0751 - 4782997'),
(5, 'ADMISION (TELP KELUAR)&OPERATOR', '0751 - 4782999'),
(6, 'KASIR 1 LANTAI 1', '5108'),
(7, 'KASIR 2 LANTAI 1', '5131'),
(8, 'KASIR (TELP KELUAR)', '0751 - 4782992'),
(9, 'FARMASI DALAM', '5152'),
(10, 'ASURANSI', '5146'),
(11, 'ASURANSI', '5147'),
(12, 'MCU /  Ruang paling ujung', '5106'),
(13, 'MCU NO 1', '5133'),
(14, 'MCU RUANG DOKTER', '5106'),
(15, 'NURSE MCU', '5156'),
(16, 'HUMAS', '5137'),
(17, 'POLI USG / TREEDMIL', '5100'),
(18, 'POLI JANTUNG', '5101'),
(19, 'POLI BEDAH ORTOPEDI', '5118'),
(20, 'POLI GIGI', '5110'),
(21, 'POLI GIGI', '5111'),
(22, 'POLI THT', '5112'),
(23, 'POLI INTERNIS', '5113'),
(24, 'POLI MATA', '5114'),
(25, 'POLI MATA', '5115'),
(26, 'POLI UMUM', '5122'),
(27, 'POLI ANAK', '5123'),
(28, 'POLI IMUNISASI', '5124'),
(29, 'POLI UMUM', '5129'),
(30, 'POLI BEDAH UROLOGI', '5132'),
(31, 'DOKTER UMUM', '5134'),
(32, 'POLI BEDAH DIGESTIF', '5135'),
(33, 'POLI SYARAF', '5136'),
(34, 'POLI TIMUR NURSE', '5155'),
(35, 'POLI TIMUR', '5157'),
(36, 'POLI BARAT (TELP KELUAR)', '0751-4782991'),
(37, 'POLI BARAT', '5159'),
(38, 'NURSE IGD ', '5121'),
(39, 'RUANG DOKTER IGD', '5128'),
(40, 'NURSE IGD', '5121'),
(41, 'RUANG DOKTER IGD', '5128'),
(42, 'NURSE IGD', '5137'),
(43, 'IGD (TELP KELUAR)', '0751 - 4782983');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cuti_karyawan`
--
ALTER TABLE `cuti_karyawan`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `ip_unit`
--
ALTER TABLE `ip_unit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `telp_unit`
--
ALTER TABLE `telp_unit`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cuti_karyawan`
--
ALTER TABLE `cuti_karyawan`
  MODIFY `no` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `ip_unit`
--
ALTER TABLE `ip_unit`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `telp_unit`
--
ALTER TABLE `telp_unit`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
