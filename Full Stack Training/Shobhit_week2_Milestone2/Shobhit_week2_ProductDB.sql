Create database Shobhit_ProductsDB_API

USE Shobhit_ProductsDB_API


Create TABLE Products (
    pId INT PRIMARY KEY,
    pName VARCHAR(40),
    pPrice INT,
    pAvailableQty INT,
    pDescription VARCHAR(max),
    pIsInStock BIT
);

CREATE TABLE Customers (
    cId INT PRIMARY KEY,
    cName VARCHAR(40),
    cAddress VARCHAR(max),
    cWalletBalance INT
);

Create TABLE Orders (
    oId INT PRIMARY KEY,
    cId INT,
    pId INT,
    oStatus NVARCHAR(50) check (oStatus in('Dilivered', 'in Progress', 'cancelled', 'failed')),
	 
   constraint fk_cId FOREIGN KEY (cId) REFERENCES Customers(cId),
   constraint fk_pId  FOREIGN KEY  (pId) REFERENCES Products(pId)
);

INSERT INTO Products (pId, pName, pPrice, pAvailableQty, pDescription, pIsInStock) VALUES
(1, 'Laptop', 1200, 30, 'High performance laptop', 1),
(2, 'Smartphone', 800, 50, 'Latest model smartphone', 1),
(3, 'Tablet', 400, 20, '10-inch tablet', 1),
(4, 'Headphones', 100, 100, 'Noise-cancelling headphones', 1),
(5, 'Smartwatch', 200, 60, 'Fitness tracking smartwatch', 1),
(6, 'Keyboard', 50, 150, 'Mechanical keyboard', 1),
(7, 'Mouse', 30, 200, 'Wireless mouse', 1),
(8, 'Monitor', 250, 40, '27-inch 4K monitor', 1),
(9, 'Printer', 150, 25, 'Inkjet printer', 1),
(10, 'External Hard Drive', 120, 35, '1TB external hard drive', 1),
(11, 'Camera', 600, 15, 'Digital camera with high resolution', 1),
(12, 'Router', 80, 45, 'High-speed router', 1),
(13, 'Speaker', 90, 55, 'Bluetooth speaker', 1),
(14, 'USB Flash Drive', 20, 300, '32GB USB flash drive', 1),
(15, 'Webcam', 70, 50, 'HD webcam', 1)


INSERT INTO Customers (cId, cName, cAddress, cWalletBalance) VALUES
(2, 'Jane Smith', '456 Oak St, Springfield', 3200),
(3, 'Alice Johnson', '789 Pine St, Springfield', 4500),
(4, 'Bob Brown', '101 Maple St, Springfield', 2000),
(5, 'Charlie Davis', '202 Cedar St, Springfield', 5500),
(6, 'Diana Evans', '303 Birch St, Springfield', 1800),
(7, 'Evan Wilson', '404 Walnut St, Springfield', 6000),
(8, 'Fiona Green', '505 Ash St, Springfield', 3500),
(9, 'George Harris', '606 Spruce St, Springfield', 4200),
(10, 'Hannah Clark', '707 Fir St, Springfield', 2900),
(11, 'Ivy Lewis', '808 Cherry St, Springfield', 3700),
(12, 'Jack Hall', '909 Dogwood St, Springfield', 4800),
(13, 'Katherine King', '1001 Magnolia St, Springfield', 1500),
(14, 'Liam Scott', '1102 Poplar St, Springfield', 2200),
(15, 'Mia Taylor', '1203 Sycamore St, Springfield', 3200);
SELECT * FROM Customers

INSERT INTO Orders (oId, cId, pId, oStatus) VALUES
(1, 1, 2, 'Dilivered'),
(2, 2, 5, 'in Progress'),
(3, 3, 1, 'Dilivered'),
(4, 4, 8, 'cancelled'),
(5, 5, 4, 'Dilivered'),
(6, 6, 7, 'failed'),
(7, 7, 3, 'in Progress'),
(8, 8, 6, 'Dilivered'),
(9, 9, 9, 'Dilivered'),
(10, 10, 11, 'in Progress'),
(11, 11, 12, 'cancelled'),
(12, 12, 10, 'Dilivered'),
(13, 13, 14, 'Dilivered'),
(14, 14, 15, 'failed'),
(15, 15, 13, 'in Progress');