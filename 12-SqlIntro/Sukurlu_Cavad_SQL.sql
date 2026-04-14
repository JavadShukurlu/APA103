CREATE DATABASE Company
use Company
CREATE TABLE Employees(
EmployeeID INT,
FirstName NVARCHAR(MAX),
LastName NVARCHAR(MAX),
Email VARCHAR(MAX),
PhoneNumber NVARCHAR(MAX),
HireDate DATE,
JobTitle NVARCHAR(MAX),
Salary MONEY,
Department NVARCHAR(MAX)
)
INSERT INTO Employees(
EmployeeID,
FirstName,
LastName,
Email,
PhoneNumber,
HireDate,
JobTitle,
Department)
VALUES (1,'Cavad','Sukurlu','sukurlucavad@gmail.com','0553316415','2025-10-10','Backend Developer','IT')
UPDATE Employees
SET Email='sevgi@company.az'
WHERE EmployeeID=3 

INSERT INTO Employees
EmployeeID,
FirstName,
LastName,
Email,
PhoneNumber,
HireDate,
JobTitle,
Salary,
Department)
VALUES (2,'Ehmed','Eliyev','ehmed@gmail.com','0553334545','2025-09-10','Backend Developer',890,'IT')

INSERT INTO Employees(
EmployeeID,
FirstName,
LastName,
Email,
PhoneNumber,
HireDate,
JobTitle,
Salary,
Department)
VALUES (3,'Teymur','Teymurov','teymur@gmail.com','0556787890','2025-12-10','Prpject Manager',1000,'IT')

INSERT INTO Employees(
EmployeeID,
FirstName,
LastName,
Email,
PhoneNumber,
HireDate,
JobTitle,
Salary,
Department)
VALUES (4,'Sevgi','Zeylanova','sevgi@gmail.com','0778909089','2025-12-23','SMM',2000,'Marketing')

INSERT INTO Employees(
EmployeeID,
FirstName,
LastName,
Email,
PhoneNumber,
HireDate,
JobTitle,
Salary,
Department)
VALUES (3,'Zeyneb','Sukurova','zeyneb@gmail.com','0556787865','2025-12-10','HR',1000,'Human Resources')


SELECT * FROM Employees
SELECT * FROM Employees WHERE Salary>2000
SELECT * FROM Employees WHERE Department='IT'
SELECT * FROM Employees order by Salary desc
SELECT FirstName, Salary from Employees
SELECT * FROM Employees Where HireDate>'2020'
SELECT * FROM Employees Where   Email like '%company.az'
SELECT  Max(Salary) as MaxSalary FROM Employees 
Select Min(Salary) as MinSalary FROM Employees
Select Avg(Salary) as AvgSalary from Employees
Select Count(*) as EmployeeCount from Employees
Select Sum(Salary) as SalarSum from Employees
Select Department, Count(*) as EmployeeCount From Employees Group By Department
Select Department, Avg(Salary) as AvgSalary from Employees Group By Department
Select Department, Max(Salary) as MaxSalary from Employees Group By Department

Update Employees
Set Salary=2800
Where EmployeeID=1


Update Employees
Set Salary=Salary*1.1
Where Department='IT'

Update Employees
Set JobTitle='HR Meneceri'
Where FirstName='Zeyneb'

Delete from Employees
Where EmployeeID=5

Delete from Employees
Where Salary<1500

Select * From Employees Where  FirstName like '%a%'

Select * From Employees where Salary Between 2000 and 2500

Select * From Employees where Department in( 'IT','Marketing')



