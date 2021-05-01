-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-05-2021 a las 18:51:34
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bbdd aev7`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `nif` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `nombre` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `apellido` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `administrador` tinyint(4) NOT NULL,
  `claveAdmin` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`nif`, `nombre`, `apellido`, `administrador`, `claveAdmin`) VALUES
('23432343D', 'pepe', 'jones', 1, '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `fichaje`
--

CREATE TABLE `fichaje` (
  `Empleado_nif` varchar(9) COLLATE utf8_spanish_ci NOT NULL,
  `dia` date NOT NULL,
  `horaEntrada` time DEFAULT NULL,
  `horaSalida` time DEFAULT NULL,
  `fichadoEntrada` tinyint(4) NOT NULL,
  `fichadoSalida` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`nif`),
  ADD KEY `nif` (`nif`);

--
-- Indices de la tabla `fichaje`
--
ALTER TABLE `fichaje`
  ADD PRIMARY KEY (`Empleado_nif`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `fichaje`
--
ALTER TABLE `fichaje`
  ADD CONSTRAINT `fichaje_ibfk_1` FOREIGN KEY (`Empleado_nif`) REFERENCES `empleado` (`nif`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
