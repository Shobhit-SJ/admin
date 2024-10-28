CREATE DATABASE emcDB;
USE emcDB;



create table users (
userId int identity(1,1) primary key, 
userName varchar(255) NOT NULL UNIQUE, 
phoneNum bigint NOT NULL, 
userEmailId varchar(50) NOT NULL UNIQUE ,
userPassword varchar(25) NOT NULL, 
userRole varchar(100), 
constraint chk_userRole check (userRole in ('Consultant', 'Client', 'Admin')),
constraint chk_pno check (len(phoneNum) = 10),


created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
updated_at DATETIME DEFAULT CURRENT_TIMESTAMP

);

CREATE TRIGGER trg_UpdateTimestamp
ON users
AFTER UPDATE
AS
BEGIN
    UPDATE users
    SET updated_at = CURRENT_TIMESTAMP
    WHERE userId IN (SELECT userId FROM inserted);
END;



-- Create Consultants Table
CREATE TABLE Consultants (
    consultant_id INT identity(1,1) PRIMARY KEY,
    User_id INT,
    profile_info TEXT,

    rating FLOAT DEFAULT 0,
    total_projects INT DEFAULT 0,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (User_id) REFERENCES Users(userId),
	constraint chk_rating check (rating between 0 and 5),


);

-- Create Clients Table
CREATE TABLE Clients (
    client_id INT identity(1,1) PRIMARY KEY,
    user_id INT,
    wallet_balance DECIMAL(10, 2) DEFAULT 0,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    
    FOREIGN KEY (user_id) REFERENCES Users(userId)
);

-- Create Appointments Table
CREATE TABLE Appointments (
    appointment_id INT identity(1,1) PRIMARY KEY,
    consultant_id INT,
    client_id INT,
    scheduled_time DATETIME NOT NULL,
	status varchar(30),

    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,

    FOREIGN KEY (consultant_id) REFERENCES Consultants(consultant_id),
    FOREIGN KEY (client_id) REFERENCES Clients(client_id),

	constraint chck_status check (status in ('Ongoing', 'accepted', 'declined', 'completed'))

);

-- Create Feedback Table
CREATE TABLE Feedback (
    feedback_id INT identity(1,1) PRIMARY KEY,
    appointment_id INT,
    rating INT CHECK (rating BETWEEN 0 AND 5),
    comments TEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (appointment_id) REFERENCES Appointments(appointment_id)
);

-- Create Performance Tracker Table
CREATE TABLE Performance_Tracker (
    tracker_id INT identity(1,1) PRIMARY KEY,
    consultant_id INT,
    completed_projects INT DEFAULT 0,
    average_rating FLOAT DEFAULT 0,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (consultant_id) REFERENCES Consultants(consultant_id)
);

-- Create Consultancy Services Table(income tac and corporate tax)
CREATE TABLE Consultancy_Services (
    service_id INT identity(1,1) PRIMARY KEY,
    service_name VARCHAR(255) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    description TEXT,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
    
);

-- Create Admin Actions Table
CREATE TABLE Admin_Actions (
    action_id INT identity(1,1) PRIMARY KEY,
    admin_id INT,
    action_type varchar(40),
    description TEXT,
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (admin_id) REFERENCES Users(userId),

	constraint chk_action_type check (action_type in ('add_consultant', 'remove_consultant', 'add_service'))

);