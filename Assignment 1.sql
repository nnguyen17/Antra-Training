--1. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p

--2. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where Not p.ListPrice = 0

--3. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color Is Null

--4. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color Is Not Null

--5. Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, and the column ListPrice has a value greater than zero.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color Is Not Null And p.ListPrice > 0

--6. Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.
Select p.Name + ' ' + p.Color [Name And Color]
From Production.Product p
Where p.Color Is Not Null

/* 7. Write a query that generates the following result set  from Production.Product:
     1. NAME: LL Crankarm  --  COLOR: Black
     2. NAME: ML Crankarm  --  COLOR: Black
     3. NAME: HL Crankarm  --  COLOR: Black
     4. NAME: Chainring Bolts  --  COLOR: Silver
     5. NAME: Chainring Nut  --  COLOR: Silver
     6. NAME: Chainring  --  COLOR: Black */
Select 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color [Name And Color]
From Production.Product p
Where p.Name Like '%Crankarm' Or p.Name Like 'Chainring%' 

--8. Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500
Select p.ProductID, p.Name
From Production.Product p
Where p.ProductID Between 400 And 500

--9. Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table restricted to the colors black and blue
Select p.ProductID, p.Name, p.Color
From Production.Product p
Where p.Color In ('Black', 'Blue')

--10. Write a query to get a result set on products that begins with the letter S. 
Select *
From Production.Product p
Where p.Name Like 'S%'

/* 11. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Your result set should look something like the following. Order the result set by the Name column. 
      1. Name                                               ListPrice
      2. Seat Lug                                              0,00
      3. Seat Post                                             0,00
      4. Seat Stays                                            0,00
      5. Seat Tube                                             0,00
      6. Short-Sleeve Classic Jersey, L                        53,99
      7. Short-Sleeve Classic Jersey, M                        53,99 */
Select p.Name [Name], p.ListPrice [ListPrice]
From Production.Product p
Where p.Name Like 'S%'
Order By p.Name Asc

/* 12. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. Your result set should look something like the following. Order the result set by the Name column. The products name should start with either 'A' or 'S'
      1. Name                                               ListPrice
      2. Adjustable Race                                      0,00
      3. All-Purpose Bike Stand                               159,00
      4. AWC Logo Cap                                         8,99
      5. Seat Lug                                             0,00
      6. Seat Post                                            0,00 */
Select p.Name [Name], p.ListPrice [ListPrice]
From Production.Product p
Where p.Name Like '[AS]%'
Order By p.Name Asc

--13. Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. After this zero or more letters can exists. Order the result set by the Name column.
Select *
From Production.Product p
Where p.Name Like 'SPO[^K]%'
Order By p.Name Asc

--14. Write a query that retrieves unique colors from the table Production.Product. Order the results  in descending  manner
Select Distinct p.Color
From Production.Product p
Order By p.Color Desc

--15. Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. Format and sort so the result set accordingly to the following. We do not want any rows that are NULL.in any of the two columns in the result.
Select Distinct p.ProductSubcategoryID, p.Color
From Production.Product p
Where p.ProductSubcategoryID Is Not Null And p.Color Is Not Null