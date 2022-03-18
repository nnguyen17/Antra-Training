--1. List all cities that have both Employees and Customers.
Select Distinct e.City 
From Employees e
Where e.City in (Select c.City From Customers c) 

--2. List all cities that have Customers but no Employee.
--a. Use sub-query
Select Distinct c.City 
From Customers c
Where Not c.City in (Select e.City From Employees e) 

--b. Do not use sub-query
Select Distinct c.City 
From Customers c, Employees e
Where c.City <> e.City

--3. List all products and their total order quantities throughout all orders.
Select p.ProductName, Sum(od.Quantity) [Total Order Quantitites]
From Products p Left Join [Order Details] od
On p.ProductID = od.ProductID
Group By p.ProductName
Order By [Total Order Quantitites] Desc

--4. List all Customer Cities and total products ordered by that city.
Select Distinct c.City, Sum(p.ProductID) [Total Products Ordered]
From Customers c Left Join Orders o
On c.CustomerID = o.CustomerID Left Join [Order Details] od
On o.OrderID = od.OrderID Left Join Products p
On od.ProductID = p.ProductID
Group By c.City
Order By [Total Products Ordered] Desc

--5. List all Customer Cities that have at least two customers.
--a. use union
Select City
From Customers
Group By City
Having Count(City) = 2
Union
Select City
From Customers
Group By City
Having Count(City) > 2

--b. Use sub-query and no union
Select Distinct City 
From Customers 
Where City in (Select City From Customers Group By City Having Count(City) >= 2)

--6. List all Customer Cities that have ordered at least two different kinds of products.
Select Distinct c.City, Count(Distinct p.ProductID) [Kinds of Product Ordered]
From Customers c Left Join Orders o
On c.CustomerID = o.CustomerID Left Join [Order Details] od
On o.OrderID = od.OrderID Left Join Products p
On od.ProductID = p.ProductID
Group By c.City
Having Count(Distinct p.ProductID) >= 2
Order By [Kinds of Product Ordered] Desc

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
Select Distinct c.ContactName, c.City, o.ShipCity
From Customers c Join Orders o
On c.CustomerID = o.CustomerID
Where c.City <> o.ShipCity

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
Select Top 5 p.ProductName, Avg(p.UnitPrice) [Average Price], c.City
From Products p Left Join [Order Details] od
On p.ProductID = od.ProductID Left Join Orders o
On od.OrderID = o.OrderID Left Join Customers c
On o.CustomerID = c.CustomerID
Group By p.ProductName, c.City
Order By Sum(od.Quantity) Desc

--9. List all cities that have never ordered something but we have employees there.
--a. Use sub-query
Select Distinct e.City
From Employees e
Where City in (Select c.City From Customers c Join Orders o 
				On c.CustomerID = o.CustomerID 
				Group By c.City
				Having Count(o.OrderID) = 0)

--b. Do not use sub-query
Select e.City
From Customers c Join Orders o 
On c.CustomerID = o.CustomerID Join Employees e
On o.EmployeeID = e.EmployeeID
Group By e.City
Having Count(o.OrderID) = 0 

--10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
Select Distinct c.City
From Customers c
Where c.City in (Select Top 1 c.City
				From Products p Join [Order Details] od
				On p.ProductID = od.ProductID Join Orders o
				On od.OrderID = o.OrderID Join Customers c
				On o.CustomerID = c.CustomerID
				Group By c.City
				Order By Count(o.ShipCity) Desc)
And c.City in (Select Top 1 c.City
				From Products p Join [Order Details] od
				On p.ProductID = od.ProductID Join Orders o
				On od.OrderID = o.OrderID Join Customers c
				On o.CustomerID = c.CustomerID
				Group By c.City
				Order By Count(p.ProductID) Desc)

--11. How do you remove the duplicates record of a table?
-- Find duplicate rows using GROUP BY clause or ROW_NUMBER() function.
-- Use DELETE statement to remove the duplicate rows.