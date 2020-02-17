INSERT INTO employee (first, last, address, city, state, zip, hiredate, hourlyrate) 
VALUES 
("Paul", "Mars", "2232 Red St.", "Denver", "CO", 44542, "2014-06-03", 9.50),
("Mark", "Saturn", "4050 Ring Rd.", "Phoenix", "AZ", 44317, "2014-06-10", 9.55),
("Juno", "Jupiter", "6273 Blueberry Ave.", "New York", "NY", 44444, "2014-06-15", 9.60),
("Samuel", "Popsky", "3343 Bumble Dr.", "Columbus", "OH", 44567, "2014-06-22", 9.40),
("Daniel", "Storm", "767 Superman Blvd.", "Cleveland", "OH", 45656, "2014-06-28", 9.45),
("Mado", "Martinez", "1750 Crumb Rd.", "Helena", "MT", 42322, "2014-06-30", 9.50),
("Bruce", "Lee", "55 Wonder Ave.", "Berne", "IN", 46755, "2014-07-05", 10.05),
("Jackie", "Chan", "223 Stinger Blvd.", "Peru", "IN", 44337, "2014-07-07", 9.35),
("Giovanni", "Martinez", "16 Papaya St.", "Huntington", "IN", 46750, "2014-07-08", 11.00),
("Tony", "Lewandowski", "4555 Bud St.", "San Diego", "CA", 22590, "2014-07-11", 8.40),
("Lodena", "Larson", "887 Broad St.", "Marion", "IN", 46777, "2014-07-15", 9.90),
("Jaron", "Lewis", "54 Curry Ave.", "Dubai", "IN", 47277, "2014-07-22", 12.00),
("Brody", "Wonder", "555 Flash St.", "Kokomo", "IN", 46775, "2014-07-29", 8.00),
("Susie", "Pillington", "221 Pillage Ave.", "Ashland", "OH", 44805, "2014-08-14", 12.50),
("Barbara", "Walters", "23 Plunder Ave.", "Ashland", "OH", 44805, "2014-08-20", 10.10);


INSERT INTO trainer (employeeid)
VALUES
(1), 
(3), 
(4), 
(5), 
(7), 
(8), 
(10), 
(12), 
(13), 
(15);


INSERT INTO class (name, day, time, employeeid)
VALUES
("Get Abs in 60 Minutes", "-M-W-F-", "13:00:00", 1),
("Cardiovascular Endurance", "--T-R--", "19:00:00", 1),
("Insanity", "-----FS", "05:00:00", 15),
("Running Club", "--T-R--", "06:00:00", 10),
("Resistance Training", "-MT-RF-", "21:00:00", 10),
("Arms of a Champion", "--T-R--", "04:00:00", 1),
("Wellness For Life", "-M-W-F-", "15:00:00", 4),
("Zumba", "--T-R--", "20:00:00", 4),
("YPYM (Yoga for Young Pregnant Women)", "-M-W-F-", "10:00:00", 15),
("Endurance Training", "-M-W-F-", "18:00:00", 13);


INSERT INTO member (first, last, address, city, state, zip, joindate) 
VALUES 
("Daniel", "Smith", "16 Poppy St.", "Ashland", "OH", 44805, "2014-09-01"),
("Jose", "Rodriguez", "232 Marcos Ave.", "Denver", "CO", 44542, "2014-09-04"),
("Samuel", "Danvers", "3333 Maggot Dr.", "Mansfield", "OH", 44906, "2014-09-05"),
("Ricky", "Danvers", "3333 Maggot Dr.", "Mansfield", "OH", 44906, "2014-09-05"),
("Tina", "Lard", "449 Tunker St.", "Salem", "OR", 49987, "2014-09-06"),
("Debra", "Devers", "368 Main St.", "Peru", "IN", 44337, "2014-09-06"),
("Mark", "Devers", "368 Main St.", "Peru", "IN", 44337, "2014-09-06"),
("Lucile", "Rongos", "7189 Ludwig Blvd.", "Huntington", "IN", 46750, "2014-09-07"),
("Heath", "Reineke", "6654 Barren St.", "San Diego", "CA", 22590, "2014-09-06"),
("Danny", "Smith", "21 Chartwells St.", "Columbus", "OH", 44567, "2014-09-10"),
("Helen", "Finley", "168 Hoopla Ave.", "Helena", "MT", 42322, "2014-09-11"),
("Geordan", "Turske", "159 Rambo Rd.", "Kokomo", "IN", 46775, "2014-09-11"),
("Edwin", "Turske", "159 Rambo Rd.", "Kokomo", "IN", 46775, "2014-09-11"),
("Jimmy", "Turske", "159 Rambo Rd.", "Kokomo", "IN", 46775, "2014-09-11"),
("Kugbe", "Sinnah", "786 Rice Rd.", "Daytona Beach", "FL", 44898, "2014-09-15"),
("Chuck", "Norris", "Olympiad Blvd.", "Ashland", "OR", 78765, "2014-09-16"),
("Linda", "Norris", "Olympiad Blvd.", "Ashland", "OR", 78765, "2014-09-16"),
("Daniel", "Wright", "235 Wright Rd.", "Huntington", "IN", 46750, "2014-09-21"),
("Maria", "Lopez", "3435 Sunday St.", "Berne", "IN", 46755, "2014-09-22"),
("Bob", "Barker", "234 Bumblebee Blvd.", "Dubai", "IN", 47277, "2014-09-25");


UPDATE member SET employeeid = 15, classid = 3
WHERE memberid = 2;

UPDATE member SET employeeid = 1, classid = 1
WHERE memberid = 19;

UPDATE member SET employeeid = 15, classid = 9
WHERE memberid = 5;

UPDATE member SET employeeid = 10, classid = 4
WHERE memberid = 6;

UPDATE member SET employeeid = 13, classid = 10
WHERE memberid = 12;

UPDATE member SET employeeid = 15, classid = 3
WHERE memberid = 17;

UPDATE member SET employeeid = 1, classid = 1
WHERE memberid = 6;

UPDATE member SET employeeid = 10, classid = 4
WHERE memberid = 7;

UPDATE member SET employeeid = 15, classid = 3
WHERE memberid = 8;

UPDATE member SET employeeid = 15, classid = 3
WHERE memberid = 20;


INSERT INTO memberclass (classid, memberid)
VALUES
(3, 2), (1, 19), (9, 5), (4, 6), (10, 12), (3, 17), (1, 6), (4, 7), (3, 8), (3, 20);

















