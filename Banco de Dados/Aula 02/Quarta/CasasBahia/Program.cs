using CasasBahia.Classes.Contextos;
using CasasBahia.Classes.Entidades;

ProdutoContexto contexto = new ProdutoContexto();
contexto.Database.EnsureCreated(); //Cria o banco de dados se ele não existir

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n--Menu do almoxarifado--" +
        "\n 1 - Consultar item no estoque" +
        "\n 2 - Cadastrar Produto" +
        "\n 3 - Sair");
    Console.Write("\nEscolha uma opção: ");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            // Lógica para consultar item no estoque
            Console.Write("\nDigite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
            if (codigo != null)
            {
                codigoProduto.ExibirDados();
            }
            else
            {
                Console.WriteLine($"\nCódigo do produto {codigo} não encontrado.");
            }
            break;
        case 2:
            // Lógica para cadastrar produto
            CadastroDeItem(contexto);
            break;
        case 3:
            //Deletar item no estoque
            DeletarItem(contexto);
            break;

        case 4:
            continuar = false;
            Console.WriteLine("Encerrando o programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
void CadastroDeItem(ProdutoContexto produto)
{
    Console.WriteLine("---Cadastro de Item---");
    Console.Write("\nDigite o nome do produto: ");
    string nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Não permitido o cadastro de produto sem nome.");
        return;
    }
    Console.Write("\nDigite a quantidade do produto: ");
    int quantidade = int.Parse(Console.ReadLine());
    if (quantidade < 0)
    {
        Console.WriteLine("Não permitido o cadastro de produto com quantidade negativa.");
        return; 
    }
    Console.Write("\nDigite o custo do produto: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    if (valor < 0) 
    {
        Console.WriteLine("Não permitido o cadastro de produto com valor negativo.");
        return;
    } 


    Produto produto1 = new Produto(nome, quantidade, valor);
    contexto.Produtos.Add(produto1);
    contexto.SaveChanges();
    produto1.ExibirDados();
}

void DeletarItem(ProdutoContexto produto)
{
    Console.WriteLine("---Deletar Item---");
    Console.Write("\nDigite o código do produto que deseja deletar: ");
    int codigo = int.Parse(Console.ReadLine());
    var codigoProduto = contexto.Produtos.FirstOrDefault(c => c.CodigoDoProduto == codigo);
    if (codigoProduto != null)
    {
        Console.Write("Deseja realmente deletar o produto? (S/N): ");
        char escolha = char.Parse(Console.ReadLine().ToUpper());
        if (escolha.Equals('S'))
        {
            contexto.Produtos.Remove(codigoProduto);
            contexto.SaveChanges();
            Console.WriteLine($"\nProduto {codigo} deletado com sucesso.");
        }
    }
    else
    {
        Console.WriteLine($"\nCódigo do produto {codigo} não encontrado.");
    }
}