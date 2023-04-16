-- Request 0

--create database Lecture_03_db;
--use Lecture_03_db;

--DROP TABLE vacancies;
--DROP TABLE equipment;
--DROP TABLE employee;
--DROP TABLE position;
--DROP TABLE project;

create table position
(
	id int not null identity(1,1),
	name varchar(20),
	rate int,
	primary key (id)
);

create table vacancies
(
	id int not null identity(1,1),
	position_id int,
	primary key (id),
	foreign key (position_id) references position (id)
);

create table project
(
	id int not null identity(1,1),
	name varchar(40),
	max_sum_rate int,
	primary key (id)
);

create table employee
(
	id int not null identity(1,1),
	first_name varchar(20),
	last_name varchar(30),
	project_id int,
	position_id int,
	primary key (id),
	foreign key (project_id) references project (id),
	foreign key (position_id) references position (id)
);

create table equipment
(
	id int not null identity(1,1),
	name varchar(20),
	price float,
	employee_id int,
	primary key (id),
	foreign key (employee_id) references employee (id)
);


insert project(name, max_sum_rate)
values
('first', 900),
('second', 1200),
('third', 300),
('fourth', 400),
('fifth', 500);

insert position(name, rate)
values
('Developer', 500),
('QA', 450),
('QA Auto', 510),
('PM', 600),
('Designer', 430);

insert employee(first_name, last_name, project_id, position_id)
values
('Mike', 'Berug', 3, 1),
('Johanna', 'Linberg', 2, 3),
('Andrew', 'Brossmann', 4, 2),
('Alex', 'Hoffmann', 2, 4),
('Hanna', 'Mayer', 1, 5),
('Mishel', 'Richard', NULL, 4);

insert vacancies(position_id)
values
(2),
(1),
(3),
(2),
(4);

insert equipment(name, price, employee_id)
values
('iMac', 2000, NULL),
('MacBook Air', 1200, 2),
('Monitor', 600, 2),
('Lenovo', 1500, 1),
('HP Laptop', 1300, 3),
('Acer Laptop', 1100, 4),
('Keyboard Logitech', 200, 3);

