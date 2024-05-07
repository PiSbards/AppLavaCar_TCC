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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.GraficoSemana = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficoMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MenuBarra = new System.Windows.Forms.Panel();
            this.btnCheckOut2 = new System.Windows.Forms.Button();
            this.btnCheckin2 = new System.Windows.Forms.Button();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnCliente1 = new System.Windows.Forms.Button();
            this.btnAgenda1 = new System.Windows.Forms.Button();
            this.btnFunc1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.MenuConteudo = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAgenda2 = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnCliente2 = new System.Windows.Forms.Button();
            this.btnFunc2 = new System.Windows.Forms.Button();
            this.PTimer = new System.Windows.Forms.Panel();
            this.lblAgendamento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTempoEstimado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTipoTratamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.lblChefe = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvAgendaDoDia = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAgendamentoDia = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes)).BeginInit();
            this.MenuBarra.SuspendLayout();
            this.MenuConteudo.SuspendLayout();
            this.PTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoDia)).BeginInit();
            this.SuspendLayout();
            // 
            // GraficoSemana
            // 
            this.GraficoSemana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.GraficoSemana.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.GraficoSemana.Legends.Add(legend7);
            this.GraficoSemana.Location = new System.Drawing.Point(836, 509);
            this.GraficoSemana.Name = "GraficoSemana";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.GraficoSemana.Series.Add(series7);
            this.GraficoSemana.Size = new System.Drawing.Size(300, 300);
            this.GraficoSemana.TabIndex = 0;
            this.GraficoSemana.Text = "Carros Semanais";
            // 
            // GraficoMes
            // 
            this.GraficoMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.GraficoMes.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.GraficoMes.Legends.Add(legend8);
            this.GraficoMes.Location = new System.Drawing.Point(1180, 509);
            this.GraficoMes.Name = "GraficoMes";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.GraficoMes.Series.Add(series8);
            this.GraficoMes.Size = new System.Drawing.Size(300, 300);
            this.GraficoMes.TabIndex = 2;
            this.GraficoMes.Text = "chart2";
            // 
            // MenuBarra
            // 
            this.MenuBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuBarra.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuBarra.Controls.Add(this.btnCheckOut2);
            this.MenuBarra.Controls.Add(this.btnCheckin2);
            this.MenuBarra.Controls.Add(this.btnSair2);
            this.MenuBarra.Controls.Add(this.btnCliente1);
            this.MenuBarra.Controls.Add(this.btnAgenda1);
            this.MenuBarra.Controls.Add(this.btnFunc1);
            this.MenuBarra.Controls.Add(this.btnMenu);
            this.MenuBarra.Location = new System.Drawing.Point(0, 5);
            this.MenuBarra.Name = "MenuBarra";
            this.MenuBarra.Size = new System.Drawing.Size(56, 818);
            this.MenuBarra.TabIndex = 4;
            // 
            // btnCheckOut2
            // 
            this.btnCheckOut2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut2.BackgroundImage = global::AppLavaCar.Properties.Resources.aceitaram;
            this.btnCheckOut2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut2.FlatAppearance.BorderSize = 0;
            this.btnCheckOut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut2.Location = new System.Drawing.Point(4, 347);
            this.btnCheckOut2.Name = "btnCheckOut2";
            this.btnCheckOut2.Size = new System.Drawing.Size(45, 46);
            this.btnCheckOut2.TabIndex = 9;
            this.btnCheckOut2.UseVisualStyleBackColor = false;
            this.btnCheckOut2.Click += new System.EventHandler(this.btnCheckOut2_Click);
            // 
            // btnCheckin2
            // 
            this.btnCheckin2.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckin2.BackgroundImage = global::AppLavaCar.Properties.Resources.check_in;
            this.btnCheckin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckin2.FlatAppearance.BorderSize = 0;
            this.btnCheckin2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin2.Location = new System.Drawing.Point(4, 287);
            this.btnCheckin2.Name = "btnCheckin2";
            this.btnCheckin2.Size = new System.Drawing.Size(45, 44);
            this.btnCheckin2.TabIndex = 8;
            this.btnCheckin2.UseVisualStyleBackColor = false;
            this.btnCheckin2.Click += new System.EventHandler(this.btnCheckin2_Click);
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
            this.btnCliente1.Location = new System.Drawing.Point(4, 228);
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
            this.btnAgenda1.Location = new System.Drawing.Point(4, 169);
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
            this.btnFunc1.Location = new System.Drawing.Point(4, 108);
            this.btnFunc1.Name = "btnFunc1";
            this.btnFunc1.Size = new System.Drawing.Size(45, 44);
            this.btnFunc1.TabIndex = 2;
            this.btnFunc1.UseVisualStyleBackColor = false;
            this.btnFunc1.Click += new System.EventHandler(this.btnFunc1_Click);
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
            this.MenuConteudo.Controls.Add(this.btnCheckOut);
            this.MenuConteudo.Controls.Add(this.btnAgenda2);
            this.MenuConteudo.Controls.Add(this.btnCheckin);
            this.MenuConteudo.Controls.Add(this.label3);
            this.MenuConteudo.Controls.Add(this.btnSair1);
            this.MenuConteudo.Controls.Add(this.btnCliente2);
            this.MenuConteudo.Controls.Add(this.btnFunc2);
            this.MenuConteudo.Location = new System.Drawing.Point(55, 5);
            this.MenuConteudo.Name = "MenuConteudo";
            this.MenuConteudo.Size = new System.Drawing.Size(200, 818);
            this.MenuConteudo.TabIndex = 5;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(4, 349);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(190, 44);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "DEVOLUÇÃO DE CARRO";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAgenda2
            // 
            this.btnAgenda2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgenda2.FlatAppearance.BorderSize = 0;
            this.btnAgenda2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgenda2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda2.ForeColor = System.Drawing.Color.White;
            this.btnAgenda2.Location = new System.Drawing.Point(7, 169);
            this.btnAgenda2.Name = "btnAgenda2";
            this.btnAgenda2.Size = new System.Drawing.Size(190, 44);
            this.btnAgenda2.TabIndex = 9;
            this.btnAgenda2.Text = "AGENDA";
            this.btnAgenda2.UseVisualStyleBackColor = false;
            this.btnAgenda2.Click += new System.EventHandler(this.btnAgenda2_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.Color.White;
            this.btnCheckin.Location = new System.Drawing.Point(4, 287);
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
            this.btnCliente2.Location = new System.Drawing.Point(4, 228);
            this.btnCliente2.Name = "btnCliente2";
            this.btnCliente2.Size = new System.Drawing.Size(190, 44);
            this.btnCliente2.TabIndex = 10;
            this.btnCliente2.Text = "CLIENTES";
            this.btnCliente2.UseVisualStyleBackColor = false;
            this.btnCliente2.Click += new System.EventHandler(this.btnCliente2_Click);
            // 
            // btnFunc2
            // 
            this.btnFunc2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFunc2.FlatAppearance.BorderSize = 0;
            this.btnFunc2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFunc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc2.ForeColor = System.Drawing.Color.White;
            this.btnFunc2.Location = new System.Drawing.Point(4, 108);
            this.btnFunc2.Name = "btnFunc2";
            this.btnFunc2.Size = new System.Drawing.Size(190, 44);
            this.btnFunc2.TabIndex = 8;
            this.btnFunc2.Text = "FUNCIONÁRIOS";
            this.btnFunc2.UseVisualStyleBackColor = false;
            this.btnFunc2.Click += new System.EventHandler(this.btnFunc2_Click);
            // 
            // PTimer
            // 
            this.PTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PTimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PTimer.Controls.Add(this.lblAgendamento);
            this.PTimer.Controls.Add(this.label8);
            this.PTimer.Controls.Add(this.lblTimer);
            this.PTimer.Controls.Add(this.lblMarca);
            this.PTimer.Controls.Add(this.lblTempoEstimado);
            this.PTimer.Controls.Add(this.label9);
            this.PTimer.Controls.Add(this.lblTipoTratamento);
            this.PTimer.Controls.Add(this.label1);
            this.PTimer.Controls.Add(this.btnLimpar);
            this.PTimer.Controls.Add(this.lblNomeCliente);
            this.PTimer.Controls.Add(this.lblPlaca);
            this.PTimer.Controls.Add(this.lblModelo);
            this.PTimer.Controls.Add(this.btnTimer);
            this.PTimer.Controls.Add(this.label7);
            this.PTimer.Controls.Add(this.label6);
            this.PTimer.Controls.Add(this.label5);
            this.PTimer.Controls.Add(this.label4);
            this.PTimer.Location = new System.Drawing.Point(493, 108);
            this.PTimer.Name = "PTimer";
            this.PTimer.Size = new System.Drawing.Size(560, 259);
            this.PTimer.TabIndex = 6;
            // 
            // lblAgendamento
            // 
            this.lblAgendamento.AutoSize = true;
            this.lblAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamento.Location = new System.Drawing.Point(350, 171);
            this.lblAgendamento.Name = "lblAgendamento";
            this.lblAgendamento.Size = new System.Drawing.Size(0, 16);
            this.lblAgendamento.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "AGENDAMENTO:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(17, 88);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 16);
            this.lblTimer.TabIndex = 46;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(240, 88);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 16);
            this.lblMarca.TabIndex = 45;
            // 
            // lblTempoEstimado
            // 
            this.lblTempoEstimado.AutoSize = true;
            this.lblTempoEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoEstimado.Location = new System.Drawing.Point(350, 221);
            this.lblTempoEstimado.Name = "lblTempoEstimado";
            this.lblTempoEstimado.Size = new System.Drawing.Size(0, 16);
            this.lblTempoEstimado.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "TEMPO ESTIMADO:";
            // 
            // lblTipoTratamento
            // 
            this.lblTipoTratamento.AutoSize = true;
            this.lblTipoTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTratamento.Location = new System.Drawing.Point(130, 168);
            this.lblTipoTratamento.Name = "lblTipoTratamento";
            this.lblTipoTratamento.Size = new System.Drawing.Size(0, 16);
            this.lblTipoTratamento.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "TRATAMENTO:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(6, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 30);
            this.btnLimpar.TabIndex = 39;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(459, 88);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 16);
            this.lblNomeCliente.TabIndex = 32;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(340, 88);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(0, 16);
            this.lblPlaca.TabIndex = 25;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(170, 88);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 16);
            this.lblModelo.TabIndex = 18;
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.Location = new System.Drawing.Point(16, 139);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(66, 30);
            this.btnTimer.TabIndex = 11;
            this.btnTimer.Text = "INICIAR";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "CLIENTE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "PLACA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "CARRO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "TIMER:";
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Location = new System.Drawing.Point(83, 108);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.ReadOnly = true;
            this.dgvAgendamento.Size = new System.Drawing.Size(404, 340);
            this.dgvAgendamento.TabIndex = 7;
            this.dgvAgendamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgendamento_CellClick);
            // 
            // lblChefe
            // 
            this.lblChefe.AutoSize = true;
            this.lblChefe.BackColor = System.Drawing.Color.Transparent;
            this.lblChefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefe.ForeColor = System.Drawing.Color.Transparent;
            this.lblChefe.Location = new System.Drawing.Point(1464, 793);
            this.lblChefe.Name = "lblChefe";
            this.lblChefe.Size = new System.Drawing.Size(0, 16);
            this.lblChefe.TabIndex = 44;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvAgendaDoDia
            // 
            this.dgvAgendaDoDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgendaDoDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaDoDia.Location = new System.Drawing.Point(83, 480);
            this.dgvAgendaDoDia.Name = "dgvAgendaDoDia";
            this.dgvAgendaDoDia.ReadOnly = true;
            this.dgvAgendaDoDia.Size = new System.Drawing.Size(404, 340);
            this.dgvAgendaDoDia.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "AGENDAMENTOS NO DIA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "CARROS NA LOJA";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(80, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 24);
            this.lblData.TabIndex = 52;
            // 
            // lblAgendamentoDia
            // 
            this.lblAgendamentoDia.AutoSize = true;
            this.lblAgendamentoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamentoDia.Location = new System.Drawing.Point(544, 461);
            this.lblAgendamentoDia.Name = "lblAgendamentoDia";
            this.lblAgendamentoDia.Size = new System.Drawing.Size(0, 16);
            this.lblAgendamentoDia.TabIndex = 53;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(83, 75);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(126, 27);
            this.btnAtualizar.TabIndex = 54;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 821);
            this.ControlBox = false;
            this.Controls.Add(this.lblAgendamentoDia);
            this.Controls.Add(this.MenuConteudo);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblChefe);
            this.Controls.Add(this.MenuBarra);
            this.Controls.Add(this.GraficoMes);
            this.Controls.Add(this.dgvAgendamento);
            this.Controls.Add(this.PTimer);
            this.Controls.Add(this.GraficoSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAgendaDoDia);
            this.Controls.Add(this.btnAtualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
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
            this.PTimer.ResumeLayout(false);
            this.PTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaDoDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoSemana;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoMes;
        private System.Windows.Forms.Panel MenuBarra;
        private System.Windows.Forms.Button btnFunc1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel MenuConteudo;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnCliente1;
        private System.Windows.Forms.Button btnAgenda1;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnCliente2;
        private System.Windows.Forms.Button btnAgenda2;
        private System.Windows.Forms.Button btnFunc2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Panel PTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCheckin2;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Label lblTempoEstimado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTipoTratamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChefe;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnCheckOut2;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblAgendamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAgendaDoDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAgendamentoDia;
        private System.Windows.Forms.Button btnAtualizar;
    }
}