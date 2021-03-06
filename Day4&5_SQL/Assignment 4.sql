--1. Create a view named ?view_product_order_[your_last_name]?, list all products and total ordered quantity for that product.
Create View view_product_order_Nguyen As
Select p.ProductName, od.Quantity
From Products p Left Join [Order Details] od
On p.ProductID = od.ProductID

--2. Create a stored procedure ?sp_product_order_quantity_[your_last_name]? that accept product id as an input and total quantities of order as output parameter.
Create Proc sp_product_order_quantity_Nguyen @Id int, @Quan int out As
Begin
Select @Quan = od.Quantity
From Products p Left Join [Order Details] od
On p.ProductID = od.ProductID
Where p.ProductID = @Id
End

--3. Create a stored procedure ?sp_product_order_city_[your_last_name]? that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
Create Proc sp_product_order_city_Nguyen @pName varchar(30), @cName varchar(30) out, @total int out As
Begin
Select Top 5 @cName = City, @total = [Total Quantity]
From (Select c.City, p.ProductName, Sum(od.Quantity) [Total Quantity]
		From Products p Left Join [Order Details] od
		On p.ProductID = od.ProductID Join Orders o
		On od.OrderID = o.OrderID Join Customers c
		On o.CustomerID = c.CustomerID
		Group By c.City,p.ProductName) dt
Where ProductName = @pName
End

--4. Create 2 new tables ?people_your_last_name? ?city_your_last_name?. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city ?Madison?. Create a view ?Packers_your_name? lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
Create Table city_Nguyen (
Id int Primary Key,
City varchar(30)
)
Create Table people_Nguyen (
id int,
Name varchar(30),
City int Foreign Key References city_Nguyen(Id)
)

Insert Into people_Nguyen 
Values (1, 'Aaron Rodgers', 2), (2, 'Russell Wilson', 1), (3, 'Jody Nelson', 2)
Insert Into city_Nguyen
Values (1, 'Seattle'), (2, 'Green Bay')

Delete From city_Nguyen 
Where City = 'Seattle'

Insert Into city_Nguyen
Values (3, 'Madison')
Update people_Nguyen
Set City = 3
Where City = 1

Create View Packers_Nam As
Select * 
From people_Nguyen p Join city_Nguyen c
On p.City = c.Id

Drop Table city_Nguyen, people_Nguyen
Drop View Packers_Nam

--5. Create a stored procedure ?sp_birthday_employees_[you_last_name]? that creates a new table ?birthday_employees_your_last_name? and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
Create Proc sp_birthday_employees_Nguyen AS
Begin
Create Table birthday_employees_Nguyen As
Select FirstName + ' ' + LastName, BirthDate
From Employees
Where cast(BirthDate as date) like '_____02%'
End

--6. I will do an Union query to check or I can use Checksum Table too. 