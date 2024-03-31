namespace FORMATOHORA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHMSM = new System.Windows.Forms.Label();
            this.lblHMSAMPM = new System.Windows.Forms.Label();
            this.lblAMPM = new System.Windows.Forms.Label();
            this.lblHM = new System.Windows.Forms.Label();
            this.lblHMS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHMSM);
            this.groupBox1.Controls.Add(this.lblHMSAMPM);
            this.groupBox1.Controls.Add(this.lblAMPM);
            this.groupBox1.Controls.Add(this.lblHM);
            this.groupBox1.Controls.Add(this.lblHMS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblHMSM
            // 
            this.lblHMSM.AutoSize = true;
            this.lblHMSM.Location = new System.Drawing.Point(115, 300);
            this.lblHMSM.Name = "lblHMSM";
            this.lblHMSM.Size = new System.Drawing.Size(60, 24);
            this.lblHMSM.TabIndex = 4;
            this.lblHMSM.Text = "label1";
            // 
            // lblHMSAMPM
            // 
            this.lblHMSAMPM.AutoSize = true;
            this.lblHMSAMPM.Location = new System.Drawing.Point(115, 246);
            this.lblHMSAMPM.Name = "lblHMSAMPM";
            this.lblHMSAMPM.Size = new System.Drawing.Size(60, 24);
            this.lblHMSAMPM.TabIndex = 3;
            this.lblHMSAMPM.Text = "label1";
            // 
            // lblAMPM
            // 
            this.lblAMPM.AutoSize = true;
            this.lblAMPM.Location = new System.Drawing.Point(115, 174);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(60, 24);
            this.lblAMPM.TabIndex = 2;
            this.lblAMPM.Text = "label1";
            // 
            // lblHM
            // 
            this.lblHM.AutoSize = true;
            this.lblHM.Location = new System.Drawing.Point(115, 103);
            this.lblHM.Name = "lblHM";
            this.lblHM.Size = new System.Drawing.Size(60, 24);
            this.lblHM.TabIndex = 1;
            this.lblHM.Text = "label1";
            // 
            // lblHMS
            // 
            this.lblHMS.AutoSize = true;
            this.lblHMS.Location = new System.Drawing.Point(115, 25);
            this.lblHMS.Name = "lblHMS";
            this.lblHMS.Size = new System.Drawing.Size(60, 24);
            this.lblHMS.TabIndex = 0;
            this.lblHMS.Text = "label1";
            this.lblHMS.Click += new System.EventHandler(this.lblHMS_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 558);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHMS;
        private System.Windows.Forms.Label lblAMPM;
        private System.Windows.Forms.Label lblHM;
        private System.Windows.Forms.Label lblHMSM;
        private System.Windows.Forms.Label lblHMSAMPM;
        private System.Windows.Forms.Timer timer1;
    }
}

