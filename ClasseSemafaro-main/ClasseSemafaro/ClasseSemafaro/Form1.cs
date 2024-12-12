using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseSemafaro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            meusLeds = new Semafaro(129);
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            txtDado.Text = meusLeds.getDado().ToString();
            txtDado2.Text = Convert.ToString(meusLeds.getDado(), 2);
            txtDado16.Text = Convert.ToString(meusLeds.getDado(), 16);
            chkLed1.Checked = meusLeds.getLed(1);
            chkLed2.Checked = meusLeds.getLed(2);
            chkLed3.Checked = meusLeds.getLed(3);
            picLed1.Image = (meusLeds.getLed(1) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed2.Image = (meusLeds.getLed(2) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
            picLed3.Image = (meusLeds.getLed(3) ?
                             projLeds.Properties.Resources.acesa :
                             projLeds.Properties.Resources.apagada);
           
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSem1Vermelho_Click(object sender, EventArgs e)
        {

        }

        private void chkAmarelo2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
