-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 21 Des 2023 pada 13.45
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventaris-sbd`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang_inventaris`
--

CREATE TABLE `barang_inventaris` (
  `Id_barang_inventaris` varchar(20) NOT NULL,
  `Nama_barang` varchar(30) NOT NULL,
  `Merek` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang_inventaris`
--

INSERT INTO `barang_inventaris` (`Id_barang_inventaris`, `Nama_barang`, `Merek`) VALUES
('INV001', 'Monitor', 'AAA'),
('INV002', 'Mouse', 'Logitech'),
('INV003', 'Keyboard', 'Logitech'),
('INV004', 'Speaker', 'Sony'),
('INV005', 'Kursi', 'AAB');

-- --------------------------------------------------------

--
-- Struktur dari tabel `inventaris`
--

CREATE TABLE `inventaris` (
  `Id_Inventaris` int(11) NOT NULL,
  `Tanggal_Inventaris` varchar(50) NOT NULL,
  `Petugas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `inventaris`
--

INSERT INTO `inventaris` (`Id_Inventaris`, `Tanggal_Inventaris`, `Petugas`) VALUES
(1, '15/12/2023 14.14.53', 'Alif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `laporan_inventaris`
--

CREATE TABLE `laporan_inventaris` (
  `Id_item_inventaris` int(11) NOT NULL,
  `Meja` varchar(3) NOT NULL,
  `Nama_barang` varchar(50) NOT NULL,
  `Merek` varchar(30) NOT NULL,
  `Kondisi` varchar(20) NOT NULL,
  `Keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `meja`
--

CREATE TABLE `meja` (
  `No_Meja` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `meja`
--

INSERT INTO `meja` (`No_Meja`) VALUES
('001'),
('002'),
('003'),
('004'),
('005'),
('006'),
('007'),
('008'),
('009'),
('010'),
('011'),
('012');

-- --------------------------------------------------------

--
-- Struktur dari tabel `petugas_inventaris`
--

CREATE TABLE `petugas_inventaris` (
  `Nim_Nip` varchar(18) NOT NULL,
  `Nama_petugas` varchar(50) NOT NULL,
  `Kelas` varchar(5) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Petugas` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `petugas_inventaris`
--

INSERT INTO `petugas_inventaris` (`Nim_Nip`, `Nama_petugas`, `Kelas`, `Password`, `Petugas`) VALUES
('NIP001', 'Admin', '1aec6', 'admin', 'Admin'),
('NIP003', 'enda2', '1aec2', 'enda', 'Petugas'),
('NIP004', 'Alif', '1AEC1', 'alif123', 'Petugas');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang_inventaris`
--
ALTER TABLE `barang_inventaris`
  ADD PRIMARY KEY (`Id_barang_inventaris`);

--
-- Indeks untuk tabel `inventaris`
--
ALTER TABLE `inventaris`
  ADD PRIMARY KEY (`Id_Inventaris`);

--
-- Indeks untuk tabel `laporan_inventaris`
--
ALTER TABLE `laporan_inventaris`
  ADD PRIMARY KEY (`Id_item_inventaris`);

--
-- Indeks untuk tabel `meja`
--
ALTER TABLE `meja`
  ADD PRIMARY KEY (`No_Meja`);

--
-- Indeks untuk tabel `petugas_inventaris`
--
ALTER TABLE `petugas_inventaris`
  ADD PRIMARY KEY (`Nim_Nip`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `inventaris`
--
ALTER TABLE `inventaris`
  MODIFY `Id_Inventaris` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `laporan_inventaris`
--
ALTER TABLE `laporan_inventaris`
  MODIFY `Id_item_inventaris` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
