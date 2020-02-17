CREATE TABLE member (
	memberid integer auto_increment NOT NULL,
	first varChar(20) NOT NULL,
	last varChar(20) NOT NULL,
	address varChar(50) NOT NULL,
	city varChar(20) NOT NULL,
	state char(2) NOT NULL,
	zip char(5) NOT NULL,
	joindate date NOT NULL,
	employeeid smallInt NULL,
	classid tinyInt NULL,
	PRIMARY KEY (memberid)
) ENGINE = InnoDB;



CREATE TABLE employee (
	employeeid smallInt auto_increment NOT NULL,
	first varChar(20) NOT NULL,
	last varChar(20) NOT NULL,
	address varChar(50) NOT NULL,
	city varChar(20) NOT NULL,
	state char(2) NOT NULL,
	zip char(5) NOT NULL,
	hiredate date NOT NULL,
	hourlyrate decimal(4,2) NOT NULL,
	PRIMARY KEY (employeeid)
) ENGINE = InnoDB;



CREATE TABLE trainer (
	employeeid smallInt NOT NULL,
	PRIMARY KEY (employeeid)  
) ENGINE = InnoDB;



CREATE TABLE class (
	classid tinyInt auto_increment NOT NULL,
	name varChar(50) NOT NULL,
	day char(7) NOT NULL,        
	time time NOT NULL,
	employeeid smallInt NOT NULL,   
	PRIMARY KEY (classid)
) ENGINE = InnoDB; 


CREATE TABLE memberclass (
	classid tinyInt,
	memberid integer,
	PRIMARY KEY (classid, memberid)
) ENGINE = InnoDB;


ALTER TABLE member
ADD CONSTRAINT fk_member_employeeid FOREIGN KEY (employeeid)
REFERENCES employee (employeeid)


ALTER TABLE member
ADD CONSTRAINT fk_member_classid FOREIGN KEY (classid)
REFERENCES class (classid);


ALTER TABLE class 
ADD CONSTRAINT fk_class_employeeid FOREIGN KEY (employeeid)
REFERENCES employee (employeeid);


ALTER TABLE trainer
ADD CONSTRAINT fk_trainer_employeeid FOREIGN KEY (employeeid)
REFERENCES employee (employeeid)


ALTER TABLE memberclass
ADD CONSTRAINT fk_memberclass_classid FOREIGN KEY (classid)
REFERENCES class (classid);


ALTER TABLE memberclass
ADD CONSTRAINT fk_memberclass_memberid FOREIGN KEY (memberid)
REFERENCES member (memberid);

	