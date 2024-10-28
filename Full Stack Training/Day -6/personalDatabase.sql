create database personalDB

create table friends
(

   friendId int primary key,
   friendName varchar(20),
   friendMobile bigint,
   friendEmail varchar(20),
   friendType varchar(20),
   seriousFriend bit,
   constraint chk_friendType check (friendType in ('Good', 'Best', 'Forever', 'Just'))

)

insert into friends values (1, 'Shobhi1', 987654321, 'shobhit@gmail.com', 'Good', 1)
insert into friends values (2, 'Shobhit2', 9876534561, 'shobhit@gmail.com', 'Good', 0)
insert into friends values (3, 'Shobhi3', 234654321, 'shobhit@gmail.com', 'Good', 1)
insert into friends values (4, 'Shobhi4',76654321, 'shobhit@gmail.com', 'Good', 0)
insert into friends values (5, 'Shobhi43',7236654321, 'shobhi12t@gmail.com', 'Good', 0)
select * from friends


-- Entity Framework --> component in .Net core to inetravt with data sources (database SQLServer, oracle, db2, MySQL)

-- it is based on open source data pattern called ORM - Object Relational Mapping

-- objects in database (table/view) will be mapped to a class (called as POCO class) in front end
-- class will ahve properties , mapped to column in the table
    -- properties will be same data type as in column for tables

-----------------------------------------------------------------------------------------------------------------------

--  .Net core application are modular
--    ie, it has no idea about entity framework, we have to add packages for the same in the application (don't add if you are not using entity framnework and keep your application light)
-- we have to 4 nuget packages
--           Microsoft.EntityFrameWorkCore.Tools
--           Microsoft.EntityFrameWorkCore.Design
--           Microsoft.EntityFrameWorkCore
--           Microsoft.EntityFrameWorkCore.SqlServer


--commands(run on visual studio-->tool--> nugetPackeManger --> package manger console) eg:    Scaffold-DbContext "connection string" -Provider  Microsoft.EntityFrameWorkCore.SqlServer -outputdir Model
--                                                                                     do this(in server put your server name)-->    Scaffold-DbContext "server=5F8CC5A69AAE530 ;database=personalDB;integrated security=true;TrustServerCertificate=true" -Provider Microsoft.EntityFrameworkCore.SqlServer -outputdir Model
