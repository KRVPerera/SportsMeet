PRAGMA foreign_keys=ON;


CREATE TABLE IF NOT EXISTS Districts (
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
    
	CONSTRAINT student_to_school 
	FOREIGN KEY ( schoolId )
	REFERENCES Schools (id) ON UPDATE CASCADE,

	CONSTRAINT student_to_district 
	FOREIGN KEY ( districtId )
	REFERENCES Districts (id) ON UPDATE CASCADE
);


CREATE TABLE PlayerEvents (
    eventId  INTEGER NOT NULL,
    playerId INTEGER NOT NULL,


	CONSTRAINT playerevent_to_players
    FOREIGN KEY (playerId)
	REFERENCES Players (no) ON DELETE CASCADE ON UPDATE CASCADE,

    PRIMARY KEY (
        eventId,
        playerId
    ),

	CONSTRAINT playerevent_to_events
    FOREIGN KEY (eventId)
    REFERENCES Events (id) ON DELETE CASCADE ON UPDATE CASCADE
);


