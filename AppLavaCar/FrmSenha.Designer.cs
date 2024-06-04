namespace AppLavaCar
{
    partial class FrmSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário(CPF)";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(112, 210);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(198, 20);
            this.txtSenha1.TabIndex = 3;
            this.txtSenha1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOVA SENHA:";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(112, 252);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(198, 20);
            this.txtSenha2.TabIndex = 5;
            this.txtSenha2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONFIRME SENHA:";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(112, 166);
            this.mtxtCpf.Mask = "999,999,999-99";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(198, 20);
            this.mtxtCpf.TabIndex = 6;
            // 
            // btnMudar
            // 
            this.btnMudar.BackColor = System.Drawing.Color.Transparent;
            this.btnMudar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnMudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(77, 311);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(92, 46);
            this.btnMudar.TabIndex = 7;
            this.btnMudar.Text = "MUDAR SENHA";
            this.btnMudar.UseVisualStyleBackColor = false;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Red;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(240, 311);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 46);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 423);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Movable = false;
            this.Name = "FrmSenha";
            this.Resizable = false;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Button btnMudar;
        private System.Windows.Forms.Button btnVoltar;
    }
}