CREATE DATABASE The_Giants;

USE The_Giants;

CREATE TABLE user_profiles(
	Giant_ID VARCHAR(10) PRIMARY KEY,
	Full_name VARCHAR(90),
    Username VARCHAR(40),
    Password_ VARCHAR(30),
    Year_group VARCHAR(4)
);

INSERT INTO user_profiles(Giant_ID, Full_name, Username, Password_, Year_group)
VALUES  ('100' , 'Francis Owusu Buabin' , 'Drizzle2018' , 'bigboy' , '2018'),
		('101' , 'Silas Owu' , 'LuxuryO' , 'diesu2020' , '2016'),
		('102' , 'Elijah Kobinah Ackah' , 'Elikobs' , 'elijah751' , '2018'),
		('103' , 'Emile Jirus Hinson' , 'Emiley' , 'puzzleB' , '2012'),
		('104' , 'Michael Gyasi' , 'Jmike' , 'micky_mouse' , '2018'),
		('105', 'Theophilus Obotan' , 'Blarh_OBT' , 'nyameBotan' , '2017');
        
SELECT * FROM USER_PROFILES;
        