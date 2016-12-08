-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2016 at 05:39 PM
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
  `fps` int(3) DEFAULT NULL,
  `opticalZoom` int(2) NOT NULL,
  `location` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Camera`
--

INSERT INTO `Camera` (`cameraID`, `resolutionWidthPixels`, `resolutionHeightPixels`, `mPixels`, `fps`, `opticalZoom`, `location`) VALUES
(31, 320, 240, 2, 0, 0, 'back'),
(11, 480, 800, 1.3, 30, 0, 'front'),
(9, 480, 800, 5, 30, 0, 'back'),
(10, 480, 800, 8, 30, 0, 'back'),
(8, 540, 960, 1.1, 30, 0, 'front'),
(7, 540, 960, 5, 30, 0, 'back'),
(24, 720, 1280, 0.9, 30, 0, 'front'),
(20, 720, 1280, 1.3, 30, 0, 'front'),
(2, 720, 1280, 5, 30, 0, 'front'),
(1, 720, 1280, 8, 30, 0, 'back'),
(17, 720, 1280, 8, 30, 0, 'front'),
(23, 720, 1280, 10, 30, 0, 'back'),
(3, 720, 1280, 13, 30, 0, 'back'),
(16, 1080, 1920, 4, 30, 0, 'front'),
(18, 1080, 1920, 5, 30, 0, 'front'),
(30, 1080, 1920, 5.1, 60, 0, 'front'),
(19, 1080, 1920, 7, 30, 0, 'front'),
(21, 1080, 1920, 8, 30, 0, 'back'),
(13, 1080, 1920, 8, 60, 0, 'front'),
(12, 1080, 1920, 12, 60, 0, 'back'),
(25, 1080, 1920, 13, 60, 0, 'back'),
(28, 1080, 1920, 13, 60, 0, 'front'),
(26, 1080, 1920, 16, 60, 0, 'back'),
(27, 1080, 1920, 23, 60, 0, 'back'),
(15, 1440, 2560, 5, 60, 0, 'front'),
(5, 1440, 2560, 8, 60, 0, 'front'),
(14, 1440, 2560, 12, 60, 0, 'back'),
(22, 1440, 2560, 16, 60, 2, 'back'),
(4, 1440, 2560, 20, 60, 0, 'back'),
(6, 1440, 2560, 21, 60, 0, 'back'),
(29, 2160, 3840, 23, 60, 2, 'back');

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
(1, 1, 'Verizon'),
(2, 2, 'AT&T'),
(3, 1, 'Sprint'),
(4, 2, 'T-Mobile'),
(5, 2, 'Metro PCS');

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
(2, 'lightning port'),
(1, 'micro USB port'),
(4, 'mini USB port'),
(3, 'USB type C port');

-- --------------------------------------------------------

--
-- Table structure for table `CPU`
--

CREATE TABLE `CPU` (
  `CPUID` int(2) NOT NULL,
  `brand` varchar(20) NOT NULL,
  `model` varchar(20) DEFAULT NULL,
  `numCores` int(2) NOT NULL,
  `frequency` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `CPU`
--

INSERT INTO `CPU` (`CPUID`, `brand`, `model`, `numCores`, `frequency`) VALUES
(10, 'Apple', 'A10 Fusion', 4, 2.34),
(9, 'Apple', 'A9', 2, 1.84),
(14, 'BlackBerry', 'null', 1, 0.312),
(12, 'Exynos', '8890 Octa', 8, 2.3),
(2, 'Mediatek ', 'MT6737', 4, 1.3),
(7, 'Mediatek', 'MT6795T Helio X10', 8, 2.2),
(1, 'SnapDragon', '210', 4, 1.1),
(4, 'SnapDragon', '400', 4, 1.2),
(11, 'Snapdragon', '800', 4, 2.2),
(8, 'Snapdragon', '810', 8, 2),
(3, 'SnapDragon', '820', 4, 2.15),
(6, 'Snapdragon', '821', 4, 2.15),
(13, 'Snapdragon', 'Qualcomm S2', 1, 0.8),
(5, 'Snapdragon', 'S4 Plus', 2, 1.5);

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
(8, 'AMOLED', 1, 1920, 1080, 5, 441),
(13, 'AMOLED', 1, 1920, 1080, 5.2, 423),
(19, 'AMOLED', 1, 1920, 1080, 5.5, 401),
(20, 'AMOLED', 1, 2560, 1440, 5.1, 577),
(17, 'AMOLED', 1, 2560, 1440, 5.4, 540),
(4, 'AMOLED', 1, 2560, 1440, 5.5, 535),
(3, 'AMOLED', 1, 2560, 1440, 5.5, 538),
(12, 'AMOLED', 1, 2560, 1440, 5.7, 518),
(7, 'IPS LCD', 1, 800, 480, 4, 233),
(2, 'IPS LCD', 1, 1280, 720, 5, 294),
(1, 'IPS LCD', 1, 1280, 720, 5.5, 267),
(10, 'IPS LCD', 1, 1334, 750, 4.7, 326),
(18, 'IPS LCD', 1, 1920, 1080, 5, 441),
(21, 'IPS LCD', 1, 1920, 1080, 5.2, 424),
(11, 'IPS LCD', 1, 1920, 1080, 5.5, 401),
(15, 'IPS LCD', 1, 2560, 1440, 5.3, 554),
(16, 'IPS LCD', 1, 2560, 1440, 5.7, 513),
(22, 'IPS LCD', 1, 3840, 2160, 5.5, 806),
(23, 'LCD', 0, 240, 320, 2.5, 160),
(6, 'TFT LCD', 1, 800, 480, 3.6, 259),
(5, 'Touch LCD', 1, 960, 540, 5, 220),
(14, 'Touch LCD', 1, 1280, 720, 4.3, 342),
(9, 'Touch LCD', 1, 2560, 1440, 5.2, 565);

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
(4, 'Dual-Back Camera'),
(5, 'Dust Resistant '),
(7, 'FM Radio'),
(3, 'Removeable Battery'),
(8, 'Scratch Resistant'),
(2, 'Shock Resistant'),
(6, 'Solar Radiation Resistant'),
(1, 'Water Resistant');

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
(1, 'Alcatel'),
(7, 'Apple'),
(3, 'Blackberry'),
(4, 'Casio'),
(5, 'Google'),
(6, 'HTC'),
(8, 'Huawei'),
(9, 'Kyocera'),
(10, 'LG'),
(11, 'Motorola'),
(12, 'Nokia'),
(13, 'Oneplus'),
(14, 'Samsung'),
(15, 'Sony'),
(2, 'ZTE');

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
(1, 'CDMA'),
(2, 'GSM');

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
(1, 'Android v2.3'),
(2, 'Android v4.0'),
(3, 'Android v5.0'),
(4, 'Android v5.1'),
(5, 'Android v6.0'),
(6, 'Android v7.0'),
(7, 'Android v7.1'),
(11, 'Blackberry 10.2'),
(12, 'BlackBerry OS'),
(10, 'iOS 10'),
(9, 'iOS 9'),
(8, 'Windows 8.1');

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
  `expandableCapacity` int(3) NOT NULL,
  `RAMcapacity` int(2) NOT NULL,
  `monthReleased` int(2) NOT NULL,
  `yearReleased` year(4) NOT NULL,
  `stillAvailable` tinyint(1) NOT NULL,
  `weight` float NOT NULL,
  `hasExternalKeyboard` tinyint(1) NOT NULL,
  `hasExternalSpeakers` tinyint(1) NOT NULL,
  `analogAudioJack` tinyint(1) NOT NULL,
  `physicalHomeButton` tinyint(1) NOT NULL,
  `manufacturerID` int(2) NOT NULL,
  `batteryCapacity` int(5) NOT NULL,
  `pictureURL` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='main table';

--
-- Dumping data for table `Phone`
--

INSERT INTO `Phone` (`phoneID`, `name`, `displayID`, `chargePortID`, `OSID`, `CPUID`, `isUnlocked`, `price`, `internalCapacity`, `expandableCapacity`, `RAMcapacity`, `monthReleased`, `yearReleased`, `stillAvailable`, `weight`, `hasExternalKeyboard`, `hasExternalSpeakers`, `analogAudioJack`, `physicalHomeButton`, `manufacturerID`, `batteryCapacity`, `pictureURL`) VALUES
(1, 'Fierce 4', 1, 1, 5, 1, 0, 130, 16384, 256, 2000, 8, 2016, 1, 163.9, 0, 1, 1, 0, 1, 2500, 'http://cdn2.gsmarena.com/vv/bigpic/alcatel-fierce-4.jpg'),
(2, 'Shine Lite', 2, 1, 5, 2, 1, 225, 16384, 256, 2000, 9, 2016, 1, 156, 0, 1, 1, 0, 1, 2460, 'http://cdn2.gsmarena.com/vv/bigpic/alcatel-shine-lite.jpg'),
(3, 'ZTE Axon 7', 3, 3, 5, 3, 1, 399.98, 65536, 256, 4000, 6, 2016, 1, 175, 0, 1, 1, 0, 2, 3250, 'http://cdn2.gsmarena.com/vv/bigpic/zte-axon-7.jpg'),
(4, 'DTEK60', 4, 3, 5, 3, 1, 499.99, 32768, 256, 4000, 10, 2016, 1, 165, 0, 1, 1, 0, 3, 2500, 'http://cdn2.gsmarena.com/vv/bigpic/bb-dtek-60r.jpg'),
(5, 'Z3', 5, 1, 11, 4, 1, 159.99, 8192, 32, 1500, 5, 2014, 1, 164, 0, 1, 1, 0, 3, 2500, 'http://cdn2.gsmarena.com/vv/bigpic/blackberry-z3-new.jpg'),
(6, 'G\'zOne Commando', 6, 1, 1, 13, 1, 54.99, 1024, 32, 512, 4, 2011, 0, 154, 0, 1, 1, 0, 4, 1460, 'http://cdn2.gsmarena.com/vv/bigpic/casio-gzone-commando.jpg'),
(7, 'G\'zOne CA-201L', 7, 1, 2, 5, 1, 89.99, 16384, 256, 1000, 5, 2013, 0, 173.8, 0, 1, 1, 0, 4, 1800, 'http://cdn2.gsmarena.com/vv/bigpic/casio-gzone-ca-201l.jpg'),
(8, 'Pixel', 8, 3, 7, 6, 0, 749, 131072, 0, 4000, 10, 2016, 1, 143, 0, 1, 1, 0, 5, 2770, 'http://cdn2.gsmarena.com/vv/bigpic/google-pixel.jpg'),
(9, '10', 9, 3, 5, 3, 1, 630, 65536, 256, 4000, 5, 2016, 1, 161, 0, 1, 1, 0, 6, 3000, 'http://cdn2.gsmarena.com/vv/bigpic/htc-10-r.jpg'),
(10, 'One M9+', 9, 1, 5, 7, 1, 417.99, 32768, 256, 3000, 5, 2015, 1, 168, 0, 1, 1, 1, 6, 2840, 'http://cdn2.gsmarena.com/vv/bigpic/htc-one-m9-plus-new.jpg'),
(11, 'Nexus 6p', 12, 3, 5, 8, 1, 459, 131072, 0, 3000, 9, 2015, 1, 178, 0, 1, 1, 0, 8, 3450, 'http://cdn2.gsmarena.com/vv/bigpic/huawei-nexus-6p-.jpg'),
(12, 'P9', 13, 3, 5, 9, 1, 490.95, 65536, 256, 4000, 4, 2016, 1, 144, 0, 1, 1, 0, 8, 3000, 'http://cdn2.gsmarena.com/vv/bigpic/huawei-p9r2.jpg'),
(13, 'Iphone 6s', 10, 2, 9, 9, 1, 549, 131072, 0, 2000, 9, 2015, 1, 143, 0, 1, 1, 1, 7, 1715, 'http://cdn2.gsmarena.com/vv/bigpic/apple-iphone-6s1.jpg'),
(14, 'Iphone 6s Plus', 11, 2, 9, 10, 1, 649, 131072, 0, 2000, 9, 2015, 1, 192, 0, 1, 1, 1, 7, 2750, 'http://cdn2.gsmarena.com/vv/bigpic/apple-iphone-6s-plus.jpg'),
(15, 'Iphone 7', 10, 2, 10, 10, 1, 649, 262144, 0, 2000, 9, 2016, 1, 138, 0, 1, 0, 1, 7, 1960, 'http://cdn2.gsmarena.com/vv/bigpic/apple-iphone-7r4.jpg'),
(16, 'Iphone 7 Plus', 11, 2, 10, 5, 1, 769, 262144, 0, 3000, 9, 2016, 1, 188, 0, 1, 0, 1, 7, 2900, 'http://cdn2.gsmarena.com/vv/bigpic/apple-iphone-7-plus-r2.jpg'),
(17, 'Hydro Elite', 14, 1, 2, 5, 1, 99.5, 16384, 256, 1500, 7, 2013, 1, 128, 0, 1, 1, 0, 9, 2100, 'http://cdn2.gsmarena.com/vv/bigpic/kyocera-hydro-elite.jpg'),
(18, 'G5', 15, 3, 5, 3, 1, 449.99, 32768, 256, 4000, 4, 2016, 1, 159, 0, 1, 1, 0, 10, 2800, 'http://cdn2.gsmarena.com/vv/bigpic/lg-g5.jpg'),
(19, 'V20', 16, 3, 6, 3, 1, 830, 65536, 256, 4000, 10, 2016, 1, 174, 0, 1, 1, 0, 10, 3200, 'http://cdn2.gsmarena.com/vv/bigpic/lg-v20-ofic1.jpg'),
(20, 'Droid Turbo 2', 17, 1, 4, 8, 1, 119.99, 65536, 256, 3000, 10, 2015, 1, 170.1, 0, 1, 1, 0, 11, 3760, 'http://cdn2.gsmarena.com/vv/bigpic/motorola-droid-turbo-2.jpg'),
(21, 'Moto Z Force', 4, 3, 5, 3, 1, 699.99, 65536, 256, 4000, 9, 2016, 1, 163, 0, 1, 0, 0, 11, 3500, 'http://cdn2.gsmarena.com/vv/bigpic/motorola-moto-z-force.jpg'),
(22, 'Lumia 830', 2, 1, 8, 4, 1, 69.8, 16384, 32, 1000, 9, 2014, 0, 150, 0, 1, 1, 0, 12, 2200, 'http://cdn2.gsmarena.com/vv/bigpic/nokia-lumia-830.jpg'),
(23, 'Lumia 930', 18, 1, 8, 11, 1, 199.99, 32768, 0, 2000, 7, 2014, 0, 167, 0, 1, 1, 0, 12, 2420, 'http://cdn2.gsmarena.com/vv/bigpic/nokia-lumia-930-new.jpg'),
(24, '2', 11, 3, 4, 8, 1, 299, 65536, 0, 4000, 8, 2015, 1, 175, 0, 1, 1, 0, 13, 3300, 'http://cdn2.gsmarena.com/vv/bigpic/oneplus-two.jpg'),
(25, '3', 19, 3, 5, 3, 1, 399, 65536, 0, 6000, 6, 2016, 1, 158, 0, 1, 1, 1, 13, 3000, 'http://cdn2.gsmarena.com/vv/bigpic/oneplus-3-.jpg'),
(26, 'Galaxy Note 7', 12, 3, 5, 12, 1, 834, 32768, 256, 4000, 9, 2016, 0, 169, 0, 1, 1, 1, 14, 3500, 'http://cdn1.tnwcdn.com/wp-content/blogs.dir/1/files/2016/09/samsung-galaxy-note-7-fire-car-.png'),
(27, 'Galaxy S7', 20, 1, 5, 3, 1, 672, 32768, 256, 4000, 3, 2016, 1, 152, 0, 1, 1, 1, 14, 3000, 'http://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s7--.jpg'),
(28, 'Galaxy S7 Edge', 4, 1, 5, 3, 1, 794.99, 32768, 256, 4000, 3, 2016, 1, 157, 0, 1, 1, 1, 14, 3600, 'http://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s7-edge-.jpg'),
(29, 'Xperia XZ', 21, 1, 5, 3, 1, 599.99, 65536, 256, 3000, 10, 2016, 1, 161, 0, 1, 1, 0, 15, 2900, 'http://cdn2.gsmarena.com/vv/bigpic/sony-xperia-xz.jpg'),
(30, 'Xperia Z5 Premium', 22, 1, 4, 8, 1, 491, 32768, 256, 3000, 11, 2015, 1, 180, 0, 1, 1, 0, 15, 3430, 'http://cdn2.gsmarena.com/vv/bigpic/sony-z5-premium-.jpg'),
(31, 'Curve 8330', 23, 4, 12, 14, 1, 299, 96, 32, 32, 12, 2007, 0, 113, 1, 1, 1, 1, 3, 1150, 'http://cdn2.gsmarena.com/vv/bigpic/blackberry-curve-8330.jpg');

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
(1, 2),
(2, 3),
(3, 4),
(10, 4),
(11, 4),
(23, 4),
(26, 4),
(3, 5),
(4, 5),
(4, 6),
(20, 6),
(21, 6),
(5, 7),
(5, 8),
(6, 9),
(7, 10),
(7, 11),
(8, 12),
(12, 12),
(8, 13),
(11, 13),
(12, 13),
(18, 13),
(25, 13),
(9, 14),
(13, 14),
(14, 14),
(15, 14),
(16, 14),
(27, 14),
(28, 14),
(9, 15),
(19, 15),
(20, 15),
(21, 15),
(26, 15),
(27, 15),
(28, 15),
(10, 16),
(2, 17),
(13, 18),
(14, 18),
(24, 18),
(15, 19),
(16, 19),
(17, 20),
(23, 20),
(17, 21),
(18, 22),
(19, 22),
(22, 23),
(22, 24),
(24, 25),
(25, 26),
(29, 27),
(29, 28),
(30, 29),
(30, 30),
(31, 31);

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
(3, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1),
(11, 1),
(12, 1),
(13, 1),
(14, 1),
(15, 1),
(16, 1),
(17, 1),
(18, 1),
(19, 1),
(20, 1),
(21, 1),
(26, 1),
(27, 1),
(28, 1),
(29, 1),
(3, 2),
(4, 2),
(5, 2),
(8, 2),
(9, 2),
(10, 2),
(11, 2),
(13, 2),
(14, 2),
(15, 2),
(16, 2),
(17, 2),
(18, 2),
(19, 2),
(20, 2),
(21, 2),
(22, 2),
(23, 2),
(24, 2),
(25, 2),
(26, 2),
(27, 2),
(28, 2),
(30, 2),
(31, 2),
(3, 3),
(8, 3),
(9, 3),
(10, 3),
(11, 3),
(12, 3),
(13, 3),
(14, 3),
(15, 3),
(16, 3),
(17, 3),
(18, 3),
(19, 3),
(20, 3),
(21, 3),
(26, 3),
(27, 3),
(28, 3),
(29, 3),
(1, 4),
(2, 4),
(3, 4),
(4, 4),
(5, 4),
(8, 4),
(9, 4),
(10, 4),
(11, 4),
(13, 4),
(14, 4),
(15, 4),
(16, 4),
(17, 4),
(18, 4),
(19, 4),
(20, 4),
(21, 4),
(22, 4),
(23, 4),
(24, 4),
(25, 4),
(26, 4),
(27, 4),
(28, 4),
(30, 4),
(31, 4),
(1, 5),
(2, 5),
(3, 5),
(4, 5),
(5, 5),
(8, 5),
(9, 5),
(10, 5),
(11, 5),
(13, 5),
(14, 5),
(15, 5),
(16, 5),
(17, 5),
(18, 5),
(19, 5),
(20, 5),
(21, 5),
(22, 5),
(23, 5),
(24, 5),
(25, 5),
(26, 5),
(27, 5),
(28, 5),
(30, 5),
(31, 5);

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
(7, 1),
(8, 1),
(9, 1),
(18, 1),
(27, 1),
(28, 1),
(29, 1),
(7, 2),
(8, 2),
(18, 2),
(7, 3),
(8, 3),
(18, 3),
(19, 3),
(20, 3),
(21, 3),
(23, 3),
(31, 3),
(17, 4),
(7, 5),
(8, 5),
(9, 5),
(18, 5),
(27, 5),
(28, 5),
(29, 5),
(7, 6),
(8, 6),
(18, 6),
(1, 7),
(5, 8),
(7, 8),
(8, 8),
(18, 8),
(30, 8);

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
(2, 1),
(3, 1),
(4, 1),
(5, 1),
(6, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1),
(11, 1),
(12, 1),
(13, 1),
(14, 1),
(15, 1),
(16, 1),
(17, 1),
(18, 1),
(19, 1),
(20, 1),
(21, 1),
(22, 1),
(23, 1),
(24, 1),
(25, 1),
(26, 1),
(27, 1),
(28, 1),
(29, 1),
(30, 1),
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 2),
(6, 2),
(7, 2),
(8, 2),
(9, 2),
(10, 2),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 2),
(16, 2),
(17, 2),
(18, 2),
(19, 2),
(20, 2),
(21, 2),
(22, 2),
(23, 2),
(24, 2),
(25, 2),
(26, 2),
(27, 2),
(28, 2),
(29, 2),
(30, 2),
(1, 3),
(2, 3),
(3, 3),
(4, 3),
(6, 3),
(7, 3),
(8, 3),
(9, 3),
(10, 3),
(11, 3),
(12, 3),
(13, 3),
(14, 3),
(15, 3),
(16, 3),
(17, 3),
(18, 3),
(19, 3),
(20, 3),
(21, 3),
(22, 3),
(23, 3),
(24, 3),
(25, 3),
(26, 3),
(27, 3),
(28, 3),
(29, 3),
(30, 3),
(2, 4),
(3, 4),
(4, 4),
(8, 4),
(9, 4),
(10, 4),
(11, 4),
(12, 4),
(13, 4),
(14, 4),
(15, 4),
(16, 4),
(18, 4),
(19, 4),
(21, 4),
(24, 4),
(25, 4),
(26, 4),
(27, 4),
(28, 4),
(29, 4),
(30, 4),
(3, 5),
(4, 5),
(8, 5),
(9, 5),
(10, 5),
(11, 5),
(12, 5),
(13, 5),
(14, 5),
(15, 5),
(16, 5),
(18, 5),
(19, 5),
(20, 5),
(21, 5),
(22, 5),
(23, 5),
(24, 5),
(25, 5),
(26, 5),
(27, 5),
(28, 5),
(29, 5),
(30, 5),
(6, 6),
(7, 6),
(7, 7),
(8, 7),
(11, 7),
(13, 7),
(14, 7),
(15, 7),
(16, 7),
(18, 7),
(26, 7),
(27, 7),
(28, 7),
(29, 7),
(30, 7),
(18, 8),
(19, 8),
(29, 8),
(23, 9),
(26, 10),
(26, 11),
(27, 11),
(28, 11),
(26, 12),
(27, 12),
(28, 12);

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
(1, 'accelerometer'),
(7, 'barometer'),
(8, 'color spectrum'),
(3, 'compass'),
(4, 'fingerprint'),
(5, 'gyro'),
(11, 'heart rate'),
(10, 'iris scanner'),
(2, 'proximity'),
(9, 'sensor core'),
(12, 'Sp02'),
(6, 'thermometer');

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
(1, 1, 'Nano'),
(2, 2, 'Nano'),
(3, 2, 'Nano'),
(4, 1, 'Nano'),
(5, 1, 'Micro'),
(6, 1, 'Embeded'),
(7, 1, 'Micro'),
(8, 1, 'Nano'),
(9, 1, 'Nano'),
(10, 1, 'Nano'),
(11, 1, 'Nano'),
(12, 2, 'Nano'),
(13, 1, 'Nano'),
(14, 1, 'Nano'),
(15, 1, 'Nano'),
(16, 1, 'Nano'),
(17, 1, 'Micro'),
(18, 2, 'Nano'),
(19, 2, 'Nano'),
(20, 1, 'Nano'),
(21, 1, 'Nano'),
(22, 1, 'Nano'),
(23, 1, 'Nano'),
(24, 1, 'Nano'),
(25, 2, 'Nano'),
(26, 2, 'Nano'),
(27, 2, 'Nano'),
(28, 2, 'Nano'),
(29, 2, 'Nano'),
(30, 1, 'Nano'),
(31, 1, 'Mini');

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
  MODIFY `cameraID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT for table `Carrier`
--
ALTER TABLE `Carrier`
  MODIFY `carrierID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `ChargePort`
--
ALTER TABLE `ChargePort`
  MODIFY `chargePortID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `CPU`
--
ALTER TABLE `CPU`
  MODIFY `CPUID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `Display`
--
ALTER TABLE `Display`
  MODIFY `displayID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `Feature`
--
ALTER TABLE `Feature`
  MODIFY `featureID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `Manufacturer`
--
ALTER TABLE `Manufacturer`
  MODIFY `manufacturerID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `Network`
--
ALTER TABLE `Network`
  MODIFY `networkID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `OS`
--
ALTER TABLE `OS`
  MODIFY `OSID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `Phone`
--
ALTER TABLE `Phone`
  MODIFY `phoneID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT for table `Sensor`
--
ALTER TABLE `Sensor`
  MODIFY `sensorID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `SIM`
--
ALTER TABLE `SIM`
  MODIFY `phoneID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Carrier`
--
ALTER TABLE `Carrier`
  ADD CONSTRAINT `CARRIER_NETEORK_networkID` FOREIGN KEY (`networkID`) REFERENCES `Network` (`networkID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `Phone`
--
ALTER TABLE `Phone`
  ADD CONSTRAINT `PHONE_CPU_cpuID` FOREIGN KEY (`CPUID`) REFERENCES `CPU` (`CPUID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONE_CHARGEPORT_chargePortID` FOREIGN KEY (`chargePortID`) REFERENCES `ChargePort` (`chargePortID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONE_DISPLAY_displayID` FOREIGN KEY (`displayID`) REFERENCES `Display` (`displayID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONE_MANUFACTURER_manufacturerID` FOREIGN KEY (`manufacturerID`) REFERENCES `Manufacturer` (`manufacturerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONE_OS_phoneID` FOREIGN KEY (`OSID`) REFERENCES `OS` (`OSID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneCamera`
--
ALTER TABLE `PhoneCamera`
  ADD CONSTRAINT `PHONECAMERA_CAMERA_cameraID` FOREIGN KEY (`cameraID`) REFERENCES `Camera` (`cameraID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONECAMERA_PHONE_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneCarrier`
--
ALTER TABLE `PhoneCarrier`
  ADD CONSTRAINT `PHONECARRIER_CARRIER_carrierID` FOREIGN KEY (`carrierID`) REFERENCES `Carrier` (`carrierID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONECARRIER_PHONE_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneFeature`
--
ALTER TABLE `PhoneFeature`
  ADD CONSTRAINT `PHONEFEATURE_FEATURE_featureID` FOREIGN KEY (`featureID`) REFERENCES `Feature` (`featureID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONEFEATURE_PHONE_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `PhoneSensor`
--
ALTER TABLE `PhoneSensor`
  ADD CONSTRAINT `PHONESENSOR_SENSOR` FOREIGN KEY (`sensorID`) REFERENCES `Sensor` (`sensorID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `PHONESENSOR_PHONE_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `SIM`
--
ALTER TABLE `SIM`
  ADD CONSTRAINT `SIM_PHONE_phoneID` FOREIGN KEY (`phoneID`) REFERENCES `Phone` (`phoneID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
