namespace AppLavaCar
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.GraficoSemana = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GraficoMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MenuBarra = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnCliente1 = new System.Windows.Forms.Button();
            this.btnAgenda1 = new System.Windows.Forms.Button();
            this.btnFunc1 = new System.Windows.Forms.Button();
            this.btnHome1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.MenuConteudo = new System.Windows.Forms.Panel();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnCliente2 = new System.Windows.Forms.Button();
            this.btnAgenda2 = new System.Windows.Forms.Button();
            this.btnFunc2 = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes)).BeginInit();
            this.MenuBarra.SuspendLayout();
            this.MenuConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraficoSemana
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoSemana.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficoSemana.Legends.Add(legend1);
            this.GraficoSemana.Location = new System.Drawing.Point(1214, 516);
            this.GraficoSemana.Name = "GraficoSemana";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraficoSemana.Series.Add(series1);
            this.GraficoSemana.Size = new System.Drawing.Size(300, 300);
            this.GraficoSemana.TabIndex = 0;
            this.GraficoSemana.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1235, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // GraficoMes
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficoMes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficoMes.Legends.Add(legend2);
            this.GraficoMes.Location = new System.Drawing.Point(908, 516);
            this.GraficoMes.Name = "GraficoMes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GraficoMes.Series.Add(series2);
            this.GraficoMes.Size = new System.Drawing.Size(300, 300);
            this.GraficoMes.TabIndex = 2;
            this.GraficoMes.Text = "chart2";
            // 
            // MenuBarra
            // 
            this.MenuBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuBarra.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuBarra.Controls.Add(this.button2);
            this.MenuBarra.Controls.Add(this.btnSair2);
            this.MenuBarra.Controls.Add(this.btnCliente1);
            this.MenuBarra.Controls.Add(this.btnAgenda1);
            this.MenuBarra.Controls.Add(this.btnFunc1);
            this.MenuBarra.Controls.Add(this.btnHome1);
            this.MenuBarra.Controls.Add(this.btnMenu);
            this.MenuBarra.Location = new System.Drawing.Point(0, 5);
            this.MenuBarra.Name = "MenuBarra";
            this.MenuBarra.Size = new System.Drawing.Size(56, 818);
            this.MenuBarra.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::AppLavaCar.Properties.Resources.check_in;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(4, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 44);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair2
            // 
            this.btnSair2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair2.BackColor = System.Drawing.Color.Transparent;
            this.btnSair2.BackgroundImage = global::AppLavaCar.Properties.Resources.sair__2_;
            this.btnSair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair2.FlatAppearance.BorderSize = 0;
            this.btnSair2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair2.ForeColor = System.Drawing.Color.Snow;
            this.btnSair2.Location = new System.Drawing.Point(4, 760);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(45, 44);
            this.btnSair2.TabIndex = 6;
            this.btnSair2.UseVisualStyleBackColor = false;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // btnCliente1
            // 
            this.btnCliente1.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente1.BackgroundImage = global::AppLavaCar.Properties.Resources.cliente;
            this.btnCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente1.FlatAppearance.BorderSize = 0;
            this.btnCliente1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCliente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente1.Location = new System.Drawing.Point(4, 296);
            this.btnCliente1.Name = "btnCliente1";
            this.btnCliente1.Size = new System.Drawing.Size(45, 44);
            this.btnCliente1.TabIndex = 4;
            this.btnCliente1.UseVisualStyleBackColor = false;
            this.btnCliente1.Click += new System.EventHandler(this.btnCliente1_Click);
            // 
            // btnAgenda1
            // 
            this.btnAgenda1.BackColor = System.Drawing.Color.Transparent;
            this.btnAgenda1.BackgroundImage = global::AppLavaCar.Properties.Resources.Agenda;
            this.btnAgenda1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgenda1.FlatAppearance.BorderSize = 0;
            this.btnAgenda1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgenda1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda1.Location = new System.Drawing.Point(4, 237);
            this.btnAgenda1.Name = "btnAgenda1";
            this.btnAgenda1.Size = new System.Drawing.Size(45, 44);
            this.btnAgenda1.TabIndex = 3;
            this.btnAgenda1.UseVisualStyleBackColor = false;
            this.btnAgenda1.Click += new System.EventHandler(this.btnAgenda1_Click);
            // 
            // btnFunc1
            // 
            this.btnFunc1.BackColor = System.Drawing.Color.Transparent;
            this.btnFunc1.BackgroundImage = global::AppLavaCar.Properties.Resources.funcionario;
            this.btnFunc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFunc1.FlatAppearance.BorderSize = 0;
            this.btnFunc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFunc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc1.Location = new System.Drawing.Point(4, 176);
            this.btnFunc1.Name = "btnFunc1";
            this.btnFunc1.Size = new System.Drawing.Size(45, 44);
            this.btnFunc1.TabIndex = 2;
            this.btnFunc1.UseVisualStyleBackColor = false;
            this.btnFunc1.Click += new System.EventHandler(this.btnFunc1_Click);
            // 
            // btnHome1
            // 
            this.btnHome1.BackColor = System.Drawing.Color.Transparent;
            this.btnHome1.BackgroundImage = global::AppLavaCar.Properties.Resources.home;
            this.btnHome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome1.FlatAppearance.BorderSize = 0;
            this.btnHome1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnHome1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome1.Location = new System.Drawing.Point(4, 116);
            this.btnHome1.Name = "btnHome1";
            this.btnHome1.Size = new System.Drawing.Size(45, 44);
            this.btnHome1.TabIndex = 1;
            this.btnHome1.UseVisualStyleBackColor = false;
            this.btnHome1.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 44);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuConteudo
            // 
            this.MenuConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuConteudo.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuConteudo.Controls.Add(this.btnCheckin);
            this.MenuConteudo.Controls.Add(this.label3);
            this.MenuConteudo.Controls.Add(this.btnSair1);
            this.MenuConteudo.Controls.Add(this.btnCliente2);
            this.MenuConteudo.Controls.Add(this.btnAgenda2);
            this.MenuConteudo.Controls.Add(this.btnFunc2);
            this.MenuConteudo.Controls.Add(this.btnHome2);
            this.MenuConteudo.Location = new System.Drawing.Point(55, 5);
            this.MenuConteudo.Name = "MenuConteudo";
            this.MenuConteudo.Size = new System.Drawing.Size(200, 818);
            this.MenuConteudo.TabIndex = 5;
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.White;
            this.btnCheckin.Location = new System.Drawing.Point(7, 355);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(190, 44);
            this.btnCheckin.TabIndex = 13;
            this.btnCheckin.Text = "CHECK-IN";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "BEM-VINDO";
            // 
            // btnSair1
            // 
            this.btnSair1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSair1.FlatAppearance.BorderSize = 0;
            this.btnSair1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.ForeColor = System.Drawing.Color.White;
            this.btnSair1.Location = new System.Drawing.Point(7, 760);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(190, 44);
            this.btnSair1.TabIndex = 11;
            this.btnSair1.Text = "LOG OFF";
            this.btnSair1.UseVisualStyleBackColor = false;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnCliente2
            // 
            this.btnCliente2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCliente2.FlatAppearance.BorderSize = 0;
            this.btnCliente2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCliente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente2.ForeColor = System.Drawing.Color.White;
            this.btnCliente2.Location = new System.Drawing.Point(7, 296);
            this.btnCliente2.Name = "btnCliente2";
            this.btnCliente2.Size = new System.Drawing.Size(190, 44);
            this.btnCliente2.TabIndex = 10;
            this.btnCliente2.Text = "CLIENTES";
            this.btnCliente2.UseVisualStyleBackColor = false;
            this.btnCliente2.Click += new System.EventHandler(this.btnCliente2_Click);
            // 
            // btnAgenda2
            // 
            this.btnAgenda2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgenda2.FlatAppearance.BorderSize = 0;
            this.btnAgenda2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgenda2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda2.ForeColor = System.Drawing.Color.White;
            this.btnAgenda2.Location = new System.Drawing.Point(10, 237);
            this.btnAgenda2.Name = "btnAgenda2";
            this.btnAgenda2.Size = new System.Drawing.Size(190, 44);
            this.btnAgenda2.TabIndex = 9;
            this.btnAgenda2.Text = "AGENDA";
            this.btnAgenda2.UseVisualStyleBackColor = false;
            this.btnAgenda2.Click += new System.EventHandler(this.btnAgenda2_Click);
            // 
            // btnFunc2
            // 
            this.btnFunc2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFunc2.FlatAppearance.BorderSize = 0;
            this.btnFunc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFunc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc2.ForeColor = System.Drawing.Color.White;
            this.btnFunc2.Location = new System.Drawing.Point(7, 176);
            this.btnFunc2.Name = "btnFunc2";
            this.btnFunc2.Size = new System.Drawing.Size(190, 44);
            this.btnFunc2.TabIndex = 8;
            this.btnFunc2.Text = "FUNCIONÁRIOS";
            this.btnFunc2.UseVisualStyleBackColor = false;
            this.btnFunc2.Click += new System.EventHandler(this.btnFunc2_Click);
            // 
            // btnHome2
            // 
            this.btnHome2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome2.FlatAppearance.BorderSize = 0;
            this.btnHome2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnHome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome2.ForeColor = System.Drawing.Color.White;
            this.btnHome2.Location = new System.Drawing.Point(7, 116);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(190, 44);
            this.btnHome2.TabIndex = 7;
            this.btnHome2.Text = "HOME";
            this.btnHome2.UseVisualStyleBackColor = false;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 821);
            this.ControlBox = false;
            this.Controls.Add(this.MenuConteudo);
            this.Controls.Add(this.MenuBarra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GraficoMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GraficoSemana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Movable = false;
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 40);
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraficoSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes)).EndInit();
            this.MenuBarra.ResumeLayout(false);
            this.MenuConteudo.ResumeLayout(false);
            this.MenuConteudo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoMes;
        private System.Windows.Forms.Panel MenuBarra;
        private System.Windows.Forms.Button btnFunc1;
        private System.Windows.Forms.Button btnHome1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel MenuConteudo;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnCliente1;
        private System.Windows.Forms.Button btnAgenda1;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnCliente2;
        private System.Windows.Forms.Button btnAgenda2;
        private System.Windows.Forms.Button btnFunc2;
        private System.Windows.Forms.Button btnHome2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheckin;
    }
}