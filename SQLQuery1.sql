CREATE TABLE users (
	id INT NOT NULL PRIMARY KEY IDENTITY,
	username nvarchar(255) NOT NULL,
	password nvarchar(255) NOT NULL,
)

/* add these users as start 
المدير | Manager
بائع 1 | Cashier 1
بائع 2 | Cashier 2
محاسب | Accountant


all off them are password: 1
*/

INSERT users (username, password) VALUES (N'Manager', '1'),
(N'Cashier 1', '1'),
(N'Cashier 2', '1'),
(N'Accountant', '1')


