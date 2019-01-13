BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Skladiste` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	TEXT NOT NULL UNIQUE,
	`Prodavac`	TEXT,
	`Kolicina`	INTEGER NOT NULL,
	`MjernaJedinica`	TEXT,
	`Cijena`	FLOAT
);

CREATE TABLE IF NOT EXISTS `Mjesta` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMjesta`	TEXT NOT NULL,
	`Adresa`	TEXT NOT NULL,
	`VrijemeRadaOD`	DATETIME,
	`VrijemeRadaDO`	DATETIME,
	CONSTRAINT `Naziv_Adresa` UNIQUE(`NazivMjesta`,`Adresa`)
); 

CREATE TABLE IF NOT EXISTS `Evidencija` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMjesta`	TEXT,
	`Datum`	DATETIME NOT NULL,
	`OpisPosla`	TEXT NOT NULL,
	`UtrosenoVrijeme`	INTEGER NOT NULL,
	`ID_mjesta` INTEGER ,
	FOREIGN KEY(`ID_mjesta`) REFERENCES `Mjesta`(`ID`)
); 

CREATE TABLE IF NOT EXISTS `Poveznica` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	Text,
	`Id_Evidencija`	INTEGER,
	`Kolicina`	INTEGER,
	`Cijena`	FLOAT,
	`Id_Materijala`	INTEGER,
	FOREIGN KEY(`Id_Evidencija`) REFERENCES `Evidencija`(`ID`),
	FOREIGN KEY(`Id_Materijala`) REFERENCES `Skladiste`(`ID`),
	FOREIGN KEY(`NazivMaterijala`) REFERENCES `Skladiste`(`NazivMaterijala`)
);

CREATE TRIGGER PromjeniUpdate AFTER UPDATE ON Mjesta FOR EACH ROW BEGIN UPDATE Mjesta 
SET VrijemeRadaOD = NULLIF(VrijemeRadaOD, ''),
VrijemeRadaDO = NULLIF(VrijemeRadaDO, ''); END;
CREATE TRIGGER PromjeniInsert AFTER INSERT ON Mjesta FOR EACH ROW BEGIN UPDATE Mjesta 
SET VrijemeRadaOD = NULLIF(VrijemeRadaOD, ''),
VrijemeRadaDO = NULLIF(VrijemeRadaDO, ''); END;
COMMIT;
