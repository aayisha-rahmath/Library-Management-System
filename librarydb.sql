-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2024 at 03:30 PM
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
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `bookid` int(11) NOT NULL,
  `title` varchar(200) NOT NULL,
  `author` varchar(200) NOT NULL,
  `total_copies` int(100) NOT NULL,
  `available_copies` int(100) NOT NULL,
  `publisher` varchar(250) NOT NULL,
  `published_year` year(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`bookid`, `title`, `author`, `total_copies`, `available_copies`, `publisher`, `published_year`) VALUES
(6, 'djcndnvndn', 'dvdvd', 3243, 34, 'fvrvr', '2027'),
(7, 'qwerty', 'zxcvbn', 11, 11, 'qwert', '2024'),
(8, 'qwerty', 'zxcvb', 10, 10, 'mnbvc', '2024');

-- --------------------------------------------------------

--
-- Table structure for table `tblissue`
--

CREATE TABLE `tblissue` (
  `Issue_ID` int(11) NOT NULL,
  `MemberId` int(100) NOT NULL,
  `MemberName` varchar(200) NOT NULL,
  `bookId` int(100) NOT NULL,
  `bookTitle` varchar(200) NOT NULL,
  `IssueDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblissue`
--

INSERT INTO `tblissue` (`Issue_ID`, `MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`) VALUES
(9, 56, 'werty', 7, 'qwerty', '2024-06-11'),
(10, 11, 'qwer', 8, 'qwerty', '2024-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `tblmember`
--

CREATE TABLE `tblmember` (
  `MemberId` int(11) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `NIC` varchar(15) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Contact` int(10) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Date_Joined` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblmember`
--

INSERT INTO `tblmember` (`MemberId`, `Name`, `NIC`, `Gender`, `Contact`, `Email`, `Date_Joined`) VALUES
(4, 'sahafs', 'sfdfdsss', 'Male', 576767, 'fdfdfd', '2024-06-10'),
(7, '', '', 'Male', 0, '', '0000-00-00'),
(8, '', '', '', 0, '', '0000-00-00'),
(9, 'Aayisha', '34353535', 'Male', 51145459, 'vkndnvfv', '2024-06-11'),
(10, '', '', 'Male', 0, '', '0000-00-00'),
(11, '', '', '', 0, '', '0000-00-00'),
(12, '', '', '', 0, '', '0000-00-00'),
(13, 'sharaf', '0498575755', 'Male', 51454, 'mkksknins', '0000-00-00'),
(14, '', '', 'Male', 0, '', '0000-00-00'),
(15, '', '', 'Male', 0, '', '0000-00-00'),
(16, '', '', 'Male', 0, '', '0000-00-00'),
(17, '', '', 'Male', 0, '', '0000-00-00'),
(18, '', '', 'Male', 0, '', '0000-00-00'),
(19, '', '', 'Male', 0, '', '0000-00-00'),
(20, '', '', 'Male', 0, '', '0000-00-00'),
(21, '', '', '', 0, '', '0000-00-00'),
(22, '', '', '', 0, '', '0000-00-00'),
(23, '', '', 'Male', 0, '', '0000-00-00'),
(25, '', '', 'Male', 0, '', '0000-00-00'),
(26, '', '', 'Male', 0, '', '0000-00-00'),
(27, '', '', 'Male', 0, '', '0000-00-00'),
(28, '', '', 'Male', 0, '', '0000-00-00'),
(29, '', '', 'Male', 0, '', '0000-00-00'),
(30, '', '', 'Male', 0, '', '0000-00-00'),
(31, '', '', 'Male', 0, '', '0000-00-00'),
(32, '', '', 'Male', 0, '', '0000-00-00'),
(33, '', '', 'Male', 0, '', '0000-00-00'),
(34, '', '', 'Male', 0, '', '0000-00-00'),
(35, '', '', 'Male', 0, '', '0000-00-00'),
(36, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(37, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(38, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(39, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(40, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(41, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(42, 'sharaf', '123456789V', 'Male', 1234567890, 'test@example.com', '0000-00-00'),
(43, '', '', 'Male', 0, '', '0000-00-00'),
(44, '', '', 'Male', 0, '', '0000-00-00'),
(45, '', '', 'Male', 0, '', '0000-00-00'),
(46, 'edecf', 'efe3', 'Male', 32442, 'ffrvr', '2026-06-09'),
(47, 'fvfvf', '2343c', 'Male', 34343, 'dvdvd', '2026-06-09'),
(48, 'effef', '334343', 'Male', 34343, 'efefe34', '2026-06-09'),
(49, 'dfdfd', '55565v', 'Male', 434334343, 'dfdfdf3', '2024-06-09'),
(50, 'fffgf', '4545v', 'Male', 3435353, 'dfddfgfgf', '2024-06-09'),
(51, 'rgfgf', '454f', 'Male', 33533, 'fvfvfv', '2025-06-09'),
(52, 'hjhhj', '6767', 'Male', 776767, 'jmjmj', '2025-06-09'),
(53, 'hnhnh', '67676', 'Male', 7868686, 'jujujuj', '2025-06-09'),
(54, 'dfdf', '343434', 'Male', 35345454, 'rgrgrg', '2025-06-09'),
(55, 'dvdkv', '4456dd', 'Male', 395039058, 'dcidividv', '2024-06-01'),
(56, 'werty', '1234', 'Male', 1234, 'qwerty', '2024-06-09');

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `Return_Id` int(11) NOT NULL,
  `MemberId` int(100) NOT NULL,
  `MemberName` varchar(100) NOT NULL,
  `bookId` int(100) NOT NULL,
  `bookTitle` varchar(100) NOT NULL,
  `IssueDate` date NOT NULL,
  `ReturnDate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`Return_Id`, `MemberId`, `MemberName`, `bookId`, `bookTitle`, `IssueDate`, `ReturnDate`) VALUES
(7, 56, 'werty', 7, 'qwerty', '2024-06-09', '2024-06-11'),
(9, 10, 'qwert', 8, 'qwerty', '2024-06-09', '2024-06-09');

-- --------------------------------------------------------

--
-- Table structure for table `tblstaff`
--

CREATE TABLE `tblstaff` (
  `Staff_ID` int(11) NOT NULL,
  `Staffname` varchar(100) NOT NULL,
  `NIC` varchar(50) NOT NULL,
  `Contact` int(10) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Joined_Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstaff`
--

INSERT INTO `tblstaff` (`Staff_ID`, `Staffname`, `NIC`, `Contact`, `Email`, `Joined_Date`) VALUES
(1, 'sharaf', 'dvfvfv2', 231122, 'gmail', '2024-06-11');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userID` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `userType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userID`, `username`, `password`, `userType`) VALUES
(1, 'admin', '123', 'Admin'),
(2, 'sharaf', '123', 'Admin'),
(3, 'user', '123', 'Librarian');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`bookid`);

--
-- Indexes for table `tblissue`
--
ALTER TABLE `tblissue`
  ADD PRIMARY KEY (`Issue_ID`),
  ADD KEY `Book` (`bookId`),
  ADD KEY `Member` (`MemberId`);

--
-- Indexes for table `tblmember`
--
ALTER TABLE `tblmember`
  ADD PRIMARY KEY (`MemberId`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`Return_Id`),
  ADD KEY `MemberId` (`MemberId`),
  ADD KEY `BookId` (`bookId`);

--
-- Indexes for table `tblstaff`
--
ALTER TABLE `tblstaff`
  ADD PRIMARY KEY (`Staff_ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `bookid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tblissue`
--
ALTER TABLE `tblissue`
  MODIFY `Issue_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tblmember`
--
ALTER TABLE `tblmember`
  MODIFY `MemberId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `Return_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblstaff`
--
ALTER TABLE `tblstaff`
  MODIFY `Staff_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblissue`
--
ALTER TABLE `tblissue`
  ADD CONSTRAINT `Book` FOREIGN KEY (`bookId`) REFERENCES `tblbooks` (`bookid`),
  ADD CONSTRAINT `Member` FOREIGN KEY (`MemberId`) REFERENCES `tblmember` (`MemberId`);

--
-- Constraints for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD CONSTRAINT `BookId` FOREIGN KEY (`bookId`) REFERENCES `tblbooks` (`bookid`),
  ADD CONSTRAINT `MemberId` FOREIGN KEY (`MemberId`) REFERENCES `tblmember` (`MemberId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;