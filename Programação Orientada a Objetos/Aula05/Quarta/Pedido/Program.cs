using Pedido.Classe.Entidade;
using Pedido.Classe.Enumerações;

Funcionario dev = new Funcionario("Clodoaldo");
Funcionario gerente = new Funcionario("Elma");

Empresa SENAI = new Empresa("João Batista Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);

Suzano = null;
