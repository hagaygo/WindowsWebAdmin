using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfHostedWWA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new MyCustomApplicationContext();
            context.StartupApp();
            Application.Run(context);            
        }
    }

    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;

        public void StartupApp()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon();
            var miExit = new MenuItem();
            miExit.Click += new EventHandler(Exit);
            miExit.Text = "Exit";                        
            trayIcon.ContextMenu = new ContextMenu(new MenuItem[] { miExit });
            trayIcon.Icon = new System.Drawing.Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("SelfHostedWWA.wwa.ico"));
            trayIcon.Visible = true;

            
            
            var path = ConfigurationManager.AppSettings["path"];
            if (string.IsNullOrEmpty(path))
                path = ".";
            var port = ConfigurationManager.AppSettings["port"];
            if (string.IsNullOrEmpty(port))
                port = "8889";
            trayIcon.Text = string.Format("Windows Web Admin (Port {0})", port);
            var srv = new CassiniDev.Server(Convert.ToInt32(port), "/", path, System.Net.IPAddress.Any);            
            srv.Start();            
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
