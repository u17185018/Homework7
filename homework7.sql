Create database Shop;

use shop;

Create table ShopItem (
ItemID int identity(1,1),
ItemName varchar(50),
ItemDesc varchar(50),
Price float,
QuantityAvailable int,

);