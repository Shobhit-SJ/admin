Create database productAPIDB

use productAPIDB


create table ProductList
(
    pId int primary key,
	pName varchar(30),
	pCategory varchar (30),
	pPrice int,
	pIsInStock bit

)


insert into ProductList values (1, 'Pepsi', 'cold-drink', 50, 1)
insert into ProductList values (2, 'Coke', 'cold-drink', 80, 1)
insert into ProductList values (3, 'Maggie', 'Fast-Food', 45, 0)
insert into ProductList values (4, 'Air pods', 'Electronics', 20000, 1)

select * from ProductList

create table customers 
(
      cId int primary key,
	  cName varchar(30),
	  cBalance int,
	  cAddress varchar(max)
)

insert into customers values (1,'Shobhit1', 50000, '345,abc,xyz')
insert into customers values (2,'Shobhit2', 60000, '123,abc,xyz')
insert into customers values (3,'Shobhit3', 45000, '567,abc,xyz')
insert into customers values (4,'Shobhit4', 23000, '789,abc,xyz')
insert into customers values (5,'Shobhit5', 11000, '543,abc,xyz')
insert into customers values (6,'Shobhit6', 78000, '876,abc,xyz')

select * from customers

