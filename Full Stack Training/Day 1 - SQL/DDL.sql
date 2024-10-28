create database clientInfoDB

create table clientDetails
(
    clientId int,
	clientName varchar(20),
	clientLocation varchar(20),
	clientIsActive bit

)


alter table clientDetails add clientRevenue float
alter table clientDetails alter column clientName varchar(60)
alter table clientDetails drop column clientLocation

--dont execute below query
drop table clientDetails

--dont execute below query
drop database clientInfoDB