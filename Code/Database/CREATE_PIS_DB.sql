CREATE TABLE userRole (roleID NUMBER(2), roleDescription VARCHAR2(30), PRIMARY KEY (roleID));
CREATE TABLE personnel (employeeID NUMBER(10) NOT NULL,firstName VARCHAR2(30), lastName VARCHAR2(30), idCard CHAR(8) UNIQUE, username CHAR(6) UNIQUE, passphrase VARCHAR2(40), 
                        roleID NUMBER(2), PRIMARY KEY (employeeID), FOREIGN KEY (roleID) REFERENCES userRole(roleID));
CREATE TABLE phone (employeeID NUMBER(10) NOT NULL, phoneNumber CHAR(10), PRIMARY KEY (phoneNumber, employeeID), FOREIGN KEY (employeeID) REFERENCES personnel(employeeID));
