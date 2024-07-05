using BankLine_API.Models;

namespace BankLine_API.Repository.Correntistas
{
    public interface ICorrentistaService
    {
        Task<IEnumerable<Correntista>> GetAllCorrentistasAsync();
        Task<Correntista?> GetCorrentistaByIdAsync(int id);
        Task AddCorrentistaAsync(Correntista correntista);
        Task UpdateCorrentistaAsync(Correntista correntista);
        Task DeleteCorrentistaAsync(int id);
    }
}
