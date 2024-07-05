using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankLine_API.Models
{
    public class Movimentacao
    {
        // campos privados
        private int id;
        private DateTime dataHora;
        private string? descricao;
        private int valor;
        private MovimentacaoTipo tipo;

        // props públicas que  encapsulam os campos setados privados
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("movimentacao_id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Column("dt_movimentacao")]
        public DateTime DataHora 
        {  
            get { return dataHora; } 
            set { dataHora = value; } 
        }

        [Column("movimentacao_desc")]
        public string? Descricao 
        {
            get { return descricao; }
            set { descricao = value; }
        }

        [Column("movimentacao_valor")]
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        [Column("movimentacao_tipo")]
        public MovimentacaoTipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        // métodos getters para acessar os campos privados
        public int getId(int id) 
        {
            return id;
        }

        public DateTime getDataHora(DateTime dataHora)
        {
            return dataHora;
        }

        public string? getDescricao(string descricao)
        {
            return descricao;
        }

        public int getValor(int valor)
        {
            return valor;
        }

        public MovimentacaoTipo getTipo(MovimentacaoTipo tipo)
        {
            return tipo;
        }
    }
}
