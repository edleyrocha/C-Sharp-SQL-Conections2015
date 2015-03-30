using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoConnections
{
    public partial class frmModeloA : Form
    {
        public frmModeloA()
        {
            InitializeComponent();
            //System.Diagnostics.Debug.Print("\r \r \r frmModeloA Iniciado");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if ((btnShow.Text == ("Show")) && (txtSenha.UseSystemPasswordChar == (true)))
            {
                btnShow.Text = "NoShow";
                txtSenha.UseSystemPasswordChar = false;
            }
            else if ((btnShow.Text == ("NoShow")) && (txtSenha.UseSystemPasswordChar == (false)))
            {
                btnShow.Text = "Show";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private enum LigarDesligar
        {
            [DescriptionAttribute("Ligar Botao")]
            Ligar = 1,
            [DescriptionAttribute("Desligar Botao")]
            Desligar = 2
        }
        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {

           

            if (btnLigaDesliga.Text == (LigarDesligar.Ligar.ToString()))
            {
                btnLigaDesliga.Text = (LigarDesligar.Desligar.ToString());
            }
            else if (btnLigaDesliga.Text == (LigarDesligar.Desligar.ToString()))
            {
                btnLigaDesliga.Text = (LigarDesligar.Ligar.ToString());
            }
        }

    }
}
