namespace AppLavaCar
{
    partial class FrmCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.chbxCNPJ = new MetroFramework.Controls.MetroCheckBox();
            this.tcControl = new MetroFramework.Controls.MetroTabControl();
            this.tpCliente = new MetroFramework.Controls.MetroTabPage();
            this.tpCarro = new MetroFramework.Controls.MetroTabPage();
            this.chbxCnpjCarro = new MetroFramework.Controls.MetroCheckBox();
            this.mktCpfDono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCpfCarro = new System.Windows.Forms.Label();
            this.txtNomeDono = new System.Windows.Forms.TextBox();
            this.dgvCarro = new System.Windows.Forms.DataGridView();
            this.btnLocalizarCarro = new System.Windows.Forms.Button();
            this.btnEditarCarro = new System.Windows.Forms.Button();
            this.btnExcluirCarro = new System.Windows.Forms.Button();
            this.lblIdCarro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tcControl.SuspendLayout();
            this.tpCliente.SuspendLayout();
            this.tpCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(4, 189);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(523, 209);
            this.dgvCliente.TabIndex = 28;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Crimson;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(395, 463);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(134, 32);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "VOLTAR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "MARCA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "MODELO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "PLACA:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(3, 34);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(164, 20);
            this.txtPlaca.TabIndex = 58;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(3, 167);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(164, 20);
            this.txtModelo.TabIndex = 57;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(208, 167);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(127, 20);
            this.txtMarca.TabIndex = 62;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(386, 136);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(138, 47);
            this.btnExcluir.TabIndex = 58;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightGray;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(386, 82);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 47);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "NOME:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizar.BackgroundImage = global::AppLavaCar.Properties.Resources.lupa;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(173, 49);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(44, 44);
            this.btnLocalizar.TabIndex = 69;
            this.btnLocalizar.UseVisualStyleBackColor = false;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(127, 20);
            this.txtNome.TabIndex = 64;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(0, 43);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 16);
            this.lblCpf.TabIndex = 65;
            this.lblCpf.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "TELEFONE:";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(3, 63);
            this.mtxtCpf.Mask = "999,999,999-99";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(164, 20);
            this.mtxtCpf.TabIndex = 67;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(3, 163);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(164, 20);
            this.txtTelefone.TabIndex = 68;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Location = new System.Drawing.Point(17, 464);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 16);
            this.lblIdCliente.TabIndex = 70;
            // 
            // chbxCNPJ
            // 
            this.chbxCNPJ.AutoSize = true;
            this.chbxCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.chbxCNPJ.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbxCNPJ.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chbxCNPJ.Location = new System.Drawing.Point(4, 12);
            this.chbxCNPJ.Name = "chbxCNPJ";
            this.chbxCNPJ.Size = new System.Drawing.Size(59, 19);
            this.chbxCNPJ.TabIndex = 71;
            this.chbxCNPJ.Text = "CNPJ";
            this.chbxCNPJ.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbxCNPJ.UseSelectable = true;
            this.chbxCNPJ.CheckedChanged += new System.EventHandler(this.chbxCNPJ_CheckedChanged);
            // 
            // tcControl
            // 
            this.tcControl.Controls.Add(this.tpCliente);
            this.tcControl.Controls.Add(this.tpCarro);
            this.tcControl.Location = new System.Drawing.Point(3, 14);
            this.tcControl.Name = "tcControl";
            this.tcControl.SelectedIndex = 1;
            this.tcControl.Size = new System.Drawing.Size(535, 443);
            this.tcControl.TabIndex = 72;
            this.tcControl.UseSelectable = true;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.btnEditar);
            this.tpCliente.Controls.Add(this.dgvCliente);
            this.tpCliente.Controls.Add(this.btnExcluir);
            this.tpCliente.Controls.Add(this.chbxCNPJ);
            this.tpCliente.Controls.Add(this.mtxtCpf);
            this.tpCliente.Controls.Add(this.label1);
            this.tpCliente.Controls.Add(this.txtTelefone);
            this.tpCliente.Controls.Add(this.btnLocalizar);
            this.tpCliente.Controls.Add(this.label4);
            this.tpCliente.Controls.Add(this.txtNome);
            this.tpCliente.Controls.Add(this.lblCpf);
            this.tpCliente.HorizontalScrollbarBarColor = true;
            this.tpCliente.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCliente.HorizontalScrollbarSize = 10;
            this.tpCliente.Location = new System.Drawing.Point(4, 38);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Size = new System.Drawing.Size(527, 401);
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "Cliente";
            this.tpCliente.VerticalScrollbarBarColor = true;
            this.tpCliente.VerticalScrollbarHighlightOnWheel = false;
            this.tpCliente.VerticalScrollbarSize = 10;
            // 
            // tpCarro
            // 
            this.tpCarro.Controls.Add(this.chbxCnpjCarro);
            this.tpCarro.Controls.Add(this.mktCpfDono);
            this.tpCarro.Controls.Add(this.label2);
            this.tpCarro.Controls.Add(this.lblCpfCarro);
            this.tpCarro.Controls.Add(this.txtNomeDono);
            this.tpCarro.Controls.Add(this.dgvCarro);
            this.tpCarro.Controls.Add(this.btnLocalizarCarro);
            this.tpCarro.Controls.Add(this.btnEditarCarro);
            this.tpCarro.Controls.Add(this.btnExcluirCarro);
            this.tpCarro.Controls.Add(this.txtMarca);
            this.tpCarro.Controls.Add(this.txtPlaca);
            this.tpCarro.Controls.Add(this.label10);
            this.tpCarro.Controls.Add(this.label9);
            this.tpCarro.Controls.Add(this.label8);
            this.tpCarro.Controls.Add(this.txtModelo);
            this.tpCarro.HorizontalScrollbarBarColor = true;
            this.tpCarro.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCarro.HorizontalScrollbarSize = 10;
            this.tpCarro.Location = new System.Drawing.Point(4, 38);
            this.tpCarro.Name = "tpCarro";
            this.tpCarro.Size = new System.Drawing.Size(527, 401);
            this.tpCarro.TabIndex = 1;
            this.tpCarro.Text = "Carro";
            this.tpCarro.VerticalScrollbarBarColor = true;
            this.tpCarro.VerticalScrollbarHighlightOnWheel = false;
            this.tpCarro.VerticalScrollbarSize = 10;
            // 
            // chbxCnpjCarro
            // 
            this.chbxCnpjCarro.AutoSize = true;
            this.chbxCnpjCarro.BackColor = System.Drawing.Color.Transparent;
            this.chbxCnpjCarro.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbxCnpjCarro.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chbxCnpjCarro.Location = new System.Drawing.Point(299, 77);
            this.chbxCnpjCarro.Name = "chbxCnpjCarro";
            this.chbxCnpjCarro.Size = new System.Drawing.Size(59, 19);
            this.chbxCnpjCarro.TabIndex = 75;
            this.chbxCnpjCarro.Text = "CNPJ";
            this.chbxCnpjCarro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chbxCnpjCarro.UseSelectable = true;
            this.chbxCnpjCarro.CheckedChanged += new System.EventHandler(this.chbxCnpjCarro_CheckedChanged);
            // 
            // mktCpfDono
            // 
            this.mktCpfDono.Location = new System.Drawing.Point(208, 98);
            this.mktCpfDono.Mask = "999,999,999-99";
            this.mktCpfDono.Name = "mktCpfDono";
            this.mktCpfDono.Size = new System.Drawing.Size(127, 20);
            this.mktCpfDono.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "NOME DONO:";
            // 
            // lblCpfCarro
            // 
            this.lblCpfCarro.AutoSize = true;
            this.lblCpfCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblCpfCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCarro.Location = new System.Drawing.Point(205, 80);
            this.lblCpfCarro.Name = "lblCpfCarro";
            this.lblCpfCarro.Size = new System.Drawing.Size(88, 16);
            this.lblCpfCarro.TabIndex = 71;
            this.lblCpfCarro.Text = "CPF DONO:";
            // 
            // txtNomeDono
            // 
            this.txtNomeDono.Location = new System.Drawing.Point(3, 99);
            this.txtNomeDono.Name = "txtNomeDono";
            this.txtNomeDono.Size = new System.Drawing.Size(164, 20);
            this.txtNomeDono.TabIndex = 73;
            // 
            // dgvCarro
            // 
            this.dgvCarro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.Location = new System.Drawing.Point(3, 193);
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.ReadOnly = true;
            this.dgvCarro.Size = new System.Drawing.Size(521, 208);
            this.dgvCarro.TabIndex = 63;
            this.dgvCarro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarro_CellClick);
            // 
            // btnLocalizarCarro
            // 
            this.btnLocalizarCarro.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalizarCarro.BackgroundImage = global::AppLavaCar.Properties.Resources.lupa;
            this.btnLocalizarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalizarCarro.FlatAppearance.BorderSize = 0;
            this.btnLocalizarCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLocalizarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCarro.Location = new System.Drawing.Point(173, 20);
            this.btnLocalizarCarro.Name = "btnLocalizarCarro";
            this.btnLocalizarCarro.Size = new System.Drawing.Size(44, 44);
            this.btnLocalizarCarro.TabIndex = 70;
            this.btnLocalizarCarro.UseVisualStyleBackColor = false;
            this.btnLocalizarCarro.Click += new System.EventHandler(this.btnLocalizarCarro_Click);
            // 
            // btnEditarCarro
            // 
            this.btnEditarCarro.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarCarro.FlatAppearance.BorderSize = 0;
            this.btnEditarCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnEditarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCarro.Location = new System.Drawing.Point(384, 84);
            this.btnEditarCarro.Name = "btnEditarCarro";
            this.btnEditarCarro.Size = new System.Drawing.Size(138, 47);
            this.btnEditarCarro.TabIndex = 64;
            this.btnEditarCarro.Text = "EDITAR";
            this.btnEditarCarro.UseVisualStyleBackColor = false;
            this.btnEditarCarro.Click += new System.EventHandler(this.btnEditarCarro_Click);
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluirCarro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnExcluirCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCarro.Location = new System.Drawing.Point(384, 140);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(138, 47);
            this.btnExcluirCarro.TabIndex = 65;
            this.btnExcluirCarro.Text = "EXCLUIR";
            this.btnExcluirCarro.UseVisualStyleBackColor = false;
            this.btnExcluirCarro.Click += new System.EventHandler(this.btnExcluirCarro_Click);
            // 
            // lblIdCarro
            // 
            this.lblIdCarro.AutoSize = true;
            this.lblIdCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCarro.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdCarro.Location = new System.Drawing.Point(126, 460);
            this.lblIdCarro.Name = "lblIdCarro";
            this.lblIdCarro.Size = new System.Drawing.Size(0, 16);
            this.lblIdCarro.TabIndex = 73;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 503);
            this.Controls.Add(this.lblIdCarro);
            this.Controls.Add(this.tcControl);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblIdCliente);
            this.Movable = false;
            this.Name = "FrmCliente";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 40);
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tcControl.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            this.tpCarro.ResumeLayout(false);
            this.tpCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblIdCliente;
        private MetroFramework.Controls.MetroCheckBox chbxCNPJ;
        private MetroFramework.Controls.MetroTabControl tcControl;
        private MetroFramework.Controls.MetroTabPage tpCliente;
        private MetroFramework.Controls.MetroTabPage tpCarro;
        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.MaskedTextBox mktCpfDono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCpfCarro;
        private System.Windows.Forms.TextBox txtNomeDono;
        private System.Windows.Forms.Button btnLocalizarCarro;
        private System.Windows.Forms.Button btnEditarCarro;
        private System.Windows.Forms.Button btnExcluirCarro;
        private System.Windows.Forms.Label lblIdCarro;
        private MetroFramework.Controls.MetroCheckBox chbxCnpjCarro;
    }
}