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
        private Semafaro sem;
        public Form1()
        {
            InitializeComponent();
            sem = new Semafaro(8);
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            txtEstBinario.Text = sem.GetEstado().ToString();
            txtEstDecimal.Text = Convert.ToString(sem.GetEstado(), 2);
            txtEstHexadecimal.Text = Convert.ToString(sem.GetEstado(), 16);

            chkVermelho1.Checked = sem.GetSemafaro(1);
            chkAmarelo1.Checked = sem.GetSemafaro(2);
            chkVerde1.Checked = sem.GetSemafaro(3);

            chkVermelho2.Checked = sem.GetSemafaro(8);
            chkAmarelo2.Checked = sem.GetSemafaro(7);
            chkVerde2.Checked = sem.GetSemafaro(6);

            //SEMAFARO 1
            pictureBox2.Image = (sem.GetSemafaro(1) ?
                           ClasseSemafaro.Properties.Resources.semafaroVermelho :
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);

            pictureBox2.Image = (sem.GetSemafaro(2) ?
                           ClasseSemafaro.Properties.Resources.semafaroAmarelo:
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);

            pictureBox2.Image = (sem.GetSemafaro(3) ?
                           ClasseSemafaro.Properties.Resources.semafaroVerde :
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);

            //SEMAFARO 2
            pictureBox1.Image = (sem.GetSemafaro(8) ?
                           ClasseSemafaro.Properties.Resources.semafaroVermelho :
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);
            
            pictureBox1.Image = (sem.GetSemafaro(7) ?
                           ClasseSemafaro.Properties.Resources.semafaroAmarelo :
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);

            pictureBox1.Image = (sem.GetSemafaro(6) ?
                           ClasseSemafaro.Properties.Resources.semafaroVerde :
                             ClasseSemafaro.Properties.Resources.semafaroApagado1);
            
            
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //Semafaro 01
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkVermelho1_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetVermelho(1);
            atualizaInterface();
        }
        private void chkAmarelo1_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetAmarelo(2);
            atualizaInterface();
        }
        private void chkVerde1_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetVerde(3);
            atualizaInterface();
        }

        //Semafaro 02
        private void chkVermelho2_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetVermelho(8);
            atualizaInterface();
        }
        private void chkAmarelo2_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetAmarelo(7);
            atualizaInterface();
        }
        private void chkVerde2_CheckedChanged(object sender, EventArgs e)
        {
            sem.SetVerde(6);
            atualizaInterface();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
