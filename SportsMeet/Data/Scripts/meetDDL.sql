CREATE TABLE Schools (
    schoolId INTEGER    PRIMARY KEY,
    name     TEXT (100) 
);

CREATE TABLE Players (
    [no]      INTEGER      PRIMARY KEY AUTOINCREMENT,
    number    TEXT         UNIQUE,
    firstName TEXT (40, 0),
    lastName  TEXT (40),
    age       INTEGER (3)  DEFAULT (0),
    schoolId  INTEGER,
    CONSTRAINT student_to_school FOREIGN KEY (
        schoolId
    )
    REFERENCES Schools (schoolId) ON DELETE SET NULL ON UPDATE CASCADE
);
