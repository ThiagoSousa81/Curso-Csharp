namespace MateriaisParaConstrucao
{
    partial class frmPesquisaClientes
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
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.Location = new System.Drawing.Point(6, 63);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(52, 20);
            this.rbCpf.TabIndex = 2;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPesquisa.Location = new System.Drawing.Point(6, 35);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(426, 22);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCnpj);
            this.groupBox3.Controls.Add(this.rbCpf);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 93);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCnpj.Location = new System.Drawing.Point(64, 63);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(61, 20);
            this.rbCnpj.TabIndex = 2;
            this.rbCnpj.TabStop = true;
            this.rbCnpj.Text = "CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = true;
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            this.dtgClientes.AllowUserToResizeColumns = false;
            this.dtgClientes.AllowUserToResizeRows = false;
            this.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.EMAIL,
            this.CEP,
            this.ESTADO,
            this.RG,
            this.IE,
            this.NOME_CLIENTE,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.NASCIMENTO,
            this.TELEFONE,
            this.CELULAR,
            this.OBSERVACAO,
            this.DATA,
            this.CPF,
            this.CNPJ,
            this.ID_PESSOA});
            this.dtgClientes.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgClientes.Location = new System.Drawing.Point(12, 111);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(446, 281);
            this.dtgClientes.TabIndex = 57;
            this.dtgClientes.TabStop = false;
            this.dtgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellDoubleClick);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "Código";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Width = 50;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL_CLIENTE";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP_CLIENTE";
            this.CEP.HeaderText = "Cep";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO_CLIENTE";
            this.ESTADO.HeaderText = "Estado";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG_CLIENTE";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Visible = false;
            // 
            // IE
            // 
            this.IE.DataPropertyName = "IE_CLIENTE";
            this.IE.HeaderText = "IE";
            this.IE.Name = "IE";
            this.IE.ReadOnly = true;
            this.IE.Visible = false;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "Nome";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 295;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO_CLIENTE";
            this.ENDERECO.HeaderText = "Endereço";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Visible = false;
            this.ENDERECO.Width = 200;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "BAIRRO_CLIENTE";
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Visible = false;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE_CLIENTE";
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Visible = false;
            this.CIDADE.Width = 200;
            // 
            // NASCIMENTO
            // 
            this.NASCIMENTO.DataPropertyName = "NASCIMENTO_CLIENTE";
            this.NASCIMENTO.HeaderText = "Nascimento";
            this.NASCIMENTO.Name = "NASCIMENTO";
            this.NASCIMENTO.ReadOnly = true;
            this.NASCIMENTO.Visible = false;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE1_CLIENTE";
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 85;
            // 
            // CELULAR
            // 
            this.CELULAR.DataPropertyName = "TELEFONE2_CLIENTE";
            this.CELULAR.HeaderText = "Celular";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            this.CELULAR.Visible = false;
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.DataPropertyName = "OBSERVACOES_CLIENTE";
            this.OBSERVACAO.HeaderText = "Observações";
            this.OBSERVACAO.Name = "OBSERVACAO";
            this.OBSERVACAO.ReadOnly = true;
            this.OBSERVACAO.Visible = false;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA_CADASTRO_CLIENTE";
            this.DATA.HeaderText = "Data";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Visible = false;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF_CLIENTE";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Visible = false;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ_CLIENTE";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Visible = false;
            // 
            // ID_PESSOA
            // 
            this.ID_PESSOA.DataPropertyName = "ID_CLIENTE1";
            this.ID_PESSOA.HeaderText = "Codigo_Pessoa";
            this.ID_PESSOA.Name = "ID_PESSOA";
            this.ID_PESSOA.ReadOnly = true;
            this.ID_PESSOA.Visible = false;
            // 
            // frmPesquisaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Clientes";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PESSOA;
    }
}