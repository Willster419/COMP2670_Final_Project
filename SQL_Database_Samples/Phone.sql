-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2016 at 01:59 AM
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
-- Table structure for table `Phone`
--

CREATE TABLE `Phone` (
  `phoneID` int(3) NOT NULL,
  `name` varchar(20) NOT NULL,
  `displayID` int(3) NOT NULL,
  `chargePortID` int(2) NOT NULL,
  `OSID` int(1) NOT NULL,
  `CPUID` int(2) NOT NULL,
  `isUnlocked` tinyint(1) NOT NULL,
  `price` float DEFAULT NULL,
  `internalCapacity` int(6) NOT NULL,
  `expandableCapacity` int(2) NOT NULL,
  `RAMcapacity` int(2) NOT NULL,
  `monthReleased` int(2) NOT NULL,
  `yearReleased` year(4) NOT NULL,
  `stillAvailable` tinyint(1) NOT NULL,
  `weight` float NOT NULL,
  `SIMID` int(1) NOT NULL,
  `hasExternalKeyboard` tinyint(1) NOT NULL,
  `numExternalSpeakers` int(1) NOT NULL,
  `analogAudioJack` tinyint(1) NOT NULL,
  `physicalHomeButton` tinyint(1) NOT NULL,
  `manufacturerID` int(2) NOT NULL,
  `batteryCapacity` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='main table';

--
-- Dumping data for table `Phone`
--

INSERT INTO `Phone` (`phoneID`, `name`, `displayID`, `chargePortID`, `OSID`, `CPUID`, `isUnlocked`, `price`, `internalCapacity`, `expandableCapacity`, `RAMcapacity`, `monthReleased`, `yearReleased`, `stillAvailable`, `weight`, `hasExternalKeyboard`, `numExternalSpeakers`, `analogAudioJack`, `physicalHomeButton`, `manufacturerID`, `batteryCapacity`) VALUES
(1, 'Fierce 4', 1, 1, 1, 1, 1, 119.99, 16384, 262144, 2048, 8, 2016, 1, 163.9, 0, 2, 1, 1, 1, 2500);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Phone`
--
ALTER TABLE `Phone`
  ADD PRIMARY KEY (`phoneID`),
  ADD KEY `OSID` (`OSID`),
  ADD KEY `CPUID` (`CPUID`),
  ADD KEY `SIMID` (`SIMID`),
  ADD KEY `manufacturerID` (`manufacturerID`),
  ADD KEY `chargePortID` (`chargePortID`),
  ADD KEY `displayID` (`displayID`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Phone`
--
ALTER TABLE `Phone`
  MODIFY `phoneID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Phone`
--
ALTER TABLE `Phone`
  ADD CONSTRAINT `FK_Phone_phoneID_S` FOREIGN KEY (`phoneID`) REFERENCES `PhoneSensor` (`phoneID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
