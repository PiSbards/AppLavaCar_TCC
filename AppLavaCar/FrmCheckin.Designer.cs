namespace AppLavaCar
{
    partial class FrmCheckin
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
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefeitos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flpFotos = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxFoto1 = new System.Windows.Forms.PictureBox();
            this.pbxFoto2 = new System.Windows.Forms.PictureBox();
            this.pbxFoto3 = new System.Windows.Forms.PictureBox();
            this.pbxFoto4 = new System.Windows.Forms.PictureBox();
            this.pbxFoto5 = new System.Windows.Forms.PictureBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSim = new MetroFramework.Controls.MetroCheckBox();
            this.cbxNao = new MetroFramework.Controls.MetroCheckBox();
            this.cbxNao2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbxSim2 = new MetroFramework.Controls.MetroCheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblPlacaCarro = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTipoTratamento = new System.Windows.Forms.Label();
            this.lblAgendamento = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flpFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(913, 735);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 28);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "VOLTAR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(538, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "CLIENTE ESTA CIENTE?";
            // 
            // txtDefeitos
            // 
            this.txtDefeitos.Location = new System.Drawing.Point(540, 258);
            this.txtDefeitos.Multiline = true;
            this.txtDefeitos.Name = "txtDefeitos";
            this.txtDefeitos.Size = new System.Drawing.Size(472, 167);
            this.txtDefeitos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(538, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "DESCRIÇÃO DEFEITOS:";
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(855, 692);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(147, 23);
            this.btnCheckin.TabIndex = 12;
            this.btnCheckin.Text = "EFETUAR CHECK-IN";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(537, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "APRESENTA DEFEITOS?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(537, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DESCRIÇÃO DO CARRO:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.flpFotos);
            this.panel1.Controls.Add(this.btnArquivo);
            this.panel1.Controls.Add(this.txtArquivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 387);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppLavaCar.Properties.Resources.info;
            this.pictureBox2.Location = new System.Drawing.Point(115, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Somente até 5 fotos");
            // 
            // flpFotos
            // 
            this.flpFotos.Controls.Add(this.pbxFoto1);
            this.flpFotos.Controls.Add(this.pbxFoto2);
            this.flpFotos.Controls.Add(this.pbxFoto3);
            this.flpFotos.Controls.Add(this.pbxFoto4);
            this.flpFotos.Controls.Add(this.pbxFoto5);
            this.flpFotos.Location = new System.Drawing.Point(5, 133);
            this.flpFotos.Name = "flpFotos";
            this.flpFotos.Size = new System.Drawing.Size(504, 251);
            this.flpFotos.TabIndex = 8;
            // 
            // pbxFoto1
            // 
            this.pbxFoto1.Location = new System.Drawing.Point(3, 3);
            this.pbxFoto1.Name = "pbxFoto1";
            this.pbxFoto1.Size = new System.Drawing.Size(162, 120);
            this.pbxFoto1.TabIndex = 0;
            this.pbxFoto1.TabStop = false;
            // 
            // pbxFoto2
            // 
            this.pbxFoto2.Location = new System.Drawing.Point(171, 3);
            this.pbxFoto2.Name = "pbxFoto2";
            this.pbxFoto2.Size = new System.Drawing.Size(162, 120);
            this.pbxFoto2.TabIndex = 1;
            this.pbxFoto2.TabStop = false;
            // 
            // pbxFoto3
            // 
            this.pbxFoto3.Location = new System.Drawing.Point(339, 3);
            this.pbxFoto3.Name = "pbxFoto3";
            this.pbxFoto3.Size = new System.Drawing.Size(162, 120);
            this.pbxFoto3.TabIndex = 2;
            this.pbxFoto3.TabStop = false;
            // 
            // pbxFoto4
            // 
            this.pbxFoto4.Location = new System.Drawing.Point(3, 129);
            this.pbxFoto4.Name = "pbxFoto4";
            this.pbxFoto4.Size = new System.Drawing.Size(162, 120);
            this.pbxFoto4.TabIndex = 3;
            this.pbxFoto4.TabStop = false;
            // 
            // pbxFoto5
            // 
            this.pbxFoto5.Location = new System.Drawing.Point(171, 129);
            this.pbxFoto5.Name = "pbxFoto5";
            this.pbxFoto5.Size = new System.Drawing.Size(162, 120);
            this.pbxFoto5.TabIndex = 4;
            this.pbxFoto5.TabStop = false;
            // 
            // btnArquivo
            // 
            this.btnArquivo.BackColor = System.Drawing.Color.Transparent;
            this.btnArquivo.FlatAppearance.BorderSize = 0;
            this.btnArquivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivo.Location = new System.Drawing.Point(342, 37);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(121, 30);
            this.btnArquivo.TabIndex = 7;
            this.btnArquivo.Text = "Selecionar arquivo";
            this.btnArquivo.UseVisualStyleBackColor = false;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(18, 34);
            this.txtArquivo.Multiline = true;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(302, 39);
            this.txtArquivo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FOTOS/ARQUIVO:";
            // 
            // cbxSim
            // 
            this.cbxSim.AutoSize = true;
            this.cbxSim.Location = new System.Drawing.Point(540, 120);
            this.cbxSim.Name = "cbxSim";
            this.cbxSim.Size = new System.Drawing.Size(43, 15);
            this.cbxSim.TabIndex = 23;
            this.cbxSim.Text = "SIM";
            this.cbxSim.UseSelectable = true;
            this.cbxSim.CheckedChanged += new System.EventHandler(this.cbxSim_CheckedChanged);
            // 
            // cbxNao
            // 
            this.cbxNao.AutoSize = true;
            this.cbxNao.Location = new System.Drawing.Point(608, 121);
            this.cbxNao.Name = "cbxNao";
            this.cbxNao.Size = new System.Drawing.Size(49, 15);
            this.cbxNao.TabIndex = 24;
            this.cbxNao.Text = "NÃO";
            this.cbxNao.UseSelectable = true;
            this.cbxNao.CheckedChanged += new System.EventHandler(this.cbxNao_CheckedChanged);
            // 
            // cbxNao2
            // 
            this.cbxNao2.AutoSize = true;
            this.cbxNao2.Location = new System.Drawing.Point(608, 196);
            this.cbxNao2.Name = "cbxNao2";
            this.cbxNao2.Size = new System.Drawing.Size(49, 15);
            this.cbxNao2.TabIndex = 26;
            this.cbxNao2.Text = "NÃO";
            this.cbxNao2.UseSelectable = true;
            this.cbxNao2.CheckedChanged += new System.EventHandler(this.cbxNao2_CheckedChanged);
            // 
            // cbxSim2
            // 
            this.cbxSim2.AutoSize = true;
            this.cbxSim2.Location = new System.Drawing.Point(540, 195);
            this.cbxSim2.Name = "cbxSim2";
            this.cbxSim2.Size = new System.Drawing.Size(43, 15);
            this.cbxSim2.TabIndex = 25;
            this.cbxSim2.Text = "SIM";
            this.cbxSim2.UseSelectable = true;
            this.cbxSim2.CheckedChanged += new System.EventHandler(this.cbxSim2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLavaCar.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(120, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Check-in é utilizado para proteção tanto do automovél quanto da empresa;\r\nENTRETA" +
        "NTO PARA PROSSEGUIR, FOTOS E ARQUIVOS SÃO OPCIONAIS.");
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(10, 456);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(533, 307);
            this.dgvAgenda.TabIndex = 28;
            this.dgvAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgenda_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(567, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "DESCRIÇÃO DO CLIENTE:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Location = new System.Drawing.Point(619, 506);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNomeCliente.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(567, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "NOME:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(567, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "CPF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(567, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "PLACA CARRO:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Location = new System.Drawing.Point(610, 533);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 13);
            this.lblCPF.TabIndex = 34;
            // 
            // lblPlacaCarro
            // 
            this.lblPlacaCarro.AutoSize = true;
            this.lblPlacaCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacaCarro.Location = new System.Drawing.Point(658, 585);
            this.lblPlacaCarro.Name = "lblPlacaCarro";
            this.lblPlacaCarro.Size = new System.Drawing.Size(0, 13);
            this.lblPlacaCarro.TabIndex = 35;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Location = new System.Drawing.Point(639, 561);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(0, 13);
            this.lblTelefone.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(567, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "TELEFONE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(567, 610);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "TIPO TRATAMENTO:";
            // 
            // lblTipoTratamento
            // 
            this.lblTipoTratamento.AutoSize = true;
            this.lblTipoTratamento.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoTratamento.Location = new System.Drawing.Point(686, 610);
            this.lblTipoTratamento.Name = "lblTipoTratamento";
            this.lblTipoTratamento.Size = new System.Drawing.Size(0, 13);
            this.lblTipoTratamento.TabIndex = 39;
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.BackColor = System.Drawing.Color.Transparent;
            this.lblAgendamento.Location = new System.Drawing.Point(667, 638);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(0, 13);
            this.lblAgendamento.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(567, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "AGENDAMENTO:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.ForeColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(873, 479);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 42;
            // 
            // FrmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 772);
            this.ControlBox = false;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAgendamento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTipoTratamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPlacaCarro);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxNao2);
            this.Controls.Add(this.cbxSim2);
            this.Controls.Add(this.cbxNao);
            this.Controls.Add(this.cbxSim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDefeitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Movable = false;
            this.Name = "FrmCheckin";
            this.Resizable = false;
            this.Text = "Check-in";
            this.Load += new System.EventHandler(this.FrmCheckin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flpFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefeitos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFotos;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox cbxSim;
        private MetroFramework.Controls.MetroCheckBox cbxNao;
        private MetroFramework.Controls.MetroCheckBox cbxNao2;
        private MetroFramework.Controls.MetroCheckBox cbxSim2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblPlacaCarro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTipoTratamento;
        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbxFoto1;
        private System.Windows.Forms.PictureBox pbxFoto2;
        private System.Windows.Forms.PictureBox pbxFoto3;
        private System.Windows.Forms.PictureBox pbxFoto4;
        private System.Windows.Forms.PictureBox pbxFoto5;
        private System.Windows.Forms.Label lblID;
    }
}