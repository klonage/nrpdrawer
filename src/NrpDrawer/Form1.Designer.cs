﻿namespace NrpDrawer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.updateTemperature = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.baseSymbolsComboBox = new System.Windows.Forms.ComboBox();
            this.mucusTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Interval = 0.5D;
            chartArea1.AxisY.Maximum = 44D;
            chartArea1.AxisY.Minimum = 34D;
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(0, 106);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(860, 335);
            this.mainChart.TabIndex = 4;
            this.mainChart.Text = "chart1";
            this.mainChart.SizeChanged += new System.EventHandler(this.mainChart_SizeChanged);
            this.mainChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainChart_MouseClick);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.beginDateTimePicker);
            this.groupBox2.Controls.Add(this.endDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(438, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 76);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mucus Type:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 441);
            this.Controls.Add(this.mainChart);
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
    }
}

