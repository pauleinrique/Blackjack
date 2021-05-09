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
    public partial class Form_jogo_indiv : Form
    {
        public Form_jogo_indiv()
        {
            InitializeComponent();
            btn_reiniciar.Enabled = false;
        }

        int pontos = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_jogar_1_Click(object sender, EventArgs e)
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);


            switch (x)
            {
                case 1: pictureBox2.Image = Properties.Resources.a; total_pontos += 1; break;
                case 2: pictureBox2.Image = Properties.Resources._2; total_pontos += 2; break;
                case 3: pictureBox2.Image = Properties.Resources._3; total_pontos += 3; break;
                case 4: pictureBox2.Image = Properties.Resources._4; total_pontos += 4; break;
                case 5: pictureBox2.Image = Properties.Resources._5; total_pontos += 5; break;
                case 6: pictureBox2.Image = Properties.Resources._6; total_pontos += 6; break;
                case 7: pictureBox2.Image = Properties.Resources._7; total_pontos += 7; break;
                case 8: pictureBox2.Image = Properties.Resources._8; total_pontos += 8; break;
                case 9: pictureBox2.Image = Properties.Resources._9; total_pontos += 9; break;
                case 10: pictureBox2.Image = Properties.Resources._10; total_pontos += 10; break;
                case 11: pictureBox2.Image = Properties.Resources.J; total_pontos += 10; break;
                case 12: pictureBox2.Image = Properties.Resources.Q; total_pontos += 10; break;
                case 13: pictureBox2.Image = Properties.Resources.K; total_pontos += 10; break;
            }
            
            pontos += total_pontos;

            lbl_pontos.Text = Convert.ToString(pontos);

            if (pontos > 21)
            {
                lbl_Resultado.Text = "Você perdeu!";
                btn_reiniciar.Enabled = true;
                btn_jogar.Enabled = false;
            }
            else
                if (pontos == 21)
            {
                lbl_Resultado.Text = "Você ganhou!";
                btn_reiniciar.Enabled = true;
                btn_jogar.Enabled = false;
            }

        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            pontos = 0;
            btn_jogar.Enabled = true;
            btn_reiniciar.Enabled = false;
            lbl_pontos.Text = "0";
            lbl_Resultado.Text = "";
            pictureBox2.Image = Properties.Resources.gray_back_cards;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Form menu = new form_apresentacao();
            menu.Show();
            this.Visible = false;
        }
    }
}
