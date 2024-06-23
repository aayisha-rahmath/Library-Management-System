-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 23, 2024 at 08:02 AM
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
(1, 'PHP & MySQL', 'Jon Duckett', 10, 10, 'Wiley', '2022'),
(2, 'JavaScript and jQuery', 'Jon Duckett', 8, 8, 'Wiley', '2014'),
(3, 'HTML &CSS', 'Jon Duckett', 12, 12, 'John Wiley and Sons', '2011'),
(4, 'Professional C#', 'Christian Nagel', 8, 8, '‎Wrox Press', '2021'),
(5, 'More Effective C#', 'Bill Wagner', 9, 9, 'Addison-Wesley Professional', '2004'),
(6, 'Clean Code', 'Robert C Martin', 10, 10, 'Prentice Hall', '2008'),
(7, 'The Pragmatic Programmer', 'Andy Hunt', 8, 8, 'Addison-Welsey', '1999'),
(8, 'Thinking in Java', 'Bruce Eckel', 10, 10, 'Prentice Hall', '1998');

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
(1, 2, 'Harry', 1, 'PHP & MySQL', '2024-02-02'),
(2, 4, 'Smith', 3, 'HTML &CSS', '2024-02-05'),
(3, 1, 'John', 2, 'JavaScript and jQuery', '2024-02-08'),
(4, 5, 'Priya', 7, 'The Pragmatic Programmer', '2024-02-10'),
(5, 3, 'Pooja', 5, 'More Effective C#', '2024-02-19'),
(6, 6, 'James', 4, 'Professional C#', '2024-02-22');

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
(1, 'John', '123456789V', 'Male', 771112233, 'john@gmail.com', '2024-01-01'),
(2, 'Harry', '234567891V', 'Male', 772223344, 'harry@gmail.com', '2024-01-01'),
(3, 'Pooja', '345678912V', 'Female', 773334455, 'pooja@gmail.com', '2024-01-02'),
(4, 'Smith', '456789123V', 'Male', 774445566, 'smith@gmail.com', '2024-01-15'),
(5, 'Priya', '567891234V', 'Female', 775556677, 'priya@gmail.com', '2024-01-16'),
(6, 'James', '678912345V', 'Male', 776667788, 'james@gmail.com', '2024-01-17'),
(7, 'Kumar', '789123456V', 'Male', 777778899, 'kumar@gmail.com', '2024-02-06');

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
(1, 2, 'Harry', 1, 'PHP & MySQL', '2024-02-02', '2024-02-09'),
(2, 4, 'Smith', 3, 'HTML &CSS', '2024-02-05', '2024-02-10'),
(3, 1, 'John', 2, 'JavaScript and jQuery', '2024-02-08', '2024-02-15'),
(4, 5, 'Priya', 7, 'The Pragmatic Programmer', '2024-01-10', '2024-02-18'),
(5, 3, 'Pooja', 5, 'More Effective C#', '2024-02-19', '2024-02-25'),
(6, 6, 'James', 4, 'Professional C#', '2024-02-22', '2024-03-09');

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
(2, 'user', '123', 'Librarian');

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
  MODIFY `Issue_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblmember`
--
ALTER TABLE `tblmember`
  MODIFY `MemberId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `Return_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblstaff`
--
ALTER TABLE `tblstaff`
  MODIFY `Staff_ID` int(11) NOT NULL AUTO_INCREMENT;

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

