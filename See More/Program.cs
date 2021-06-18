using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace See_More
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Reproductor());
        }
        static NotifyIcon notifyIcon = new NotifyIcon();
        public static void Displaynotify(String nombre)
        {
            try
            {
                notifyIcon.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                notifyIcon.Text = "Se guardo nuevo registro";
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = "Se guardo el anime " + nombre;
                notifyIcon.BalloonTipText = "El anime " + nombre + " se ha almacenado";
                notifyIcon.ShowBalloonTip(100);
            }
            catch (Exception) { }
        }
    }
}
