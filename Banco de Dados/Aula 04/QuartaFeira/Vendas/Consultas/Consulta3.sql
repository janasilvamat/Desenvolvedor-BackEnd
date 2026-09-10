--Seleciona todas as colunas através do * da tabela Vendas
SELECT * FROM Vendas;
GO

--Seleciona todas as colunas da tabela Vendas onde o faturamento é maior que 100
SELECT * FROM Vendas WHERE Faturamento > 100;
GO

--Seleciona as colunas Tipo e Lucro da tabela Vendas onde o Tipo é igual a Camisa.
--Usando o LIKE se colocar %Cam% vai trazer todos que contenham o trecho Cam, 
--se colocar Cam% vai trazer todos que comecem com Cam 
--e se colocar %Cam vai trazer todos que terminem com Cam.
SELECT Tipo, Lucro FROM Vendas WHERE Tipo LIKE 'Camisa';
GO
