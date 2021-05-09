using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Dupla_Click(object sender, EventArgs e)
        {
            Form jogo_dupla = new Form_jogo_dupla();
            jogo_dupla.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form_apresentacao_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Indiv_Click(object sender, EventArgs e)
        {
            Form jogo_indiv = new Form_jogo_indiv();
            jogo_indiv.Show();
            this.Visible = false;
        }
    }
}
