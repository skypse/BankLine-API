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

        // métodos públicos para acessar os campos privados
        public long GetNumero()
        {
            return this.numero;
        }

        public void SetNumero(long numero)
        {
            this.numero = numero;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
    }
}
