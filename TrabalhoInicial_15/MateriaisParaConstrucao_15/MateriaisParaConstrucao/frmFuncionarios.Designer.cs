namespace MateriaisParaConstrucao
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgFuncionarios = new System.Windows.Forms.DataGridView();
            this.ID_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACOES_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE1_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE2_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CADASTRO_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbDocumentosPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.GroupBox();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).BeginInit();
            this.gbDocumentosPessoaFisica.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.Pesquisa.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(838, 58);
            this.toolStrip1.TabIndex = 138;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // dtgFuncionarios
            // 
            this.dtgFuncionarios.AllowUserToAddRows = false;
            this.dtgFuncionarios.AllowUserToDeleteRows = false;
            this.dtgFuncionarios.AllowUserToResizeColumns = false;
            this.dtgFuncionarios.AllowUserToResizeRows = false;
            this.dtgFuncionarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FUNCIONARIO,
            this.NOME_FUNCIONARIO,
            this.ENDERECO_FUNCIONARIO,
            this.BAIRRO_FUNCIONARIO,
            this.CEP_FUNCIONARIO,
            this.CIDADE_FUNCIONARIO,
            this.EMAIL_FUNCIONARIO,
            this.NASCIMENTO_FUNCIONARIO,
            this.OBSERVACOES_FUNCIONARIO,
            this.TELEFONE1_FUNCIONARIO,
            this.TELEFONE2_FUNCIONARIO,
            this.RG_FUNCIONARIO,
            this.CPF_FUNCIONARIO,
            this.DATA_CADASTRO_FUNCIONARIO,
            this.btnEditar,
            this.btnExcluir});
            this.dtgFuncionarios.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgFuncionarios.Location = new System.Drawing.Point(12, 386);
            this.dtgFuncionarios.Name = "dtgFuncionarios";
            this.dtgFuncionarios.ReadOnly = true;
            this.dtgFuncionarios.RowHeadersVisible = false;
            this.dtgFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionarios.Size = new System.Drawing.Size(815, 235);
            this.dtgFuncionarios.TabIndex = 175;
            this.dtgFuncionarios.TabStop = false;
            this.dtgFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionarios_CellContentClick);
            // 
            // ID_FUNCIONARIO
            // 
            this.ID_FUNCIONARIO.DataPropertyName = "ID_FUNCIONARIO";
            this.ID_FUNCIONARIO.HeaderText = "Código";
            this.ID_FUNCIONARIO.Name = "ID_FUNCIONARIO";
            this.ID_FUNCIONARIO.ReadOnly = true;
            this.ID_FUNCIONARIO.Visible = false;
            // 
            // NOME_FUNCIONARIO
            // 
            this.NOME_FUNCIONARIO.DataPropertyName = "NOME_FUNCIONARIO";
            this.NOME_FUNCIONARIO.HeaderText = "Nome";
            this.NOME_FUNCIONARIO.Name = "NOME_FUNCIONARIO";
            this.NOME_FUNCIONARIO.ReadOnly = true;
            this.NOME_FUNCIONARIO.Width = 230;
            // 
            // ENDERECO_FUNCIONARIO
            // 
            this.ENDERECO_FUNCIONARIO.DataPropertyName = "ENDERECO_FUNCIONARIO";
            this.ENDERECO_FUNCIONARIO.HeaderText = "Endereço";
            this.ENDERECO_FUNCIONARIO.Name = "ENDERECO_FUNCIONARIO";
            this.ENDERECO_FUNCIONARIO.ReadOnly = true;
            this.ENDERECO_FUNCIONARIO.Width = 250;
            // 
            // BAIRRO_FUNCIONARIO
            // 
            this.BAIRRO_FUNCIONARIO.DataPropertyName = "BAIRRO_FUNCIONARIO";
            this.BAIRRO_FUNCIONARIO.HeaderText = "Bairro";
            this.BAIRRO_FUNCIONARIO.Name = "BAIRRO_FUNCIONARIO";
            this.BAIRRO_FUNCIONARIO.ReadOnly = true;
            this.BAIRRO_FUNCIONARIO.Visible = false;
            // 
            // CEP_FUNCIONARIO
            // 
            this.CEP_FUNCIONARIO.DataPropertyName = "CEP_FUNCIONARIO";
            this.CEP_FUNCIONARIO.HeaderText = "Cep";
            this.CEP_FUNCIONARIO.Name = "CEP_FUNCIONARIO";
            this.CEP_FUNCIONARIO.ReadOnly = true;
            this.CEP_FUNCIONARIO.Visible = false;
            // 
            // CIDADE_FUNCIONARIO
            // 
            this.CIDADE_FUNCIONARIO.DataPropertyName = "CIDADE_FUNCIONARIO";
            this.CIDADE_FUNCIONARIO.HeaderText = "Cidade";
            this.CIDADE_FUNCIONARIO.Name = "CIDADE_FUNCIONARIO";
            this.CIDADE_FUNCIONARIO.ReadOnly = true;
            this.CIDADE_FUNCIONARIO.Visible = false;
            this.CIDADE_FUNCIONARIO.Width = 200;
            // 
            // EMAIL_FUNCIONARIO
            // 
            this.EMAIL_FUNCIONARIO.DataPropertyName = "EMAIL_FUNCIONARIO";
            this.EMAIL_FUNCIONARIO.HeaderText = "Email";
            this.EMAIL_FUNCIONARIO.Name = "EMAIL_FUNCIONARIO";
            this.EMAIL_FUNCIONARIO.ReadOnly = true;
            this.EMAIL_FUNCIONARIO.Width = 170;
            // 
            // NASCIMENTO_FUNCIONARIO
            // 
            this.NASCIMENTO_FUNCIONARIO.DataPropertyName = "NASCIMENTO_FUNCIONARIO";
            this.NASCIMENTO_FUNCIONARIO.HeaderText = "Nascimento";
            this.NASCIMENTO_FUNCIONARIO.Name = "NASCIMENTO_FUNCIONARIO";
            this.NASCIMENTO_FUNCIONARIO.ReadOnly = true;
            this.NASCIMENTO_FUNCIONARIO.Visible = false;
            // 
            // OBSERVACOES_FUNCIONARIO
            // 
            this.OBSERVACOES_FUNCIONARIO.DataPropertyName = "OBSERVACOES_FUNCIONARIO";
            this.OBSERVACOES_FUNCIONARIO.HeaderText = "Observações";
            this.OBSERVACOES_FUNCIONARIO.Name = "OBSERVACOES_FUNCIONARIO";
            this.OBSERVACOES_FUNCIONARIO.ReadOnly = true;
            this.OBSERVACOES_FUNCIONARIO.Visible = false;
            // 
            // TELEFONE1_FUNCIONARIO
            // 
            this.TELEFONE1_FUNCIONARIO.DataPropertyName = "TELEFONE1_FUNCIONARIO";
            this.TELEFONE1_FUNCIONARIO.HeaderText = "Telefone";
            this.TELEFONE1_FUNCIONARIO.Name = "TELEFONE1_FUNCIONARIO";
            this.TELEFONE1_FUNCIONARIO.ReadOnly = true;
            this.TELEFONE1_FUNCIONARIO.Width = 95;
            // 
            // TELEFONE2_FUNCIONARIO
            // 
            this.TELEFONE2_FUNCIONARIO.DataPropertyName = "TELEFONE2_FUNCIONARIO";
            this.TELEFONE2_FUNCIONARIO.HeaderText = "Telefone2";
            this.TELEFONE2_FUNCIONARIO.Name = "TELEFONE2_FUNCIONARIO";
            this.TELEFONE2_FUNCIONARIO.ReadOnly = true;
            this.TELEFONE2_FUNCIONARIO.Visible = false;
            // 
            // RG_FUNCIONARIO
            // 
            this.RG_FUNCIONARIO.DataPropertyName = "RG_FUNCIONARIO";
            this.RG_FUNCIONARIO.HeaderText = "RG";
            this.RG_FUNCIONARIO.Name = "RG_FUNCIONARIO";
            this.RG_FUNCIONARIO.ReadOnly = true;
            this.RG_FUNCIONARIO.Visible = false;
            // 
            // CPF_FUNCIONARIO
            // 
            this.CPF_FUNCIONARIO.DataPropertyName = "CPF_FUNCIONARIO";
            this.CPF_FUNCIONARIO.HeaderText = "CPF";
            this.CPF_FUNCIONARIO.Name = "CPF_FUNCIONARIO";
            this.CPF_FUNCIONARIO.ReadOnly = true;
            this.CPF_FUNCIONARIO.Visible = false;
            // 
            // DATA_CADASTRO_FUNCIONARIO
            // 
            this.DATA_CADASTRO_FUNCIONARIO.DataPropertyName = "DATA_CADASTRO_FUNCIONARIO";
            this.DATA_CADASTRO_FUNCIONARIO.HeaderText = "Data";
            this.DATA_CADASTRO_FUNCIONARIO.Name = "DATA_CADASTRO_FUNCIONARIO";
            this.DATA_CADASTRO_FUNCIONARIO.ReadOnly = true;
            this.DATA_CADASTRO_FUNCIONARIO.Visible = false;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(16, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 18);
            this.label17.TabIndex = 174;
            this.label17.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(124, 265);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(107, 22);
            this.dtpNascimento.TabIndex = 158;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(64, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 173;
            this.label13.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(124, 237);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(418, 22);
            this.txtEmail.TabIndex = 157;
            // 
            // gbDocumentosPessoaFisica
            // 
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtCpf);
            this.gbDocumentosPessoaFisica.Controls.Add(this.txtRg);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label14);
            this.gbDocumentosPessoaFisica.Controls.Add(this.label15);
            this.gbDocumentosPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDocumentosPessoaFisica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDocumentosPessoaFisica.Location = new System.Drawing.Point(576, 91);
            this.gbDocumentosPessoaFisica.Name = "gbDocumentosPessoaFisica";
            this.gbDocumentosPessoaFisica.Size = new System.Drawing.Size(251, 81);
            this.gbDocumentosPessoaFisica.TabIndex = 160;
            this.gbDocumentosPessoaFisica.TabStop = false;
            this.gbDocumentosPessoaFisica.Text = "Documentos";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(70, 53);
            this.txtCpf.Mask = "999,999,999-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(148, 22);
            this.txtCpf.TabIndex = 1;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(70, 25);
            this.txtRg.MaxLength = 50;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(148, 22);
            this.txtRg.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "RG:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "CPF:";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.txtTelefone2);
            this.gbContato.Controls.Add(this.txtTelefone1);
            this.gbContato.Controls.Add(this.label7);
            this.gbContato.Controls.Add(this.label8);
            this.gbContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbContato.Location = new System.Drawing.Point(576, 179);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(251, 93);
            this.gbContato.TabIndex = 161;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(313, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 172;
            this.label12.Text = "Data Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCadastro.Location = new System.Drawing.Point(437, 91);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(105, 22);
            this.dtpDataCadastro.TabIndex = 171;
            this.dtpDataCadastro.TabStop = false;
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(462, 178);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(80, 22);
            this.txtCep.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 163;
            this.label1.Text = "Registro:";
            // 
            // Pesquisa
            // 
            this.Pesquisa.Controls.Add(this.rbCpf);
            this.Pesquisa.Controls.Add(this.rbNome);
            this.Pesquisa.Controls.Add(this.txtPesquisa);
            this.Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pesquisa.Location = new System.Drawing.Point(576, 278);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(251, 93);
            this.Pesquisa.TabIndex = 162;
            this.Pesquisa.TabStop = false;
            this.Pesquisa.Text = "Pesquisa";
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCpf.Location = new System.Drawing.Point(135, 62);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(60, 22);
            this.rbCpf.TabIndex = 2;
            this.rbCpf.Text = "CPF ";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(47, 62);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(67, 22);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(54, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 169;
            this.label6.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(60, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 167;
            this.label4.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(413, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 168;
            this.label5.Text = "CEP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 166;
            this.label3.Text = "Endereço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(6, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 165;
            this.label10.Text = "Observações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(60, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 164;
            this.label2.Text = "Nome:";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(124, 206);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(418, 22);
            this.txtCidade.TabIndex = 156;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(124, 178);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(283, 22);
            this.txtBairro.TabIndex = 154;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(124, 150);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(418, 22);
            this.txtEndereco.TabIndex = 153;
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(124, 293);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(418, 78);
            this.txtObservacao.TabIndex = 159;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 120);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(418, 22);
            this.txtNome.TabIndex = 152;
            // 
            // txtRegistro
            // 
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.Location = new System.Drawing.Point(124, 91);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(55, 22);
            this.txtRegistro.TabIndex = 170;
            this.txtRegistro.TabStop = false;
            this.txtRegistro.Text = "0";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 632);
            this.Controls.Add(this.dtgFuncionarios);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gbDocumentosPessoaFisica);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpDataCadastro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionarios)).EndInit();
            this.gbDocumentosPessoaFisica.ResumeLayout(false);
            this.gbDocumentosPessoaFisica.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.Pesquisa.ResumeLayout(false);
            this.Pesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dtgFuncionarios;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbDocumentosPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Pesquisa;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE1_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE2_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CADASTRO_FUNCIONARIO;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}