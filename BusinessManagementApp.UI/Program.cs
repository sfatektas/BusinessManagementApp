using BusinessManagementApp.UI.Forms;
using BussinesManagementApp.Bussines.DependencyResolver;
using BussinesManagementApp.Bussines.Helpers;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Bussines.Services;
using BussinessManagementApp.Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity;
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

            //Task addData = SeedData.EnsurePopulated(ServiceProvider); // DB yap�s�na tohum data ekliyorum.

            Application.Run(ServiceProvider.GetRequiredService<Giris>()); // TODO i�lemler yap�ld�ktan sonra a��lacak.
            //Application.Run(ServiceProvider.GetRequiredService<AnaMenu>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {

            // TODO seed data eklenecek.
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //Forms DI
                    services.AddTransient<Giris>();
                    services.AddTransient<AnaMenu>();
                    services.AddTransient<DepodakiUrunler>();
                    services.AddTransient<MusteriIslemleri>();
                    services.AddTransient<TedarikciEkle>();
                    services.AddTransient<TedarikciIslemler>();
                    services.AddTransient<UrunAl�mListeleme>();
                    services.AddTransient<UrunAl�m�>();
                    services.AddTransient<UrunIslemleri>();
                    services.AddTransient<UrunSat>();
                    services.AddTransient<UrunEkle>();
                    services.AddTransient<DepodakiUrunDetay>();
                    services.AddTransient<MusteriEkle>();
                    services.AddTransient<SiparisIslemleri>();
                    services.AddTransient<OnSiprarisDetay>();
                    services.AddTransient<RaporOlustur>();
                    services.AddTransient<LastOrders>();
                    services.AddTransient<UrunGuncelle>();

                    services.DependencyExtension(GetConfig.GetDbConnectionString(),GetConfig.GetIdentityDbConnectionString());
                    // Connection String verilerini app.config �zerinden ald�m.
                });
        }
        public class GetConfig
        {
            public static string GetDbConnectionString()
            {
                return System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            }
            public static string GetIdentityDbConnectionString()
            {
                return System.Configuration.ConfigurationManager.AppSettings["IdentityConnectionString"];
            }
        }
    }
}