CREATE DATABASE ProjectTestFour;

USE ProjectTestFour;

-- Tournament Owenr --
CREATE TABLE TournamentOwner(
	TournamentOwner_ID NVARCHAR(10), --pk
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,
	UserName NVARCHAR(30) NOT NULL UNIQUE,
	Password_ NVARCHAR(30) NOT NULL,

	CONSTRAINT pk_TO_ID PRIMARY KEY (TournamentOwner_ID)
);

SELECT * FROM TournamentOwner;

-- Captain --
CREATE TABLE Captain (
	Captain_ID NVARCHAR(20), -- pk
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,

	CONSTRAINT pk_CaptainID PRIMARY KEY (Captain_ID)
);

SELECT * FROM Captain;

-- Coach --
CREATE TABLE Coach (
	Coach_ID NVARCHAR(20), -- pk
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,

	CONSTRAINT pk_CoachID PRIMARY KEY (Coach_ID)
);
SELECT * FROM Coach;


-- Team --
CREATE TABLE Team (
	Team_ID NVARCHAR(10) UNIQUE, -- pk
	TeamName NVARCHAR(30) NULL,
	Captain_ID NVARCHAR(20), -- fk
	Coach_ID NVARCHAR(20), -- fk

	CONSTRAINT fk_CoachID FOREIGN KEY (Coach_ID) REFERENCES Coach(Coach_ID) ON UPDATE CASCADE ON DELETE SET NULL,
	CONSTRAINT fk_CaptainID FOREIGN KEY (Captain_ID) REFERENCES Captain(Captain_ID) ON DELETE SET NULL,
	CONSTRAINT pk_TeamID PRIMARY KEY (Team_ID)
);


-- Player --
CREATE TABLE Player (
	Player_ID NVARCHAR(10), --PK
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,
	PlayerExperience NVARCHAR(30) NULL,
	PlayerScore NVARCHAR(20) NULL,
	PlayerDescription  NVARCHAR(50) NULL,
	PlayerStatus NVARCHAR(20) NULL,

	Team_ID NVARCHAR(10),

	CONSTRAINT fk_TeamID1 FOREIGN KEY (Team_ID) REFERENCES Team(Team_ID) ON DELETE SET NULL,
	CONSTRAINT pk_PlayerID PRIMARY KEY (Player_ID)
);

SELECT * FROM Coach;


-- Teams in Tournament --
/*CREATE TABLE TeamsInTournament (
	TeamsInTournament_ID NVARCHAR(10),
	Team_ID NVARCHAR(10),

	CONSTRAINT pk_TeamsInTournamentID PRIMARY KEY (TeamsInTournament_ID),
	CONSTRAINT fk_TeamID2 FOREIGN KEY (Team_ID) REFERENCES Team(Team_ID) ON UPDATE CASCADE ON DELETE SET NULL
);*/
CREATE TABLE TeamsInTournament (
	TeamsInTournament_ID INT IDENTITY(1,1),
	Team_ID NVARCHAR(10),
	Tournament_ID nvarchar(10),
	CONSTRAINT pk_TeamsInTournamentID PRIMARY KEY (TeamsInTournament_ID),
	CONSTRAINT fk_TeamID2 FOREIGN KEY (Team_ID) REFERENCES Team(Team_ID) ON UPDATE CASCADE ON DELETE SET NULL,
	CONSTRAINT fk_33 FOREIGN KEY (Tournament_ID) REFERENCES Tournaments(Tournament_ID)
);

SELECT * FROM Tournaments;
SELECT * FROM Team;	
SELECT * FROM TeamsInTournament;
DROP TABLE TeamsInTournament;



-- Tournaments --
CREATE TABLE Tournaments(
	TournamentOwner_ID NVARCHAR(10), -- fk 
	Tournament_ID NVARCHAR(10) UNIQUE, -- pk
	TournamentTitle NVARCHAR (30) NOT NULL,
	StartDate NVARCHAR(30) NULL,
	EndDate NVARCHAR(30) NULL,
	Location_ NVARCHAR(40) NULL,
	  

	CONSTRAINT fk_tournamentOwner FOREIGN KEY (TournamentOwner_ID) REFERENCES TournamentOwner(TournamentOwner_ID) ON UPDATE CASCADE,
	CONSTRAINT pk_tournamnetID PRIMARY KEY (Tournament_ID)
);

SELECT * FROM Tournaments;
SELECT Tournament_ID FROM Tournaments WHERE TournamentOwner_ID = 'O2';
DROP Table Tournaments;
--GetTeamIDs()

-- Match --
/*CREATE TABLE Match(
	Match_ID NVARCHAR(10),
	TeamA_ID NVARCHAR(10) UNIQUE,
	TeamB_ID NVARCHAR(10) UNIQUE,
	ScoreA NVARCHAR(20) NULL,
	ScoreB NVARCHAR(20) NULL,

	CONSTRAINT fk_TeamIDA FOREIGN KEY (TeamA_ID) REFERENCES Team(Team_ID) ON UPDATE CASCADE ON DELETE SET NULL,
	CONSTRAINT fk_TeamIDB FOREIGN KEY (TeamB_ID) REFERENCES Team(Team_ID),
	CONSTRAINT pk_MatchID PRIMARY KEY (Match_ID)
);*/

-- Match Table -- 
/*CREATE TABLE Match(
	Match_ID NVARCHAR(10),
	Team_ID NVARCHAR(10),
	Score NVARCHAR(20) NULL,
	MatchStatus NVARCHAR(20) NULL,
	Round_ID nvarchar(10),
		
	CONSTRAINT fk_TeamID3 FOREIGN KEY (Team_ID) REFERENCES Team(Team_ID) ON UPDATE CASCADE ON DELETE SET NULL,
	CONSTRAINT pk_MatchID PRIMARY KEY (Match_ID)
);
select * from Match;
ALTER TABLE MATCH ADD CONSTRAINT fk_TeamID5534 FOREIGN KEY (Round_ID) REFERENCES Rounds(Round_ID);


-- Rounds --
CREATE TABLE Rounds (
	Round_ID NVARCHAR(10) UNIQUE,
	Match_ID NVARCHAR(10),
	Tournament_ID nvarchar(10),
CONSTRAINT fk_w21 FOREIGN KEY (Tournament_ID) REFERENCES Tournaments(Tournament_ID),

	CONSTRAINT fk_MatchID1 FOREIGN KEY (Match_ID) REFERENCES Match(Match_ID) ON UPDATE CASCADE ON DELETE SET NULL,
	CONSTRAINT pk_RoundID PRIMARY KEY (Round_ID)
);
*/



-- Match Making --
CREATE TABLE MatchMaking (
	MatchMaking_ID INT IDENTITY(1,1),
	CONSTRAINT pk_MM PRIMARY KEY (MatchMaking_ID),
	Tournament_ID NVARCHAR(10),
	RoundNo NVARCHAR(5),
	MatchNo NVARCHAR(5),
	TeamA NVARCHAR(10),
	TeamB NVARCHAR(10),
	ScoreA NVARCHAR(10),
	ScoreB NVARCHAR(10),


	CONSTRAINT fk_tId3 FOREIGN KEY(Tournament_ID) REFERENCES Tournaments(Tournament_ID) ON UPDATE CASCADE  ON DELETE SET NULL
);

DROP TABLE MatchMaking;

SELECT * FROM MatchMaking;


CREATE TABLE Winner(
	
	Winner_ID INT IDENTITY(1,1), -- pk
	CONSTRAINT pk_WinnerID PRIMARY KEY (Winner_ID),

	MatchNo NVARCHAR(10), -- fk
	TeamWinnerID NVARCHAR(10),
	WinnerPrice NVARCHAR(20),

);

SELECT * FROM Winner;

CREATE TABLE RunnerUp(
	
	Runnerup_ID INT IDENTITY(1,1), -- pk
	CONSTRAINT pk_RunnerupID PRIMARY KEY (Runnerup_ID),

	MatchNo NVARCHAR(10), -- fk
	TeamRunnerupID NVARCHAR(10),
	RunneruprPrice NVARCHAR(20)
);

SELECT * FROM Winner;
SELECT * FROM RunnerUp;

-- Price --
CREATE TABLE Price(
	Tournament_ID NVARCHAR(10),
	WinnerAmount NVARCHAR(20),
	RunnerUpAmount NVARCHAR(20),

	CONSTRAINT fk_tId FOREIGN KEY(Tournament_ID) REFERENCES Tournaments(Tournament_ID) ON UPDATE CASCADE  ON DELETE SET NULL
);






CREATE TABLE Viewer(
	Viewer_ID NVARCHAR(10), --pk
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,
	Username NVARCHAR(30) NOT NULL UNIQUE,
	Password_ NVARCHAR(30) NOT NULL,

	CONSTRAINT pk_viewerID PRIMARY KEY (Viewer_ID)
);
























-- Viewer --
CREATE TABLE Viewer(
	Viewer_ID NVARCHAR(10), --pk
	FirstName NVARCHAR(30) NULL,
	LastName NVARCHAR(30) NULL,
	Email NVARCHAR(30) NULL,
	Address_ NVARCHAR(50) NULL,
	ContactNo NVARCHAR(30) NULL,
	Username NVARCHAR(30) NOT NULL UNIQUE,
	Password_ NVARCHAR(30) NOT NULL,

	CONSTRAINT pk_viewerID PRIMARY KEY (Viewer_ID)
);