SELECT ProductName, CategoryName
FROM dbo.Products as prod
LEFT JOIN dbo.ProductsCategories as prodCat
	ON prod.ProductId = prodCat.ProductId
LEFT JOIN dbo.Categories as cat
	ON cat.CategoryId = prodCat.CategoryId