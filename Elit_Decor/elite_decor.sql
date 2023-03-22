-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Már 22. 14:30
-- Kiszolgáló verziója: 10.4.6-MariaDB
-- PHP verzió: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `elite_decor`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `idopotfoglalas`
--

CREATE TABLE `idopotfoglalas` (
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `telszam` int(7) NOT NULL,
  `email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `idopont` date NOT NULL,
  `id` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `idopotfoglalas`
--

INSERT INTO `idopotfoglalas` (`nev`, `telszam`, `email`, `idopont`, `id`) VALUES
('fdfddfd', 454554, 'dfdfd', '0000-00-00', 0),
('fdfddfd', 454554, 'dfdfd', '0000-00-00', 0),
('fddf', 3434, 'dfdff', '0000-00-00', 0),
('fddf', 3434, 'dfdff', '0000-00-00', 0),
('fgd', 454, 'fdf', '0000-00-00', 0),
('gbgh', 3434, 'fgtg', '0000-00-00', 0),
('vgfvgfg', 545656, 'fgfgffg', '2022-12-12', 0),
('', 0, '', '0000-00-00', 0),
('', 0, '', '0000-00-00', 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ingatlanok`
--

CREATE TABLE `ingatlanok` (
  `id` int(11) NOT NULL,
  `ar` int(7) NOT NULL,
  `hely` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `cm2` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `szobak_szama` int(2) NOT NULL,
  `tipus` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `kep` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ingatlanok`
--

INSERT INTO `ingatlanok` (`id`, `ar`, `hely`, `cm2`, `szobak_szama`, `tipus`, `kep`) VALUES
(1, 4000000, '6900. Makó, Fasirt utca 12.', '100', 4, 'kertes ház', 'haz1.jpg'),
(2, 6000000, '6900. Makó, Fagyi utca 1.', '90', 3, 'kertes ház', 'haz2.jpg'),
(3, 9000000, '6900. Makó, Póni utca 50.', '130', 5, 'kertes ház', 'haz3.jpg'),
(4, 3000000, '6900. Makó, Kísértet utca 40.', '140', 4, 'kísértet ház', 'haz4.jpg'),
(5, 4000000, '6900. Makó, Nyuszi utca 14.', '60', 2, 'panel', 'haz5.jpg'),
(6, 6000000, '6900. Makó, Pillangó utca 2.', '50', 1, 'panel', 'haz6.jpg'),
(7, 9000000, '6900. Makó, Luxus utca 4.', '80', 3, 'panel', 'haz7.jpg'),
(8, 20000000, '6900. Makó, Kálvin utca 4.', '130', 4, 'kertes ház', 'haz8.jpg');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szolgaltatasok`
--

CREATE TABLE `szolgaltatasok` (
  `id` int(1) NOT NULL,
  `megnev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(500) COLLATE utf8_hungarian_ci NOT NULL,
  `ar` int(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `szolgaltatasok`
--

INSERT INTO `szolgaltatasok` (`id`, `megnev`, `leiras`, `ar`) VALUES
(1, 'tanácsadás', 'Tanácsadás színekben, kiegészítőkben, textíliákban, bútorokban, valamint elrendezésben.', 20000),
(2, 'tervezés', 'Tervek készítése ízlésnek és stílusnak megfelelően.', 40000),
(3, 'tervezés és kivitelezés', '2-3 terv készítése, Teljeskörű konszignáció és műleírás és teljeskörű költségvetés készítése.', 80000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vetel`
--

CREATE TABLE `vetel` (
  `id` int(2) NOT NULL,
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `idopotfoglalas`
--
ALTER TABLE `idopotfoglalas`
  ADD KEY `idopont` (`idopont`);

--
-- A tábla indexei `ingatlanok`
--
ALTER TABLE `ingatlanok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `szolgaltatasok`
--
ALTER TABLE `szolgaltatasok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `vetel`
--
ALTER TABLE `vetel`
  ADD PRIMARY KEY (`email`),
  ADD KEY `id` (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `ingatlanok`
--
ALTER TABLE `ingatlanok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
