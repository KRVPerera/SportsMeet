CREATE TABLE IF NOT EXISTS Districts (
    [no]      INTEGER  PRIMARY KEY AUTOINCREMENT,
	name  TEXT      UNIQUE,
);


CREATE TABLE Schools (
    schoolId INTEGER    PRIMARY KEY,
    name     TEXT (100) UNIQUE,
	districId INTEGER,

	CONSTRAINT school_to_district FOREIGN KEY ( districId )

	REFERENCES Schools (districId) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE Events (
    [id]      INT     PRIMARY KEY AUTOINCREMENT,
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
    
	CONSTRAINT student_to_school FOREIGN KEY ( schoolId )

	CONSTRAINT student_to_district FOREIGN KEY ( districId )

    REFERENCES Schools (schoolId) ON DELETE SET NULL ON UPDATE CASCADE

	REFERENCES Schools (districId) ON DELETE SET NULL ON UPDATE CASCADE
);


CREATE TABLE PlayerEvents (
    eventId  INT NOT NULL,
    playerId INT NOT NULL,

    FOREIGN KEY (
        playerId
    )

    REFERENCES Players (number) ON DELETE CASCADE
                                ON UPDATE CASCADE,
    PRIMARY KEY (
        eventId,
        playerId
    ),
    FOREIGN KEY (
        eventId
    )
    REFERENCES Events (id) ON DELETE CASCADE
                           ON UPDATE CASCADE
);


