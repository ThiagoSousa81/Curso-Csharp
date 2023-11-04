namespace MateriaisParaConstrucao
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBarra = new System.Windows.Forms.ProgressBar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema para Lojas de Materiais para Construção";
            // 
            // pbBarra
            // 
            this.pbBarra.Location = new System.Drawing.Point(10, 273);
            this.pbBarra.MarqueeAnimationSpeed = 1000;
            this.pbBarra.Name = "pbBarra";
            this.pbBarra.Size = new System.Drawing.Size(665, 30);
            this.pbBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbBarra.TabIndex = 1;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 32;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MateriaisParaConstrucao.Properties.Resources.Construção_Civil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 310);
            this.Controls.Add(this.pbBarra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbBarra;
        private System.Windows.Forms.Timer relogio;
    }
}