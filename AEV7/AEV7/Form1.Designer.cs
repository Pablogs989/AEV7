
namespace AEV7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtRelojH = new System.Windows.Forms.Label();
            this.txtRelojF = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtRelojH
            // 
            this.txtRelojH.AutoSize = true;
            this.txtRelojH.Font = new System.Drawing.Font("Source Sans Pro Light", 16.25F);
            this.txtRelojH.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRelojH.Location = new System.Drawing.Point(164, 89);
            this.txtRelojH.Name = "txtRelojH";
            this.txtRelojH.Size = new System.Drawing.Size(55, 28);
            this.txtRelojH.TabIndex = 1;
            this.txtRelojH.Text = "Hora";
            // 
            // txtRelojF
            // 
            this.txtRelojF.AutoSize = true;
            this.txtRelojF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRelojF.Font = new System.Drawing.Font("Source Sans Pro Light", 16.25F);
            this.txtRelojF.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRelojF.Location = new System.Drawing.Point(155, 52);
            this.txtRelojF.Name = "txtRelojF";
            this.txtRelojF.Size = new System.Drawing.Size(66, 28);
            this.txtRelojF.TabIndex = 2;
            this.txtRelojF.Text = "Fecha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AEV7.Properties.Resources.lineaHF;
            this.pictureBox2.Location = new System.Drawing.Point(68, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AEV7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.txtRelojF);
            this.Controls.Add(this.txtRelojH);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtRelojH;
        private System.Windows.Forms.Label txtRelojF;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

