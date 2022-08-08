CREATE TABLE Product  
(  
    Id int NOT NULL,
    ProductName nvarchar(20) NOT NULL UNIQUE,
	Price decimal NOT NULL,
	PRIMARY KEY(Id),
);  

CREATE TABLE Category  
(  
    Id int NOT NULL,
	CategoryName nvarchar(20) NOT NULL UNIQUE,
	PRIMARY KEY(Id),
);  

CREATE TABLE Category_Product 
(  
    CategoryId int NULL,
	ProductId int NULL,
	FOREIGN KEY (CategoryId) REFERENCES Category (Id),
	FOREIGN KEY (ProductId) REFERENCES Product (Id)
);  

INSERT Category VALUES (1, 'Fish')
INSERT Category VALUES (2, 'Meat')
INSERT Category VALUES (3, 'Fruit')

INSERT Product VALUES (1, 'mackerel', 12)
INSERT Product VALUES (2, 'beef', 42)
INSERT Product VALUES (3, 'apple', 25)
INSERT Product VALUES (4, 'boots', 25)
INSERT Product VALUES (5, 'whale meat', 25)

INSERT Category_Product VALUES (1, 1)
INSERT Category_Product VALUES (2, 2)
INSERT Category_Product VALUES (3, 3)
INSERT Category_Product VALUES (NULL, 4)
INSERT Category_Product VALUES (1, 5)
INSERT Category_Product VALUES (2, 5)

SELECT ProductName,
       CategoryName
FROM Category_Product 
LEFT JOIN Product 
ON Category_Product.ProductId = Product.Id
LEFT JOIN Category 
ON Category_Product.CategoryId = Category.Id
