CREATE TABLE IF NOT EXISTS Districts (
	id  INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE
);

CREATE TABLE IF NOT EXISTS EducationZones (
	id  INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE
);

INSERT INTO Districts (name) VALUES  ('Central Province');
INSERT INTO Districts (name) VALUES  ('Eastern Province');
INSERT INTO Districts (name) VALUES  ('Northern Province');
INSERT INTO Districts (name) VALUES  ('North Central Province');
INSERT INTO Districts (name) VALUES  ('North Western Province');
INSERT INTO Districts (name) VALUES  ('Sabaragamuwa Province');
INSERT INTO Districts (name) VALUES  ('Southern Province');
INSERT INTO Districts (name) VALUES  ('Uva Province');
INSERT INTO Districts (name) VALUES  ('Western Province');

--INSERT INTO Districts (name) VALUES  ('Galle');
--INSERT INTO Districts (name) VALUES  ('Hambantota');
--INSERT INTO Districts (name) VALUES  ('Matara');

--INSERT INTO Districts (name) VALUES  ('Ampara');
--INSERT INTO Districts (name) VALUES  ('Anuradhapura');
--INSERT INTO Districts (name) VALUES  ('Badulla');
--INSERT INTO Districts (name) VALUES  ('Batticaloa');
--INSERT INTO Districts (name) VALUES  ('Colombo');

--INSERT INTO Districts (name) VALUES  ('Gampaha');

--INSERT INTO Districts (name) VALUES  ('Jaffna');
--INSERT INTO Districts (name) VALUES  ('Kalutara');
--INSERT INTO Districts (name) VALUES  ('Kandy');
--INSERT INTO Districts (name) VALUES  ('Kegalle');
--INSERT INTO Districts (name) VALUES  ('Kilinochchi');
--INSERT INTO Districts (name) VALUES  ('Kurunegala');
--INSERT INTO Districts (name) VALUES  ('Mannar');
--INSERT INTO Districts (name) VALUES  ('Matale');

--INSERT INTO Districts (name) VALUES  ('Monaragala');
--INSERT INTO Districts (name) VALUES  ('Mullaitivu');
--INSERT INTO Districts (name) VALUES  ('Nuwara Eliya	');
--INSERT INTO Districts (name) VALUES  ('Polonnaruwa');
--INSERT INTO Districts (name) VALUES  ('Puttalam');
--INSERT INTO Districts (name) VALUES  ('Ratnapura');
--INSERT INTO Districts (name) VALUES  ('Trincomalee');
--INSERT INTO Districts (name) VALUES  ('Vavuniya');


INSERT INTO EducationZones (name) VALUES  ('Piliyandala');
INSERT INTO EducationZones (name) VALUES  ('Minuwangoda');
INSERT INTO EducationZones (name) VALUES  ('Colombo');
INSERT INTO EducationZones (name) VALUES  ('Gampaha');
INSERT INTO EducationZones (name) VALUES  ('Homagama');
INSERT INTO EducationZones (name) VALUES  ('Sri Jaya Pura');
INSERT INTO EducationZones (name) VALUES  ('Negombo');
INSERT INTO EducationZones (name) VALUES  ('Kelaniya');
INSERT INTO EducationZones (name) VALUES  ('Kalutara');
INSERT INTO EducationZones (name) VALUES  ('Matugama');
INSERT INTO EducationZones (name) VALUES  ('Horana');
INSERT INTO EducationZones (name) VALUES  ('Jafna');
INSERT INTO EducationZones (name) VALUES  ('Island');
INSERT INTO EducationZones (name) VALUES  ('Thenmarachchi');
INSERT INTO EducationZones (name) VALUES  ('Valikamam');
INSERT INTO EducationZones (name) VALUES  ('Vadamarachchi');
INSERT INTO EducationZones (name) VALUES  ('Kilinochchi');
INSERT INTO EducationZones (name) VALUES  ('Mannar');
INSERT INTO EducationZones (name) VALUES  ('Madhu');
INSERT INTO EducationZones (name) VALUES  ('Vauniya South');
INSERT INTO EducationZones (name) VALUES  ('Vauniya North');
INSERT INTO EducationZones (name) VALUES  ('Mulativu');
INSERT INTO EducationZones (name) VALUES  ('Thunukkai');
INSERT INTO EducationZones (name) VALUES  ('Anuradhapura');
INSERT INTO EducationZones (name) VALUES  ('Kebithigollewa');
INSERT INTO EducationZones (name) VALUES  ('Kekirawa');
INSERT INTO EducationZones (name) VALUES  ('Thambuttegama');
INSERT INTO EducationZones (name) VALUES  ('GalenBindunuWewa');
INSERT INTO EducationZones (name) VALUES  ('Dimbulagala');
INSERT INTO EducationZones (name) VALUES  ('Hingurakgoda');
INSERT INTO EducationZones (name) VALUES  ('Polonnaruwa');
INSERT INTO EducationZones (name) VALUES  ('Rathnapura');
INSERT INTO EducationZones (name) VALUES  ('Balangoda');
INSERT INTO EducationZones (name) VALUES  ('Nivithigala');
INSERT INTO EducationZones (name) VALUES  ('Embilipitiya');
INSERT INTO EducationZones (name) VALUES  ('Kegalla');
INSERT INTO EducationZones (name) VALUES  ('Mawanella');
INSERT INTO EducationZones (name) VALUES  ('Dehiovita');
INSERT INTO EducationZones (name) VALUES  ('Kandy');
INSERT INTO EducationZones (name) VALUES  ('Denuwara');
INSERT INTO EducationZones (name) VALUES  ('Gampola');
INSERT INTO EducationZones (name) VALUES  ('Teldeniya');
INSERT INTO EducationZones (name) VALUES  ('Wattegama');
INSERT INTO EducationZones (name) VALUES  ('Katugastota');
INSERT INTO EducationZones (name) VALUES  ('Matale');
INSERT INTO EducationZones (name) VALUES  ('Galewela');
INSERT INTO EducationZones (name) VALUES  ('Naula');
INSERT INTO EducationZones (name) VALUES  ('Wilgamuwa');
INSERT INTO EducationZones (name) VALUES  ('NuwaraEliya');
INSERT INTO EducationZones (name) VALUES  ('Kothmale');
INSERT INTO EducationZones (name) VALUES  ('Hatton');
INSERT INTO EducationZones (name) VALUES  ('Walapane');
INSERT INTO EducationZones (name) VALUES  ('Hanguranketha');
INSERT INTO EducationZones (name) VALUES  ('Kurunegala');
INSERT INTO EducationZones (name) VALUES  ('Kuliyapitiya');
INSERT INTO EducationZones (name) VALUES  ('Nikaweratiya');
INSERT INTO EducationZones (name) VALUES  ('Maho');
INSERT INTO EducationZones (name) VALUES  ('Giriulla');
INSERT INTO EducationZones (name) VALUES  ('Ibbagamuwa');
INSERT INTO EducationZones (name) VALUES  ('Puttalam');
INSERT INTO EducationZones (name) VALUES  ('Chilaw');
INSERT INTO EducationZones (name) VALUES  ('Galle');
INSERT INTO EducationZones (name) VALUES  ('Elpitiya');
INSERT INTO EducationZones (name) VALUES  ('Ambalangoda');
INSERT INTO EducationZones (name) VALUES  ('Udugama');
INSERT INTO EducationZones (name) VALUES  ('Matara');
INSERT INTO EducationZones (name) VALUES  ('Akuressa');
INSERT INTO EducationZones (name) VALUES  ('Mulatiyana(Hakmana)');
INSERT INTO EducationZones (name) VALUES  ('Morawaka');
INSERT INTO EducationZones (name) VALUES  ('Tangalle');
INSERT INTO EducationZones (name) VALUES  ('Hambantota');
INSERT INTO EducationZones (name) VALUES  ('Walasmulla');
INSERT INTO EducationZones (name) VALUES  ('Badulla');
INSERT INTO EducationZones (name) VALUES  ('Viyaluwa');
INSERT INTO EducationZones (name) VALUES  ('Bandarawela');
INSERT INTO EducationZones (name) VALUES  ('Mahiyanganaya');
INSERT INTO EducationZones (name) VALUES  ('Welimada');
INSERT INTO EducationZones (name) VALUES  ('Passara');
INSERT INTO EducationZones (name) VALUES  ('Monaragala');
INSERT INTO EducationZones (name) VALUES  ('Wellawaya');
INSERT INTO EducationZones (name) VALUES  ('Bibile');
INSERT INTO EducationZones (name) VALUES  ('Batticaloa');
INSERT INTO EducationZones (name) VALUES  ('Kalkudha');
INSERT INTO EducationZones (name) VALUES  ('Paddiruppu');
INSERT INTO EducationZones (name) VALUES  ('Batticaloa Central');
INSERT INTO EducationZones (name) VALUES  ('Batticaloa West');
INSERT INTO EducationZones (name) VALUES  ('Ampara');
INSERT INTO EducationZones (name) VALUES  ('Kalmunai');
INSERT INTO EducationZones (name) VALUES  ('Smmanthurai');
INSERT INTO EducationZones (name) VALUES  ('MahaOya');
INSERT INTO EducationZones (name) VALUES  ('DehiattaKandiya');
INSERT INTO EducationZones (name) VALUES  ('Akkaraipattu');
INSERT INTO EducationZones (name) VALUES  ('Thirukkovil');
INSERT INTO EducationZones (name) VALUES  ('Trincomalee');
INSERT INTO EducationZones (name) VALUES  ('Mutur');
INSERT INTO EducationZones (name) VALUES  ('Kantalai');
INSERT INTO EducationZones (name) VALUES  ('Kinniya');
INSERT INTO EducationZones (name) VALUES  ('Trincomalee North');

