-- 8.feladat
CREATE DATABASE paralimpia
CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

-- 10.feladat
INSERT INTO paralimpia.jatekok VALUES("XVII.", 2024, "Párizs", "Franciaország");

-- 11.feladat
UPDATE paralimpia.versenyszamok set versenyszam="vegyespáros" WHERE id=9;

-- 12.feladat
DELETE FROM paralimpia.sportagak WHERE sportag="Lovaglás";

-- 13.feladat
SELECT jatekok.evszam, jatekok.varos FROM jatekok WHERE jatekok.evszam < 2021 ORDER BY jatekok.evszam DESC LIMIT 5;

-- 14.feladat
SELECT sportagak.sportag, COUNT(versenyszamok.id) AS expr1
FROM versenyszamok INNER JOIN sportagak ON versenyszamok.sportagId = sportagak.id GROUP BY sportagak.sportag;

-- 15.feladat
SELECT
  jatekok.sorszam,
  eredmenyek.helyezes,
  sportagak.sportag,
  olimpikonok.nev
FROM eredmenyek
  INNER JOIN jatekok
    ON eredmenyek.jatekId = jatekok.sorszam
  INNER JOIN versenyszamok
    ON eredmenyek.versenyszamId = versenyszamok.id
  INNER JOIN sportagak
    ON versenyszamok.sportagId = sportagak.id
  INNER JOIN olimpikonok
    ON eredmenyek.olimpikonId = olimpikonok.id
WHERE olimpikonok.nev LIKE "%,%"
ORDER BY eredmenyek.helyezes ASC, sportagak.sportag ASC;
