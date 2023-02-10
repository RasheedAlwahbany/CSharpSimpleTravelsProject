/*create table employee(
id char(9) primary key,
fname varchar(40),
lname varchar(40),
jtype varchar(40),
phone int,
salary decimal(9,2),
bouns decimal(9,2),
minus decimal(9,2),
address varchar(40),
m_id char(9),
description varchar(50),
hdate date,
foreign key(m_id) references employee(id)
)
 

 */


create table travels(
id char(9) primary key,
name varchar(40),
dir varchar(40),
gtime varchar(30),
dtime varchar(30),
t_saits int,
a_saits int,
b_saits int,
a_cost decimal(9,2),
b_cost decimal(9,2),
c_name varchar(40),
description varchar(40),
t_date date,
foreign key(c_name) references company(name)
)


 create table invoice (
id char(9) primary key,
fname varchar(40),
lname varchar(40),
phone int,
c_name varchar(40),
t_id char(9),
t_dir varchar(40),
s_number char(9),
total_cost decimal(9), 
description varchar(40),
t_date date,
r_date date,
g_time varchar(40),
foreign key(c_name) references company(name),
foreign key(t_id) references travels(id)
 )
  




create table company(
name varchar(40) primary key,
m_id char(9),
m_fname varchar(40),
m_lname varchar(40),
m_phnumber int,
description varchar(40),
Address varchar(50),
c_date date,
foreign key(m_id) references employee(id)

)


