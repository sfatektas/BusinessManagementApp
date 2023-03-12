using BusinessManagementApp.UI.Forms;
using BussinesManagementApp.Bussines.DependencyResolver;
using BussinesManagementApp.Bussines.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace BusinessManagementApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            //Application.Run(ServiceProvider.GetRequiredService<Giris>()); // TODO işlemler yapıldıktan sonra açılacak.
            Application.Run(ServiceProvider.GetRequiredService<AnaMenu>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            // TODO seed data eklenecek.
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddTransient<IHelloService, HelloService>();

                    //Forms DI
                    services.AddTransient<Giris>();
                    services.AddTransient<AnaMenu>();
                    services.AddTransient<DepodakiUrunler>();
                    services.AddTransient<MusteriIslemleri>();
                    services.AddTransient<TedarikciEkle>();
                    services.AddTransient<TedarikciIslemler>();
                    services.AddTransient<UrunAlımListeleme>();
                    services.AddTransient<UrunAlımı>();
                    services.AddTransient<UrunIslemleri>();
                    services.AddTransient<UrunSat>();
                    services.AddTransient<UrunEkle>();
                    services.AddTransient<DepodakiUrunDetay>();
                    services.AddTransient<MusteriEkle>();
                    services.AddTransient<SiparisIslemleri>();
                    services.AddTransient<OnSiprarisDetay>();
                    services.AddTransient<RaporOlustur>();
                    services.AddTransient<LastOrders>();

                    services.DependencyExtension(GetConfig.GetDbConnectionString());
                });
        }
        public class GetConfig
        {
            public static string GetDbConnectionString()
            {
                return System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            }
        }
    }
}