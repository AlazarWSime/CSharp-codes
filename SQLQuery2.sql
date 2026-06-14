USE MyDatabase -- this one is going to chose the database you want to use

-- Retrieve all customers data
SELECT * 
FROM customers

-- Retrieve all orders data
SELECT * 
FROM orders

-- Retrieve each customer's name, country and score
SELECT
	first_name,
	country,
	score
FROM customers

-- Retrieve custormer's with score not equal to 0
SELECT *
FROM customers
WHERE score != 0

-- Retrieve custormer's from Germany only their name and country
SELECT 
	first_name,
	country 
FROM customers
WHERE country = 'Germany'

-- retrive all customers and sort the result by the highest score first
SELECT *
FROM customers
ORDER BY score DESC

-- retrive all customers and sort the result by the lowest score first
SELECT *
FROM customers 
ORDER BY score ASC

/* Retrieve all customers and sort the results by the cuntry and then by the higher score*/
SELECT * 
FROM customers
ORDER BY country ASC,
score DESC 

-- retrieve all customers and sort the reslults by the higher socre and then by the county
SELECT * 
FROM customers
ORDER BY score DESC, 
country ASC

-- find the total score for each country
SELECT 
   country,
   SUM(score) AS total_score
FROM customers
GROUP BY country

--find the total score and the total number of customeres for each country
SELECT 
    country,
	COUNT(id) AS total_customers,
	SUM(score) AS  total_score
FROM customers
GROUP BY country
  
--count the number of rows in the table
SELECT 
COUNT(id) AS total_number_of_rows
FROM customers

/* find the avrage score for each country considering only customers with a score
not equal to 0 And return only those countries with an average score greater 
than 430 */
SELECT country, AVG (score) AS average_score 
FROM customers 
WHERE score != 0 
GROUP BY country 
HAVING AVG (score) > 430

--return unique lists of all the countries
SELECT DISTINCT country 
FROM customers 

--retrive only three customers
SELECT TOP 3 * 
FROM customers

--retrive the TOP 3 Customers with the Highest Scores
SELECT TOP 3
	score 
FROM customers
ORDER BY score DESC

--Get the two most recent orders
SELECT TOP 2 *
FROM orders
ORDER BY order_id DESC 

-- test
SELECT 
	 country,
	 score
 FROM customers 

 --test
 SELECT 
    country,
	SUM(score) AS total_score
FROM customers
WHERE score > 10
GROUP BY country 
HAVING SUM(score) > 30

--TEST
SELECT 
   country,
   AVG(score) AS Arg
FROM customers
WHERE score != 0 
GROUP BY country
HAVING AVG(score) > 450
ORDER BY AVG(score) ASC
