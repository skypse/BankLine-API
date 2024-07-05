using BankLine_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BankLine_API.Data
{
    public class BankLineDbContext : DbContext
    {
        public BankLineDbContext(DbContextOptions<BankLineDbContext> options) : base(options){}

        public DbSet<Correntista> tab_correntista { get; set; }
        public DbSet<Conta> tab_conta { get; set; }
        public DbSet<Movimentacao> tab_movimentacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Correntista>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Correntista>()
                .Property(c => c.Cpf)
                .HasMaxLength(20)
                .HasColumnName("correntista_cpf");

            modelBuilder.Entity<Correntista>()
                .Property(c => c.Nome)
                .HasMaxLength(60)
                .HasColumnName("correntista_nome");

            modelBuilder.Entity<Correntista>()
                .HasOne(c => c.Conta)
                .WithOne()
                .HasForeignKey<Correntista>(c => c.ContaNumero);

            modelBuilder.Entity<Correntista>()
                .Property(c => c.ContaNumero)
                .HasColumnName("conta_numero_fk");

            modelBuilder.Entity<Conta>()
                .Property(c => c.Numero)
                .HasColumnName("conta_numero");

            modelBuilder.Entity<Conta>()
                .Property(c => c.Saldo)
                .HasColumnName("conta_saldo");

            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.Id)
                .HasColumnName("movimentacao_id");

            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.DataHora)
                .HasColumnName("movimentacao_dt");

            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.Descricao)
                .HasColumnName("movimentacao_desc");

            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.Valor)
                .HasColumnName("movimentacao_valor");

            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.Tipo)
                .HasConversion<string>() // guardado como string
                .HasColumnName("movimentacao_tipo");

            base.OnModelCreating(modelBuilder);
        }
    }
}
