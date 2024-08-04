-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 02, 2024 at 09:09 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gestion_pharmacie`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `idadmin` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`idadmin`, `username`, `password`) VALUES
(1, 'Admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `categorie`
--

CREATE TABLE `categorie` (
  `id` int(11) NOT NULL,
  `nomcat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categorie`
--

INSERT INTO `categorie` (`id`, `nomcat`) VALUES
(1, 'Antibiotique'),
(2, 'Sérum'),
(3, 'Antiramine'),
(4, 'Diclof');

-- --------------------------------------------------------

--
-- Table structure for table `entree`
--

CREATE TABLE `entree` (
  `ident` int(11) NOT NULL,
  `date_entree` date NOT NULL,
  `medicament` int(11) NOT NULL,
  `fournisseur` int(11) NOT NULL,
  `prix` double NOT NULL,
  `qte` int(11) NOT NULL,
  `datefab` date NOT NULL,
  `dateexp` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `entree`
--

INSERT INTO `entree` (`ident`, `date_entree`, `medicament`, `fournisseur`, `prix`, `qte`, `datefab`, `dateexp`) VALUES
(7, '2024-05-01', 1, 3, 50, 216, '2023-11-01', '2025-04-04'),
(8, '2024-05-01', 3, 4, 20, 783, '2024-05-01', '2024-11-27'),
(9, '2024-05-01', 4, 3, 10, 500, '2023-12-26', '2025-07-10');

-- --------------------------------------------------------

--
-- Table structure for table `fournisseurs`
--

CREATE TABLE `fournisseurs` (
  `idfour` int(11) NOT NULL,
  `Date` date NOT NULL,
  `nomfournisseur` text NOT NULL,
  `postnom` text NOT NULL,
  `tel` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `fournisseurs`
--

INSERT INTO `fournisseurs` (`idfour`, `Date`, `nomfournisseur`, `postnom`, `tel`) VALUES
(3, '2024-05-01', 'Shalina', 'ets', '094563215789'),
(4, '2024-05-01', 'India Ets', 'Sama', '032648565452');

-- --------------------------------------------------------

--
-- Table structure for table `malade`
--

CREATE TABLE `malade` (
  `idmalade` int(11) NOT NULL,
  `nommal` text NOT NULL,
  `postnommal` text NOT NULL,
  `tel` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `malade`
--

INSERT INTO `malade` (`idmalade`, `nommal`, `postnommal`, `tel`) VALUES
(1, 'kavira', 'valimu', '098653245'),
(2, 'Masika', 'kitawita', '0867562325'),
(3, 'Rachel', 'Masika', '09865321548');

-- --------------------------------------------------------

--
-- Table structure for table `medicaments`
--

CREATE TABLE `medicaments` (
  `idmed` int(11) NOT NULL,
  `nommed` text NOT NULL,
  `categorie` int(11) NOT NULL,
  `dose` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicaments`
--

INSERT INTO `medicaments` (`idmed`, `nommed`, `categorie`, `dose`) VALUES
(1, 'Paracetamol ', 1, '120g'),
(3, 'Vitamin C', 1, '60g'),
(4, 'maxadol', 3, '500g');

-- --------------------------------------------------------

--
-- Table structure for table `sortie`
--

CREATE TABLE `sortie` (
  `idsortie` int(11) NOT NULL,
  `date_sortie` datetime NOT NULL,
  `qtesortie` int(11) NOT NULL,
  `medicament` int(11) NOT NULL,
  `malade` int(11) NOT NULL,
  `montant` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sortie`
--

INSERT INTO `sortie` (`idsortie`, `date_sortie`, `qtesortie`, `medicament`, `malade`, `montant`) VALUES
(1, '2024-05-01 23:45:57', 12, 7, 1, 600);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `iduser` int(11) NOT NULL,
  `nomuser` text NOT NULL,
  `teluser` text NOT NULL,
  `adresse` text NOT NULL,
  `sexe` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`iduser`, `nomuser`, `teluser`, `adresse`, `sexe`, `password`) VALUES
(1, 'chris', '09865324120', 'butembo', 'F', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`idadmin`);

--
-- Indexes for table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `entree`
--
ALTER TABLE `entree`
  ADD PRIMARY KEY (`ident`);

--
-- Indexes for table `fournisseurs`
--
ALTER TABLE `fournisseurs`
  ADD PRIMARY KEY (`idfour`);

--
-- Indexes for table `malade`
--
ALTER TABLE `malade`
  ADD PRIMARY KEY (`idmalade`);

--
-- Indexes for table `medicaments`
--
ALTER TABLE `medicaments`
  ADD PRIMARY KEY (`idmed`);

--
-- Indexes for table `sortie`
--
ALTER TABLE `sortie`
  ADD PRIMARY KEY (`idsortie`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`iduser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `idadmin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `entree`
--
ALTER TABLE `entree`
  MODIFY `ident` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `fournisseurs`
--
ALTER TABLE `fournisseurs`
  MODIFY `idfour` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `malade`
--
ALTER TABLE `malade`
  MODIFY `idmalade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `medicaments`
--
ALTER TABLE `medicaments`
  MODIFY `idmed` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sortie`
--
ALTER TABLE `sortie`
  MODIFY `idsortie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `iduser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
