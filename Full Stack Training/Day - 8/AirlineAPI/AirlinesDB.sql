create database AirlinesAPIDB

use AirlinesAPIDB

create table FlightScheduleInfo
(
       fightId int primary key,
	   Airline varchar(30),
	   SourceCity varchar(30),
	   Destination varchar (30),
	   AircraftType varchar(20)
)

insert into FlightScheduleInfo values (123, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (121, 'VISTARA', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (122, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (124, 'VISTARA', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (125, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (126, 'VISTARA', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (127, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (128, 'AIR INDIA', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (129, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (120, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (112, 'AIR INDIA', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (113, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (114, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (115, 'INDIGO', 'IXD', 'BLR', 'Economy')
insert into FlightScheduleInfo values (116, 'AIR INDIA', 'IXD', 'BLR', 'Economy')

Create table PassengerInfo
(
       PassengerId int primary key,
	   FirstName varchar(30),
	   LastName varchar(30),
	   Age int,
	   PANNo varchar(30) UNIQUE,
	   Address varchar(max),
	   City varchar(30)
)

CREATE TABLE BookingInfo
(
       PNRNo int primary key,
	   PassengerId int,
	   FlightId int,
	   FlightDate DATE, -- if you want to use system date format use GETDATE so whichever format your computer has eg DD-MM-YYYY you can insert in that only
	   FlightStatus varchar(20),
	   
	    constraint fk_pId foreign key (FlightId) references FlightScheduleInfo(fightId),
		constraint chk_FlightStatus Check (FlightStatus in ('Scheduled', 'Departed', 'Delayed', 'Cancelled'))


)

insert into PassengerInfo values ( 1, 'shobhit1', 'jaiswal', 22, 'ABCD1234', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 2, 'shobhit2', 'jaiswal', 23, 'ABCD1235', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 3, 'shobhit3', 'jaiswal', 24, 'ABCD1236', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 4, 'shobhit4', 'jaiswal', 25, 'ABCD1237', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 5, 'shobhit5', 'jaiswal', 26, 'ABCD1238', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 6, 'shobhit6', 'jaiswal', 27, 'ABCD1239', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 8, 'shobhit7', 'jaiswal', 28, 'ABCD1231', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 9, 'shobhit8', 'jaiswal', 29, 'ABCD1232', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 10, 'shobhit10', 'jaiswal', 20, 'ABCD1233', 'ABC/9876,BANGALORE','BLR')
insert into PassengerInfo values ( 7, 'shobhit9', 'jaiswal', 20, 'ABCD1230', 'ABC/9876,BANGALORE','BLR')

SELECT * FROM PassengerInfo

INSERT INTO BookingInfo VALUES ('123',1,121,'2024-09-10', 'Scheduled')
INSERT INTO BookingInfo VALUES ('234',2,122,'2024-09-11', 'Delayed')
INSERT INTO BookingInfo VALUES ('453',3,123,'2024-09-13', 'Departed')
INSERT INTO BookingInfo VALUES ('762',4,124,'2024-09-16', 'Cancelled')
INSERT INTO BookingInfo VALUES ('987',5,125,'2024-09-10', 'Scheduled')
INSERT INTO BookingInfo VALUES ('467',6,126,'2024-09-11', 'Delayed')
INSERT INTO BookingInfo VALUES ('34',7,127,'2024-09-13', 'Departed')
INSERT INTO BookingInfo VALUES ('988',8,112,'2024-09-16', 'Cancelled')
INSERT INTO BookingInfo VALUES ('545',9,113,'2024-09-13', 'Departed')
INSERT INTO BookingInfo VALUES ('989',10,114,'2024-09-16', 'Cancelled')

select * from BookingInfo







