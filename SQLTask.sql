SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON c.CategoryID = pc.CategoryID

UNION

SELECT p.ProductName, NULL AS CategoryName
FROM Products p
WHERE NOT EXISTS (
    SELECT 1
    FROM ProductCategories pc
    WHERE pc.ProductID = p.ProductID
)