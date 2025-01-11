CREATE TABLE ProductTable (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,      
    ProductCategory VARCHAR(50) NOT NULL,          
    ProductPrice INT NOT NULL,          
    ProductQuantity INT NOT NULL,                  
    Description NVARCHAR(MAX) NULL           
);
