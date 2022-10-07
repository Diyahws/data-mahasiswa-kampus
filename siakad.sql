-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 27 Bulan Mei 2022 pada 09.14
-- Versi server: 10.4.19-MariaDB
-- Versi PHP: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `siakad`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akun`
--

CREATE TABLE `akun` (
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`username`, `password`) VALUES
('admin', '123456'),
('user', '112233');

-- --------------------------------------------------------

--
-- Struktur dari tabel `dosen`
--

CREATE TABLE `dosen` (
  `nip` int(20) NOT NULL,
  `nama_dosen` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `dosen`
--

INSERT INTO `dosen` (`nip`, `nama_dosen`) VALUES
(20001, 'Cikgu'),
(20002, 'Opa'),
(20003, 'Oma'),
(20004, 'Megawati'),
(20005, 'Jokowi');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kelas`
--

CREATE TABLE `kelas` (
  `id` int(15) NOT NULL,
  `nama_kelas` varchar(50) NOT NULL,
  `dosen_nip` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `kelas`
--

INSERT INTO `kelas` (`id`, `nama_kelas`, `dosen_nip`) VALUES
(1, 'IT A', 20001),
(2, 'IT B', 20002),
(3, 'IT C', 20002),
(4, 'IT D', 20001),
(5, 'IT E', 20003),
(6, 'IT F', 20005);

-- --------------------------------------------------------

--
-- Struktur dari tabel `mahasiswa`
--

CREATE TABLE `mahasiswa` (
  `nim` int(15) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jenis_kelamin` enum('Laki-Laki','Perempuan') NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `kelas_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mahasiswa`
--

INSERT INTO `mahasiswa` (`nim`, `nama`, `jenis_kelamin`, `tempat_lahir`, `tgl_lahir`, `alamat`, `kelas_id`) VALUES
(10001, 'Upin', 'Laki-Laki', 'Sorong', '1999-08-08', 'Jl. M. Said', 1),
(10002, 'Ipin', 'Laki-Laki', 'Sorong', '1999-08-08', 'Jl. M. Said', 2),
(10003, 'Kakros', 'Perempuan', 'Makassar', '1998-12-06', 'Jl. M. Said', 3),
(10004, 'Meymey', 'Perempuan', 'Pontianak', '1999-07-30', 'Jl. Juanda', 4),
(10005, 'Jarjit', 'Laki-Laki', 'Makassar', '1999-11-22', 'Jl. A. Yani', 1),
(10006, 'Ehsan', 'Laki-Laki', 'Samarinda', '1999-07-30', 'Jl. Dr. Soetomo', 2),
(10007, 'Santi', 'Perempuan', 'Balikpapan', '1999-07-30', 'Jl. Revolusi', 3),
(10008, 'Mail', 'Perempuan', 'Yogyakarta', '1998-12-06', 'Jl. Monginsidi', 4),
(10009, 'Fizi', 'Laki-Laki', 'Lombok', '2022-01-17', 'Jl. Juanda', 3);

-- --------------------------------------------------------

--
-- Struktur dari tabel `mata_kuliah`
--

CREATE TABLE `mata_kuliah` (
  `id_matkul` int(15) NOT NULL,
  `nama_matkul` varchar(100) NOT NULL,
  `sks` int(1) NOT NULL,
  `dosen_nip` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `mata_kuliah`
--

INSERT INTO `mata_kuliah` (`id_matkul`, `nama_matkul`, `sks`, `dosen_nip`) VALUES
(1, 'Pemrogaman', 2, 20001),
(2, 'Perakitan', 3, 20002),
(3, 'Dasar IT', 2, 20003),
(4, 'Matematika', 2, 20004),
(5, 'Database', 3, 20005),
(6, 'Perulangan', 2, 20005);

-- --------------------------------------------------------

--
-- Struktur dari tabel `nilai`
--

CREATE TABLE `nilai` (
  `id` int(15) NOT NULL,
  `nim` int(15) NOT NULL,
  `id_matkul` int(10) NOT NULL,
  `jenis_nilai` enum('Quiz','UTS','UAS') NOT NULL,
  `nip` int(50) NOT NULL,
  `nilai` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `nilai`
--

INSERT INTO `nilai` (`id`, `nim`, `id_matkul`, `jenis_nilai`, `nip`, `nilai`) VALUES
(1, 10001, 1, 'Quiz', 20003, 80),
(2, 10002, 2, 'UTS', 20001, 88),
(3, 10005, 1, 'UTS', 20003, 95),
(4, 10009, 4, 'UTS', 20004, 86),
(5, 10008, 5, 'UAS', 20002, 99),
(6, 10003, 4, 'UTS', 20004, 87),
(7, 10002, 2, 'UTS', 20002, 78);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD UNIQUE KEY `username` (`username`);

--
-- Indeks untuk tabel `dosen`
--
ALTER TABLE `dosen`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `dosen_nip` (`dosen_nip`);

--
-- Indeks untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD PRIMARY KEY (`nim`) USING BTREE,
  ADD KEY `kelas_id` (`kelas_id`);

--
-- Indeks untuk tabel `mata_kuliah`
--
ALTER TABLE `mata_kuliah`
  ADD PRIMARY KEY (`id_matkul`),
  ADD KEY `dosen_nip` (`dosen_nip`);

--
-- Indeks untuk tabel `nilai`
--
ALTER TABLE `nilai`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_matkul` (`id_matkul`),
  ADD KEY `nip` (`nip`),
  ADD KEY `nim` (`nim`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `dosen`
--
ALTER TABLE `dosen`
  MODIFY `nip` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20008;

--
-- AUTO_INCREMENT untuk tabel `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT untuk tabel `mata_kuliah`
--
ALTER TABLE `mata_kuliah`
  MODIFY `id_matkul` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT untuk tabel `nilai`
--
ALTER TABLE `nilai`
  MODIFY `id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `kelas`
--
ALTER TABLE `kelas`
  ADD CONSTRAINT `kelas_ibfk_1` FOREIGN KEY (`dosen_nip`) REFERENCES `dosen` (`nip`);

--
-- Ketidakleluasaan untuk tabel `mahasiswa`
--
ALTER TABLE `mahasiswa`
  ADD CONSTRAINT `mahasiswa_ibfk_1` FOREIGN KEY (`kelas_id`) REFERENCES `kelas` (`id`);

--
-- Ketidakleluasaan untuk tabel `mata_kuliah`
--
ALTER TABLE `mata_kuliah`
  ADD CONSTRAINT `mata_kuliah_ibfk_1` FOREIGN KEY (`dosen_nip`) REFERENCES `dosen` (`nip`);

--
-- Ketidakleluasaan untuk tabel `nilai`
--
ALTER TABLE `nilai`
  ADD CONSTRAINT `nilai_ibfk_1` FOREIGN KEY (`id_matkul`) REFERENCES `mata_kuliah` (`id_matkul`),
  ADD CONSTRAINT `nilai_ibfk_2` FOREIGN KEY (`nip`) REFERENCES `dosen` (`nip`),
  ADD CONSTRAINT `nilai_ibfk_3` FOREIGN KEY (`nim`) REFERENCES `mahasiswa` (`nim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
