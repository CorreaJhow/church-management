using church_management_system.Data;

namespace church_management_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            InitializeDatabase(); 

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new LoginForm());
        }

        private static void InitializeDatabase()
        {
            try
            {
                using (var context = new DataContext())
                {
                    // Cria o banco de dados, caso ainda não exista
                    context.Database.EnsureCreated();
                }
                Console.WriteLine("Banco de dados SQLite inicializado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // Encerra a aplicação em caso de falha
            }
        }

    }
}