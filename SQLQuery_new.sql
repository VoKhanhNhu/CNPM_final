USE master
--DROP DATABASE se_project
CREATE DATABASE se_project
go 
USE se_project
GO
CREATE TABLE products (
    product_id VARCHAR(255) PRIMARY KEY,
    product_name VARCHAR(50) NOT NULL,
    price FLOAT  NOT NULL,
    quantity INT NOT NULL
);
						
-- Table for authorized resellers/agents
CREATE TABLE resellers (
    reseller_id INT PRIMARY KEY,
    reseller_name VARCHAR(50) NOT NULL,
    address VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    email VARCHAR(50)
);

-- Table for orders placed by resellers
CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    reseller_id INT NOT NULL,
    order_date DATETIME NOT NULL,
    total_cost FLOAT NOT NULL,
    payment_method VARCHAR(20) NOT NULL,
    payment_status VARCHAR(20) NOT NULL,
    delivery_status VARCHAR(20) NOT NULL,
    FOREIGN KEY (reseller_id) REFERENCES resellers(reseller_id)
);


-- Table for items in each order
CREATE TABLE order_products (
    order_id INT NOT NULL,
    product_id VARCHAR(255) NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (order_id, product_id),
    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Table for good received
CREATE TABLE received_notes (
    received_id INT PRIMARY KEY,
    received_date DATETIME NOT NULL
);

select * from received_notes


-- Table for items in each warehouse receipt
CREATE TABLE received_products (
    received_id INT NOT NULL,
    product_id VARCHAR(255) NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (received_id, product_id),
    FOREIGN KEY (received_id) REFERENCES received_notes(received_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Table for goods delivery notes
CREATE TABLE delivery_notes (
    delivery_note_id INT PRIMARY KEY,
    order_id INT NOT NULL,
    delivery_date DATETIME NOT NULL,
    FOREIGN KEY (order_id) REFERENCES orders(order_id)
);
-- Table for delivery note items
CREATE TABLE delivery_note_products (
    id INT PRIMARY KEY,
    delivery_note_id INT,
    product_id VARCHAR(255),
    quantity INT,
    FOREIGN KEY (delivery_note_id) REFERENCES delivery_notes(delivery_note_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Table for incoming/outgoing stock report
CREATE TABLE stock_report (
    report_id INT PRIMARY KEY,
    report_date DATETIME NOT NULL,
    report_type VARCHAR(20) NOT NULL
);

-- Table for items in stock report
CREATE TABLE report_items (
    report_id INT NOT NULL,
    product_id VARCHAR(255) NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (report_id, product_id),
    FOREIGN KEY (report_id) REFERENCES stock_report(report_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

-- Table for revenue report
CREATE TABLE revenue_report (
    report_id INT PRIMARY KEY,
    report_date DATETIME NOT NULL
);

-- Table for revenue by product in revenue report
CREATE TABLE revenue_items (
    report_id INT NOT NULL,
    product_id VARCHAR(255) NOT NULL,
    revenue DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (report_id, product_id),
    FOREIGN KEY (report_id) REFERENCES revenue_report(report_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);
SELECT received_products.product_id,received_products.quantity,products.price FROM received_products INNER JOIN products ON received_products.product_id = products.product_id WHERE received_id like 2
INSERT INTO received_notes VALUES(1,'8/7/2022')
INSERT INTO received_notes VALUES(2,'6/3/2012')
INSERT INTO products(product_id,product_name,price,quantity) VALUES ('S001','SAMSUNG GALAXY S23 ULTRA',21.82,15)
INSERT INTO products(product_id,product_name,price,quantity) VALUES('S002','SAMSUNG GALAXY S22 ULTRA',17.39,40)
INSERT INTO products(product_id,product_name,price,quantity) VALUES('S003','SAMSUNG GALAXY Z FLIP4',16.49,20)
INSERT INTO products(product_id,product_name,price,quantity) VALUES('A004','IPHONE 14 PROMAX',24.5,30)
INSERT INTO received_products(received_id,product_id,quantity) VALUES(1,'S001',10)
INSERT INTO received_products(received_id,product_id,quantity) VALUES(1,'S003',4)




