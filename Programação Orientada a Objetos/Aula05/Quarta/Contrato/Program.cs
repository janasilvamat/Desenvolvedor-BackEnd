using Contrato.Classes.Entidades;

Enpresa SENAI = new Enpresa("Roberto Mange", "Clodoaldo");
SENAI.RegistrarContratoFuncionario(10, 50);

Console.WriteLine(SENAI);

SENAI = null;

Console.WriteLine(SENAI);
Console.WriteLine();

