--Select
--Alias : Değişkenden sonra yazacağımız ifade sütun adını değiştirmemize yarar
Select ContactName KontakAdı,CompanyName ŞirketAdi,City Şehir from Customers
Select *from Customers where City ='Berlin' --City = Berlin olanları getirir
Select *from Products where CategoryID=1 or CategoryID=3 -- categoryıd sı 1ve 3 olanları getirir
Select *from Products where CategoryID=1 and  UnitPrice>=10 -- Unitprice'ı 10dan büyük olan ve categoryıd'sı 1 olanları getirdi,
Select * from Products order by ProductName   -- Products sütunundaki ProductName'leri sıralı şekilde getirdik
Select * from Products order by ProductName ,CategoryID  -- Products sütunundaki ProductNamecategoryıd sıralı şekilde getirdik
Select * from Products order by UnitPrice asc --ascending sıralamayı en alttan artırarak sıralar
Select * from Products order by UnitPrice desc --descending sıralamayı en yukardan azaltarak sıralar
Select * from Products where CategoryID=1 order by UnitPrice desc --categoryId'sı 1 olanlarıen yukardan azalan şekilde sıralar
Select Count(*) from Products --Products sütunundaki toplam satır sayısını verir(toplam ürün sayısı)
Select Count(*) from Products where CategoryID=2 --Products sütunundaki Categoryıd'sı 2 olanların toplam sayısını verir
Select Count(*)Adi from Products where CategoryID=2 --Products/ ategoryıd'sı 2 olanların toplam sayısını verir /alias kullandık
select CategoryID,count(*) from Products group by CategoryID --hangi categoryıd'den kaç tane oldugunu gruplar
select CategoryID,count(*) from Products group by CategoryID having count (*)<10--Category sütununda sayısı 10dan az olanları getir

select *from Products inner join Categories on Products.CategoryId =Categories.CategoryId