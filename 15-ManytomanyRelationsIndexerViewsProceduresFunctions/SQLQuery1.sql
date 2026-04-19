CREATE DATABASE CompanyMM;
USE CompanyMM;

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    CHECK (BirthDate < '2005-01-01')
);

CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY AUTO_INCREMENT,
    ProjectName VARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    CHECK (EndDate > StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT,
    ProjectID INT,
    AssignedDate DATE NOT NULL,
    PRIMARY KEY (EmployeeID, ProjectID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email) VALUES
('Anar', 'Hasanov', '1990-03-15', 'anar.hasanov@company.az'),
('Leyla', 'Mammadova', '1988-07-22', 'leyla.mammadova@company.az'),
('Tural', 'Aliyev', '1995-11-05', 'tural.aliyev@company.az'),
('Nigar', 'Huseynova', '1992-01-30', 'nigar.huseynova@company.az'),
('Kamran', 'Rzayev', '1985-09-18', 'kamran.rzayev@company.az');

INSERT INTO Projects (ProjectName, StartDate, EndDate) VALUES
('Web Portal', '2024-01-10', '2024-06-30'),
('Mobile App', '2024-03-01', '2024-09-30'),
('Data Migration', '2024-02-15', '2024-05-15');

INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate) VALUES
(1, 1, '2024-01-10'),
(1, 2, '2024-03-01'),
(1, 3, '2024-02-15'),
(2, 1, '2024-01-12'),
(2, 2, '2024-03-05'),
(3, 2, '2024-03-10'),
(3, 3, '2024-02-20'),
(4, 1, '2024-01-15'),
(5, 3, '2024-02-18');

SELECT * FROM Employees;

SELECT * FROM Projects;

SELECT e.EmployeeID, e.FirstName, e.LastName, p.ProjectID, p.ProjectName, ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT p.ProjectID, p.ProjectName, COUNT(ep.EmployeeID) AS EmployeeCount
FROM Projects p
JOIN EmployeeProjects ep ON p.ProjectID = ep.ProjectID
GROUP BY p.ProjectID, p.ProjectName;

SELECT e.EmployeeID, e.FirstName, e.LastName, COUNT(ep.ProjectID) AS ProjectCount
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
GROUP BY e.EmployeeID, e.FirstName, e.LastName
HAVING COUNT(ep.ProjectID) > 2;

CREATE VIEW EmployeeProjectView AS
SELECT e.EmployeeID, CONCAT(e.FirstName, ' ', e.LastName) AS FullName,
       p.ProjectID, p.ProjectName, ep.AssignedDate
FROM Employees e
JOIN EmployeeProjects ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects p ON ep.ProjectID = p.ProjectID;

SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;

DELIMITER $$
CREATE PROCEDURE sp_AssignEmployeeToProject(IN empId INT, IN projId INT)
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM EmployeeProjects WHERE EmployeeID = empId AND ProjectID = projId
    ) THEN
        INSERT INTO EmployeeProjects (EmployeeID, ProjectID, AssignedDate) VALUES (empId, projId, CURDATE());
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE FUNCTION fn_GetProjectCount(empId INT) RETURNS INT
DETERMINISTIC
BEGIN
    DECLARE total INT;
    SELECT COUNT(*) INTO total FROM EmployeeProjects WHERE EmployeeID = empId;
    RETURN total;
END$$
DELIMITER ;

SELECT fn_GetProjectCount(1) AS ProjectCount;

CALL sp_AssignEmployeeToProject(5, 1);
SELECT * FROM EmployeeProjects WHERE EmployeeID = 5;

DELETE FROM EmployeeProjects WHERE EmployeeID = 3;
SELECT * FROM EmployeeProjects;