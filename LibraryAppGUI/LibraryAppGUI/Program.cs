using Microsoft.EntityFrameworkCore;

namespace LibraryAppGUI
{
    internal static class Program
    {
        private static string connStr = "server=localhost; port=4306; database=library; uid=root; password=;";
        private static User currentUser;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                var optionsBuilder = new DbContextOptionsBuilder<DbLibrary>();
                optionsBuilder.UseMySQL(connStr);

                using (var context = new DbLibrary(optionsBuilder.Options))
                {
                    context.Database.EnsureCreated();
                    // To customize application configuration such as set high DPI settings or default font,
                    // see https://aka.ms/applicationconfiguration.
                    ApplicationConfiguration.Initialize();
                    Application.Run(new adminform(context));
                }

            }

            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
                    Console.WriteLine($"Inner Exception: {innerException.Message}");
                    innerException = innerException.InnerException;
                }
            }

            
        }
    }
}