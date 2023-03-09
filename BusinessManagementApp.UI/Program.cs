using BusinessManagementApp.UI.Forms;
using BussinesManagementApp.Bussines.DependencyResolver;
using BussinesManagementApp.Bussines.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            //Application.Run(ServiceProvider.GetRequiredService<Giris>()); // TODO iþlemler yapýldýktan sonra açýlacak.
            Application.Run(ServiceProvider.GetRequiredService<AnaMenu>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
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
                    services.AddTransient<UrunAlýmListeleme>();
                    services.AddTransient<UrunAlýmý>();
                    services.AddTransient<UrunIslemleri>();
                    services.AddTransient<UrunSat>();
                    services.AddTransient<UrunEkle>();
                    services.AddTransient<DepodakiUrunDetay>();
                    services.AddTransient<MusteriEkle>();
                    services.AddTransient<SiparisIslemleri>();
                    services.AddTransient<OnSiprarisDetay>();

                    services.DependencyExtension();
                });
        }
    }
}