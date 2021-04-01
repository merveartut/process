using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _171180006_MERVE_ARTUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }


        private void islemler()
        {
            Process[] comp = Process.GetProcesses();

            foreach (Process islem in comp)
            {
                liste.Items.Add(islem.ProcessName);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            liste.Items.Clear();
            islemler();
        }



        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int indis = liste.IndexFromPoint(e.Location);
            liste.SelectedIndex = indis;
        }
       



        private void liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       

         private void threadSayısıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            int indis = liste.SelectedIndex;

            Process[] p = Process.GetProcesses();
            if (liste.SelectedIndex >= 0)
            {
                MessageBox.Show(p[indis].ToString() + " işleminin thread sayısı: " + p[indis].Threads.Count.ToString());

            }
            else
                MessageBox.Show("Bir işlem seçiniz!");
        }

        private void prosesiÖldürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex >= 0)
            {

                int indis = liste.SelectedIndex;

                Process[] p = Process.GetProcesses();

                p[indis].Kill();

                MessageBox.Show(p[indis].ToString() + " işlemi silindi !");

            }
            else
                MessageBox.Show("Bir işlem seçiniz!");
        }

        private void kullanılanBellekMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indis = liste.SelectedIndex;

            Process[] p = Process.GetProcesses();


            if (liste.SelectedIndex >= 0)
            {
                PerformanceCounter bellek_kullanımı = new PerformanceCounter("Process", "Working Set - Private", p[indis].ProcessName);
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show(p[indis].ToString() + " programının bellek kullanımı: " + bellek_kullanımı.NextValue() / (1024 * 1024) + "mb");

            }
            else
                MessageBox.Show("Bir işlem seçiniz!");

        }

        private void kullanılanİşlemciYüzdesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indis = liste.SelectedIndex;

            Process[] p = Process.GetProcesses();
            if (liste.SelectedIndex >= 0)
            {

                PerformanceCounter toplam_cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                PerformanceCounter islem_cpu = new PerformanceCounter("Process", "% Processor Time", p[indis].ProcessName);



                float total = toplam_cpu.NextValue();
                System.Threading.Thread.Sleep(1000);
                total = toplam_cpu.NextValue();

                float proc = islem_cpu.NextValue();

                System.Threading.Thread.Sleep(1000);
                MessageBox.Show(p[indis].ToString() + " programının işlemci kullanımı : % " + islem_cpu.NextValue() / 10);
            }
            else
                MessageBox.Show("Bir işlem seçiniz!");

        }
    }
}
