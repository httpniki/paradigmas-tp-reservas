using Microsoft.Extensions.DependencyInjection;
using TP_RESERVAS.Repositorios;


namespace TP_RESERVAS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddScoped<IReservaRepository, ReservaRepositorySQL>();
            services.AddTransient<frmTPeservas>();

            using var provider = services.BuildServiceProvider();
            var mainForm = provider.GetRequiredService<frmTPeservas>();

            Application.Run(mainForm);
        }
    }
}