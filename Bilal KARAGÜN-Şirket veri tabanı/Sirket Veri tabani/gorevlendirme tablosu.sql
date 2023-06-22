CREATE TABLE gorevlendirme (
gorevlendirme_no INT IDENTITY(1,1) PRIMARY KEY,
proje_no INT NOT NULL REFERENCES proje(proje_no),
personel_no INT NOT NULL REFERENCES personel(personel_no),
CONSTRAINT projePersonelTekil UNIQUE (proje_no,personel_no)
);

INSERT INTO gorevlendirme VALUES 
(1,3),(1,5),(1,7),(1,8),(1,11),(2,1),
(2,3),(2,5),(2,10),(2,12),(2,13),(3,3),
(3,4),(3,9),(3,15),(3,19),(3,21),(3,25),
(3,27),(4,2),(4,3),(4,8),(4,10),(4,20),
(4,27),(5,3),(5,5),(5,11),(5,21),(5,26);