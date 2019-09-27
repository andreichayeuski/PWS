create table Student
(
	Id int identity(1,1) primary key,
	[Name] nvarchar(max)
)

create table Note
(
	Id int identity(1,1) primary key,
	Subj nvarchar(max),
	Note int null,
	StudentId int not null foreign key 
	references Student(Id)
)

insert into Student values 
('Andrei'), ('Yaroslav'), ('Bogdan')

insert into Note values
('œ»—', 4, 3),
('œ»—', 8, 2),
('œ»—', 5, 1),
('œ— œ', 10, 1),
('œ— œ', 8, 2),
('œ— œ', 4, 3),
('Œ—', 9, 1),
('Œ—', 8, 2),
('Œ—', 8, 3)