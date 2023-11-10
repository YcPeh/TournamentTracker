

--exec dbo.spTestPerson_GetByLastName'Smith'

--SELECT @@SERVERNAME;

--DBCC CHECKIDENT('Prizes', RESEED, 2);

--select * from dbo.Prizes

--select * from dbo.People

--exec dbo.spPeople_GetAll

select * from dbo.Teams;

select * from dbo.Tournaments;

--select * from dbo.TeamMembers;

--select * from dbo.People where id in (1,2);

select * from dbo.Matchups where TournamentId = 4;

select * from dbo.MatchupEntries where MatchupId between 10 and 12;


