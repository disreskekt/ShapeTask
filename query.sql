SELECT Products.Name, Categories.Name
FROM dbo.Products
LEFT OUTER JOIN dbo.ProductsCategories ON Id = ProductId
LEFT OUTER JOIN dbo.Categories ON CategoryId = Categories.Id;