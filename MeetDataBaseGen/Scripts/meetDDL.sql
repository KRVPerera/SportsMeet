CREATE TABLE Schools (
    schoolId INTEGER    PRIMARY KEY,
    name     TEXT (100) 
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
