SELECT P.Name as [Имя продукта], C.Name as [Имя категории] 
FROM Products as P
LEFT JOIN ProductsToCategories PC on P.Id = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.Id; 
