-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2020 at 12:17 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coffee cafe`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `Username` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `CustomerLastname` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') COLLATE utf8_unicode_ci NOT NULL,
  `CustomerType` enum('Member','VIP','Other') COLLATE utf8_unicode_ci NOT NULL,
  `CustomerTelNo` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `CustumerEmail` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `Username`, `CustomerName`, `CustomerLastname`, `Gender`, `CustomerType`, `CustomerTelNo`, `CustumerEmail`) VALUES
(31654, 'Ju', 'Phunumas', 'Thanhoog', 'M', 'VIP', '0987654321', 'Phunamas'),
(123456, 'rew', 'rewt', 'sadff', 'F', 'VIP', '0987456311', 'agdt@gmail.com'),
(698741, 'gad', 'had', 'jaou', 'M', 'Member', '0123456789', 'asd@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES
(1001, 'Iced Latte', 35, 'Cold'),
(1002, 'Iced Cocoa', 30, 'Cold'),
(1003, 'Iced Green Tea', 40, 'Cold'),
(1004, 'Hot Americano', 45, 'Hot'),
(1005, 'Hot Latte', 50, 'Hot'),
(1006, 'Hot Mocha', 55, 'Hot'),
(1007, 'Americano', 50, 'Cold'),
(1008, 'Latte', 55, 'Cold'),
(1009, 'Espresso', 65, 'Cold'),
(1010, 'Mocha', 60, 'Cold'),
(1011, 'Espresso', 60, 'Hot'),
(1012, 'Cappuccino', 60, 'Hot'),
(1013, 'Cappuccino', 65, 'Cold'),
(1014, 'Macchiato', 60, 'Hot'),
(1015, 'Macchiato', 65, 'Cold'),
(1016, 'Frappe', 45, 'Hot'),
(1017, 'Frappe', 50, 'Cold'),
(1018, 'Affogato', 50, 'Hot'),
(1019, 'Affogato', 55, 'Cold'),
(1020, 'Green Teaa Matcha Soda', 55, 'Cold'),
(1021, 'Matcha Green Tea Smoothie', 60, 'cold'),
(1022, 'Thai tea', 35, 'cold'),
(1023, 'Bonsai Milk Tea', 55, 'cold'),
(1024, 'Driedd Fruit Tea', 50, 'cold'),
(1025, 'Roselle Tea', 45, 'cold'),
(1026, 'Ginger Lemon Tea', 40, 'clod'),
(1027, 'Ice Ceylon Tea Milk Foam', 55, 'clod'),
(1028, 'Hot Ceylon Tea Milk Foam', 50, 'Hot'),
(1029, 'Matcha Green Tea Macchiato', 50, 'cold'),
(1030, 'Crepe Cake', 50, 'Bakery'),
(1031, 'Pancakes', 45, 'Bakery'),
(1032, 'Roll Cake', 35, 'Bakery'),
(1033, 'Browine', 40, 'Bakery'),
(1034, 'Chocolate Lava', 55, 'Bakery'),
(1035, 'Cheese cake', 50, 'Bakery'),
(1036, 'waffle', 25, 'Bakery'),
(1037, 'Honey Toast', 70, 'Bakery'),
(1038, 'Fondue', 120, 'Bakery'),
(1039, 'Cup Cake', 20, 'Bakery'),
(1040, 'Red Velvet Cake', 55, 'Bakery'),
(1041, 'Cup Cake ice', 60, 'Bakery'),
(1042, 'hot cocoa', 50, 'hot'),
(1043, 'ice cocoa', 45, 'ict'),
(1044, 'ict', 12, 'ict');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `SaleDateTime` datetime NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `GrandTotal` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`, `GrandTotal`) VALUES
(102, '2020-04-23 00:00:00', 31654, 2, 35),
(6285, '2020-04-23 00:06:32', 31654, 2, 35),
(6337, '2020-04-22 00:06:58', 31654, 2, 105);

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `SaleDetailID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `ProductName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Amount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sale_details`
--

INSERT INTO `sale_details` (`SaleDetailID`, `SaleID`, `ProductName`, `Price`, `Quantity`, `Amount`) VALUES
(19008, 6285, 'Iced Latte   ', 35, 1, 35),
(47814, 6337, 'Iced Latte   ', 35, 3, 105);

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `StaffName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') COLLATE utf8_unicode_ci NOT NULL,
  `StaffPassword` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES
(1, '101', 'mr.rattanasuk', 'F', 'asd', 'Manager'),
(2, '102', 'mr.rattanasuk', 'F', 'asd', 'Staff'),
(3, '103', 'mr.rattanasuk', 'F', 'asd', 'Admin'),
(4, '104', 'rattanasuk', 'M', 'asd', 'Staff'),
(5, '105', 'com', 'M', 'asd', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `StaffCode` (`StaffCode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=123456790;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1058;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9886;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=99778;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2147483648;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
