create database bankingDB

use bankingDB

create table accountsInfo
(
      accNo int,
	  accName varchar(25),
	  accType varchar (25),
	  accBalance int,
	  accIsActive bit
)

insert into  accountsInfo values (100, 'Shobhit', 'Saving', 40000, 0)
insert into  accountsInfo values (101, 'Shobhit1', 'Current', 30000, 1)
insert into  accountsInfo values (102, 'Shobhit2', 'Saving', 20000, 0)
insert into  accountsInfo values (103, 'Shobhit3', 'Saving', 60000, 1)
insert into  accountsInfo values (104, 'Shobhit4', 'Current', 70000, 0)
insert into  accountsInfo values (105, 'Shobhit5', 'Saving', 55000, 1)
insert into  accountsInfo values (106, 'Shobhit6', 'PF', 80000, 1)
insert into  accountsInfo values (107, 'Shobhit7', 'Saving', 1000, 0)
insert into  accountsInfo values (108, 'Shobhit8', 'Saving', 4000, 1)
insert into  accountsInfo values (109, 'Shobhit9', 'PF', 15000, 0)
insert into  accountsInfo values (110, 'Shobhit10', 'Saving', 7000, 1)
insert into  accountsInfo values (111, 'Shobhit11', 'Saving', 40000, 1)
insert into  accountsInfo values (112, 'Shobhit15', 'Current', 22000, 1)
insert into  accountsInfo values (113, 'Shobhit12', 'Saving', 66000, 0)
insert into  accountsInfo values (114, 'Shobhit13', 'PF', 77000, 1)


--DQL
--1. select all data
    select * from accountsInfo

--2. select limited columns only
    select accNo, accName from accountsInfo

--3. select with column alias (different names for column)
   select accNo as [Account Number],
          accName as [Name],
		  accType as [Type],
		  accBalance as [Available Balance]
		  from accountsInfo
  


--4. slect with concatination
    select CONCAT (accName,'Has a ', accType, ' Account with bank ')
        as Info
		from accountsInfo

--5.select with where clause (filter data)

    select * from accountsInfo where accNo = 101
    select * from accountsInfo where accName = 'Shobhit4'
    select * from accountsInfo where accType = 'Current'
    select * from accountsInfo where accName like 'N%'

     select * from accountsInfo where 
          accType = 'Saving' and accBalance > 50000

--6. select with sorting the data (asc or desc)

     select * from accountsInfo order by accType
     select * from accountsInfo order by accBalance desc
     select * from accountsInfo where accType = 'Current' order by accBalance

--7. select with function
   --a. aggregate functions

     select sum(accBalance) from accountsInfo
	 select count(accNo) from accountsInfo
	 select avg(accBalance) from accountsInfo where accBalance = 'Saving'
	 select count(accBalance) from accountsInfo
	 select count(accBalance) from accountsInfo

	 --b. string functions

	 select accNo, upper(accName) from accountsInfo
	 select accNo, UPPER(accName), LOWER (accName) from accountsInfo
	 select accNo, accName, len(accName) from accountsInfo
	 select accNo, accName, left(accName,3)as [Nick Name] from accountsInfo

	 --c. get the data 
	 select GETDATE() --this will get the data, time of the machine where server
	 select DATEPART(month, getdate())
	 select DATEPART(day, getdate())
	 select DATEPART(DAYOFYEAR, getdate())
	 select DATEPART(ISO_WEEK, getdate()) -- TELLS THE NUMBER OF THE WEEK OF CURRENT YEAR (Saal ka kon sa week chl ra vo batata hai)

--8. 



--9. 

     select accNo, accName, accType, case accType
                                when 'Saving' then '*****'



--10. JOINS -- MOST USED
--before thatb we should first understand contraints

-- 5 types of constraints
   -- not NULL - value cannot be left blank
   -- Primary key -- used for identity of a record
   -- Unique key -- must have but cannot dublicate
   -- check -- validation of data (eg. salary min 20000, accType on 'Sav', 'Cur', 'PF', name should be minimum 3 character)
   -- Foreign key -- to create relationship between tables

   -- refer file constraint sql







