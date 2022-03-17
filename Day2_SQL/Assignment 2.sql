--1. How many products can you find in the Production.Product table?
Select Count(*) 
From Production.Product

--2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
Select Count(*)
From Production.Product p
Where p.ProductSubcategoryID Is Not Null

/* 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
     ProductSubcategoryID CountedProducts
     -------------------- --------------- */
Select p.ProductSubcategoryID, Count(*) [CountedProducts]
From Production.Product p
Group By p.ProductSubcategoryID 

--4. How many products that do not have a product subcategory.
Select Count(*)
From Production.Product p
Where p.ProductSubcategoryID Is Null

--5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
Select Sum(p.Quantity)
From Production.ProductInventory p 

/* 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
     ProductID    TheSum
     -----------        ---------- */
Select p.ProductID, Sum(p.Quantity) [The Sum]
From Production.ProductInventory p 
Where p.LocationID = 40 And p.Quantity < 100
Group By p.ProductID

/* 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
      Shelf      ProductID    TheSum
	  -----      ---------    ------ */
Select p.Shelf, p.ProductID, Sum(p.Quantity) [The Sum]
From Production.ProductInventory p 
Where p.LocationID = 40 And p.Quantity < 100
Group By p.Shelf, p.ProductID

--8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
Select Avg(p.Quantity)
From Production.ProductInventory p
Where p.LocationID = 10

/* 9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
      ProductID   Shelf      TheAvg
	  ---------   -----      ------ */
Select p.ProductID, p.Shelf, Avg(p.Quantity) [The Avg]
From Production.ProductInventory p 
Group By p.ProductID, p.Shelf

/* 10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
       ProductID   Shelf      TheAvg
	   ---------   -----      ------ */
Select p.ProductID, p.Shelf, Avg(p.Quantity) [The Avg]
From Production.ProductInventory p 
Where p.Shelf <> 'N/A'
Group By p.ProductID, p.Shelf

/* 11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.
       Color               Class              TheCount          AvgPrice
	   -----               -----              --------          -------- */
Select p.Color, p.Class, Count(*) [The Count], Avg(p.ListPrice) [Avg Price]
From Production.Product p
Where p.Color Is Not Null And p.Class Is Not Null
Group By p.Color, p.Class

/* 12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.
       Country                        Province
	   -------                        -------- */
Select c.Name [Country], s.Name [Province]
From Person.CountryRegion c Join Person.StateProvince s
On c.CountryRegionCode = s.CountryRegionCode

/* 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
       Country                        Province
	   -------                        -------- */
Select c.Name [Country], s.Name [Province]
From Person.CountryRegion c Join Person.StateProvince s
On c.CountryRegionCode = s.CountryRegionCode
Where c.Name In ('Germany', 'Canada')

--14. List all Products that has been sold at least once in last 25 years.
Select p.ProductName, o.OrderDate
From Products p Join [Order Details] od
On p.ProductID = od.ProductID Join Orders o
On od.OrderID = o.OrderID
Where o.OrderDate Between '1997-03-17' And '2022-03-17'

--15. List top 5 locations (Zip Code) where the products sold most.
Select Top 5 o.ShipPostalCode ,Count(o.ShipPostalCode) [Count]
From Orders o
Group By o.ShipPostalCode
Order By [Count] Desc

--16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
Select Top 5 o.ShipPostalCode ,Count(o.ShipPostalCode) [Count]
From Orders o
Where o.OrderDate Between '1997-03-17' And '2022-03-17'
Group By o.ShipPostalCode
Order By [Count] Desc

--17. List all city names and number of customers in that city.   
Select c.City, Count(*)
From Customers c
Group By c.City

--18. List city names which have more than 2 customers, and number of customers in that city
Select c.City, Count(*)
From Customers c
Group By c.City
Having Count(*) > 2

--19. List the names of customers who placed orders after 1/1/98 with order date.
Select c.ContactName, o.OrderDate
From Customers c Join Orders o
On c.CustomerID = o.CustomerID
Where o.OrderDate > '1998-01-01'

--20. List the names of all customers with most recent order dates
Select c.ContactName, Max(o.OrderDate)
From Customers c Join Orders o
On c.CustomerID = o.CustomerID
Group By c.ContactName

--21. Display the names of all customers  along with the  count of products they bought
Select c.ContactName, Count(*) [Count]
From Customers c Join Orders o
On c.CustomerID = o.CustomerID
Group By c.ContactName

--22. Display the customer ids who bought more than 100 Products with count of products.
Select c.CustomerID, Count(*) [Count]
From Customers c Join Orders o
On c.CustomerID = o.CustomerID
Group By c.CustomerID
Having Count(*) > 100

/* 23. List all of the possible ways that suppliers can ship their products. Display the results as below
    Supplier Company Name                Shipping Company Name
    ---------------------                --------------------- */
Select su.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
From Suppliers su Cross Join Shippers sh

--24. Display the products order each day. Show Order date and Product Name.
Select Distinct o.OrderDate, p.ProductName
From Orders o Join [Order Details] od
On o.OrderID = od.OrderID Join Products p
On od.ProductID = p.ProductID
Order By o.OrderDate

--25. Displays pairs of employees who have the same job title.
Select Distinct e1.FirstName + ' ' + e1.LastName [1st Employee Name], e1.Title, e2.FirstName + ' ' + e2.LastName [2nd Employee Name], e2.Title
From Employees e1 Join Employees e2
On e1.Title = e2.Title
Where e1.EmployeeID <> e2.EmployeeID

--26. Display all the Managers who have more than 2 employees reporting to them.
Select Distinct e2.FirstName + ' ' + e2.LastName [2nd Employee Name], Count(*) [NumReportsTo]
From Employees e1 Join Employees e2
On e1.ReportsTo = e2.EmployeeID
Group By e2.FirstName + ' ' + e2.LastName

/* 27. Display the customers and suppliers by city. The results should have the following columns
       City
	   Name
	   Contact Name,
	   Type (Customer or Supplier) */
Select c.City, c.ContactName, IsNull(c.CompanyName, 'N/A') [Company Name], 'Customer' [Type] 
From Customers c 
Union 
Select s.City, IsNull(s.ContactName, 'N/A'), s.CompanyName [Company Name], 'Supplier' [Type]
From Suppliers s
