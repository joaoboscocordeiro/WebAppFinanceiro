using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WebAppFinanceiro.Models;

namespace WebAppFinanceiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly string _connectionString;

        public TransactionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        private IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        public Task<int> AddAsync(Transaction t)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            using var conn = CreateConnection();
            var sql = "SELECT * FROM Transactions";

            return await conn.QueryAsync<Transaction>(sql);
        }

        public async Task<Transaction?> GetByIdAsync(int id)
        {
            using var conn = CreateConnection();
            var sql = "SELECT * FROM Transactions WHERE Id = @Id";

            return await conn.QueryFirstOrDefaultAsync<Transaction>(sql, new { Id = id });
        }

        public Task<int> UpdateAsync(Transaction t)
        {
            throw new NotImplementedException();
        }
    }
}
