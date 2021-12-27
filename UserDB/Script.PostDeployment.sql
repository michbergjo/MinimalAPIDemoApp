if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values ('Michelle', 'Joseph'),
	('Tim', 'Corey'),
	('John', 'Smith'),
	('Mary', 'Jones');
end 