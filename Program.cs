using System;
using Serilog;

namespace serilog_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.Seq("http://localhost:5341")
                .Enrich.WithProperty("AppName", "serilog_project")
                .CreateLogger();
            
            string adSoyad = "Ali GOREN";
            
            Log.Information("{adSoyad} giriş yaptı", adSoyad);

            Log.Error("{adSoyad} onceden yasaklanmis bir kullanici!", adSoyad);

            Log.CloseAndFlush();
            
        }
    }
}
