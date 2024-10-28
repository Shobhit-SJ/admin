create database employeeDB
use employeeDB
create table employeeDetails
(
     empNo int,
	 empNmae varchar(25),
	 empDesignation varchar(20),
	 empSalary int,
	 empIsPermanent bit
)

insert into employeeDetails values (101,'shobhit', 'sde', 600000, 1)
insert into employeeDetails values (102,'raj', 'sde2', 500000, 1)
insert into employeeDetails values (103,'alex', 'sde', 700000, 1)
insert into employeeDetails values (104,'sarthak', 'sde3', 500000, 1)
insert into employeeDetails values (105,'anand', 'sde', 800000, 1)
insert into employeeDetails values (106,'jeet', 'sde3', 700000, 1)

--DQL
select * from employeeDetails

update employeeDetails set empSalary = empSalary + 10000

update employeeDetails set empNmae = 'Hello ' + empNmae,
                           empSalary = empSalary + 10000,
						   empDesignation = 'Sr. ' + empDesignation
update employeeDetails delete empNmae = 'Hello ' + empNmae


--trim name
update employeeDetails set empNmae = SUBSTRING(empNmae,12,80)
--right click to rename empNmae to empName




