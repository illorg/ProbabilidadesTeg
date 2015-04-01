namespace ProbabilidadesTeg
{
    partial class CalcuTeg
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
            this.txtbdefensa = new System.Windows.Forms.TextBox();
            this.txtbAtaque = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl_victoriaA = new System.Windows.Forms.Label();
            this.lblVictoriaD = new System.Windows.Forms.Label();
            this.lblProbabilidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbdefensa
            // 
            this.txtbdefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbdefensa.Location = new System.Drawing.Point(148, 67);
            this.txtbdefensa.Name = "txtbdefensa";
            this.txtbdefensa.Size = new System.Drawing.Size(49, 31);
            this.txtbdefensa.TabIndex = 0;
            // 
            // txtbAtaque
            // 
            this.txtbAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbAtaque.Location = new System.Drawing.Point(38, 67);
            this.txtbAtaque.Name = "txtbAtaque";
            this.txtbAtaque.Size = new System.Drawing.Size(49, 31);
            this.txtbAtaque.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(38, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 36);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Simular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl_victoriaA
            // 
            this.lbl_victoriaA.AutoSize = true;
            this.lbl_victoriaA.Location = new System.Drawing.Point(35, 230);
            this.lbl_victoriaA.Name = "lbl_victoriaA";
            this.lbl_victoriaA.Size = new System.Drawing.Size(35, 13);
            this.lbl_victoriaA.TabIndex = 3;
            this.lbl_victoriaA.Text = "label1";
            // 
            // lblVictoriaD
            // 
            this.lblVictoriaD.AutoSize = true;
            this.lblVictoriaD.Location = new System.Drawing.Point(162, 230);
            this.lblVictoriaD.Name = "lblVictoriaD";
            this.lblVictoriaD.Size = new System.Drawing.Size(35, 13);
            this.lblVictoriaD.TabIndex = 4;
            this.lblVictoriaD.Text = "label2";
            // 
            // lblProbabilidad
            // 
            this.lblProbabilidad.AutoSize = true;
            this.lblProbabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProbabilidad.Location = new System.Drawing.Point(35, 196);
            this.lblProbabilidad.Name = "lblProbabilidad";
            this.lblProbabilidad.Size = new System.Drawing.Size(149, 16);
            this.lblProbabilidad.TabIndex = 5;
            this.lblProbabilidad.Text = "Probabilidad de ganar..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fichas ataque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fichas defensa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProbabilidadesTeg.Properties.Resources.na13fo01;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CalcuTeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProbabilidad);
            this.Controls.Add(this.lblVictoriaD);
            this.Controls.Add(this.lbl_victoriaA);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtbAtaque);
            this.Controls.Add(this.txtbdefensa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CalcuTeg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probabilidades de exito en el TEG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbdefensa;
        private System.Windows.Forms.TextBox txtbAtaque;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl_victoriaA;
        private System.Windows.Forms.Label lblVictoriaD;
        private System.Windows.Forms.Label lblProbabilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

