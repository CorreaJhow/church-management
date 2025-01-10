using church_management_system.Models;
using Microsoft.EntityFrameworkCore;

namespace church_management_system.Data
{
    public class DataContext : DbContext
    {
        // Configuração padrão do DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure o SQLite com a string de conexão
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=church_management.db");
            }
        }

        // Defina as tabelas do banco de dados
        public DbSet<UserModel> Users { get; set; }
    }
}
