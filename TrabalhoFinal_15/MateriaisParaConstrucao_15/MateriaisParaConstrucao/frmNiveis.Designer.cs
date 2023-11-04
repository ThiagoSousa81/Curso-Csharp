namespace MateriaisParaConstrucao
{
    partial class frmNiveis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNiveis));
            this.dtgNiveis = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ID_NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNiveis)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgNiveis
            // 
            this.dtgNiveis.AllowUserToAddRows = false;
            this.dtgNiveis.AllowUserToDeleteRows = false;
            this.dtgNiveis.AllowUserToResizeColumns = false;
            this.dtgNiveis.AllowUserToResizeRows = false;
            this.dtgNiveis.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NIVEL,
            this.NOME_NIVEL,
            this.DESCRICAO_NIVEL,
            this.btnEditar,
            this.btnExcluir});
            this.dtgNiveis.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgNiveis.Location = new System.Drawing.Point(12, 132);
            this.dtgNiveis.Name = "dtgNiveis";
            this.dtgNiveis.ReadOnly = true;
            this.dtgNiveis.RowHeadersVisible = false;
            this.dtgNiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNiveis.Size = new System.Drawing.Size(452, 175);
            this.dtgNiveis.TabIndex = 30;
            this.dtgNiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNiveis_CellContentClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescricao.Location = new System.Drawing.Point(282, 71);
            this.txtDescricao.MaxLength = 500;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(182, 52);
            this.txtDescricao.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(88, 100);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 22);
            this.txtNome.TabIndex = 28;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigo.Location = new System.Drawing.Point(88, 71);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(62, 22);
            this.txtCodigo.TabIndex = 32;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Text = "0";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 54);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ID_NIVEL
            // 
            this.ID_NIVEL.DataPropertyName = "ID_NIVEL";
            this.ID_NIVEL.HeaderText = "Código";
            this.ID_NIVEL.Name = "ID_NIVEL";
            this.ID_NIVEL.ReadOnly = true;
            this.ID_NIVEL.Width = 50;
            // 
            // NOME_NIVEL
            // 
            this.NOME_NIVEL.DataPropertyName = "NOME_NIVEL";
            this.NOME_NIVEL.HeaderText = "Nome";
            this.NOME_NIVEL.Name = "NOME_NIVEL";
            this.NOME_NIVEL.ReadOnly = true;
            // 
            // DESCRICAO_NIVEL
            // 
            this.DESCRICAO_NIVEL.DataPropertyName = "DESCRICAO_NIVEL";
            this.DESCRICAO_NIVEL.HeaderText = "Descrição";
            this.DESCRICAO_NIVEL.Name = "DESCRICAO_NIVEL";
            this.DESCRICAO_NIVEL.ReadOnly = true;
            this.DESCRICAO_NIVEL.Width = 230;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::MateriaisParaConstrucao.Properties.Resources.editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::MateriaisParaConstrucao.Properties.Resources.excluir;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::MateriaisParaConstrucao.Properties.Resources.editar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.Width = 30;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::MateriaisParaConstrucao.Properties.Resources.excluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ReadOnly = true;
            this.btnExcluir.Width = 30;
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
            this.btnNovo.Image = global::MateriaisParaConstrucao.Properties.Resources.novo;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(50, 51);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Image = global::MateriaisParaConstrucao.Properties.Resources.salvar;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(50, 51);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmNiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 316);
            this.Controls.Add(this.dtgNiveis);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNiveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Níveis de usuário";
            this.Load += new System.EventHandler(this.frmNiveis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNiveis)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNiveis;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_NIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_NIVEL;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}