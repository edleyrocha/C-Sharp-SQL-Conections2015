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
            AppStatus.Debugar.Status();
        }

        #region ---> btnShow Simples
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
        #endregion ---> btnShow Simples

        #region ---> btnLigaDesliga Completo
       
        private enum LigarDesligar
        {
            Ligar = 1,
            Desligar = 2
        }
       
        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(btnLigaDesliga.Tag)) == ((int)LigarDesligar.Ligar))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Liga");
               
                cboTimeOut.Enabled = (!true);
                cboTimeOut.Items.Clear();
                cboTimeOut.Text = (String.Empty);

               
                btnLigaDesliga.Text = Convert.ToString((LigarDesligar)(Convert.ToInt32(btnLigaDesliga.Tag)));
                btnLigaDesliga.Tag = Convert.ToChar((LigarDesligar)2);

                AppStatus.Debugar.EscreverDebugPrint("\r numeroItens [CLEAR] = " + Convert.ToString(cboTimeOut.Items.Count));
            }
            else if ((Convert.ToInt32(btnLigaDesliga.Tag)) == ((int)LigarDesligar.Desligar))
            {
                AppStatus.Debugar.EscreverDebugPrint("\r\r\r btnLigaDesliga = Desliga");

                cboTimeOut.Enabled = (true);

                btnLigaDesliga.Text = Convert.ToString((LigarDesligar)(Convert.ToInt32(btnLigaDesliga.Tag)));
                btnLigaDesliga.Tag = Convert.ToChar((LigarDesligar)1);

                int[] numeroItens = new int[999];
                foreach (int i in numeroItens)
                {
                    numeroItens[0]++;
                    cboTimeOut.Items.Add(Convert.ToString(numeroItens[0]));

                    AppStatus.Debugar.EscreverDebugPrint("\r numeroItens [TOTAL] = " + Convert.ToString(numeroItens[0]));
                }
            }
        }
        
        #endregion ---> btnLigaDesliga Completo

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnConectar_Click(object sender, EventArgs e)
        {

        }


    }
}
