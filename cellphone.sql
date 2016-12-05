-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2016 at 09:42 PM
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
-- Table structure for table `Camera`
--

CREATE TABLE `Camera` (
  `cameraID` int(3) NOT NULL,
  `resolutionWidthPixels` int(5) NOT NULL,
  `resolutionHeightPixels` int(5) NOT NULL,
  `mPixels` float NOT NULL,
  `fps` int(3) NOT NULL,
  `opticalZoom` int(2) NOT NULL,
  `location` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Camera`
--

INSERT INTO `Camera` (`cameraID`, `resolutionWidthPixels`, `resolutionHeightPixels`, `mPixels`, `fps`, `opticalZoom`, `location`) VALUES
(2, 1280, 720, 5, 30, 0, 'front'),
(1, 1280, 720, 8, 30, 0, 'back');

-- --------------------------------------------------------

--
-- Table structure for table `Carrier`
--

CREATE TABLE `Carrier` (
  `carrierID` int(2) NOT NULL,
  `networkID` int(2) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Carrier`
--

INSERT INTO `Carrier` (`carrierID`, `networkID`, `name`) VALUES
(1, 1, 'MetroPCS'),
(2, 1, 'T-Mobile'),
(3, 1, 'AT&T'),
(4, 2, 'Verizon'),
(5, 2, 'Sprint');

-- --------------------------------------------------------

--
-- Table structure for table `ChargePort`
--

CREATE TABLE `ChargePort` (
  `chargePortID` int(2) NOT NULL,
  `name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ChargePort`
--

INSERT INTO `ChargePort` (`chargePortID`, `name`) VALUES
(1, 'Micro USB 2.0');

-- --------------------------------------------------------

--
-- Table structure for table `CPU`
--

CREATE TABLE `CPU` (
  `CPUID` int(2) NOT NULL,
  `brand` varchar(20) NOT NULL,
  `model` varchar(20) NOT NULL,
  `numCores` int(2) NOT NULL,
  `frequency` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `CPU`
--

INSERT INTO `CPU` (`CPUID`, `brand`, `model`, `numCores`, `frequency`) VALUES
(1, 'Qualcomm', 'MSM8909', 4, 1.1);

-- --------------------------------------------------------

--
-- Table structure for table `Display`
--

CREATE TABLE `Display` (
  `displayID` int(3) NOT NULL,
  `displayType` varchar(20) NOT NULL,
  `isTouchscreen` tinyint(1) NOT NULL,
  `heightPixels` int(4) NOT NULL,
  `widthPixels` int(4) NOT NULL,
  `sizeInches` float NOT NULL,
  `DPI` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Display`
--

INSERT INTO `Display` (`displayID`, `displayType`, `isTouchscreen`, `heightPixels`, `widthPixels`, `sizeInches`, `DPI`) VALUES
(1, 'IPS LCD', 1, 1280, 720, 5.5, 267);

-- --------------------------------------------------------

--
-- Table structure for table `Feature`
--

CREATE TABLE `Feature` (
  `featureID` int(2) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Feature`
--

INSERT INTO `Feature` (`featureID`, `name`) VALUES
(1, 'FM Radio');

-- --------------------------------------------------------

--
-- Table structure for table `Manufacturer`
--

CREATE TABLE `Manufacturer` (
  `manufacturerID` int(2) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Manufacturer`
--

INSERT INTO `Manufacturer` (`manufacturerID`, `name`) VALUES
(1, 'Acatel');

-- --------------------------------------------------------

--
-- Table structure for table `Network`
--

CREATE TABLE `Network` (
  `networkID` int(2) NOT NULL,
  `type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Network`
--

INSERT INTO `Network` (`networkID`, `type`) VALUES
(2, 'CDMA'),
(1, 'GSM');

-- --------------------------------------------------------

--
-- Table structure for table `OS`
--

CREATE TABLE `OS` (
  `OSID` int(2) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `OS`
--

INSERT INTO `OS` (`OSID`, `name`) VALUES
(1, 'Android 6.0 (Marshmallow)');

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
  `hasExternalKeyboard` tinyint(1) NOT NULL,
  `numExternalSpeakers` int(1) NOT NULL,
  `analogAudioJack` tinyint(1) NOT NULL,
  `physicalHomeButton` tinyint(1) NOT NULL,
  `manufacturerID` int(2) NOT NULL,
  `batteryCapacity` int(5) NOT NULL,
  `pictureURL` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='main table';

--
-- Dumping data for table `Phone`
--

INSERT INTO `Phone` (`phoneID`, `name`, `displayID`, `chargePortID`, `OSID`, `CPUID`, `isUnlocked`, `price`, `internalCapacity`, `expandableCapacity`, `RAMcapacity`, `monthReleased`, `yearReleased`, `stillAvailable`, `weight`, `hasExternalKeyboard`, `numExternalSpeakers`, `analogAudioJack`, `physicalHomeButton`, `manufacturerID`, `batteryCapacity`, `pictureURL`) VALUES
(1, 'Fierce 4', 1, 1, 1, 1, 1, 89, 128, 1, 2, 12, 1996, 1, 55546, 1, 1, 1, 1, 1, 1, 'http://cdn2.gsmarena.com/vv/bigpic/alcatel-fierce-4.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `PhoneCamera`
--

CREATE TABLE `PhoneCamera` (
  `phoneID` int(3) NOT NULL,
  `cameraID` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PhoneCamera`
--

INSERT INTO `PhoneCamera` (`phoneID`, `cameraID`) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `PhoneCarrier`
--

CREATE TABLE `PhoneCarrier` (
  `phoneID` int(3) NOT NULL,
  `carrierID` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PhoneCarrier`
--

INSERT INTO `PhoneCarrier` (`phoneID`, `carrierID`) VALUES
(1, 1),
(1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `PhoneFeature`
--

CREATE TABLE `PhoneFeature` (
  `phoneID` int(3) NOT NULL,
  `featureID` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `PhoneFeature`
--

INSERT INTO `PhoneFeature` (`phoneID`, `featureID`) VALUES
(1, 1);

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

-- --------------------------------------------------------

--
-- Table structure for table `Sensor`
--

CREATE TABLE `Sensor` (
  `sensorID` int(2) NOT NULL,
  `name` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Sensor`
--

INSERT INTO `Sensor` (`sensorID`, `name`) VALUES
(2, 'Accelorometer'),
(1, 'Compass');

-- --------------------------------------------------------

--
-- Table structure for table `SIM`
--

CREATE TABLE `SIM` (
  `phoneID` int(3) NOT NULL,
  `numCards` int(1) NOT NULL,
  `type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `SIM`
--

INSERT INTO `SIM` (`phoneID`, `numCards`, `type`) VALUES
(1, 1, 'nano');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Camera`
--
ALTER TABLE `Camera`
  ADD PRIMARY KEY (`cameraID`),
  ADD UNIQUE KEY `resolutionWidthPixels` (`resolutionWidthPixels`,`resolutionHeightPixels`,`mPixels`,`fps`,`opticalZoom`,`location`);

--
-- Indexes for table `Carrier`
--
ALTER TABLE `Carrier`
  ADD PRIMARY KEY (`carrierID`),
  ADD UNIQUE KEY `name` (`name`),
  ADD KEY `networkID` (`networkID`);

--
-- Indexes for table `ChargePort`
--
ALTER TABLE `ChargePort`
  ADD PRIMARY KEY (`chargePortID`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `CPU`
--
ALTER TABLE `CPU`
  ADD PRIMARY KEY (`CPUID`),
  ADD UNIQUE KEY `brand` (`brand`,`model`,`numCores`,`frequency`);

--
-- Indexes for table `Display`
--
ALTER TABLE `Display`
  ADD PRIMARY KEY (`displayID`),
  ADD UNIQUE KEY `displayType` (`displayType`,`isTouchscreen`,`heightPixels`,`widthPixels`,`sizeInches`,`DPI`);

--
-- Indexes for table `Feature`
--
ALTER TABLE `Feature`
  ADD PRIMARY KEY (`featureID`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `Manufacturer`
--
ALTER TABLE `Manufacturer`
  ADD PRIMARY KEY (`manufacturerID`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `Network`
--
ALTER TABLE `Network`
  ADD PRIMARY KEY (`networkID`),
  ADD UNIQUE KEY `type` (`type`);

--
-- Indexes for table `OS`
--
ALTER TABLE `OS`
  ADD PRIMARY KEY (`OSID`),
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `Phone`
--
ALTER TABLE `Phone`
  ADD PRIMARY KEY (`phoneID`),
  ADD UNIQUE KEY `pictureURL` (`pictureURL`),
  ADD KEY `OSID` (`OSID`),
  ADD KEY `CPUID` (`CPUID`),
  ADD KEY `manufacturerID` (`manufacturerID`),
  ADD KEY `chargePortID` (`chargePortID`),
  ADD KEY `displayID` (`displayID`) USING BTREE;

--
-- Indexes for table `PhoneCamera`
--
ALTER TABLE `PhoneCamera`
  ADD PRIMARY KEY (`phoneID`,`cameraID`),
  ADD KEY `cameraID` (`cameraID`);

--
-- Indexes for table `PhoneCarrier`
--
ALTER TABLE `PhoneCarrier`
  ADD PRIMARY KEY (`phoneID`,`carrierID`),
  ADD KEY `FK_PhoneCarrier_carrierID` (`carrierID`);

--
-- Indexes for table `PhoneFeature`
--
ALTER TABLE `PhoneFeature`
  ADD PRIMARY KEY (`phoneID`,`featureID`),
  ADD KEY `featureID` (`featureID`);

--
-- Indexes for table `PhoneSensor`
--
ALTER TABLE `PhoneSensor`
  ADD PRIMARY KEY (`phoneID`,`sensorID`),
  ADD KEY `sensorID` (`sensorID`);

--
-- Indexes for table `Sensor`
--
ALTER TABLE `Sensor`
  ADD PRIMARY KEY (`sensorID`) USING BTREE,
  ADD UNIQUE KEY `name` (`name`);

--
-- Indexes for table `SIM`
--
ALTER TABLE `SIM`
  ADD PRIMARY KEY (`phoneID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Camera`
--
ALTER TABLE `Camera`
  MODIFY `cameraID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `Carrier`
--
ALTER TABLE `Carrier`
  MODIFY `carrierID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `ChargePort`
--
ALTER TABLE `ChargePort`
  MODIFY `chargePortID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `CPU`
--
ALTER TABLE `CPU`
  MODIFY `CPUID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Display`
--
ALTER TABLE `Display`
  MODIFY `displayID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `Feature`
--
ALTER TABLE `Feature`
  MODIFY `featureID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Manufacturer`
--
ALTER TABLE `Manufacturer`
  MODIFY `manufacturerID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Network`
--
ALTER TABLE `Network`
  MODIFY `networkID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `OS`
--
ALTER TABLE `OS`
  MODIFY `OSID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Phone`
--
ALTER TABLE `Phone`
  MODIFY `phoneID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `Sensor`
--
ALTER TABLE `Sensor`
  MODIFY `sensorID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `SIM`
--
ALTER TABLE `SIM`
  MODIFY `phoneID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Carrier`
--
ALTER TABLE `Carrier`
  ADD CONSTRAINT `FK_Carrier_networkID_Carrier` FOREIGN KEY (`networkID`) REFERENCES `Network` (`networkID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Phone`
--
ALTER TABLE `Phone`
  ADD CONSTRAINT `FK_Phone_chargeportID_CP` FOREIGN KEY (`chargePortID`) REFERENCES `ChargePort` (`chargePortID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Phone_CPUID_CPU` FOREIGN KEY (`CPUID`) REFERENCES `CPU` (`CPUID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Phone_displayID_D` FOREIGN KEY (`displayID`) REFERENCES `Display` (`displayID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Phone_manufacturerID_M` FOREIGN KEY (`manufacturerID`) REFERENCES `Manufacturer` (`manufacturerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Phone_OSID_OS` FOREIGN KEY (`OSID`) REFERENCES `OS` (`OSID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneCamera`
--
ALTER TABLE `PhoneCamera`
  ADD CONSTRAINT `FK_PhoneCamera_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PhoneCamera_cameraID` FOREIGN KEY (`cameraID`) REFERENCES `Camera` (`cameraID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneCarrier`
--
ALTER TABLE `PhoneCarrier`
  ADD CONSTRAINT `FK_PhoneCarriier_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PhoneCarrier_carrierID` FOREIGN KEY (`carrierID`) REFERENCES `Carrier` (`carrierID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneFeature`
--
ALTER TABLE `PhoneFeature`
  ADD CONSTRAINT `FK_PhoneFeature_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PhoneFeature_FeatureID_F` FOREIGN KEY (`featureID`) REFERENCES `Feature` (`featureID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneSensor`
--
ALTER TABLE `PhoneSensor`
  ADD CONSTRAINT `FK_PhoneSensor_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_PhoneSensor_sensorID` FOREIGN KEY (`sensorID`) REFERENCES `Sensor` (`sensorID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `SIM`
--
ALTER TABLE `SIM`
  ADD CONSTRAINT `FK_SIM_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
