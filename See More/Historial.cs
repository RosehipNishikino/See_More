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
        public String historialSeleccionado { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
        
        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //try
            //{
            //    String line;
            //    StreamWriter sw = new StreamWriter("C:\\Users\\sealt\\Configuraciones SeeMore\\historial_temporal.txt");
            //    StreamReader sr = new StreamReader("C:\\Users\\sealt\\Configuraciones SeeMore\\historial.txt");
            //    line = sr.ReadLine();
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        if (line == null)
            //        {

            //        }
            //        else
            //        {
            //            if (line.Contains(textBox1.Text) && richTextBox1.Contains(textBox1))
            //            {
            //                sw.WriteLine(line);
                           
            //            }
            //        }
            //    }
            //    sw.Close();
            //}
            //catch (Exception) { }
            //richTextBox1.Find("Dangan");
            //richTextBox1.Find);

            //richTextBox1.Select
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
           // richTextBox1.Find(textBox1.Text);
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
