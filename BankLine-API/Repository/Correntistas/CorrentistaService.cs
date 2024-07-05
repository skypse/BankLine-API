using BankLine_API.Models;

namespace BankLine_API.Repository.Correntistas
{
    public class CorrentistaService : ICorrentistaService
    {
        private readonly ICorrentistaRepository _correntistaRepository;

        public CorrentistaService(ICorrentistaRepository correntistaRepository)
        {
            _correntistaRepository = correntistaRepository;
        }

        public async Task<IEnumerable<Correntista>> GetAllCorrentistasAsync()
        {
            return await _correntistaRepository.GetAllAsync();
        }

        public async Task<Correntista?> GetCorrentistaByIdAsync(int id)
        {
            return await _correntistaRepository.GetByIdAsync(id);
        }

        public async Task AddCorrentistaAsync(Correntista correntista)
        {
            await _correntistaRepository.AddAsync(correntista);
        }

        public async Task UpdateCorrentistaAsync(Correntista correntista)
        {
            await _correntistaRepository.UpdateAsync(correntista);
        }

        public async Task DeleteCorrentistaAsync(int id)
        {
            var correntista = await _correntistaRepository.GetByIdAsync(id);
            if (correntista != null)
            {
                await _correntistaRepository.DeleteAsync(correntista);
            }
        }
    }
}
