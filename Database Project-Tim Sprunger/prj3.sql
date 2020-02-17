--#1  Select using a sort on two or more columns

SELECT first, last, state 
FROM member
ORDER BY last ASC, state ASC;

--Description...This query would be used by a company if they needed to know the first 
--name,last name, and state of each member.  By first organizing the last name in 
--ascending order, then organizing the state in asceding order, the company would now be 
--able to more easily examine the data in the member table.



--#2  Select using a calculated field

SELECT first, last, hourlyrate*40 AS "Weekly Rate"
FROM employee;

--Description...This query would be helpful for a company because it will display the 
--first and last name of each employee along with the amount of money each of them will
--make per week assuming all their employees work full time.  Rather than just showing 
--the hourly rate, knowing the weekly amount of money employees are being payed could be 
--helpful for a company to know.



--#3  Select using a MariaDB function

SELECT first, last, DATE_ADD(joindate, INTERVAL 365 DAY)
FROM member;

--Description...This query will show the first and last name of each member along with 
--the date when each individual has been a memeber for a year.  A gym could use the 
--information if they wanted to send out a card to customers thanking them for being part 
--of their gym for a year.



--#4  Select using an aggregation with group by and having 

SELECT state, round(AVG(hourlyrate),2) AS "Average Hourly Rate"
FROM employee
GROUP BY state;

--Description...This query will show each state and the average hourly rate for each 
--corresponding state.  A company might use this query if they need to know how much, on
--average, how much they are paying employees by state.



--#5  Select forming a join 

SELECT member.first AS "Member First", member.last AS "Member Last", employee.first AS 
"Trainer First", employee.last AS "Trainer Last", class.name AS "Class Name"
from employee, member, trainer, class
WHERE member.employeeid = trainer.employeeid
AND class.classid = member.classid
AND employee.employeeid = trainer.employeeid;

--Description...This query would be very useful for a gym because it shows each members 
--first and last name with their trainers first and last name along with the class they 
--are in.  This query joins together four different tables that makes it much more easy 
--to read the information together.



--#6  Selecting cross product style join (self join) of three or more tables

SELECT a.last, b.last
FROM member a, member b
WHERE a.memberid = b.employeeid;

--The design of my database doesn't allow for the practical use of a self join.  
--Therefore, this query doesn't really have a practical use, but it shows how the concept 
--of a self join works. This query would be used by a gym if, for some reason, they wanted
--to know the last names of the members where the memberid is the same as the employee id. 

--#7  Update query

UPDATE member
SET address = "222 Drury Lane" 
WHERE memberid = 2;

--Description...This query would be used by a gym if one of its members moved to a 
--different address. The query would update the member's info to contain his or her new 
--address.



--#8  Delete query

DELETE FROM class
WHERE classid = 13;

--Description...This query would be used by a gym if they started a new class, but no 
--members signed up for it.  Therefore, they decided to stop the class and stop storing 
--information about it.



--#9  View (and demonstrate the use of this view)

CREATE VIEW membertrainerclass AS
SELECT member.first AS "Member First", member.last AS "Member Last", employee.first AS 
"Trainer First", employee.last AS "Trainer Last", class.name AS "Class Name"
from employee, member, trainer, class
WHERE member.employeeid = trainer.employeeid
AND class.classid = member.classid
AND employee.employeeid = trainer.employeeid;

SELECT * from membertrainerclass;

--Description...This query is the same as the join created in #5.  However, because it is
--very likely that the gym would need to look at all of this information frequently, 
--creating a view basically stores this query under a name and allows you to run the query 
--just by selecting all from the view name.  This query is very powerful and can save a 
--gym a lot of time instead of having to recreate your query every time they want the 
--information.



--#10  Your Choice

SELECT first, last, city, state 
FROM member
WHERE city = "Ashland" AND state = "OH";

--Description...This query would be use to show all members of the gym who are from 
--Ashland, Ohio.  A query like this could be helpful if a company wants to see all of its 
--members from a specific city and state.


