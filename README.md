# Ответ на задание 3 
Select p.ProductName AS "Имя продукта", c.CategoryName AS "Имя категори"
From Products AS p Left join Categories AS c On p.CategoryID = p.CategoryID
