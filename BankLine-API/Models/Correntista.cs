using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankLine_API.Models
{
    public class Correntista
    {
        // campos privados
        private int id;
        private string? cpf;
        private string? nome;
        private Conta? conta;

        // props públicas que  encapsulam os campos setados privados
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("correntista_id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [MaxLength(20)]
        [Column("correntista_cpf")]
        public string? Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        [MaxLength(60)]
        [Column("correntista_nome")]
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Conta? Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        [ForeignKey("Conta")]
        [Column("conta_numero_fk")]
        public long ContaNumero { get; set; }

        // métodos getters para acessar os campos privados
        public int GetId()
        {
            return id;
        }

        public string? GetCpf()
        {
            return cpf;
        }

        public string? GetNome()
        {
            return nome;
        }

        public Conta? GetConta()
        {
            return conta;
        }
    }
}
