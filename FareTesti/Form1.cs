using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int tiklama;
        public int sifirlamadurumu = 0;
        public int sayacbasladimi = 0;
        public int deneme = 0;

        //yukselexe tarafından yapılmıştır...
        public void sayacibaslat() 
        {
            if (sifirlamadurumu != 1)
            {
                if (sayacbasladimi != 1)
                {
                    timer1.Interval = 10000;
                    timer1.Enabled = true;
                    sifirlamadurumu = 1;
                    sayacbasladimi = 1;
                }
                
                
            }
            else
            MessageBox.Show("Önce Sıfırlamalısın.", "Oh Shit", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Button1_Click(object sender, EventArgs e) //butona basınca
        {

            if (deneme != 1)
            {
                deneme = 1;
                sayacibaslat();
            }
            else if (deneme == 1)
            {
                tiklama += 1;
                label3.Text = Convert.ToString(tiklama);
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e) //süre bitince
        {
            button1.Enabled = false;


            timer1.Enabled = false;
           
            DialogResult cıkıs = MessageBox.Show("10 Saniyede " + tiklama + " Kere Tıkladın!", "Süre Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (cıkıs == DialogResult.OK)
            {
                if (label4.Text == ".")
                {
                    label4.Text = Convert.ToString(tiklama);
                }
                else if (label5.Text == ".")
                {
                    label5.Text = Convert.ToString(tiklama);
                }
                else if (label6.Text == ".")
                {
                    label6.Text = Convert.ToString(tiklama);
                }
                else if (label7.Text == ".")
                {
                    label7.Text = Convert.ToString(tiklama);
                }
                else if (label8.Text == ".")
                {
                    label8.Text = Convert.ToString(tiklama);
                }
                else if (label9.Text == ".")
                {
                    label9.Text = Convert.ToString(tiklama);
                }
               else if (label10.Text == ".")
                {
                    label10.Text = Convert.ToString(tiklama);
                }
                else if (label11.Text == ".")
                {
                    label11.Text = Convert.ToString(tiklama);
                }
                else
                    MessageBox.Show("Sonucun Kayıt Edilemedi \n Muhtemelen kayıt yerleri dolu! \n Programı yeniden çalıştırarak bu sorunu çözebilirsin.", "Hmm...", MessageBoxButtons.OK, MessageBoxIcon.Information);








                sifirla();
                deneme = 0;
               




            }
        }


        public void sifirla()
        {
            button1.Enabled = true;
            label3.Text = "0";
            tiklama = 0;
            sifirlamadurumu = 0;
            sayacbasladimi = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.github.com/yukselexe");
        }
    }
}
