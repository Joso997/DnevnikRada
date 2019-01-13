INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina) VALUES ('Drva','Pilana','tone','22');
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Cigle','','kg','50',35);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('PISTOLJ','HRVASTSKA VOJSKA','',1,500);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Šmajser','VOJSKA','',2,4000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('WD 40','','',10,120);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Hard Disk 5TB','Western digital','',5,5000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('SSD 250GB','Kingston','',10,300);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('SSD 500GB','Kingston','',15,700);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Hard Disk 5TB','Samsung','',5,3000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Ram 8GB','Kingston','',13,300);

INSERT INTO `Mjesta` (NazivMjesta,Adresa, VrijemeRadaOD, VrijemeRadaDO) VALUES ('Rijeka','Nojev2 36','2019-01-12 00:00:00',NULL);
INSERT INTO `Mjesta` (NazivMjesta,Adresa, VrijemeRadaOD, VrijemeRadaDO) VALUES ('Pula','Kebab 77',NULL,NULL);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijeka','2019-01-10 11:09:08','Prodano kupljeno nabavljeno nije bitno nesto sam radio',10,2);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijek2','2019-01-10 11:15:12','Opis posla je jako bitan da bi firma radila pravilno i da se vidi potrosnja',12,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Crkvenica','2019-01-10 11:16:43','opis posla kazes a',4,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Pula','2019-01-10 12:05:47','RADI VALJDA HAHAHAHAHAHAHAHAHAHAHAHAHAHA',10,1);
INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('Drva',7,5,10.0,3);