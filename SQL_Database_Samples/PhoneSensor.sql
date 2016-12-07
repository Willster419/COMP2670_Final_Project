-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2016 at 02:00 AM
-- Server version: 5.5.52-0+deb8u1
-- PHP Version: 5.6.24-0+deb8u1.netgear1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cellphone`
--

-- --------------------------------------------------------

--
-- Table structure for table `PhoneSensor`
--

CREATE TABLE `PhoneSensor` (
  `phoneID` int(3) NOT NULL,
  `sensorID` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PhoneSensor`
--

INSERT INTO `PhoneSensor` (`phoneID`, `sensorID`) VALUES
(1, 1),
(1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `PhoneSensor`
--
ALTER TABLE `PhoneSensor`
  ADD PRIMARY KEY (`phoneID`,`sensorID`),
  ADD KEY `sensorID` (`sensorID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `PhoneSensor`
--
ALTER TABLE `PhoneSensor`
  ADD CONSTRAINT `FK_PhoneSensor_sensorID` FOREIGN KEY (`sensorID`) REFERENCES `Sensor` (`sensorID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
