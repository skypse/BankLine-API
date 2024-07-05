using BankLine_API.Models;

namespace BankLine_API.Repository.Movimentacoes
{
    public interface IMovimentacaoRepository
    {
        Task<Movimentacao> GetByIdAsync(int id); // retorna uma movimentação pelo ID (PK)
        Task<IEnumerable<Movimentacao>> GetAllAsync(); // retorna todas as movimentações
        Task AddAsync(Movimentacao movimentacao); // adiciona uma nova movimentação
        Task UpdateAsync(Movimentacao movimentacao); // atualiza informações de uma movimentação existente
        Task DeleteAsync(Movimentacao movimentacao); // remove uma movimentação
    }
}
