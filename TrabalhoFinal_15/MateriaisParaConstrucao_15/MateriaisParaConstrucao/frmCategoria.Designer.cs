namespace MateriaisParaConstrucao
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgCategorias = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_CATEGORIA_PRODUTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btnSalvar,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 70);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::MateriaisParaConstrucao.Properties.Resources.novo;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 55);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 67);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 55);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(82, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 24);
            this.txtNome.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(82, 89);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Text = "0";
            // 
            // dtgCategorias
            // 
            this.dtgCategorias.AllowUserToAddRows = false;
            this.dtgCategorias.AllowUserToDeleteRows = false;
            this.dtgCategorias.AllowUserToResizeColumns = false;
            this.dtgCategorias.AllowUserToResizeRows = false;
            this.dtgCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CATEGORIA_PRODUTOS,
            this.NOME_CATEGORIA_PRODUTOS,
            this.DESCRICAO_CATEGORIA_PRODUTOS,
            this.btnEditar,
            this.btnExcluir});
            this.dtgCategorias.Location = new System.Drawing.Point(12, 149);
            this.dtgCategorias.Name = "dtgCategorias";
            this.dtgCategorias.ReadOnly = true;
            this.dtgCategorias.RowHeadersVisible = false;
            this.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategorias.Size = new System.Drawing.Size(480, 235);
            this.dtgCategorias.TabIndex = 21;
            this.dtgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategorias_CellContentClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(289, 89);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(203, 54);
            this.txtDescricao.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código:";
            // 
            // ID_CATEGORIA_PRODUTOS
            // 
            this.ID_CATEGORIA_PRODUTOS.DataPropertyName = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.HeaderText = "Código";
            this.ID_CATEGORIA_PRODUTOS.Name = "ID_CATEGORIA_PRODUTOS";
            this.ID_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.ID_CATEGORIA_PRODUTOS.Width = 70;
            // 
            // NOME_CATEGORIA_PRODUTOS
            // 
            this.NOME_CATEGORIA_PRODUTOS.DataPropertyName = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.HeaderText = "Nome";
            this.NOME_CATEGORIA_PRODUTOS.Name = "NOME_CATEGORIA_PRODUTOS";
            this.NOME_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.NOME_CATEGORIA_PRODUTOS.Width = 190;
            // 
            // DESCRICAO_CATEGORIA_PRODUTOS
            // 
            this.DESCRICAO_CATEGORIA_PRODUTOS.DataPropertyName = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.HeaderText = "Descrição";
            this.DESCRICAO_CATEGORIA_PRODUTOS.Name = "DESCRICAO_CATEGORIA_PRODUTOS";
            this.DESCRICAO_CATEGORIA_PRODUTOS.ReadOnly = true;
            this.DESCRICAO_CATEGORIA_PRODUTOS.Width = 140;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::MateriaisParaConstrucao.Properties.Resources.editar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
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
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dtgCategorias);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dtgCategorias;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_CATEGORIA_PRODUTOS;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}