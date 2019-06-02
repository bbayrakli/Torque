namespace TORQUE_v2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uutz = new System.Windows.Forms.TextBox();
            this.uuty = new System.Windows.Forms.TextBox();
            this.uutx = new System.Windows.Forms.TextBox();
            this.uutmass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fz = new System.Windows.Forms.TextBox();
            this.fy = new System.Windows.Forms.TextBox();
            this.fx = new System.Windows.Forms.TextBox();
            this.fmass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pz = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.TextBox();
            this.px = new System.Windows.Forms.TextBox();
            this.pmass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tgrms = new System.Windows.Forms.TextBox();
            this.lgrms = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.ptyaw = new System.Windows.Forms.Label();
            this.ptpitch = new System.Windows.Forms.Label();
            this.plyaw = new System.Windows.Forms.Label();
            this.plpitch = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tyaw = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tpitch = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lyaw = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lpitch = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cogz = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cogy = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cogx = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totalmass = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(11, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.uutz);
            this.groupBox1.Controls.Add(this.uuty);
            this.groupBox1.Controls.Add(this.uutx);
            this.groupBox1.Controls.Add(this.uutmass);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Under Test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "COG (X, Y, Z) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mass           :";
            // 
            // uutz
            // 
            this.uutz.Location = new System.Drawing.Point(197, 65);
            this.uutz.Name = "uutz";
            this.uutz.Size = new System.Drawing.Size(37, 26);
            this.uutz.TabIndex = 3;
            // 
            // uuty
            // 
            this.uuty.Location = new System.Drawing.Point(154, 65);
            this.uuty.Name = "uuty";
            this.uuty.Size = new System.Drawing.Size(37, 26);
            this.uuty.TabIndex = 2;
            // 
            // uutx
            // 
            this.uutx.Location = new System.Drawing.Point(111, 65);
            this.uutx.Name = "uutx";
            this.uutx.Size = new System.Drawing.Size(37, 26);
            this.uutx.TabIndex = 1;
            // 
            // uutmass
            // 
            this.uutmass.Location = new System.Drawing.Point(134, 33);
            this.uutmass.Name = "uutmass";
            this.uutmass.Size = new System.Drawing.Size(100, 26);
            this.uutmass.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.fz);
            this.groupBox2.Controls.Add(this.fy);
            this.groupBox2.Controls.Add(this.fx);
            this.groupBox2.Controls.Add(this.fmass);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(11, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit Under Test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "COG (X, Y, Z) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mass           :";
            // 
            // fz
            // 
            this.fz.Location = new System.Drawing.Point(197, 65);
            this.fz.Name = "fz";
            this.fz.Size = new System.Drawing.Size(37, 26);
            this.fz.TabIndex = 3;
            // 
            // fy
            // 
            this.fy.Location = new System.Drawing.Point(154, 65);
            this.fy.Name = "fy";
            this.fy.Size = new System.Drawing.Size(37, 26);
            this.fy.TabIndex = 2;
            // 
            // fx
            // 
            this.fx.Location = new System.Drawing.Point(111, 65);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(37, 26);
            this.fx.TabIndex = 1;
            // 
            // fmass
            // 
            this.fmass.Location = new System.Drawing.Point(134, 33);
            this.fmass.Name = "fmass";
            this.fmass.Size = new System.Drawing.Size(100, 26);
            this.fmass.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.pz);
            this.groupBox3.Controls.Add(this.py);
            this.groupBox3.Controls.Add(this.px);
            this.groupBox3.Controls.Add(this.pmass);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(11, 246);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unit Under Test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "COG (X, Y, Z) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Mass           :";
            // 
            // pz
            // 
            this.pz.Location = new System.Drawing.Point(197, 65);
            this.pz.Name = "pz";
            this.pz.Size = new System.Drawing.Size(37, 26);
            this.pz.TabIndex = 3;
            // 
            // py
            // 
            this.py.Location = new System.Drawing.Point(154, 65);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(37, 26);
            this.py.TabIndex = 2;
            // 
            // px
            // 
            this.px.Location = new System.Drawing.Point(111, 65);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(37, 26);
            this.px.TabIndex = 1;
            // 
            // pmass
            // 
            this.pmass.Location = new System.Drawing.Point(134, 33);
            this.pmass.Name = "pmass";
            this.pmass.Size = new System.Drawing.Size(100, 26);
            this.pmass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tgrms);
            this.groupBox4.Controls.Add(this.lgrms);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(11, 363);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 111);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unit Under Test";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 18);
            this.label13.TabIndex = 7;
            this.label13.Text = "gRMS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "gRMS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Transversal    :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "Longitudinal :";
            // 
            // tgrms
            // 
            this.tgrms.Location = new System.Drawing.Point(111, 65);
            this.tgrms.Name = "tgrms";
            this.tgrms.Size = new System.Drawing.Size(80, 26);
            this.tgrms.TabIndex = 2;
            // 
            // lgrms
            // 
            this.lgrms.Location = new System.Drawing.Point(111, 36);
            this.lgrms.Name = "lgrms";
            this.lgrms.Size = new System.Drawing.Size(80, 26);
            this.lgrms.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.ptyaw);
            this.groupBox5.Controls.Add(this.ptpitch);
            this.groupBox5.Controls.Add(this.plyaw);
            this.groupBox5.Controls.Add(this.plpitch);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.tyaw);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.tpitch);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.lyaw);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.lpitch);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.cogz);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.cogy);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.cogx);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.totalmass);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(291, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1046, 528);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CALCULATIONS";
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Mass";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Z";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(411, 33);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(621, 436);
            this.chart1.TabIndex = 35;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mass,
            this.Z});
            this.dataGridView1.Location = new System.Drawing.Point(252, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(153, 436);
            this.dataGridView1.TabIndex = 34;
            // 
            // Mass
            // 
            this.Mass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mass.HeaderText = "Mass";
            this.Mass.MinimumWidth = 50;
            this.Mass.Name = "Mass";
            this.Mass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mass.Width = 75;
            // 
            // Z
            // 
            this.Z.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Z.HeaderText = "Z";
            this.Z.MinimumWidth = 50;
            this.Z.Name = "Z";
            this.Z.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Z.Width = 75;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(25, 441);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(124, 18);
            this.label37.TabIndex = 31;
            this.label37.Text = "Transversal Yaw     :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(25, 423);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(124, 18);
            this.label39.TabIndex = 30;
            this.label39.Text = "Transversal Pitch   :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(25, 405);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(126, 18);
            this.label41.TabIndex = 29;
            this.label41.Text = "Longitudinal Yaw   :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(25, 387);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(126, 18);
            this.label43.TabIndex = 28;
            this.label43.Text = "Longitudinal Pitch :";
            // 
            // ptyaw
            // 
            this.ptyaw.AutoSize = true;
            this.ptyaw.Location = new System.Drawing.Point(157, 442);
            this.ptyaw.Name = "ptyaw";
            this.ptyaw.Size = new System.Drawing.Size(0, 18);
            this.ptyaw.TabIndex = 27;
            // 
            // ptpitch
            // 
            this.ptpitch.AutoSize = true;
            this.ptpitch.Location = new System.Drawing.Point(157, 423);
            this.ptpitch.Name = "ptpitch";
            this.ptpitch.Size = new System.Drawing.Size(0, 18);
            this.ptpitch.TabIndex = 25;
            // 
            // plyaw
            // 
            this.plyaw.AutoSize = true;
            this.plyaw.Location = new System.Drawing.Point(157, 406);
            this.plyaw.Name = "plyaw";
            this.plyaw.Size = new System.Drawing.Size(0, 18);
            this.plyaw.TabIndex = 23;
            // 
            // plpitch
            // 
            this.plpitch.AutoSize = true;
            this.plpitch.Location = new System.Drawing.Point(157, 387);
            this.plpitch.Name = "plpitch";
            this.plpitch.Size = new System.Drawing.Size(0, 18);
            this.plpitch.TabIndex = 21;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label44.Location = new System.Drawing.Point(25, 351);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 18);
            this.label44.TabIndex = 19;
            this.label44.Text = "CAPACITY";
            // 
            // tyaw
            // 
            this.tyaw.AutoSize = true;
            this.tyaw.Location = new System.Drawing.Point(157, 311);
            this.tyaw.Name = "tyaw";
            this.tyaw.Size = new System.Drawing.Size(0, 18);
            this.tyaw.TabIndex = 18;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(25, 310);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(124, 18);
            this.label33.TabIndex = 17;
            this.label33.Text = "Transversal Yaw     :";
            // 
            // tpitch
            // 
            this.tpitch.AutoSize = true;
            this.tpitch.Location = new System.Drawing.Point(157, 293);
            this.tpitch.Name = "tpitch";
            this.tpitch.Size = new System.Drawing.Size(0, 18);
            this.tpitch.TabIndex = 16;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(25, 292);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(124, 18);
            this.label35.TabIndex = 15;
            this.label35.Text = "Transversal Pitch   :";
            // 
            // lyaw
            // 
            this.lyaw.AutoSize = true;
            this.lyaw.Location = new System.Drawing.Point(157, 275);
            this.lyaw.Name = "lyaw";
            this.lyaw.Size = new System.Drawing.Size(0, 18);
            this.lyaw.TabIndex = 14;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 274);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 18);
            this.label30.TabIndex = 13;
            this.label30.Text = "Longitudinal Yaw   :";
            // 
            // lpitch
            // 
            this.lpitch.AutoSize = true;
            this.lpitch.Location = new System.Drawing.Point(157, 256);
            this.lpitch.Name = "lpitch";
            this.lpitch.Size = new System.Drawing.Size(0, 18);
            this.lpitch.TabIndex = 12;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 256);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 18);
            this.label28.TabIndex = 11;
            this.label28.Text = "Longitudinal Pitch :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(25, 219);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 18);
            this.label27.TabIndex = 10;
            this.label27.Text = "MOMENTS";
            // 
            // cogz
            // 
            this.cogz.AutoSize = true;
            this.cogz.Location = new System.Drawing.Point(54, 174);
            this.cogz.Name = "cogz";
            this.cogz.Size = new System.Drawing.Size(0, 18);
            this.cogz.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(25, 174);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 18);
            this.label25.TabIndex = 8;
            this.label25.Text = "Z :";
            // 
            // cogy
            // 
            this.cogy.AutoSize = true;
            this.cogy.Location = new System.Drawing.Point(54, 156);
            this.cogy.Name = "cogy";
            this.cogy.Size = new System.Drawing.Size(0, 18);
            this.cogy.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 156);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 18);
            this.label23.TabIndex = 6;
            this.label23.Text = "Y :";
            // 
            // cogx
            // 
            this.cogx.AutoSize = true;
            this.cogx.Location = new System.Drawing.Point(54, 138);
            this.cogx.Name = "cogx";
            this.cogx.Size = new System.Drawing.Size(0, 18);
            this.cogx.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(25, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 18);
            this.label21.TabIndex = 4;
            this.label21.Text = "X :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(25, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 18);
            this.label20.TabIndex = 3;
            this.label20.Text = "COG COORDINATES";
            // 
            // totalmass
            // 
            this.totalmass.AutoSize = true;
            this.totalmass.Location = new System.Drawing.Point(57, 65);
            this.totalmass.Name = "totalmass";
            this.totalmass.Size = new System.Drawing.Size(0, 18);
            this.totalmass.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "M :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(25, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "TOTAL MASS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1349, 594);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uutz;
        private System.Windows.Forms.TextBox uuty;
        private System.Windows.Forms.TextBox uutx;
        private System.Windows.Forms.TextBox uutmass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fz;
        private System.Windows.Forms.TextBox fy;
        private System.Windows.Forms.TextBox fx;
        private System.Windows.Forms.TextBox fmass;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pz;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.TextBox px;
        private System.Windows.Forms.TextBox pmass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tgrms;
        private System.Windows.Forms.TextBox lgrms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label ptyaw;
        private System.Windows.Forms.Label ptpitch;
        private System.Windows.Forms.Label plyaw;
        private System.Windows.Forms.Label plpitch;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label tyaw;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label tpitch;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lyaw;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lpitch;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label cogz;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label cogy;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label cogx;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalmass;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
    }
}

