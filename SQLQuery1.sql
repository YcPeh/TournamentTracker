

--exec dbo.spTestPerson_GetByLastName'Smith'

--SELECT @@SERVERNAME;

--DBCC CHECKIDENT('Prizes', RESEED, 2);

--select * from dbo.Prizes

--select * from dbo.People

--exec dbo.spPeople_GetAll

select * from dbo.Teams;

select * from dbo.TeamMembers;

select * from dbo.People where id in (1,2);

