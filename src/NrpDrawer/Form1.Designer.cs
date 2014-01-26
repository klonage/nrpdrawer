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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.currentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.mainMenuStrip.Size = new System.Drawing.Size(860, 24);
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
            this.currentDateTimePicker.Size = new System.Drawing.Size(213, 20);
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
            chartArea15.AxisX.Interval = 1D;
            chartArea15.AxisX.IntervalOffset = 1D;
            chartArea15.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea15.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea15.AxisX.Title = "Date";
            chartArea15.AxisY.Interval = 0.5D;
            chartArea15.AxisY.Maximum = 44D;
            chartArea15.AxisY.Minimum = 34D;
            chartArea15.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea15);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            this.mainChart.Legends.Add(legend15);
            this.mainChart.Location = new System.Drawing.Point(0, 241);
            this.mainChart.Name = "mainChart";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.mainChart.Series.Add(series15);
            this.mainChart.Size = new System.Drawing.Size(860, 200);
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
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 82);
            this.panel1.TabIndex = 5;
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
            this.groupBox2.Location = new System.Drawing.Point(438, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 76);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Data Range";
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
            this.groupBox1.Size = new System.Drawing.Size(429, 76);
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
            this.baseSymbolsComboBox.Location = new System.Drawing.Point(195, 42);
            this.baseSymbolsComboBox.Name = "baseSymbolsComboBox";
            this.baseSymbolsComboBox.Size = new System.Drawing.Size(63, 21);
            this.baseSymbolsComboBox.TabIndex = 11;
            this.baseSymbolsComboBox.SelectedIndexChanged += new System.EventHandler(this.baseSymbolsComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Observation:";
            // 
            // updateTemperature
            // 
            this.updateTemperature.Location = new System.Drawing.Point(260, 13);
            this.updateTemperature.Name = "updateTemperature";
            this.updateTemperature.Size = new System.Drawing.Size(73, 23);
            this.updateTemperature.TabIndex = 8;
            this.updateTemperature.Text = "Set/Update";
            this.updateTemperature.UseVisualStyleBackColor = true;
            this.updateTemperature.Click += new System.EventHandler(this.updateTemperature_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mucus Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 13);
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
            this.mucusTypeComboBox.Location = new System.Drawing.Point(339, 42);
            this.mucusTypeComboBox.Name = "mucusTypeComboBox";
            this.mucusTypeComboBox.Size = new System.Drawing.Size(83, 21);
            this.mucusTypeComboBox.TabIndex = 12;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(6, 45);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(70, 13);
            this.temperatureLabel.TabIndex = 6;
            this.temperatureLabel.Text = "Temperature:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(77, 42);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(39, 20);
            this.temperatureTextBox.TabIndex = 7;
            // 
            // mucusChart
            // 
            chartArea16.AxisX.Interval = 1D;
            chartArea16.AxisX.IntervalOffset = 1D;
            chartArea16.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea16.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea16.AxisX.Title = "Date";
            chartArea16.AxisY.Interval = 1D;
            chartArea16.AxisY.Maximum = 2D;
            chartArea16.AxisY.Minimum = 0D;
            chartArea16.Name = "ChartArea1";
            this.mucusChart.ChartAreas.Add(chartArea16);
            this.mucusChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend16.Name = "Legend1";
            this.mucusChart.Legends.Add(legend16);
            this.mucusChart.Location = new System.Drawing.Point(0, 106);
            this.mucusChart.Name = "mucusChart";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.mucusChart.Series.Add(series16);
            this.mucusChart.Size = new System.Drawing.Size(860, 135);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
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
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 52);
            this.button6.TabIndex = 13;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(248, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 52);
            this.button7.TabIndex = 12;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 441);
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
    }
}

