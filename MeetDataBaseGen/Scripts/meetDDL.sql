PRAGMA foreign_keys=ON;

DROP TABLE IF EXISTS Events;
DROP TABLE IF EXISTS Players;
DROP TABLE IF EXISTS Schools;
DROP TABLE IF EXISTS Districts;
DROP TABLE IF EXISTS EducationZones;
DROP TABLE IF EXISTS PlayerEvents;


CREATE TABLE Districts (
	id  INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE
);

CREATE TABLE EducationZones (
	id  INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE
);

CREATE TABLE Schools (
	id INTEGER    PRIMARY KEY AUTOINCREMENT,
	name     TEXT (100) UNIQUE
);


CREATE TABLE Events (
	id     INTEGER     PRIMARY KEY AUTOINCREMENT,
	number    TEXT         UNIQUE,
	name     TEXT    UNIQUE NOT NULL,
	sex   TINYINT,
	agelimit INTEGER NOT NULL
);



CREATE TABLE Players (
	id        INTEGER      PRIMARY KEY AUTOINCREMENT,
	number    TEXT         UNIQUE,
	firstName TEXT ,
	lastName  TEXT ,
	age       INTEGER  DEFAULT (0),
	sex		  TINYINT,
	schoolId  INTEGER,
	districtId INTEGER,
	educationZoneId INTEGER,
	
	CONSTRAINT student_to_school 
	FOREIGN KEY ( schoolId )
	REFERENCES Schools (id) ON UPDATE CASCADE,

	CONSTRAINT student_to_district 
	FOREIGN KEY ( districtId )
	REFERENCES Districts (id) ON UPDATE CASCADE

	CONSTRAINT student_to_educationzone 
	FOREIGN KEY ( educationZoneId )
	REFERENCES EducationZones (id) ON UPDATE CASCADE
);


CREATE TABLE PlayerEvents (
	eventId  INTEGER NOT NULL,
	playerId INTEGER NOT NULL,


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


