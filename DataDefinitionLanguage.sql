/* create a new table called persons with columns: id, person_name,
 birth_date, and phone */
 
 CREATE TABLE persons(
 id INT NOT NULL,
 person_name VARCHAR(50),
 birth_date DATE,
 phone VARCHAR(15),
 CONSTRAINT pk_persons PRIMARY KEY (id)
 )

 SELECT * FROM persons
 
 -- ADD  a new column called email to the persons table 
ALTER TABLE persons
ADD email VARCHAR(50) NOT NULL

SELECT * FROM persons

--remove a the column called phone from the persons table
ALTER TABLE persons
DROP COLUMN phone

SELECT * FROM persons

--remove the table person
DROP TABLE persons 

SELECT * FROM persons 