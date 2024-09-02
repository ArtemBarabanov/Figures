Т.к. в задании идет речь о связи многие-ко-многим, то предполагается наличие трех таблиц Product, Category и ProductCategory. Запрос на получение требуемой информации может быть следующим

SELECT
Product.Name , Category.Name
FROM
Product
LEFT JOIN ProductCategory
ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON ProductCategory.CategoryId = Category.Id
