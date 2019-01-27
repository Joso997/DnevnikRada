BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Skladiste` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	TEXT NOT NULL UNIQUE,
	`Prodavac`	TEXT,
	`Kolicina`	INTEGER NOT NULL DEFAULT (0),
	`MjernaJedinica`	TEXT,
	`Cijena`	FLOAT,
	`Sifra`	INTEGER UNIQUE  check(Sifra between 1000 and 9999),
	`Link` TEXT,
	Sakriveno BOOLEAN  DEFAULT (0)
);

CREATE TABLE IF NOT EXISTS `Mjesta` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMjesta`	TEXT NOT NULL,
	`Adresa`	TEXT NOT NULL,
	Sakriveno BOOLEAN  DEFAULT (0),
	CONSTRAINT `Naziv_Adresa` UNIQUE(`NazivMjesta`,`Adresa`)
); 

CREATE TABLE IF NOT EXISTS `Evidencija` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMjesta`	TEXT,
	`Datum`	DATETIME NOT NULL,
	`OpisPosla`	TEXT NOT NULL,
	`UtrosenoVrijeme`	INTEGER NOT NULL,
	`ID_mjesta` INTEGER ,
	`Sifra`	INTEGER UNIQUE check(Sifra between 1000 and 9999),
	Sakriveno BOOLEAN  DEFAULT (0),
	FOREIGN KEY(`NazivMjesta`) REFERENCES `Mjesta`(`ID`),
	FOREIGN KEY(`ID_mjesta`) REFERENCES `Mjesta`(`ID`)
); 

CREATE TABLE IF NOT EXISTS `Poveznica` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	Text,
	`Id_Evidencija`	INTEGER,
	`Kolicina`	INTEGER,
	`Cijena`	FLOAT,
	`Id_Materijala`	INTEGER,
	Sakriveno BOOLEAN  DEFAULT (0),
	FOREIGN KEY(`Id_Evidencija`) REFERENCES `Evidencija`(`ID`),
	FOREIGN KEY(`Id_Materijala`) REFERENCES `Skladiste`(`ID`),
	FOREIGN KEY(`NazivMaterijala`) REFERENCES `Skladiste`(`NazivMaterijala`)
);

CREATE TABLE Kalendar (
    ID        INTEGER  PRIMARY KEY AUTOINCREMENT
                       NOT NULL
                       UNIQUE,
    Id_Mjesta INTEGER  NOT NULL,
    Datum     DATETIME NOT NULL,
    Sakriveno BOOLEAN  DEFAULT (0),
    Sifra     INTEGER  CHECK (Sifra BETWEEN 1000 AND 9999) 
                       UNIQUE,
    FOREIGN KEY (
        Id_Mjesta
    )
    REFERENCES Mjesta (ID) 
);



CREATE TRIGGER Nadopuni_Sifru
         AFTER INSERT
            ON Evidencija
      FOR EACH ROW
BEGIN
    UPDATE Evidencija
       SET Sifra = new.ID + 1000
     WHERE ID = new.ID;
END;
CREATE TRIGGER Nadopuni_Sifru_Kalendar
         AFTER INSERT
            ON Kalendar
      FOR EACH ROW
BEGIN
    UPDATE Kalendar
       SET Sifra = new.ID + 1000
     WHERE ID = new.ID;
END;

COMMIT;
