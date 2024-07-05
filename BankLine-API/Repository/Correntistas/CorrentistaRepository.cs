using BankLine_API.Data;
using BankLine_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BankLine_API.Repository.Correntistas
{
    public class CorrentistaRepository : ICorrentistaRepository
    {
        private readonly BankLineDbContext _context;

        public CorrentistaRepository(BankLineDbContext context)
        {
            _context = context;
        }

        public async Task<Correntista?> GetByIdAsync(int id)
        {
            return await _context.tab_correntista.FindAsync(id);
        }

        public async Task<IEnumerable<Correntista>> GetAllAsync()
        {
            return await _context.tab_correntista.ToListAsync();
        }

        public async Task AddAsync(Correntista correntista)
        {
            _context.tab_correntista.Add(correntista);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Correntista correntista)
        {
            _context.tab_correntista.Update(correntista);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Correntista correntista)
        {
            _context.tab_correntista.Remove(correntista);
            await _context.SaveChangesAsync();
        }
    }
}
