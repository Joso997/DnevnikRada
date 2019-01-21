INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina) VALUES ('Drva','Pilana','tone','22');
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Cigle','','kg','50',35);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('PISTOLJ','HRVASTSKA VOJSKA','',1,500);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Šmajser','VOJSKA','',2,4000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('WD 40','','',10,120);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Hard Disk 10TB','Western digital','',5,5000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('SSD 250GB ','Kingston','',10,300);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('SSD 500GB ','Kingston','',15,700);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Hard Disk 5TB','Samsung','',5,3000);
INSERT INTO `Skladiste` (NazivMaterijala, Prodavac, MjernaJedinica, Kolicina, Cijena) VALUES ('Ram 8GB','Kingston','',13,300);

INSERT INTO `Mjesta` (NazivMjesta,Adresa) VALUES ('Rijeka','Nojev2 36');
INSERT INTO `Mjesta` (NazivMjesta,Adresa) VALUES ('Pula','Kebab 77');
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijeka','2018-01-01 11:09:08','Samo za dodavanje svih materijala',10,2);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijeka','2019-01-10 11:09:08','Prodano kupljeno nabavljeno nije bitno nesto sam radio',10,2);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Rijek2','2019-01-15 11:15:12','Opis posla je jako bitan da bi firma radila pravilno i da se vidi potrosnja',12,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Crkvenica','2019-01-20 11:16:43','opis posla kazes a',4,1);
INSERT INTO `Evidencija` (NazivMjesta, Datum, OpisPOsla, UtrosenoVrijeme, ID_Mjesta) VALUES ('Pula','2019-01-22 12:05:47','RADI VALJDA HAHAHAHAHAHAHAHAHAHAHAHAHAHA',10,1);

insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,1, 22,'Drva');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,2, 50,'Cigle');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,3, 1,'PISTOLJ');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,4, 2,'Šmajser');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,5, 10,'WD 40');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,6, 5,'Hard Disk 10TB');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,7, 10,'SSD 250GB ');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,8, 15,'SSD 500GB ');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,9, 5,'Hard Disk 5TB');
insert into `Poveznica` (Id_Evidencija,Id_Materijala,Kolicina,NazivMaterijala) VALUES (1,10, 13,'Ram 8GB');


INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('Drva',1,5,10.0,2);
INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('Drva',1,5,10.0,3);
INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('Drva',1,-5,10.0,4);
INSERT INTO `Poveznica` (NazivMaterijala, Id_Materijala,Kolicina, Cijena, Id_Evidencija) VALUES ('Drva',1,-15,10.0,5);
