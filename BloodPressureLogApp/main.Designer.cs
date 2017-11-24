
namespace BloodPressureLogApp
{
    partial class main
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radiobutton_Pulse = new System.Windows.Forms.RadioButton();
            this.radiobutton_Dia = new System.Windows.Forms.RadioButton();
            this.radiobutton_Sys = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiobutton_Pm = new System.Windows.Forms.RadioButton();
            this.radiobutton_Am = new System.Windows.Forms.RadioButton();
            this.radiobutton_Day = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_mutat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_mutat);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(796, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 497);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radiobutton_Pulse);
            this.groupBox4.Controls.Add(this.radiobutton_Dia);
            this.groupBox4.Controls.Add(this.radiobutton_Sys);
            this.groupBox4.Location = new System.Drawing.Point(228, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // radiobutton_Pulse
            // 
            this.radiobutton_Pulse.AutoSize = true;
            this.radiobutton_Pulse.Location = new System.Drawing.Point(7, 68);
            this.radiobutton_Pulse.Name = "radiobutton_Pulse";
            this.radiobutton_Pulse.Size = new System.Drawing.Size(45, 17);
            this.radiobutton_Pulse.TabIndex = 2;
            this.radiobutton_Pulse.TabStop = true;
            this.radiobutton_Pulse.Text = "Puls";
            this.radiobutton_Pulse.UseVisualStyleBackColor = true;
            this.radiobutton_Pulse.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radiobutton_Dia
            // 
            this.radiobutton_Dia.AutoSize = true;
            this.radiobutton_Dia.Location = new System.Drawing.Point(7, 44);
            this.radiobutton_Dia.Name = "radiobutton_Dia";
            this.radiobutton_Dia.Size = new System.Drawing.Size(41, 17);
            this.radiobutton_Dia.TabIndex = 1;
            this.radiobutton_Dia.TabStop = true;
            this.radiobutton_Dia.Text = "Dia";
            this.radiobutton_Dia.UseVisualStyleBackColor = true;
            this.radiobutton_Dia.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radiobutton_Sys
            // 
            this.radiobutton_Sys.AutoSize = true;
            this.radiobutton_Sys.Location = new System.Drawing.Point(7, 20);
            this.radiobutton_Sys.Name = "radiobutton_Sys";
            this.radiobutton_Sys.Size = new System.Drawing.Size(42, 17);
            this.radiobutton_Sys.TabIndex = 0;
            this.radiobutton_Sys.TabStop = true;
            this.radiobutton_Sys.Text = "Sys";
            this.radiobutton_Sys.UseVisualStyleBackColor = true;
            this.radiobutton_Sys.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiobutton_Pm);
            this.groupBox3.Controls.Add(this.radiobutton_Am);
            this.groupBox3.Controls.Add(this.radiobutton_Day);
            this.groupBox3.Location = new System.Drawing.Point(21, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // radiobutton_Pm
            // 
            this.radiobutton_Pm.AutoSize = true;
            this.radiobutton_Pm.Location = new System.Drawing.Point(7, 68);
            this.radiobutton_Pm.Name = "radiobutton_Pm";
            this.radiobutton_Pm.Size = new System.Drawing.Size(42, 17);
            this.radiobutton_Pm.TabIndex = 2;
            this.radiobutton_Pm.TabStop = true;
            this.radiobutton_Pm.Text = "Esti";
            this.radiobutton_Pm.UseVisualStyleBackColor = true;
            this.radiobutton_Pm.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChangedDayPart);
            // 
            // radiobutton_Am
            // 
            this.radiobutton_Am.AutoSize = true;
            this.radiobutton_Am.Location = new System.Drawing.Point(8, 44);
            this.radiobutton_Am.Name = "radiobutton_Am";
            this.radiobutton_Am.Size = new System.Drawing.Size(61, 17);
            this.radiobutton_Am.TabIndex = 1;
            this.radiobutton_Am.TabStop = true;
            this.radiobutton_Am.Text = "Reggeli";
            this.radiobutton_Am.UseVisualStyleBackColor = true;
            this.radiobutton_Am.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChangedDayPart);
            // 
            // radiobutton_Day
            // 
            this.radiobutton_Day.AutoSize = true;
            this.radiobutton_Day.Location = new System.Drawing.Point(7, 20);
            this.radiobutton_Day.Name = "radiobutton_Day";
            this.radiobutton_Day.Size = new System.Drawing.Size(72, 17);
            this.radiobutton_Day.TabIndex = 0;
            this.radiobutton_Day.TabStop = true;
            this.radiobutton_Day.Text = "Egésznap";
            this.radiobutton_Day.UseVisualStyleBackColor = true;
            this.radiobutton_Day.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChangedDayPart);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(21, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 497);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(11, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Sys";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Dia";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "Pulse";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(781, 478);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_mutat
            // 
            this.button_mutat.Location = new System.Drawing.Point(21, 188);
            this.button_mutat.Name = "button_mutat";
            this.button_mutat.Size = new System.Drawing.Size(109, 26);
            this.button_mutat.TabIndex = 4;
            this.button_mutat.Text = "Mutat";
            this.button_mutat.UseVisualStyleBackColor = true;
            this.button_mutat.Click += new System.EventHandler(this.button_mutat_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "Belépve";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radiobutton_Pm;
        private System.Windows.Forms.RadioButton radiobutton_Am;
        private System.Windows.Forms.RadioButton radiobutton_Day;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radiobutton_Pulse;
        private System.Windows.Forms.RadioButton radiobutton_Dia;
        private System.Windows.Forms.RadioButton radiobutton_Sys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_mutat;
    }
}