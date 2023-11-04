namespace MateriaisParaConstrucao
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.gbTipoPessoa = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.Pesquisa = new System.Windows.Forms.GroupBox();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbDocumentosPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbDocumentosPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE1_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE2_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbTipoPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.gbContato.SuspendLayout();
            this.Pesquisa.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbDocumentosPessoaFisica.SuspendLayout();
            this.gbDocumentosPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(10, 61);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(67, 22);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(53, 301);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 18);
            this.lblEstado.TabIndex = 128;
            this.lblEstado.Text = "Estado:";
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = false;
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = false;
            this.btnSalvar.Image = global::MateriaisParaConstrucao.Properties.Resources.salvar;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 55);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(254, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 126;
            this.label13.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(315, 301);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 22);
            this.txtEmail.TabIndex = 107;
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaJuridica.Location = new System.Drawing.Point(238, 35);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(132, 22);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Checked = true;
            this.rbPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoaFisica.Location = new System.Drawing.Point(60, 35);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(120, 22);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(15, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 18);
            this.label17.TabIndex = 127;
            this.label17.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(130, 329);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(107, 22);
            this.dtpNascimento.TabIndex = 108;
            // 
            // gbTipoPessoa
            // 
            this.gbTipoPessoa.Controls.Add(this.rbPessoaJuridica);
            this.gbTipoPessoa.Controls.Add(this.rbPessoaFisica);
            this.gbTipoPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbTipoPessoa.Location = new System.Drawing.Point(130, 79);
            this.gbTipoPessoa.Name = "gbTipoPessoa";
            this.gbTipoPessoa.Size = new System.Drawing.Size(418, 70);
            this.gbTipoPessoa.TabIndex = 100;
            this.gbTipoPessoa.TabStop = false;
            this.gbTipoPessoa.Text = "Escolha o tipo de Pessoa";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 29);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(239, 22);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(130, 301);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(107, 22);
            this.txtEstado.TabIndex = 106;
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
            this.NOME_CLIENTE,
            this.ENDERECO_CLIENTE,
            this.BAIRRO_CLIENTE,
            this.CEP_CLIENTE,
            this.CIDADE_CLIENTE,
            this.ESTADO_CLIENTE,
            this.TELEFONE1_CLIENTE,
            this.TELEFONE2_CLIENTE,
            this.EMAIL_CLIENTE,
            this.DATA_CADASTRO_CLIENTE,
            this.NASCIMENTO_CLIENTE,
            this.OBSERVACOES_CLIENTE,
            this.CPF,
            this.CNPJ,
            this.btnEditar,
            this.btnExcluir});
            this.dtgClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgClientes.Location = new System.Drawing.Point(13, 441);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(814, 235);
            this.dtgClientes.TabIndex = 124;
            this.dtgClientes.TabStop = false;
            this.dtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellContentClick);
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.Location = new System.Drawing.Point(120, 30);
            this.txtTelefone1.Mask = "(99) 0000-0000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(98, 22);
            this.txtTelefone1.TabIndex = 0;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefone2);
            this.gbContato.Controls.Add(this.txtTelefone1);
            this.gbContato.Controls.Add(this.label7);
            this.gbContato.Controls.Add(this.label8);
            this.gbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbContato.Location = new System.Drawing.Point(574, 202);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(251, 93);
            this.gbContato.TabIndex = 111;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(120, 58);
            this.txtTelefone2.Mask = "(99) 0000-0000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(98, 22);
            this.txtTelefone2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefone 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Telefone 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 117;
            this.label3.Text = "Endereço:";
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCnpj.Location = new System.Drawing.Point(179, 61);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(66, 22);
            this.rbCnpj.TabIndex = 3;
            this.rbCnpj.Text = "CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(318, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 123;
            this.label12.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(443, 155);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(105, 22);
            this.dtpDataCadastro.TabIndex = 122;
            this.dtpDataCadastro.TabStop = false;
            // 
            // Pesquisa
            // 
            this.Pesquisa.Controls.Add(this.rbCnpj);
            this.Pesquisa.Controls.Add(this.rbCpf);
            this.Pesquisa.Controls.Add(this.rbNome);
            this.Pesquisa.Controls.Add(this.txtPesquisa);
            this.Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pesquisa.Location = new System.Drawing.Point(574, 337);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(251, 93);
            this.Pesquisa.TabIndex = 112;
            this.Pesquisa.TabStop = false;
            this.Pesquisa.Text = "Pesquisa";
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.Location = new System.Drawing.Point(98, 61);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(60, 22);
            this.rbCpf.TabIndex = 2;
            this.rbCpf.Text = "CPF ";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(468, 242);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(80, 22);
            this.txtCep.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 114;
            this.label1.Text = "Registro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(419, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 119;
            this.label5.Text = "CEP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(53, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 120;
            this.label6.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(59, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 118;
            this.label4.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(5, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 116;
            this.label10.Text = "Observações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(59, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 115;
            this.label2.Text = "Nome:";
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(130, 155);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(55, 22);
            this.txtRegistro.TabIndex = 121;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(130, 270);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(418, 22);
            this.txtCidade.TabIndex = 105;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(130, 242);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(283, 22);
            this.txtBairro.TabIndex = 103;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(130, 214);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(418, 22);
            this.txtEndereco.TabIndex = 102;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(130, 357);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(418, 64);
            this.txtObservacao.TabIndex = 109;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(130, 184);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(418, 22);
            this.txtNome.TabIndex = 101;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnSalvar,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(839, 58);
            this.toolStrip1.TabIndex = 113;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // gbDocumentosPessoaFisica
            // 
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtCpf);
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtRg);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label14);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label15);
            this.gbDocumentosPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaFisica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaFisica.Location = new System.Drawing.Point(574, 79);
            this.gbDocumentosPessoaFisica.Name = "gbDocumentosPessoaFisica";
            this.gbDocumentosPessoaFisica.Size = new System.Drawing.Size(251, 81);
            this.gbDocumentosPessoaFisica.TabIndex = 129;
            this.gbDocumentosPessoaFisica.TabStop = false;
            this.gbDocumentosPessoaFisica.Text = "Documentos";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(78, 49);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(140, 22);
            this.txtCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(78, 21);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(140, 22);
            this.txtRg.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "RG:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "CPF:";
            // 
            // gbDocumentosPessoaJuridica
            // 
            this.gbDocumentosPessoaJuridica.Controls.Add(this.txtCnpj);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.txtIe);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.label11);
            this.gbDocumentosPessoaJuridica.Controls.Add(this.label9);
            this.gbDocumentosPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaJuridica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaJuridica.Location = new System.Drawing.Point(574, 79);
            this.gbDocumentosPessoaJuridica.Name = "gbDocumentosPessoaJuridica";
            this.gbDocumentosPessoaJuridica.Size = new System.Drawing.Size(251, 81);
            this.gbDocumentosPessoaJuridica.TabIndex = 130;
            this.gbDocumentosPessoaJuridica.TabStop = false;
            this.gbDocumentosPessoaJuridica.Text = "Documentos";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(78, 49);
            this.txtCnpj.Mask = "99.999.999/9999-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(140, 22);
            this.txtCnpj.TabIndex = 96;
            // 
            // txtIe
            // 
            this.txtIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIe.Location = new System.Drawing.Point(78, 21);
            this.txtIe.MaxLength = 50;
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(140, 22);
            this.txtIe.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "IE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "CNPJ:";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "Código";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "Nome";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 230;
            // 
            // ENDERECO_CLIENTE
            // 
            this.ENDERECO_CLIENTE.DataPropertyName = "ENDERECO_CLIENTE";
            this.ENDERECO_CLIENTE.HeaderText = "Endereço";
            this.ENDERECO_CLIENTE.Name = "ENDERECO_CLIENTE";
            this.ENDERECO_CLIENTE.ReadOnly = true;
            this.ENDERECO_CLIENTE.Width = 230;
            // 
            // BAIRRO_CLIENTE
            // 
            this.BAIRRO_CLIENTE.DataPropertyName = "BAIRRO_CLIENTE";
            this.BAIRRO_CLIENTE.HeaderText = "Bairro";
            this.BAIRRO_CLIENTE.Name = "BAIRRO_CLIENTE";
            this.BAIRRO_CLIENTE.ReadOnly = true;
            this.BAIRRO_CLIENTE.Visible = false;
            // 
            // CEP_CLIENTE
            // 
            this.CEP_CLIENTE.DataPropertyName = "CEP_CLIENTE";
            this.CEP_CLIENTE.HeaderText = "CEP";
            this.CEP_CLIENTE.Name = "CEP_CLIENTE";
            this.CEP_CLIENTE.ReadOnly = true;
            this.CEP_CLIENTE.Visible = false;
            // 
            // CIDADE_CLIENTE
            // 
            this.CIDADE_CLIENTE.DataPropertyName = "CIDADE_CLIENTE";
            this.CIDADE_CLIENTE.HeaderText = "Cidade";
            this.CIDADE_CLIENTE.Name = "CIDADE_CLIENTE";
            this.CIDADE_CLIENTE.ReadOnly = true;
            this.CIDADE_CLIENTE.Width = 200;
            // 
            // ESTADO_CLIENTE
            // 
            this.ESTADO_CLIENTE.DataPropertyName = "ESTADO_CLIENTE";
            this.ESTADO_CLIENTE.HeaderText = "Estado";
            this.ESTADO_CLIENTE.Name = "ESTADO_CLIENTE";
            this.ESTADO_CLIENTE.ReadOnly = true;
            this.ESTADO_CLIENTE.Visible = false;
            // 
            // TELEFONE1_CLIENTE
            // 
            this.TELEFONE1_CLIENTE.DataPropertyName = "TELEFONE1_CLIENTE";
            this.TELEFONE1_CLIENTE.HeaderText = "Telefone";
            this.TELEFONE1_CLIENTE.Name = "TELEFONE1_CLIENTE";
            this.TELEFONE1_CLIENTE.ReadOnly = true;
            this.TELEFONE1_CLIENTE.Width = 85;
            // 
            // TELEFONE2_CLIENTE
            // 
            this.TELEFONE2_CLIENTE.DataPropertyName = "TELEFONE2_CLIENTE";
            this.TELEFONE2_CLIENTE.HeaderText = "Telefone2";
            this.TELEFONE2_CLIENTE.Name = "TELEFONE2_CLIENTE";
            this.TELEFONE2_CLIENTE.ReadOnly = true;
            this.TELEFONE2_CLIENTE.Visible = false;
            // 
            // EMAIL_CLIENTE
            // 
            this.EMAIL_CLIENTE.DataPropertyName = "EMAIL_CLIENTE";
            this.EMAIL_CLIENTE.HeaderText = "Email";
            this.EMAIL_CLIENTE.Name = "EMAIL_CLIENTE";
            this.EMAIL_CLIENTE.ReadOnly = true;
            this.EMAIL_CLIENTE.Visible = false;
            // 
            // DATA_CADASTRO_CLIENTE
            // 
            this.DATA_CADASTRO_CLIENTE.DataPropertyName = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.HeaderText = "Data";
            this.DATA_CADASTRO_CLIENTE.Name = "DATA_CADASTRO_CLIENTE";
            this.DATA_CADASTRO_CLIENTE.ReadOnly = true;
            this.DATA_CADASTRO_CLIENTE.Visible = false;
            // 
            // NASCIMENTO_CLIENTE
            // 
            this.NASCIMENTO_CLIENTE.DataPropertyName = "NASCIMENTO_CLIENTE";
            this.NASCIMENTO_CLIENTE.HeaderText = "Nascimento";
            this.NASCIMENTO_CLIENTE.Name = "NASCIMENTO_CLIENTE";
            this.NASCIMENTO_CLIENTE.ReadOnly = true;
            this.NASCIMENTO_CLIENTE.Visible = false;
            // 
            // OBSERVACOES_CLIENTE
            // 
            this.OBSERVACOES_CLIENTE.DataPropertyName = "OBSERVACOES_CLIENTE";
            this.OBSERVACOES_CLIENTE.HeaderText = "Observações";
            this.OBSERVACOES_CLIENTE.Name = "OBSERVACOES_CLIENTE";
            this.OBSERVACOES_CLIENTE.ReadOnly = true;
            this.OBSERVACOES_CLIENTE.Visible = false;
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
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 682);
            this.Controls.Add(this.gbDocumentosPessoaFisica);
            this.Controls.Add(this.gbDocumentosPessoaJuridica);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.gbTipoPessoa);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.gbTipoPessoa.ResumeLayout(false);
            this.gbTipoPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.Pesquisa.ResumeLayout(false);
            this.Pesquisa.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbDocumentosPessoaFisica.ResumeLayout(false);
            this.gbDocumentosPessoaFisica.PerformLayout();
            this.gbDocumentosPessoaJuridica.ResumeLayout(false);
            this.gbDocumentosPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.GroupBox gbTipoPessoa;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.GroupBox Pesquisa;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaJuridica;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE1_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE2_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}