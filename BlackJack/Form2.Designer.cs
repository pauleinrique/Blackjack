
namespace BlackJack
{
    partial class form_apresentacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Iniciar_Dupla = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Iniciar_Indiv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(427, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.Text = "DUPLA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Iniciar_Dupla
            // 
            this.btn_Iniciar_Dupla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Iniciar_Dupla.Image = global::BlackJack.Properties.Resources.background_min;
            this.btn_Iniciar_Dupla.Location = new System.Drawing.Point(385, 359);
            this.btn_Iniciar_Dupla.Name = "btn_Iniciar_Dupla";
            this.btn_Iniciar_Dupla.Size = new System.Drawing.Size(153, 29);
            this.btn_Iniciar_Dupla.TabIndex = 2;
            this.btn_Iniciar_Dupla.Text = "INICIAR";
            this.btn_Iniciar_Dupla.UseVisualStyleBackColor = true;
            this.btn_Iniciar_Dupla.Click += new System.EventHandler(this.btn_Iniciar_Dupla_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(122, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(416, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Iniciar_Indiv
            // 
            this.btn_Iniciar_Indiv.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Iniciar_Indiv.Image = global::BlackJack.Properties.Resources.background_min;
            this.btn_Iniciar_Indiv.Location = new System.Drawing.Point(122, 359);
            this.btn_Iniciar_Indiv.Name = "btn_Iniciar_Indiv";
            this.btn_Iniciar_Indiv.Size = new System.Drawing.Size(153, 29);
            this.btn_Iniciar_Indiv.TabIndex = 1;
            this.btn_Iniciar_Indiv.Text = "INICIAR";
            this.btn_Iniciar_Indiv.UseVisualStyleBackColor = true;
            this.btn_Iniciar_Indiv.Click += new System.EventHandler(this.btn_Iniciar_Indiv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.Text = "INDIVÍDUAL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // form_apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.btn_Iniciar_Indiv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Iniciar_Dupla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_apresentacao";
            this.Text = "BlackJack (Duplas)";
            this.Load += new System.EventHandler(this.form_apresentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Iniciar_Indiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Iniciar_Dupla;
    }
}