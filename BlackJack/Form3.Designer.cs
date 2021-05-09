
namespace BlackJack
{
    partial class Form_jogo_indiv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            
            this.label2.Text = "Pontos: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pontos.Location = new System.Drawing.Point(105, 454);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(18, 20);
            
            this.lbl_pontos.Text = "0";
            this.lbl_pontos.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.gray_back_cards;
            this.pictureBox2.Location = new System.Drawing.Point(44, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 353);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
            this.pictureBox2.TabStop = false;
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_jogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_jogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_jogar.Location = new System.Drawing.Point(44, 416);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(110, 29);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reiniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reiniciar.Location = new System.Drawing.Point(170, 417);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(110, 29);
            this.btn_reiniciar.TabIndex = 2;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = false;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(151, 454);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 20);
            
            this.lbl_Resultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_menu.Location = new System.Drawing.Point(180, 8);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(110, 29);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // Form_jogo_indiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.background_button2;
            this.ClientSize = new System.Drawing.Size(334, 484);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_pontos);
            this.Controls.Add(this.label2);
            this.Name = "Form_jogo_indiv";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_pontos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_menu;
    }
}