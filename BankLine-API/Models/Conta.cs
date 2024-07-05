using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankLine_API.Models
{
    public class Conta
    {
        // campos privados
        private long numero;
        private double saldo;

        // props públicas que encapsulam os campos setados privados
        [Key]
        [Column("conta_numero")]
        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        [Column("conta_saldo")]
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        // métodos getters para acessar os campos privados
        public long getNumero()
        {
            return numero;
        }

        public double getSaldo() 
        {
            return saldo;
        }
    }
}
