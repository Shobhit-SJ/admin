create table employeeInfo
(
    empNo int not null, 
	empName varchar(20) not null,
	empDesignation varchar(20),
	empSalary int not null,
	empIsPermanent bit,
	empEmail varchar(100) not null,
	empHobbies varchar(300),


	constraint pk_empNo primary key (empNo),
	constraint chk_empName_len check (len(empName) > 3),
	constraint chk_empDesignation_list check (empDesignation in ('Designer', 'Developer', 'Manager')),
	constraint chk_empSalary check (empSalary between 20000 and 80000),
	constraint uni_empEmail unique(empEmail)



)

-- Modify constraint
alter table employeeInfo
drop constraint chk_empSalary_range  --before modifying any constraint do drop constraint

alter table employeeInfo
add constraint chk_empSalary_range check (empSalary between 25000 and 90000)

--alter column 

alter table employeeInfo
alter column empIsPermanent bit not null

alter table employeeInfo
alter column empName varchar(60)


-- for foreign key, it is  A relation between two or more tables
-- for this we ahve a parent table (master table ) and a child table ()


create table deptInfo
(
     deptNo int,
	 deptName varchar(20),
	 deptLocation varchar (20),
	 constraint pk_deptNo primary key (deptNo)
)

insert into deptInfo values(10, 'HR', 'Delhi')
insert into deptInfo values(12, 'IT', 'Bangalore')
insert into deptInfo values(13, 'Accounts', 'Mumbai')
insert into deptInfo values(14, 'Sales', 'Pune')
select * from deptInfo

alter table employeeInfo
add empDept int



alter table employeeInfo
add constraint fk_empDept foreign key (empDept) references deptInfo

----------------------------------------------------------------------------------
-- insert 6 records in deptInfo - 4 already done
-- insert 15 records in employeeInfo



insert into deptInfo values(18, 'HR', 'Delhi')
insert into deptInfo values(17, 'HR', 'Delhi')


select * from employeeInfo
insert into   employeeInfo values (1, 'shobhit7', 'Designer', 50000, 1,' hi@gmail.com','guitar', 10)
insert into   employeeInfo values (2, 'shobhit72', 'Designer', 50000, 1,' hi2@gmail.com','guitar', 10)
insert into   employeeInfo values (3, 'shobhit723', 'Manager', 40000, 1,' hi3@gmail.com','guitar', 10)
insert into   employeeInfo values (4, 'shobhit754', 'Designer', 30000, 1,' hi4@gmail.com','guitar', 10)
insert into   employeeInfo values (5, 'shobhit71', 'Designer', 55000, 1,' hi5@gmail.com','guitar', 18)
insert into   employeeInfo values (6, 'shobhit77', 'Manager', 33000, 1,' hi6@gmail.com','guitar', 10)
insert into   employeeInfo values (7, 'shobhit78', 'Developer', 27000, 1,' hi7@gmail.com','guitar', 17)
insert into   employeeInfo values (8, 'shobhit79', 'Designer', 56000, 1,' hi87@gmail.com','guitar', 10)
insert into   employeeInfo values (9, 'shobhit798', 'Manager', 50000, 1,' hi89@gmail.com','guitar', 10)
insert into   employeeInfo values (10, 'shobhit776', 'Designer', 50000, 1,' hi9@gmail.com','guitar', 10)
insert into   employeeInfo values (11, 'shobhit765', 'Developer', 40000, 1,' hi99@gmail.com','guitar', 18)
insert into   employeeInfo values (12, 'shobhit73', 'Designer', 30000, 1,' hi98@gmail.com','guitar', 10)
insert into   employeeInfo values (13, 'shobhit732', 'Developer', 40000, 1,' hi76@gmail.com','guitar', 10)
insert into   employeeInfo values (14, 'shobhit721', 'Manager', 50000, 1,' hi43@gmail.com','guitar', 17)
insert into   employeeInfo values (15, 'shobhit711', 'Developer', 50000, 1,' hi23@gmail.com','guitar', 10)


insert into employeeInfo (empNo,empName, empDesignation, empSalary, empIsPermanent,empEmail)
            values( 17, 'john', 'Manager', 45000, 1, '1234@gmail.com')

			
insert into employeeInfo (empNo,empName, empDesignation, empSalary, empIsPermanent,empEmail)
            values( 18, 'john2', 'Designer', 55000, 1, '123344@gmail.com')

			
insert into employeeInfo (empNo,empName, empDesignation, empSalary, empIsPermanent,empEmail)
            values( 19, 'john3', 'Developer', 35000, 1, '128734@gmail.com')


select * from employeeInfo
-------------------------------------------------------------------
----------------------JOINS----------------------------------------
-- a. Cross joins/ Cartisian Product (used by admins, analyst for forcasting)
        -- result is no of rows in table A * no of rows in table B
		-- 6*18
select * from employeeInfo, deptInfo   -- this will create a combination of 1 emp with all the department

--b. Equi Join/ Inner Join --  combination of records
select * from employeeInfo join deptInfo
          on  employeeInfo.empDept = deptInfo.deptNo


		  --JOIN with WHERE clause--

select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where deptNo = 10


--JOIN with WHERE clause and ORDER BY --

select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where deptNo = 10
	order by employeeInfo.empDesignation


--c. Left JOIN - get all the records from left table and equal records from right


select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo left join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where deptNo = 10
	order by employeeInfo.empDesignation

--d. Right JOIN

select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo right join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where deptNo = 10
	order by employeeInfo.empDesignation

---E. FULL JOIN

select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo FULL join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where deptNo = 10
	order by employeeInfo.empDesignation DESC ---FOR DECENDING ORDER put DESC

--f. Null JOIN --only non equal records


select employeeInfo.empName,
       employeeInfo.empNo,
	   employeeInfo.empDesignation,
	   deptInfo.deptNo,
	   deptInfo.deptName,
	   deptInfo.deptLocation
	from employeeInfo full join deptInfo
	on 
	employeeInfo.empDept = deptInfo.deptNo
	where employeeInfo.empDept is NULL --- just add IS NULL  in	WHERE clause where you want
	order by employeeInfo.empDesignation 



	-- TRY 
	-- 1.  get the total employee working in dept 10
	-- 2.  which dept pays the highest salary
	--3.   total salary paid by each dept
	---4.   display email id of every emp in below format
	       --> empName.first2characterofdesignation@myorg.co.first2characterofdeptlocation
	-- 5.  display starts for every dept - '*' for dept 10, 2 for 17, 3 for 18

---1. 
       select count(empNo) from employeeInfo join deptInfo
          on  employeeInfo.empDept = deptInfo.deptNo
		  where deptNo=10

--2. 
select deptInfo.deptName, MAX(empSalary) as maxi from employeeInfo FULL join deptInfo
          on  employeeInfo.empDept = deptInfo.deptNo
		  group by (deptName)
		  having max(empSalary)
		 
		  
--3.
select deptInfo.deptName, SUM(empSalary)   from employeeInfo FULL join deptInfo
          on  employeeInfo.empDept = deptInfo.deptNo
		  GROUP BY (deptName)



--10. JOINS -- most used
-- before that we should first understand constraint
--5 types
    --not NULL - value cannot be left blank
	--Primary key -- used for identity of a record
	--Unique -- must have but cannot be duplicate - not an identity
	-- check -- validation of data (eg. salary min 20000, accType on 'Sav', 'Cur', 'PF')
	-- foreign key -- to create relationship between tables

	--refer file constraint and join.sql

--Views 
--this is most used object - you store the data in a table and forget it
-- you should not give access to tables to any1
-- you use it, to hide the name of table,
                -- name of columns, operators
				-- calculatoions, validation, join logic
--views are virtual - they hold nothing besides query info
--you can have multiple views for a table
-- different users are given different view bases on their access
-- all you have to learn is below 2 lines
-- you can select * from a view 
-- you can select wanted columns from the view
-- you can delete, update data from a view, when it is based on a single table, 
-- you cannot insert, update or delete from view when it is based on join


create view empView
as
select empNo as [Number],
       empName as [first name],
	   empDesignation as [Work As],
	   empSalary * 12 as [CTC],
	   deptName as [department],
	   deptLocation as [work city]
	   from employeeInfo e  join deptInfo d
	on e.empDept = d.deptNo


select * from empView

create view SalaryDetails
as 
Select e.empNo as Number --if its only one word then square braket is not mandatory
       e.empName as Name,
	   e.empSalary as [Monthly Pay],
	   e.empSalary * 0.1 as bonus,
	   e.empSalary * 0.2 as [performance bonus],
	   case e.empSalary
	           when between 0 and 30000 then 'Low Pay'
			   when between 30000 and 40000 then 'Low Pay'
			   when between 40000 and 50000 then 'Modarate'
			   when between 50000 and 60000 then 'Low Pay'
			   when between 60000 and 70000 then 'Low Pay'

		from employeeInfo e














