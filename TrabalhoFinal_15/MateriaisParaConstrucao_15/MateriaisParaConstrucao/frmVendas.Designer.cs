namespace MateriaisParaConstrucao
{
    partial class frmVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.gbDetalhesVendas = new System.Windows.Forms.GroupBox();
            this.lblUsuário = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lblValorSubtotal = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dtgVendas = new System.Windows.Forms.DataGridView();
            this.ID_DETALHES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_BARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.gbItemEmDestaque = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnDigitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.gbDetalhesVendas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendas)).BeginInit();
            this.gbItemEmDestaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalhesVendas
            // 
            this.gbDetalhesVendas.BackColor = System.Drawing.SystemColors.Control;
            this.gbDetalhesVendas.Controls.Add(this.btnPesquisar);
            this.gbDetalhesVendas.Controls.Add(this.lblUsuário);
            this.gbDetalhesVendas.Controls.Add(this.lblData);
            this.gbDetalhesVendas.Controls.Add(this.label5);
            this.gbDetalhesVendas.Controls.Add(this.label3);
            this.gbDetalhesVendas.Controls.Add(this.lblNomeCliente);
            this.gbDetalhesVendas.Controls.Add(this.label2);
            this.gbDetalhesVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalhesVendas.Location = new System.Drawing.Point(297, 3);
            this.gbDetalhesVendas.Name = "gbDetalhesVendas";
            this.gbDetalhesVendas.Size = new System.Drawing.Size(405, 109);
            this.gbDetalhesVendas.TabIndex = 32;
            this.gbDetalhesVendas.TabStop = false;
            this.gbDetalhesVendas.Text = "Detalhes da venda";
            // 
            // lblUsuário
            // 
            this.lblUsuário.AutoSize = true;
            this.lblUsuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuário.Location = new System.Drawing.Point(135, 78);
            this.lblUsuário.Name = "lblUsuário";
            this.lblUsuário.Size = new System.Drawing.Size(96, 15);
            this.lblUsuário.TabIndex = 5;
            this.lblUsuário.Text = "Administrador";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 78);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(89, 15);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data de hoje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 39);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(208, 15);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Não informado para esta venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnDigitar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodBarras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 109);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto por código";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entre com o código de barras do produto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCodBarras.Location = new System.Drawing.Point(6, 25);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(254, 35);
            this.txtCodBarras.TabIndex = 0;
            this.txtCodBarras.TextChanged += new System.EventHandler(this.txtCodBarras_TextChanged);
            // 
            // lblValorSubtotal
            // 
            this.lblValorSubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSubtotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorSubtotal.Location = new System.Drawing.Point(526, 534);
            this.lblValorSubtotal.Name = "lblValorSubtotal";
            this.lblValorSubtotal.Size = new System.Drawing.Size(176, 31);
            this.lblValorSubtotal.TabIndex = 30;
            this.lblValorSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar,
            this.btnRemover,
            this.toolStripSeparator1,
            this.btnFinalizar,
            this.btnSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 583);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 54);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // dtgVendas
            // 
            this.dtgVendas.AllowUserToAddRows = false;
            this.dtgVendas.AllowUserToDeleteRows = false;
            this.dtgVendas.AllowUserToResizeColumns = false;
            this.dtgVendas.AllowUserToResizeRows = false;
            this.dtgVendas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DETALHES,
            this.ID_VENDA,
            this.ID_PRODUTO,
            this.CODIGO_BARRAS,
            this.NOME_PRODUTO,
            this.DESCRICAO_PRODUTO,
            this.VALOR_VENDA,
            this.QUANTIDADE,
            this.SUBTOTAL});
            this.dtgVendas.Location = new System.Drawing.Point(12, 224);
            this.dtgVendas.Name = "dtgVendas";
            this.dtgVendas.ReadOnly = true;
            this.dtgVendas.RowHeadersVisible = false;
            this.dtgVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVendas.Size = new System.Drawing.Size(690, 296);
            this.dtgVendas.TabIndex = 29;
            // 
            // ID_DETALHES
            // 
            this.ID_DETALHES.DataPropertyName = "ID_DETALHES";
            this.ID_DETALHES.HeaderText = "CodDetalhes";
            this.ID_DETALHES.Name = "ID_DETALHES";
            this.ID_DETALHES.ReadOnly = true;
            this.ID_DETALHES.Visible = false;
            // 
            // ID_VENDA
            // 
            this.ID_VENDA.DataPropertyName = "ID_VENDA";
            this.ID_VENDA.HeaderText = "CodVenda";
            this.ID_VENDA.Name = "ID_VENDA";
            this.ID_VENDA.ReadOnly = true;
            this.ID_VENDA.Visible = false;
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "CodProduto";
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.ReadOnly = true;
            this.ID_PRODUTO.Visible = false;
            // 
            // CODIGO_BARRAS
            // 
            this.CODIGO_BARRAS.DataPropertyName = "CODIGO_BARRAS_PRODUTO";
            this.CODIGO_BARRAS.HeaderText = "Cód Barras";
            this.CODIGO_BARRAS.Name = "CODIGO_BARRAS";
            this.CODIGO_BARRAS.ReadOnly = true;
            // 
            // NOME_PRODUTO
            // 
            this.NOME_PRODUTO.DataPropertyName = "NOME_PRODUTO";
            this.NOME_PRODUTO.HeaderText = "Nome";
            this.NOME_PRODUTO.Name = "NOME_PRODUTO";
            this.NOME_PRODUTO.ReadOnly = true;
            this.NOME_PRODUTO.Width = 180;
            // 
            // DESCRICAO_PRODUTO
            // 
            this.DESCRICAO_PRODUTO.DataPropertyName = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.HeaderText = "Descrição";
            this.DESCRICAO_PRODUTO.Name = "DESCRICAO_PRODUTO";
            this.DESCRICAO_PRODUTO.ReadOnly = true;
            this.DESCRICAO_PRODUTO.Width = 150;
            // 
            // VALOR_VENDA
            // 
            this.VALOR_VENDA.DataPropertyName = "VALOR_VENDA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.VALOR_VENDA.DefaultCellStyle = dataGridViewCellStyle1;
            this.VALOR_VENDA.HeaderText = "Valor unitário";
            this.VALOR_VENDA.Name = "VALOR_VENDA";
            this.VALOR_VENDA.ReadOnly = true;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QUANTIDADE.DefaultCellStyle = dataGridViewCellStyle2;
            this.QUANTIDADE.HeaderText = "Qtde";
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 50;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.DataPropertyName = "VALOR_CUSTO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.SUBTOTAL.DefaultCellStyle = dataGridViewCellStyle3;
            this.SUBTOTAL.HeaderText = "Subtotal";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            this.SUBTOTAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(393, 534);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(131, 31);
            this.labelSubtotal.TabIndex = 31;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // gbItemEmDestaque
            // 
            this.gbItemEmDestaque.BackColor = System.Drawing.SystemColors.Window;
            this.gbItemEmDestaque.Controls.Add(this.label7);
            this.gbItemEmDestaque.Controls.Add(this.lblSubtotal);
            this.gbItemEmDestaque.Controls.Add(this.lblQuantidade);
            this.gbItemEmDestaque.Controls.Add(this.lblValor);
            this.gbItemEmDestaque.Controls.Add(this.lblDescricao);
            this.gbItemEmDestaque.Controls.Add(this.lblItem);
            this.gbItemEmDestaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItemEmDestaque.Location = new System.Drawing.Point(12, 118);
            this.gbItemEmDestaque.Name = "gbItemEmDestaque";
            this.gbItemEmDestaque.Size = new System.Drawing.Size(689, 100);
            this.gbItemEmDestaque.TabIndex = 27;
            this.gbItemEmDestaque.TabStop = false;
            this.gbItemEmDestaque.Text = "Item em destaque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSubtotal.Location = new System.Drawing.Point(573, 68);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(110, 20);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQuantidade.Location = new System.Drawing.Point(478, 68);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(53, 20);
            this.lblQuantidade.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblValor.Location = new System.Drawing.Point(348, 68);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(97, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDescricao.Location = new System.Drawing.Point(6, 60);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(325, 33);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblItem.Location = new System.Drawing.Point(6, 23);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(677, 33);
            this.lblItem.TabIndex = 0;
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::MateriaisParaConstrucao.Properties.Resources.pesquisa;
            this.btnPesquisar.Location = new System.Drawing.Point(249, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 24);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnDigitar
            // 
            this.btnDigitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitar.Image = global::MateriaisParaConstrucao.Properties.Resources.barcode;
            this.btnDigitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDigitar.Location = new System.Drawing.Point(170, 68);
            this.btnDigitar.Name = "btnDigitar";
            this.btnDigitar.Size = new System.Drawing.Size(90, 26);
            this.btnDigitar.TabIndex = 1;
            this.btnDigitar.Text = "Digitar";
            this.btnDigitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDigitar.UseVisualStyleBackColor = true;
            this.btnDigitar.Click += new System.EventHandler(this.btnDigitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MateriaisParaConstrucao.Properties.Resources.cancelar_e_fechar;
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 51);
            this.btnCancelar.Text = "Cancelar e fechar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::MateriaisParaConstrucao.Properties.Resources.remover_item;
            this.btnRemover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 51);
            this.btnRemover.Text = "Remover ítem";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFinalizar.Image = global::MateriaisParaConstrucao.Properties.Resources.finalizar_venda;
            this.btnFinalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(90, 51);
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MateriaisParaConstrucao.Properties.Resources.salvar_e_finalizar;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 51);
            this.btnSalvar.Text = "Salvar e Finalizar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(714, 637);
            this.ControlBox = false;
            this.Controls.Add(this.gbDetalhesVendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblValorSubtotal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgVendas);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.gbItemEmDestaque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.gbDetalhesVendas.ResumeLayout(false);
            this.gbDetalhesVendas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendas)).EndInit();
            this.gbItemEmDestaque.ResumeLayout(false);
            this.gbItemEmDestaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalhesVendas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblUsuário;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDigitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorSubtotal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnRemover;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.DataGridView dtgVendas;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.GroupBox gbItemEmDestaque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DETALHES;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_BARRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        public System.Windows.Forms.TextBox txtCodBarras;
        public System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label2;
    }
}