CREATE TABLE Product(
	ID_Product int IDENTITY (1,1) NOT NULL ,
	Name_product NVARCHAR(50) NOT NULL,
	Price_product MONEY NOT NULL,
	Categories_product 
)

CREATE TABLE Categories_Product(
	Cat_Prod int NOT NULL,
	Name_Categories NVARCHAR(40) NOT NULL,
)



 -- левое внешнее соединение
select Name_product , Price_product , Name_Categories,Cat_Prod AS Categories
 FROM Product LEFT OUTER JOIN Categories_Product  
	     ON Categories_Product.Cat_Prod  = Product.Categories_product

-- правое внешнее соединение
select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product RIGHT OUTER JOIN Categories_Product  
	     ON Product.Categories_product = Categories_Product.Cat_Prod 

--полное внешнее соединение
select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product FULL OUTER JOIN Categories_Product  
	     ON Product.Categories_product = Categories_Product.Cat_Prod 


--левое внешнее соединение с ограниничением
select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product LEFT OUTER JOIN Categories_Product  
	     ON Categories_Product.Cat_Prod  = Product.Categories_product
 WHERE Cat_Prod is NULL

--правое внешнее соединение с ограниничением
select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product RIGHT OUTER JOIN Categories_Product  
	     ON Product.Categories_product = Categories_Product.Cat_Prod 
 WHERE Categories_product is NULL


 --Всё кроме пересечения UNION ALL

 (select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product LEFT OUTER JOIN Categories_Product  
	     ON Categories_Product.Cat_Prod  = Product.Categories_product
 WHERE Cat_Prod is NULL)

 UNION ALL

 (select Name_product,Price_product,Name_Categories,Cat_Prod AS Categories
 FROM Product RIGHT OUTER JOIN Categories_Product  
	     ON Product.Categories_product = Categories_Product.Cat_Prod 
 WHERE Categories_product is NULL)