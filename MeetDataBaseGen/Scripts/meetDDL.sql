CREATE TABLE IF NOT EXISTS Districts (
    [no]  INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE
);


CREATE TABLE Schools (
    schoolId INTEGER    PRIMARY KEY,
    name     TEXT (100) UNIQUE,
	districId INTEGER,

	CONSTRAINT school_to_district 
	FOREIGN KEY ( districId )
	REFERENCES Districts (districId) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Events (
    [id]     INTEGER     PRIMARY KEY AUTOINCREMENT,
    name     TEXT    UNIQUE NOT NULL,
    gender   BOOLEAN,
    agelimit INTEGER NOT NULL
);


CREATE TABLE Players (
    [no]      INTEGER      PRIMARY KEY AUTOINCREMENT,
    number    TEXT         UNIQUE,
    firstName TEXT ,
    lastName  TEXT ,
    age       INTEGER  DEFAULT (0),
    schoolId  INTEGER,
	districId INTEGER,
    
	CONSTRAINT student_to_school 
	FOREIGN KEY ( schoolId )
	REFERENCES Schools (schoolId) ON DELETE SET NULL ON UPDATE CASCADE,

	CONSTRAINT student_to_district 
	FOREIGN KEY ( districId )
	REFERENCES Districts (districId) ON DELETE SET NULL ON UPDATE CASCADE
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


