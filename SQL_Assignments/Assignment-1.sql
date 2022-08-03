CREATE DATABASE sql_task;
CREATE TABLE EmployeeDetails (
    EmpID int NOT NULL PRIMARY KEY,
    FullName varchar(255) NOT NULL,
    ManagerID int NOT NULL,
	DateOfJoining Date NOT NULL,
    City varchar(50)
);
INSERT INTO EmployeeDetails VALUES(121,'Lakshmi Kumar',321,'2001-01-31','Hyderabad');
INSERT INTO EmployeeDetails VALUES(321,'Damodaran',986,'2002-01-30','Chennai');
INSERT INTO EmployeeDetails VALUES(421,'Priyadarshini',876,'2003-07-1','Bangalore');
INSERT INTO EmployeeDetails VALUES(521,'Mahesh',768,'2004-08-09','Mumbai');
INSERT INTO EmployeeDetails VALUES(621,'Mrinalini',456,'2005-09-10','Thiruvanthapuram');
INSERT INTO EmployeeDetails VALUES(721,'Yuvraj',654,'2006-06-08','Bhopal');
INSERT INTO EmployeeDetails VALUES(821,'Shruthi',546,'2007-05-05','Chandigarh');
INSERT INTO EmployeeDetails VALUES(921,'Nandini',256,'2008-09-06','Shimla');
INSERT INTO EmployeeDetails VALUES(221,'Santhya',345,'2009-07-11','Shilong');
INSERT INTO EmployeeDetails VALUES(122,'Privarshini',324,'2010-08-12','Amravathi');

CREATE TABLE EmployeeSalary (
    EmpID int NOT NULL PRIMARY KEY,
    Project varchar(10) ,
    Salary int NOT NULL,
	Variable int NOT NULL,
    
);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(121,'P1',15000,500);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(321,'P2',10000,1000);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(421,'P1',12000,0);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(521,'P2',9000,600);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(621,Null,11000,0);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(721,'P1',9000,850);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(821,'P2',14000,478);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(921,'P1',13000,0);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(221,'P2',9000,586);
INSERT INTO EmployeeSalary(EmpID,Project,Salary,Variable) VALUES(122,Null,7000,750);

SELECT MAX(Salary) As MaxSalary FROM EmployeeSalary;


SELECT DISTINCT Project From EmployeeSalary WHERE Project IS NOT NULL;

SELECT EmpID,Salary  FROM EmployeeSalary WHERE Salary BETWEEN 9000 AND 15000;

SELECT COUNT(*) FROM EmployeeSalary GROUP BY Project HAVING Project='P1';

SELECT MAX(Salary) as MaxSalary,
MIN(Salary) as MinSalary,
 AVG(Salary)as AvgSalary FROM EmployeeSalary;

SELECT * FROM EmployeeDetails WHERE City='Hyderabad' OR ManagerID='321';

SELECT EmpId,ManagerID FROM EmployeeDetails;

SELECT EmpID FROM EmployeeSalary WHERE Project IS NULL;

SELECT * FROM EmployeeDetails WHERE EXISTS (SELECT * FROM EmployeeSalary

WHERE EmployeeDetails.EmpID = EmployeeDetails.EmpID);


SELECT * FROM EmployeeDetails WHERE (EmpID IN (SELECT ManagerID FROM EmployeeDetails));


