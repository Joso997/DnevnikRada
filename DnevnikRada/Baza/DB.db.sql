BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS Skladiste (
    ID              INTEGER NOT NULL
                            PRIMARY KEY AUTOINCREMENT
                            UNIQUE,
    Sifra           INTEGER UNIQUE
                            NOT NULL,
    NazivMaterijala TEXT    NOT NULL,
    Prodavac        TEXT,
    Kolicina        INTEGER NOT NULL
                            DEFAULT (0),
    MjernaJedinica  TEXT,
    Cijena          FLOAT,
    Link            TEXT,
    Sakriveno       BOOLEAN DEFAULT (0),
    UNIQUE (
        Sifra,
        NazivMaterijala,
        Prodavac
    )
    ON CONFLICT ROLLBACK
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
	`Sifra`	INTEGER UNIQUE check(Sifra between 1000 and 9999),
	`NazivMjesta`	TEXT,
	`Datum`	DATETIME NOT NULL,
	`OpisPosla`	TEXT NOT NULL,
	`UtrosenoVrijeme`	INTEGER NOT NULL,
	`ID_mjesta` INTEGER ,
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

CREATE TABLE IF NOT EXISTS Kalendar (
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



CREATE TRIGGER IF NOT EXISTS Nadopuni_Sifru
         AFTER INSERT
            ON Evidencija
      FOR EACH ROW
BEGIN
    UPDATE Evidencija
       SET Sifra = new.ID + 1000
     WHERE ID = new.ID;
END;
CREATE TRIGGER IF NOT EXISTS Nadopuni_Sifru_Kalendar
         AFTER INSERT
            ON Kalendar
      FOR EACH ROW
BEGIN
    UPDATE Kalendar
       SET Sifra = new.ID + 1000
     WHERE ID = new.ID;
END;

COMMIT;
