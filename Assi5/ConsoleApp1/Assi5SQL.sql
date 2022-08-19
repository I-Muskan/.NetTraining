CREATE TABLE Category (
    CategoryID int NOT NULL,
    CategoryName varchar(100) NOT NULL,
    
    PRIMARY KEY (CategoryID),
   
);
CREATE TABLE Product (
    ProductID int NOT NULL,
    ProductName varchar(100) NOT NULL,
    Price float(53),
	CategoryID int NOT NULL,
    PRIMARY KEY (ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);
Select * from Product;
Select * from Category;
