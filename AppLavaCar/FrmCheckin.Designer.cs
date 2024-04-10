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
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDefeitos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpFotos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSim = new MetroFramework.Controls.MetroCheckBox();
            this.cbxNao = new MetroFramework.Controls.MetroCheckBox();
            this.cbxNao2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbxSim2 = new MetroFramework.Controls.MetroCheckBox();
            this.panel1.SuspendLayout();
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
            this.btnSair.Location = new System.Drawing.Point(908, 598);
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
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "QUAIS:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(850, 445);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "EFETUAR CHECK-IN";
            this.button3.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.flpFotos);
            this.panel1.Controls.Add(this.btnArquivo);
            this.panel1.Controls.Add(this.txtArquivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 573);
            this.panel1.TabIndex = 22;
            // 
            // flpFotos
            // 
            this.flpFotos.Location = new System.Drawing.Point(5, 133);
            this.flpFotos.Name = "flpFotos";
            this.flpFotos.Size = new System.Drawing.Size(504, 433);
            this.flpFotos.TabIndex = 8;
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
            // FrmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 649);
            this.ControlBox = false;
            this.Controls.Add(this.cbxNao2);
            this.Controls.Add(this.cbxSim2);
            this.Controls.Add(this.cbxNao);
            this.Controls.Add(this.cbxSim);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDefeitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDefeitos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
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
    }
}