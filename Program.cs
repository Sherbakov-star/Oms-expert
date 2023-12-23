using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.Helpers;
using System.Net.NetworkInformation;

namespace Mee
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static Logger Log = new Logger(Path.Combine($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles"));
        [STAThread]
        
        static void Main()
        {
         
            Application.EnableVisualStyles();
            
            
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;

            var f014Path =
                $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\F014.json";

            var t003Path = $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\T003.json";

            var lastUpdate = $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicLastUpdate.txt";

            var fileForReport = $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\F014.xlsx";

            var f014DicVersion = $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicF014Version.txt";

            var t003DicVersion = $"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicT003Version.txt";
            //!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()

            if ((!File.Exists(f014Path) || !File.Exists(t003Path) || !File.Exists(fileForReport)) && !CheckForInternetConnection())
            {
                MessageBox.Show("Интернет не подключен, работа программы не возможна", "Загрузка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if ((!File.Exists(t003DicVersion) || (!File.Exists(f014DicVersion) ||
                                                       (!File.Exists(f014Path) || !File.Exists(t003Path) ||
                                                        !File.Exists(lastUpdate) || !File.Exists(fileForReport)) &&
                                                       CheckForInternetConnection()))) 
            {
                File.Delete($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicF014Version.txt");
                File.Delete($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicT003Version.txt");
                File.Delete($"{System.Environment.GetEnvironmentVariable("USERPROFILE")}\\OmsFiles\\DicLastUpdate.txt");
                Application.Run(new Main());
            }
            else
            {
                Application.Run(new Main());
            }
           
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Произошла ошибка, подробности в лог-файле","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            Log.Add(e.Exception.Message);
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.yandex.ru"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
