
DROP TABLE IF EXISTS PlayerEvents;
DROP TABLE IF EXISTS Players;
DROP TABLE IF EXISTS Events;
DROP TABLE IF EXISTS Schools;
DROP TABLE IF EXISTS Districts;
DROP TABLE IF EXISTS EducationZones;



CREATE TABLE Districts (
	id  INTEGER PRIMARY KEY,
	name VARCHAR(30) UNIQUE
);

CREATE TABLE EducationZones (
	id  INTEGER PRIMARY KEY,
	name  VARCHAR(30) UNIQUE
);

CREATE TABLE Schools (
	id  INTEGER PRIMARY KEY,
	name CHAR  UNIQUE
);


CREATE TABLE Events (
	id  INTEGER PRIMARY KEY,
	number    CHAR         UNIQUE,
	name     CHAR    UNIQUE NOT NULL,
	sex   TINYINT,
	agelimit int NOT NULL
);



CREATE TABLE Players (
	id  INTEGER PRIMARY KEY,
	number    CHAR         UNIQUE,
	firstName CHAR ,
	lastName  CHAR ,
	age       int  DEFAULT (0),
	sex		  TINYINT,
	schoolId  INTEGER,
	districtId INTEGER,
	educationZoneId INTEGER,
	
	CONSTRAINT student_to_school 
	FOREIGN KEY ( schoolId )
	REFERENCES Schools (id) ON UPDATE CASCADE,

	CONSTRAINT student_to_district 
	FOREIGN KEY ( districtId )
	REFERENCES Districts (id) ON UPDATE CASCADE,
	
	CONSTRAINT student_to_educationzone 
	FOREIGN KEY (educationZoneId)
	REFERENCES EducationZones (id) ON UPDATE CASCADE

);


CREATE TABLE PlayerEvents (
	eventId  INTEGER,
	playerId INTEGER,


	CONSTRAINT playerevent_to_players
	FOREIGN KEY (playerId)
	REFERENCES Players (id) ON DELETE CASCADE ON UPDATE CASCADE,

	PRIMARY KEY (
		eventId,
		playerId
	),

	CONSTRAINT playerevent_to_events
	FOREIGN KEY (eventId)
	REFERENCES Events (id) ON DELETE CASCADE ON UPDATE CASCADE
);


