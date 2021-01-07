using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace See_More
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
            lblHistorial.Text = "Este es tu historial";
            rtxHistorial.LoadFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt", RichTextBoxStreamType.PlainText);
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\history.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }

        }
        private void Historial_FormClosing(object sender, FormClosingEventArgs e)
        {
            rtxHistorial.SaveFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt", RichTextBoxStreamType.PlainText);
        }
        private void Historial_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Historial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F5)
            {
                timer1.Start();
                this.Text = "Historial - Actualizado";
                rtxHistorial.SaveFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt", RichTextBoxStreamType.PlainText);
                rtxHistorial.LoadFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt", RichTextBoxStreamType.PlainText);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Text = "Historial";
        }
    }
}
