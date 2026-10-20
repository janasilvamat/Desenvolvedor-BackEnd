using System.ComponentModel.DataAnnotations;
namespace Banco.Classes.Models.Entidades
{
    public class ContaBancaria
    {

        //Cria o número da conta bancária no database
        [Key]
        public int NumeroConta { get; set; }

        //Cria o titular da conta bancária no database
        [Required]
        public string TitularConta { get; set; }
        //Saldo da da conta, este valor pode ser zero
        [Required]
        public decimal Saldo { get; set; }

        public ContaBancaria(string titularConta, decimal saldo)
        {
            TitularConta = titularConta;
            Saldo = saldo;
        }
       
    }
}
