alter table Users
add Rolle NVARCHAR(MAX)


INSERT INTO Users(Username, PassCode,  Rolle) values('admin', 'admin123', 'Admin'),('staff', 'staff123', 'staff') 
select * from Users

use invetory_MS
