CREATE TABLE cocuk (
cocuk_no INT IDENTITY(1,1) PRIMARY KEY,
ad VARCHAR(25) NOT NULL, 
soyad VARCHAR(25) NOT NULL,
cinsiyet CHAR(1),
dogum_tarihi DATE UNIQUE NOT NULL,
dogu_yeri INT NOT NULL REFERENCES ilce(ilce_no),
personel_no INT NOT NULL REFERENCES personel(personel_no)
);

INSERT INTO cocuk VALUES
('Emin','ESMER','E','2016.05.21',5,6),
('Selen','BUZDAÐ','K','2015.09.11',1,17),
('Akif','ÇAKIR','E','2018.01.05',1,19),
('Halide','ESMER','K','2017.12.10',8,6),
('Jülide','BUZDAÐ','K','2016.03.03',6,17),
('Elif','BUZDAÐ','K','2013.11.11',2,17);