using BankLine_API.Models;

namespace BankLine_API.Repository.Correntistas
{
    public interface ICorrentistaRepository
    {
        Task<Correntista?> GetByIdAsync(int id); // retorna um correntista referente ID (PK)
        Task<IEnumerable<Correntista>> GetAllAsync(); // retorna todos correntistas
        Task AddAsync(Correntista correntista); // adicionar um novo correntista
        Task UpdateAsync(Correntista correntista); // atualizar informações de um correntista existente
        Task DeleteAsync(Correntista correntista); // remove um correntista
    }
}
