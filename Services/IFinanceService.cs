using WebAppFinanceiro.Dtos;
using WebAppFinanceiro.Models;

namespace WebAppFinanceiro.Services
{
    public interface IFinanceService
    {
        Task<IEnumerable<Transaction>> GetTransactionsAsync(int? month = null, int? year = null, char? type = null);
        Task<Transaction?> GetTransactionByIdAsync(int id);
        Task<Transaction> AddTransactionAsync(Transaction t);
        Task UpdateTransactionAsync(Transaction t);
        Task DeleteTransactionAsync(int id);
        Task<DashboardDto> GetDashboardAsync(int month, int year);
        Task<IEnumerable<CategoryTotalDto>> GetTotalsByCategoryAsync(int? month = null, int? year = null);
    }
}
