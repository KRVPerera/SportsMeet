CREATE TABLE Schools (
    schoolId INTEGER    PRIMARY KEY,
    name     TEXT (100) 
);

CREATE TABLE Events (
    id       INT     PRIMARY KEY,
    name     TEXT    UNIQUE
                     NOT NULL,
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
    
	CONSTRAINT student_to_school FOREIGN KEY ( schoolId )

    REFERENCES Schools (schoolId) ON DELETE SET NULL ON UPDATE CASCADE
);

CREATE TABLE PlayerEvents (
    eventId  INT,
    playerId INT,

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


