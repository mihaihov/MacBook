--SELECT * FROM Customers WHERE city = 'Springfield'
-- SELECT * FROM Products WHERE stock_quantity <= 0
SELECT * FROM Orders
SELECT * FROM Customers
SELECT * FROM Orders
LEFT JOIN
Customers
ON Orders.customer_id = Customers.customer_id
DELETE FROM Customers WHERE first_name = 'Charlie'
INSERT INTO Orders (customer_id, order_date,status,total_amount)
VALUES (null, '2024-07-10 12:00:00.000', 'Pending', 822.43)

SELECT * FROM Products
SELECT * FROM Suppliers
SELECT * FROM ProductSuppliers
SELECT * FROM Products p
JOIN ProductSuppliers ps
ON p.product_id = ps.product_id
JOIN Suppliers s
ON ps.supplier_id = s.supplier_id

SELECT p.product_id, p.name, p.price, s.name AS supplier_name ,s.address AS supplier_address
FROM Products p
JOIN ProductSuppliers ps
ON p.product_id = ps.product_id
JOIN Suppliers s
ON ps.supplier_id = s.supplier_id

SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM OrderDetails
SELECT p.name AS product_name, SUM(od.quantity * od.price) AS total_revenue
FROM Products p
JOIN OrderDetails od
ON p.product_id = od.product_id
GROUP BY
p.product_id, p.name
SELECT * FROM OrderDetails
SELECT od.product_id, SUM(od.quantity * od.price) AS total_revenue
FROM OrderDetails od
GROUP BY od.product_id

SELECT * FROM Customers
SELECT * FROM OrderDetails
SELECT * FROM Orders
SELECT c.name AS customer_name
FROM Customers c, COUNT(od.quantity)
JOIN Orders o ON c.customer_id = o.customer_id
JOIN OrderDetails od ON o.order_id = od.order_id
GROUP BY c.customer_id
ORDER BY DESC

SELECT * FROM Products
SELECT * FROM OrderDetails
SELECT pr.product_name FROM
(SELECT p.name AS product_name, od.product_id AS product_id
FROM Products p
LEFT JOIN OrderDetails od ON p.product_id = od.product_id) pr
WHERE pr.product_id IS NULL

SELECT (c.first_name + ' ' + c.last_name) AS customer_name
FROM Customers c
JOIN Orders o ON c.customer_id = o.customer_id
WHERE o.total_amount > 300

SELECT * FROM Orders
INSERT INTO Orders(customer_id,order_date,status,total_amount)
VALUES (2,'2024-03-12 09:30:00.000', 'Shipped', '321.45')

SELECT * FROM Products
UPDATE Products SET stock_quantity = 49 WHERE product_id = 1

SELECT * FROM Customers
SELECT * FROM Customers

EXEC ModifyCustomerZipcode @CustomerName = 'Smith'