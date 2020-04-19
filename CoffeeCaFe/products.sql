-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 19, 2020 at 08:55 AM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `menu_coffee`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
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
(1040, 'Red Velvet Cake', 55, 'Bakery');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1041;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
