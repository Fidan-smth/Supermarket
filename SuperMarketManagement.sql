USE Supermarket;

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'ProductTable' AND type = 'U')
    DROP TABLE ProductTable;
CREATE TABLE ProductTable (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,      
    ProductCategory VARCHAR(50) NOT NULL,          
    ProductPrice INT NOT NULL,          
    ProductQuantity INT NOT NULL
);

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'SellerTable' AND type = 'U')
    DROP TABLE SellerTable;
CREATE TABLE SellerTable (
    SellerID INT IDENTITY(1,1) PRIMARY KEY,    
    SellerName VARCHAR(100) NOT NULL,             
    SellerAge INT NOT NULL,                       
    SellerPhone VARCHAR(15) NOT NULL,             
    SellerPassword VARCHAR(50) NOT NULL
);

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CategoryTable' AND type = 'U')
    DROP TABLE CategoryTable;
CREATE TABLE CategoryTable (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,  
    CategoryName VARCHAR(100) NOT NULL,  
    CategoryDescription VARCHAR(100) NOT NULL  
);

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'BillTable' AND type = 'U')
    DROP TABLE BillTable;
CREATE TABLE BillTable (
    BillId INT IDENTITY(1,1) PRIMARY KEY,    
    SellerName VARCHAR(100) NOT NULL,             
    Date VARCHAR(100) NOT NULL,                       
    Amount INT NOT NULL
);