create database Company
use Company



create table Employees(
Id int identity primary key,
[Name] nvarchar(max) not null ,
Surname nvarchar(max) default('XXX'),
Age int,
Salary decimal,
Position nvarchar(max),
IsDeleted bit,

CityId int foreign key(CityId) references Cities(Id)
)
drop table Cities

create table Cities(
Id int identity primary key,
[Name] nvarchar(100) not null unique,

CountryId int,
foreign key (CountryId) references Countries(Id)
)

create table Countries(
Id int identity primary key,
[Name] nvarchar(max)
)
--Ishcilerin ozlerini, yashadiqi sheherlerini ve olkelerini gosterin.
select e.Name  as EmployeeName, c.Name as CityName, co.Name as CountryName from Employees as e
Join Cities as c on e.CityId=c.Id
Join Countries as co on c.CountryId=co.Id
-- Maashi 2000-den yuxari olan ishcilerin adlari ve yashadiqi olkeleri gosterin.
select e.Name as EmployeeName, co.Name as CompanyName from Employees as e
Join Cities as c on e.CityId=c.Id
Join Countries as co on c.CountryId=co.Id
where e.Salary>2000
-- Hansi sheherin hansi olkeye aid olduqunu gosterin.
select c.Name as CityName, co.Name as CountryName from Cities as c
Join Countries as co on c.CountryId=co.Id
select * from Countries

update Employees
set IsDeleted=1 where Id=2
--Positioni "Reseption" olan ishcilerin table-larin id-leri daxil olmamaq sherti ile daxil olmamaq sherti ile butun melumatlarini gostermek.
select e.Name,e.Surname, e.Age, e.Salary, e.Position, e.IsDeleted,c.Name,co.Name from Employees as e
Join Cities as c on e.CityId=c.Id
Join Countries as co on c.CountryId=co.Id
where Position='Reseptions'


--ishden cixan ishcilerin yashadiqi sheher ve olkeleri, hemcinin ishcilerin oz ad ve soyadlarini gosteren query yazin.
select  e.Name, e.Surname, c.Name, co.Name from  Employees as e
Join Cities as c on e.CityId=c.Id
Join Countries as co on c.CountryId=co.Id
where IsDeleted=1
insert into Employees
values
('Cavad','Sukurlu',20,2000.0,'Backend Developer',0,1),
('Emin','Memmedov',20,1500.0,'Devops',0,2),
('Ferid','Aliyev',20,3000.0,'Hr',0,3)

insert into Cities
values
('Baku',1),
('Ankara',2),
('Madrid',3)

insert into Countries
values
('Azerbaycan'),
('Turkiye'),
('Ispaniya')



