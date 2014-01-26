namespace NrpDrawer
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.endCycleLabel = new System.Windows.Forms.Label();
            this.beginCycleLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cycleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseSymbolsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateTemperature = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mucusTypeComboBox = new System.Windows.Forms.ComboBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.mucusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mucusChart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(986, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDatabaseFileToolStripMenuItem
            // 
            this.openDatabaseFileToolStripMenuItem.Name = "openDatabaseFileToolStripMenuItem";
            this.openDatabaseFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDatabaseFileToolStripMenuItem.Text = "Open Database File...";
            this.openDatabaseFileToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseFileToolStripMenuItem_Click);
            // 
            // currentDateTimePicker
            // 
            this.currentDateTimePicker.Location = new System.Drawing.Point(45, 16);
            this.currentDateTimePicker.Name = "currentDateTimePicker";
            this.currentDateTimePicker.Size = new System.Drawing.Size(181, 20);
            this.currentDateTimePicker.TabIndex = 1;
            this.currentDateTimePicker.ValueChanged += new System.EventHandler(this.currentDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // mainChart
            // 
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.IntervalOffset = 1D;
            chartArea7.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea7.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea7.AxisX.Title = "Date";
            chartArea7.AxisY.Interval = 0.5D;
            chartArea7.AxisY.Maximum = 44D;
            chartArea7.AxisY.Minimum = 34D;
            chartArea7.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea7);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.mainChart.Legends.Add(legend7);
            this.mainChart.Location = new System.Drawing.Point(0, 255);
            this.mainChart.Name = "mainChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.mainChart.Series.Add(series7);
            this.mainChart.Size = new System.Drawing.Size(986, 227);
            this.mainChart.TabIndex = 4;
            this.mainChart.Text = "chart1";
            this.mainChart.SizeChanged += new System.EventHandler(this.mainChart_SizeChanged);
            this.mainChart.Paint += new System.Windows.Forms.PaintEventHandler(this.mainChart_Paint);
            this.mainChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainChart_MouseClick);
            this.mainChart.MouseLeave += new System.EventHandler(this.mainChart_MouseLeave);
            this.mainChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainChart_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 96);
            this.panel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.endCycleLabel);
            this.groupBox3.Controls.Add(this.beginCycleLabel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cycleDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(642, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 93);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cycles";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(49, 67);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 23);
            this.button10.TabIndex = 8;
            this.button10.Text = "Start new cycle today";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(175, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(34, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "<<";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // endCycleLabel
            // 
            this.endCycleLabel.AutoSize = true;
            this.endCycleLabel.Location = new System.Drawing.Point(148, 45);
            this.endCycleLabel.Name = "endCycleLabel";
            this.endCycleLabel.Size = new System.Drawing.Size(61, 13);
            this.endCycleLabel.TabIndex = 5;
            this.endCycleLabel.Text = "0000-00-00";
            // 
            // beginCycleLabel
            // 
            this.beginCycleLabel.AutoSize = true;
            this.beginCycleLabel.Location = new System.Drawing.Point(39, 45);
            this.beginCycleLabel.Name = "beginCycleLabel";
            this.beginCycleLabel.Size = new System.Drawing.Size(61, 13);
            this.beginCycleLabel.TabIndex = 4;
            this.beginCycleLabel.Text = "0000-00-00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Begin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "From date:";
            // 
            // cycleDateTimePicker
            // 
            this.cycleDateTimePicker.Location = new System.Drawing.Point(69, 16);
            this.cycleDateTimePicker.Name = "cycleDateTimePicker";
            this.cycleDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.cycleDateTimePicker.TabIndex = 0;
            this.cycleDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.beginDateTimePicker);
            this.groupBox2.Controls.Add(this.endDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(385, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 93);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Data Range";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(154, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(45, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(214, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // beginDateTimePicker
            // 
            this.beginDateTimePicker.Location = new System.Drawing.Point(45, 16);
            this.beginDateTimePicker.Name = "beginDateTimePicker";
            this.beginDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.beginDateTimePicker.TabIndex = 4;
            this.beginDateTimePicker.ValueChanged += new System.EventHandler(this.beginDateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(45, 42);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.endDateTimePicker.TabIndex = 5;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.beginDateTimePicker_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baseSymbolsComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.updateTemperature);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mucusTypeComboBox);
            this.groupBox1.Controls.Add(this.temperatureLabel);
            this.groupBox1.Controls.Add(this.temperatureTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.currentDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current item";
            // 
            // baseSymbolsComboBox
            // 
            this.baseSymbolsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseSymbolsComboBox.FormattingEnabled = true;
            this.baseSymbolsComboBox.Items.AddRange(new object[] {
            "Ø – nic nie czuję, nic nie widzę",
            "su – odczucie suchości",
            "c – stała wydzielina",
            "w – objaw “wnikliwej obserwacji”",
            "wl – wilgotność odczuwana na zewnętrznych narządach płciowych"});
            this.baseSymbolsComboBox.Location = new System.Drawing.Point(82, 41);
            this.baseSymbolsComboBox.Name = "baseSymbolsComboBox";
            this.baseSymbolsComboBox.Size = new System.Drawing.Size(144, 21);
            this.baseSymbolsComboBox.TabIndex = 11;
            this.baseSymbolsComboBox.SelectedIndexChanged += new System.EventHandler(this.baseSymbolsComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Observation:";
            // 
            // updateTemperature
            // 
            this.updateTemperature.Location = new System.Drawing.Point(235, 67);
            this.updateTemperature.Name = "updateTemperature";
            this.updateTemperature.Size = new System.Drawing.Size(133, 23);
            this.updateTemperature.TabIndex = 8;
            this.updateTemperature.Text = "Set/Update";
            this.updateTemperature.UseVisualStyleBackColor = true;
            this.updateTemperature.Click += new System.EventHandler(this.updateTemperature_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mucus Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mucusTypeComboBox
            // 
            this.mucusTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mucusTypeComboBox.FormattingEnabled = true;
            this.mucusTypeComboBox.Items.AddRange(new object[] {
            "b – śluz biały, białawy",
            "ż – śluz żółty",
            "żt – śluz żółtawy",
            "gr – śluz grudkowaty",
            "m – śluz mętny",
            "kl – śluz kleisty",
            "S – bliżej nieokreślony śluz gorszej jakości",
            "Bj – śluz jak surowe białko jaja (rozciągliwy na kilka centymetrów, przejrzysty z" +
                " ewentualnymi pojedynczymi białymi smugami)",
            "szk – śluz szklisty (rozciągliwy i przejrzysty jak szkło)",
            "pł – śluz płynny",
            "mś – intensywne odczucie “mokro-ślisko”, wrażenie śliskości i naoliwienia w przed" +
                "sionku pochwy"});
            this.mucusTypeComboBox.Location = new System.Drawing.Point(232, 41);
            this.mucusTypeComboBox.Name = "mucusTypeComboBox";
            this.mucusTypeComboBox.Size = new System.Drawing.Size(136, 21);
            this.mucusTypeComboBox.TabIndex = 12;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(6, 74);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(70, 13);
            this.temperatureLabel.TabIndex = 6;
            this.temperatureLabel.Text = "Temperature:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(82, 70);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(39, 20);
            this.temperatureTextBox.TabIndex = 7;
            // 
            // mucusChart
            // 
            chartArea8.AxisX.Interval = 1D;
            chartArea8.AxisX.IntervalOffset = 1D;
            chartArea8.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea8.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea8.AxisX.Title = "Date";
            chartArea8.AxisY.Interval = 1D;
            chartArea8.AxisY.Maximum = 2D;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.Name = "ChartArea1";
            this.mucusChart.ChartAreas.Add(chartArea8);
            this.mucusChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend8.Name = "Legend1";
            this.mucusChart.Legends.Add(legend8);
            this.mucusChart.Location = new System.Drawing.Point(0, 120);
            this.mucusChart.Name = "mucusChart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.mucusChart.Series.Add(series8);
            this.mucusChart.Size = new System.Drawing.Size(986, 135);
            this.mucusChart.TabIndex = 6;
            this.mucusChart.Text = "chart1";
            this.mucusChart.Paint += new System.Windows.Forms.PaintEventHandler(this.mucusChart_Paint);
            this.mucusChart.MouseLeave += new System.EventHandler(this.mucusChart_MouseLeave);
            this.mucusChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mucusChart_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.dateToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Date: ";
            // 
            // dateToolStripLabel
            // 
            this.dateToolStripLabel.Name = "dateToolStripLabel";
            this.dateToolStripLabel.Size = new System.Drawing.Size(63, 17);
            this.dateToolStripLabel.Text = "0000-00-00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.mucusChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mucusChart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dbOpenFileDialog;
        private System.Windows.Forms.DateTimePicker currentDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker beginDateTimePicker;
        private System.Windows.Forms.Button updateTemperature;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox baseSymbolsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mucusTypeComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart mucusChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel dateToolStripLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label endCycleLabel;
        private System.Windows.Forms.Label beginCycleLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker cycleDateTimePicker;
    }
}

