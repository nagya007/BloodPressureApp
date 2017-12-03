
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Avg = new System.Windows.Forms.Button();
            this.button_Max = new System.Windows.Forms.Button();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_XmlCreat = new System.Windows.Forms.Button();
            this.button_delet = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_NewEntry = new System.Windows.Forms.Button();
            this.button_mutat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkbox_Pulse = new System.Windows.Forms.CheckBox();
            this.checkbox_Dia = new System.Windows.Forms.CheckBox();
            this.checkbox_Sys = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radiobutton_Pm = new System.Windows.Forms.RadioButton();
            this.radiobutton_Am = new System.Windows.Forms.RadioButton();
            this.radiobutton_Day = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Avg);
            this.groupBox1.Controls.Add(this.button_Max);
            this.groupBox1.Controls.Add(this.button_Min);
            this.groupBox1.Controls.Add(this.button_XmlCreat);
            this.groupBox1.Controls.Add(this.button_delet);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_NewEntry);
            this.groupBox1.Controls.Add(this.button_mutat);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(796, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 497);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button_Avg
            // 
            this.button_Avg.Location = new System.Drawing.Point(179, 303);
            this.button_Avg.Name = "button_Avg";
            this.button_Avg.Size = new System.Drawing.Size(75, 23);
            this.button_Avg.TabIndex = 12;
            this.button_Avg.Text = "Átlag";
            this.button_Avg.UseVisualStyleBackColor = true;
            this.button_Avg.Click += new System.EventHandler(this.button_Avg_Click);
            // 
            // button_Max
            // 
            this.button_Max.Location = new System.Drawing.Point(179, 274);
            this.button_Max.Name = "button_Max";
            this.button_Max.Size = new System.Drawing.Size(75, 23);
            this.button_Max.TabIndex = 11;
            this.button_Max.Text = "Maximum";
            this.button_Max.UseVisualStyleBackColor = true;
            this.button_Max.Click += new System.EventHandler(this.button_Max_Click);
            // 
            // button_Min
            // 
            this.button_Min.Location = new System.Drawing.Point(179, 245);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(75, 23);
            this.button_Min.TabIndex = 10;
            this.button_Min.Text = "Minimum";
            this.button_Min.UseVisualStyleBackColor = true;
            this.button_Min.Click += new System.EventHandler(this.button_Min_Click);
            // 
            // button_XmlCreat
            // 
            this.button_XmlCreat.Location = new System.Drawing.Point(21, 303);
            this.button_XmlCreat.Name = "button_XmlCreat";
            this.button_XmlCreat.Size = new System.Drawing.Size(107, 23);
            this.button_XmlCreat.TabIndex = 9;
            this.button_XmlCreat.Text = "Xml Készítés";
            this.button_XmlCreat.UseVisualStyleBackColor = true;
            this.button_XmlCreat.Click += new System.EventHandler(this.button_XmlCreat_Click);
            // 
            // button_delet
            // 
            this.button_delet.Location = new System.Drawing.Point(21, 274);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(107, 23);
            this.button_delet.TabIndex = 8;
            this.button_delet.Text = "Adat Törlése";
            this.button_delet.UseVisualStyleBackColor = true;
            this.button_delet.Click += new System.EventHandler(this.button_delet_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(21, 245);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(107, 23);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Adat Szerkesztés";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_NewEntry
            // 
            this.button_NewEntry.Location = new System.Drawing.Point(21, 216);
            this.button_NewEntry.Name = "button_NewEntry";
            this.button_NewEntry.Size = new System.Drawing.Size(107, 23);
            this.button_NewEntry.TabIndex = 6;
            this.button_NewEntry.Text = "Új adat";
            this.button_NewEntry.UseVisualStyleBackColor = true;
            this.button_NewEntry.Click += new System.EventHandler(this.button_NewEntry_Click);
            // 
            // button_mutat
            // 
            this.button_mutat.Location = new System.Drawing.Point(179, 217);
            this.button_mutat.Name = "button_mutat";
            this.button_mutat.Size = new System.Drawing.Size(75, 22);
            this.button_mutat.TabIndex = 4;
            this.button_mutat.Text = "Mutat";
            this.button_mutat.UseVisualStyleBackColor = true;
            this.button_mutat.Click += new System.EventHandler(this.button_mutat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkbox_Pulse);
            this.groupBox4.Controls.Add(this.checkbox_Dia);
            this.groupBox4.Controls.Add(this.checkbox_Sys);
            this.groupBox4.Location = new System.Drawing.Point(149, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Válasszon adatot:";
            // 
            // checkbox_Pulse
            // 
            this.checkbox_Pulse.AutoSize = true;
            this.checkbox_Pulse.Location = new System.Drawing.Point(6, 69);
            this.checkbox_Pulse.Name = "checkbox_Pulse";
            this.checkbox_Pulse.Size = new System.Drawing.Size(52, 17);
            this.checkbox_Pulse.TabIndex = 2;
            this.checkbox_Pulse.Text = "Pulse";
            this.checkbox_Pulse.UseVisualStyleBackColor = true;
            this.checkbox_Pulse.CheckedChanged += new System.EventHandler(this.checkbox_Serise_CheckedChanged);
            // 
            // checkbox_Dia
            // 
            this.checkbox_Dia.AutoSize = true;
            this.checkbox_Dia.Location = new System.Drawing.Point(6, 45);
            this.checkbox_Dia.Name = "checkbox_Dia";
            this.checkbox_Dia.Size = new System.Drawing.Size(42, 17);
            this.checkbox_Dia.TabIndex = 1;
            this.checkbox_Dia.Text = "Dia";
            this.checkbox_Dia.UseVisualStyleBackColor = true;
            this.checkbox_Dia.CheckedChanged += new System.EventHandler(this.checkbox_Serise_CheckedChanged);
            // 
            // checkbox_Sys
            // 
            this.checkbox_Sys.AutoSize = true;
            this.checkbox_Sys.Location = new System.Drawing.Point(7, 20);
            this.checkbox_Sys.Name = "checkbox_Sys";
            this.checkbox_Sys.Size = new System.Drawing.Size(43, 17);
            this.checkbox_Sys.TabIndex = 0;
            this.checkbox_Sys.Text = "Sys";
            this.checkbox_Sys.UseVisualStyleBackColor = true;
            this.checkbox_Sys.CheckedChanged += new System.EventHandler(this.checkbox_Serise_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radiobutton_Pm);
            this.groupBox3.Controls.Add(this.radiobutton_Am);
            this.groupBox3.Controls.Add(this.radiobutton_Day);
            this.groupBox3.Location = new System.Drawing.Point(21, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Válasszon napszakot:";
            // 
            // radiobutton_Pm
            // 
            this.radiobutton_Pm.AutoSize = true;
            this.radiobutton_Pm.Location = new System.Drawing.Point(7, 80);
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
            this.radiobutton_Am.Location = new System.Drawing.Point(7, 57);
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
            this.radiobutton_Day.Location = new System.Drawing.Point(7, 34);
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
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 497);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
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
            this.chart1.Size = new System.Drawing.Size(781, 478);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "Belépve";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_mutat;
        private System.Windows.Forms.Button button_Avg;
        private System.Windows.Forms.Button button_Max;
        private System.Windows.Forms.Button button_Min;
        private System.Windows.Forms.Button button_XmlCreat;
        private System.Windows.Forms.Button button_delet;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_NewEntry;
        private System.Windows.Forms.CheckBox checkbox_Pulse;
        private System.Windows.Forms.CheckBox checkbox_Dia;
        private System.Windows.Forms.CheckBox checkbox_Sys;
    }
}