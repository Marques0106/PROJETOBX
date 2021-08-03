using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOBX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //btns
            btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPainel.FlatAppearance.BorderSize = 0;
            btnPainel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPainel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPainel.BackColor = Color.Transparent;

            btnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnListas.FlatAppearance.BorderSize = 0;
            btnListas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnListas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnListas.BackColor = Color.Transparent;

            btnProtocolos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProtocolos.FlatAppearance.BorderSize = 0;
            btnProtocolos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProtocolos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProtocolos.BackColor = Color.Transparent;

            btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCadastro.BackColor = Color.Transparent;

            buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHelp.BackColor = Color.Transparent;

            buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMinimizar.FlatAppearance.BorderSize = 0;
            buttonMinimizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMinimizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMinimizar.BackColor = Color.Transparent;

            buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonFechar.FlatAppearance.BorderSize = 0;
            buttonFechar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonFechar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonFechar.BackColor = Color.Transparent;

            buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonMaximizar.FlatAppearance.BorderSize = 0;
            buttonMaximizar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMaximizar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMaximizar.BackColor = Color.Transparent;


            //picturebox







        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnPainel_Click(object sender, EventArgs e)
        {
            Painel painel = new Painel();
            painel.Show();
            

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            Listas list = new Listas();
            list.Show();
        }

        private void btnProtocolos_Click(object sender, EventArgs e)
        {
            Protocolos protocolar = new Protocolos();
            protocolar.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastros cad = new Cadastros();
            cad.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help ajuda = new Help();
            ajuda.Show();
        }

        private void pictureBoxProtocolos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxListas_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
