-- Criação da tabela Vendas
CREATE TABLE Vendas1 (
    Id INT PRIMARY KEY,
    DataCompra NVARCHAR(10),   
    Tipo NVARCHAR(25),
    Marca NVARCHAR(25),
    Faturamento DECIMAL(10, 2),
    Lucro DECIMAL(10, 2)
);
GO 