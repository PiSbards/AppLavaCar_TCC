﻿namespace AppLavaCar
{
    partial class FrmAgenda
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboHoraAgenda = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbxCNPJ = new MetroFramework.Controls.MetroCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.Calendario.Location = new System.Drawing.Point(9, 55);
            this.Calendario.Name = "Calendario";
            this.Calendario.ShowToday = false;
            this.Calendario.TabIndex = 0;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(248, 78);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(518, 413);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblData);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.mtxtTelefone);
            this.metroTabPage1.Controls.Add(this.btnAgendar);
            this.metroTabPage1.Controls.Add(this.mtxtCPF);
            this.metroTabPage1.Controls.Add(this.cboHoraAgenda);
            this.metroTabPage1.Controls.Add(this.label8);
            this.metroTabPage1.Controls.Add(this.cbxTipo);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.chbxCNPJ);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.btnReiniciar);
            this.metroTabPage1.Controls.Add(this.txtModelo);
            this.metroTabPage1.Controls.Add(this.txtMarca);
            this.metroTabPage1.Controls.Add(this.txtPlaca);
            this.metroTabPage1.Controls.Add(this.txtNome);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.lblCPF);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(510, 371);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Agendar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(289, 242);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 16);
            this.lblData.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Data:";
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(298, 10);
            this.mtxtTelefone.Mask = "(99)9 9999-9999";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(129, 20);
            this.mtxtTelefone.TabIndex = 45;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(324, 338);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(83, 23);
            this.btnAgendar.TabIndex = 44;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(74, 42);
            this.mtxtCPF.Mask = "999.999.999-99";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(148, 20);
            this.mtxtCPF.TabIndex = 43;
            // 
            // cboHoraAgenda
            // 
            this.cboHoraAgenda.CustomFormat = "h:mm tt";
            this.cboHoraAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cboHoraAgenda.Location = new System.Drawing.Point(361, 277);
            this.cboHoraAgenda.Name = "cboHoraAgenda";
            this.cboHoraAgenda.ShowUpDown = true;
            this.cboHoraAgenda.Size = new System.Drawing.Size(105, 20);
            this.cboHoraAgenda.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Hora Agendamento:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(331, 179);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tipo Lavagem:";
            // 
            // chbxCNPJ
            // 
            this.chbxCNPJ.AutoSize = true;
            this.chbxCNPJ.Location = new System.Drawing.Point(74, 73);
            this.chbxCNPJ.Name = "chbxCNPJ";
            this.chbxCNPJ.Size = new System.Drawing.Size(50, 15);
            this.chbxCNPJ.TabIndex = 38;
            this.chbxCNPJ.Text = "CNPJ";
            this.chbxCNPJ.UseSelectable = true;
            this.chbxCNPJ.CheckedChanged += new System.EventHandler(this.chbxCNPJ_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Telefone:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(413, 338);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(83, 23);
            this.btnReiniciar.TabIndex = 36;
            this.btnReiniciar.Text = "REINICIAR";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(74, 176);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(96, 20);
            this.txtModelo.TabIndex = 35;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(74, 139);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(96, 20);
            this.txtMarca.TabIndex = 34;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(74, 102);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(96, 20);
            this.txtPlaca.TabIndex = 33;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(119, 20);
            this.txtNome.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Placa:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(14, 47);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(36, 16);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cliente:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Crimson;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1028, 483);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(768, 78);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.Size = new System.Drawing.Size(343, 394);
            this.dgvAgenda.TabIndex = 19;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 515);
            this.ControlBox = false;
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Calendario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmAgenda";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 40);
            this.Resizable = false;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.DateTimePicker cboHoraAgenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroCheckBox chbxCNPJ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label1;
    }
}