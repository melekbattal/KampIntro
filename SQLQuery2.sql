--select
select CompanyName Adi,City,ContactName SirketAdi from Customers

select * from Customers where City ='London'

select * from Products where CategoryId=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID, ProductName
select * from Products where categoryId=1 order by UnitPrice desc
select count (*) from Products
select categoryId, count (*) from products group by CategoryID
select * from Products inner join Categories on Products. CategoryID =Categories