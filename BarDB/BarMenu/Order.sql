CREATE TABLE [dbo].[Order]
(
	[OrderID] INT NOT NULL PRIMARY KEY, 
    [DrinkName] VARCHAR(255) NOT NULL,
	[DrinkModification] VARCHAR(255) NULL, 
    [Time] TIME NULL, 
    [FinishCheck] VARCHAR(50) NOT NULL DEFAULT 'No', 
   
)
