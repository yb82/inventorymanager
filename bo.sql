-- phpMyAdmin SQL Dump
-- version 4.6.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- 생성 시간: 17-03-27 15:47
-- 서버 버전: 5.5.52-MariaDB
-- PHP 버전: 5.6.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 데이터베이스: `bo`
--

-- --------------------------------------------------------

--
-- 테이블 구조 `Category`
--

CREATE TABLE `Category` (
  `Item_Category` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Duration` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- 테이블 구조 `CheckLog`
--

CREATE TABLE `CheckLog` (
  `id` int(11) NOT NULL,
  `Items_Barcode` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Item_Description` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `User_initial` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `StudentNo` varchar(7) COLLATE utf8_unicode_ci NOT NULL,
  `Check_Status` tinyint(1) DEFAULT NULL,
  `Check_Date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Expiry_Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- 테이블 구조 `Items`
--

CREATE TABLE `Items` (
  `Barcode` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `Item_Description` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `Status` tinyint(1) NOT NULL DEFAULT '1',
  `Item_Category` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Student_No` varchar(7) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Checkout_Date` date DEFAULT NULL,
  `Expiry_Date` date DEFAULT NULL,
  `User_Initial` varchar(3) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- 테이블 구조 `User`
--

CREATE TABLE `User` (
  `User_ID` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `User_Password` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `User_initial` varchar(3) COLLATE utf8_unicode_ci NOT NULL,
  `Role` varchar(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT 'User'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- 덤프된 테이블의 인덱스
--

--
-- 테이블의 인덱스 `Category`
--
ALTER TABLE `Category`
  ADD PRIMARY KEY (`Item_Category`);

--
-- 테이블의 인덱스 `CheckLog`
--
ALTER TABLE `CheckLog`
  ADD PRIMARY KEY (`id`);

--
-- 테이블의 인덱스 `Items`
--
ALTER TABLE `Items`
  ADD PRIMARY KEY (`Barcode`),
  ADD UNIQUE KEY `Barcode_UNIQUE` (`Barcode`),
  ADD KEY `fk_Items_Category_idx` (`Item_Category`);

--
-- 테이블의 인덱스 `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`User_ID`);

--
-- 덤프된 테이블의 AUTO_INCREMENT
--

--
-- 테이블의 AUTO_INCREMENT `CheckLog`
--
ALTER TABLE `CheckLog`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=810;
--
-- 덤프된 테이블의 제약사항
--

--
-- 테이블의 제약사항 `Items`
--
ALTER TABLE `Items`
  ADD CONSTRAINT `fk_Items_Category` FOREIGN KEY (`Item_Category`) REFERENCES `Category` (`Item_Category`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
