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
        private int idConta;

        // props públicas que encapsulam os campos setados privados
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

        // métodos públicos para acessar os campos privados
        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public DateTime GetDataHora()
        {
            return dataHora;
        }

        public void SetDataHora(DateTime dataHora)
        {
            this.dataHora = dataHora;
        }

        public string? GetDescricao()
        {
            return descricao;
        }

        public void SetDescricao(string? descricao)
        {
            this.descricao = descricao;
        }

        public int GetValor()
        {
            return valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
        }

        public MovimentacaoTipo GetTipo()
        {
            return tipo;
        }

        public void SetTipo(MovimentacaoTipo tipo)
        {
            this.tipo = tipo;
        }

        public int GetIdConta()
        {
            return idConta;
        }

        public void SetIdConta(int idConta)
        {
            this.idConta = idConta;
        }
    }
}
