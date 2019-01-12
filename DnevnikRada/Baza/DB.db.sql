BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `Skladiste` (
	`ID`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	TEXT NOT NULL UNIQUE,
	`Prodavac`	TEXT,
	`Kolicina`	INTEGER NOT NULL,
	`MjernaJedinica`	TEXT,
	`Cijena`	REAL
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
	`ID_mjesta` INTEGER NOT NULL,
	FOREIGN KEY(`ID_mjesta`) REFERENCES `Mjesta`(`ID`)
); 

CREATE TABLE IF NOT EXISTS `Poveznica` (
	`Id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`NazivMaterijala`	Text,
	`Id_Evidencija`	INTEGER,
	`Kolicina`	INTEGER,
	`Cijena`	REAL,
	`Id_Materijala`	INTEGER,
	FOREIGN KEY(`Id_Evidencija`) REFERENCES `Evidencija`(`ID`),
	FOREIGN KEY(`Id_Materijala`) REFERENCES `Skladiste`(`ID`),
	FOREIGN KEY(`NazivMaterijala`) REFERENCES `Skladiste`(`NazivMaterijala`)
);

INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina) VALUES ('bbb','kklol','jabuka','22');
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('sezam','',13,'',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('PISTOLJ','HRVASTSKA VOJSKA',1,'NEMA',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('šmajser','VOJSKA',1,'NEMA',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('šMAJSER','hrvatska vojska',2,'nema',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('ss','njemacka',4,'infinite',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('uizgrt','rdtfzguikhoj',23,'gg',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('zrtztu','tutut',44,'rr',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('jedan','dva','tri','22',NULL);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('sezam2','','','13',NULL);

INSERT INTO `Mjesta` (NazivMjesta,Adresa, VrijemeRadaOD, VrijemeRadaDO) VALUES ('asd','asd','2019-01-12 00:00:00',NULL);
INSERT INTO `Mjesta` (NazivMjesta,Adresa, VrijemeRadaOD, VrijemeRadaDO) VALUES ('qwe','qwe',NULL,NULL);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijeka','2019-01-10 11:09:08','piraj ako te sto zanima joso i vidite dal vam se baza uplouda kada skinete updejt ako ne da znam jer vam je onda moram poslat mislim ona baza sta je na kompu ne ovdje jer ovdje umetanje neradi trenutno lol al ZATO TRAZILICA RADI VALJDA HAHAHAHAHAHAHAHAHAHAHAHAHAHA',10,2);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijek2','2019-01-10 11:15:12','piraj ako te sto zanima joso i vidite dal vam se baza uplouda kada skinete updejt ako ne da znam jer vam je onda moram poslat mislim ona baza sta je na kompu ne ovdje jer ovdje umetanje neradi trenutno lol al ZATO TRAZILICA RADI VALJDA HAHAHAHAHAHAHAHAHAHAHAHAHAHA',12,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Crkvenica','2019-01-10 11:16:43','opis posla kazes a',4,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Pula','2019-01-10 12:05:47','piraj ako te sto zanima joso i vidite dal vam se baza uplouda kada skinete updejt ako ne da znam jer vam je onda moram poslat mislim ona baza sta je na kompu ne ovdje jer ovdje umetanje neradi trenutno lol al ZATO TRAZILICA RADI VALJDA HAHAHAHAHAHAHAHAHAHAHAHAHAHA',10,1);
INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('bbb',7,5,10.0,3);
CREATE TRIGGER PromjeniUpdate AFTER UPDATE ON Mjesta FOR EACH ROW BEGIN UPDATE Mjesta 
SET VrijemeRadaOD = NULLIF(VrijemeRadaOD, ''),
VrijemeRadaDO = NULLIF(VrijemeRadaDO, ''); END;
CREATE TRIGGER PromjeniInsert AFTER INSERT ON Mjesta FOR EACH ROW BEGIN UPDATE Mjesta 
SET VrijemeRadaOD = NULLIF(VrijemeRadaOD, ''),
VrijemeRadaDO = NULLIF(VrijemeRadaDO, ''); END;
COMMIT;
