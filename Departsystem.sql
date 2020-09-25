-- create new database
create database StudentSystem;

USE StudentSystem;

-- LOGIN TABLE
create table Log_In(
NAME varchar(30) not null,
EMAIL varchar(20) not null,
CNIC char(13) primary key,
PHONE_NO int not null,
username varchar(50) unique not null,
u_password varchar(50) not null,
usertype varchar(50)
);

select * from Log_In;
drop table Log_In;

-- ADD STUDENT TABLE
create table Add_Student(
id int IDENTITY(1,1) PRIMARY KEY,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
DOB date CHECK(YEAR(GETDATE()) - YEAR(DOB)>18) not null,
gender varchar(10) not null,
phone int not null,
std_address text not null,
stdImage image not null
);

select * from Add_Student;
drop table Add_Student;

-- COURSES TABLE
create table Courses(
Course_Id varchar(10) primary key,
Course_Name varchar(20) not null,
Credit_Hours int CHECK (Credit_Hours<4) not null,
Course_Description text
);

select * from Courses;
drop table Courses;

-- SCORES TABLE
create table Scores(
score_id int IDENTITY(1,1) PRIMARY KEY,
Std_id int FOREIGN KEY REFERENCES Add_Student(id),
Course_Id varchar(10) FOREIGN KEY REFERENCES Courses(Course_Id),
obtain_score int,
Total_score int,
sc_description text 
);

select * from Scores;
drop table Scores;

-- REGISTRATION TABLE
create table Registration(
reg_id int IDENTITY(1,1) PRIMARY KEY,
Std_id int FOREIGN KEY REFERENCES Add_Student(id) unique,
Course_Id varchar(10) FOREIGN KEY REFERENCES Courses(Course_Id)
);

select * from Registration;
drop table Registration;

insert into Registration(Std_id,Course_id) values(1,'cs345');

-- QUERY FOR FIND NUMBER OF STUDENTS ENROLL IN COURSE 
SELECT Registration.Course_Id, 
        Courses.Course_Name, 
        COUNT(Registration.Std_id) AS No_Of_Student
FROM Registration
INNER JOIN Courses
ON Registration.Course_ID=Courses.Course_ID
GROUP BY Registration.Course_ID, Courses.Course_Name;






-- FOR NORMALIZATION
-- 1) Student Table 
create table Student(
id int IDENTITY(1,1) PRIMARY KEY,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
DOB date CHECK(YEAR(GETDATE()) - YEAR(DOB)>18) not null,
gender varchar(10) not null,
phone int not null,
add_id int FOREIGN KEY REFERENCES Std_Address(add_id), -- Convert 1NF
stdImage image not null
) 
create table Std_Address(
add_id int primary key,
street varchar(30),
postal_code int,
add_state varchar(30),
country varchar(30)
)

-- 2) student table
-- Condition if admin wants to add student and score at same time
 create table Student(
id int IDENTITY(1,1) PRIMARY KEY,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
DOB date CHECK(YEAR(GETDATE()) - YEAR(DOB)>18) not null,
gender varchar(10) not null,
phone int not null,
add_id int FOREIGN KEY REFERENCES Std_Address(add_id), -- Convert 1NF
stdImage image not null,
score_id int FOREIGN KEY REFERENCES Score(score_id), -- Convert 2NF
) 
create table Scores(
score_id int IDENTITY(1,1) PRIMARY KEY,
Course_Id varchar(10) FOREIGN KEY REFERENCES Courses(Course_Id),
obtain_score int,
Total_score int,
sc_description text 
);

-- 3) Student table
-- Condition if admin wants to add student and score at same time
 create table Student(
id int IDENTITY(1,1) PRIMARY KEY,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
DOB date CHECK(YEAR(GETDATE()) - YEAR(DOB)>18) not null,
gender varchar(10) not null,
phone int not null,
add_id int FOREIGN KEY REFERENCES Std_Address(add_id), -- Convert 1NF
stdImage image not null,
course_id int FOREIGN KEY REFERENCES Courses(course_id), -- Convert 2NF
) 
create table Courses(
Course_Id varchar(10) primary key,
Course_Name varchar(20) not null,
Credit_Hours int CHECK (Credit_Hours<4) not null,
Course_Description text
);

-- 4) Student and Courses
--  As we see in student table one student ca enroll in multiple courses
-- which causes partial dependency so I create another Registeration table
create table Registration(
reg_id int IDENTITY(1,1) PRIMARY KEY,
Std_id int FOREIGN KEY REFERENCES Add_Student(id) unique,
Course_Id varchar(10) FOREIGN KEY REFERENCES Courses(Course_Id)
);

-- 5) Address  Table
-- If address_attributes present i student table it will cause transitive dependency
-- as street determines state and state determines country
-- Convert this into 3NF
 create table Student(
id int IDENTITY(1,1) PRIMARY KEY,
First_Name varchar(50) not null,
Last_Name varchar(50) not null,
DOB date CHECK(YEAR(GETDATE()) - YEAR(DOB)>18) not null,
gender varchar(10) not null,
phone int not null,
add_id int FOREIGN KEY REFERENCES Std_Address(add_id), -- Convert 1NF
stdImage image not null
) 
create table Std_Address(
add_id int primary key,
street varchar(30),
postal_code int,
add_state varchar(30),
country varchar(30)
)