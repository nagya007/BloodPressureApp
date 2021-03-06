﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BloodPressureLogApp.Properties;
using System.Windows.Forms.DataVisualization.Charting;




namespace BloodPressureLogApp
{
    public partial class main : Form
    {
        BAL.BusinessLogicService logicService = BAL.BusinessLogicService.getInstance();
        BAL.GraficLogicService chartService = BAL.GraficLogicService.getInstance();
        DAL.DbService dbService = DAL.DbService.getInstance();
        BAL.UserOutput userOut = new BAL.UserOutput();
        LogDbContext context = new LogDbContext();
        string dayPart;
        Boolean sysOn;
        Boolean diaOn;
        Boolean pulseOn;
        Series Sys = new Series();     
        Series Dia = new Series();
        Series Pulse = new Series();
        Series DistributionSys = new Series();
        Series DistributionDia = new Series();
        Series DistributionPulse = new Series();
        Series Correlation = new Series();
        BAL.XmlHandler xhandler = new BAL.XmlHandler();
        public main()
        {
            InitializeComponent();
            Sys.Name = BAL.Constants.SYS;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
            chart1.ChartAreas[0].AxisY.IntervalOffset = 1;
        }            
        private void radioButton_CheckedChangedDayPart(object sender, EventArgs e)
        {
            groupBox4.Enabled = true;            
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radiobutton_Day":
                        dayPart = "all";
                        break;
                    case "radiobutton_Am":
                        dayPart = "Am";
                        break;
                    case "radiobutton_Pm":
                        dayPart = "Pm";
                        break;
                }               
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button_mutat.Enabled = true;
            groupBox3.Enabled = true;
            button_Min.Enabled = true;
            button_Max.Enabled = true;
            button_Avg.Enabled = true;

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
         {

            button_mutat.Enabled = true;
            groupBox3.Enabled = true;
            button_Min.Enabled = true;
            button_Max.Enabled = true;
            button_Avg.Enabled = true;
        }
        private void button_mutat_Click(object sender, EventArgs e)
        { 
            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart3.Series.Clear();
            chart2.Series.Clear();
            chart1.Series.Clear();
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            if (entriesDay!=null)
            {
                switch (dayPart)
                {
                    case "all":
                        Sys = chartService.Draw(entriesDay, BAL.Constants.SYS);
                        Dia = chartService.Draw(entriesDay, BAL.Constants.DIA);
                        Pulse = chartService.Draw(entriesDay, BAL.Constants.PULSE);
                        break;
                    case "Am":
                        var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
                        Sys = chartService.Draw(entriesAm, BAL.Constants.SYS);
                        Dia = chartService.Draw(entriesAm, BAL.Constants.DIA);
                        Pulse = chartService.Draw(entriesAm, BAL.Constants.PULSE);
                        break;
                    case "Pm":
                        var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
                        Sys = chartService.Draw(entriesPm, BAL.Constants.SYS);
                        Dia = chartService.Draw(entriesPm, BAL.Constants.DIA);
                        Pulse = chartService.Draw(entriesPm, BAL.Constants.PULSE);
                        break;
                }

                if (sysOn)
                {
                    Sys.Name = BAL.Constants.SYS;
                    Sys.Color = Color.Green;
                    Sys.ChartType = SeriesChartType.Line;
                    Sys.BorderWidth = 3;
                    chart1.Series.Add(Sys);
                }
                if (diaOn)
                {
                    Dia.Name = BAL.Constants.DIA;
                    Dia.Color = Color.Red;
                    Dia.ChartType = SeriesChartType.Line;
                    Dia.BorderWidth = 3;
                    chart1.Series.Add(Dia);
                }
                if (pulseOn)
                {
                    Pulse.Name = BAL.Constants.PULSE;
                    Pulse.Color = Color.Blue;
                    Pulse.ChartType = SeriesChartType.Line;
                    Pulse.BorderWidth = 3;
                    chart1.Series.Add(Pulse);
                }
                if(!sysOn && !diaOn && !pulseOn)
                {
                    MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
                }
            }
           
        }
        private void button_XmlCreat_Click(object sender, EventArgs e)
        {
            userOut.User = dbService.GetUserByUserName(logicService.CurrentUser);
            userOut.AllUserData = dbService.FindAllEntriesOfUser(userOut.User).ToList();
            string fileName = userOut.User.UserName + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".xml";
            if (!xhandler.WriteToXml(fileName, userOut))
            {

                MessageBox.Show(xhandler.LastError);
            }
            else
            {
                MessageBox.Show("Siker");

            }
        }
        private void button_Min_Click(object sender, EventArgs e)
        {
            
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
            var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
            if (entriesDay.Any())
            {
                if (dayPart == "all")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double minAllSys = logicService.GetMinEntryBySys(entriesDay);
                        MessageBox.Show($"Minimum az összes Sys alapján: {minAllSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double minAllDia = logicService.GetMinEntryByDia(entriesDay);
                        MessageBox.Show($"Minimum az összes Dia alapján: {minAllDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double minAllPulse = logicService.GetMinEntryByPulse(entriesDay);
                        MessageBox.Show($"Minimum az összes Pulse alapján: {minAllPulse}");
                    }
                }
                if (dayPart == "Am")
                {
                    if (checkbox_Sys.Checked)
                    {

                        double minAmPSys = logicService.GetMinEntryBySys(entriesAm);
                        MessageBox.Show($"Minimum a reggeli Sys alapján: {minAmPSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double minAmDia = logicService.GetMinEntryByDia(entriesAm);
                        MessageBox.Show($"Minimum a reggeli Dia alapján: {minAmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double minAmPulse = logicService.GetMinEntryByPulse(entriesAm);
                        MessageBox.Show($"Minimum a reggeli Pulse alapján: {minAmPulse}");
                    }
                }
                if (dayPart == "Pm")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double minPmSys = logicService.GetMinEntryBySys(entriesPm);
                        MessageBox.Show($"Minimum az esti Sys alapján: {minPmSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double minPmDia = logicService.GetMinEntryByDia(entriesPm);
                        MessageBox.Show($"Minimum az esti Dia alapján: {minPmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double minPmPulse = logicService.GetMinEntryByPulse(entriesPm);
                        MessageBox.Show($"Minimum az esti Pulse alapján: {minPmPulse}");
                    }
                }
            }
            else
            {
                MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
            }
           
        }
        private void button_NewEntry_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();      
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateEntry Update = new UpdateEntry();
            Update.ShowDialog();
        }
        private void button_delet_Click(object sender, EventArgs e)
        {
            Delet Remove = new Delet();
            Remove.ShowDialog();
        }
        private void checkbox_Serise_CheckedChanged(object sender, EventArgs e)
        {
            sysOn = checkbox_Sys.Checked;
            diaOn = checkbox_Dia.Checked;
            pulseOn = checkbox_Pulse.Checked;                    
        }
        private void main_Load(object sender, EventArgs e)
        { 
            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            button_Min.Enabled = false;
            button_Max.Enabled = false;
            button_Avg.Enabled = false;
            button_mutat.Enabled = false;
        }
        private void button_Max_Click(object sender, EventArgs e)
        {
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
            var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
            if (entriesDay.Any())
            {
                if (dayPart == "all")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double maxAllSys = logicService.GetMaxEntryBySys(entriesDay);
                        MessageBox.Show($"Maximum az összes Sys alapján: {maxAllSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double maxAllDia = logicService.GetMaxEntryByDia(entriesDay);
                        MessageBox.Show($"Maximum az összes Dia alapján: {maxAllDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double maxAllPulse = logicService.GetMaxEntryByPulse(entriesDay);
                        MessageBox.Show($"Maximum az összes Pulse alapján: {maxAllPulse}");
                    }
                }
                else if (dayPart == "Am")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double maxAmPSys = logicService.GetMaxEntryBySys(entriesAm);
                        MessageBox.Show($"Maximum a reggeli Sys alapján: {maxAmPSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double maxAmDia = logicService.GetMaxEntryByDia(entriesAm);
                        MessageBox.Show($"Maximum a reggeli Dia alapján: {maxAmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double maxAmPulse = logicService.GetMaxEntryByPulse(entriesAm);
                        MessageBox.Show($"Maximum a reggeli Pulse alapján: {maxAmPulse}");
                    }
                }
                else if (dayPart == "Pm")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double maxPmSys = logicService.GetMaxEntryBySys(entriesPm);
                        MessageBox.Show($"Maximum az esti Sys alapján: {maxPmSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double maxPmDia = logicService.GetMaxEntryByDia(entriesPm);
                        MessageBox.Show($"Maximum az esti Dia alapján: {maxPmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double maxPmPulse = logicService.GetMaxEntryByPulse(entriesPm);
                        MessageBox.Show($"Maximum az esti Pulse alapján: {maxPmPulse}");
                    }
                }
            }
            else
            {
                MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
            }
           
        }
        private void button_Avg_Click(object sender, EventArgs e)
        {
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
            var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
            if (entriesDay.Any())
            {
                if (dayPart == "all")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double avgAllSys = logicService.GetAvgEntryBySys(entriesDay);
                        MessageBox.Show($"Átlag az összes Sys alapján: {avgAllSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double avgAllDia = logicService.GetAvgEntryByDia(entriesDay);
                        MessageBox.Show($"Átlag az összes Dia alapján: {avgAllDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double avgAllPulse = logicService.GetAvgEntryByPulse(entriesDay);
                        MessageBox.Show($"Átlag az összes Pulse alapján: {avgAllPulse}");
                    }
                }
                else if (dayPart == "Am")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double avgAmPSys = logicService.GetAvgEntryBySys(entriesAm);
                        MessageBox.Show($"Átlag a reggeli Sys alapján: {avgAmPSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double avgAmDia = logicService.GetAvgEntryByDia(entriesAm);
                        MessageBox.Show($"Átlag a reggeli Dia alapján: {avgAmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double avgAmPulse = logicService.GetAvgEntryByPulse(entriesAm);
                        MessageBox.Show($"Átlag a reggeli Pulse alapján: {avgAmPulse}");
                    }
                }
                else if (dayPart == "Pm")
                {
                    if (checkbox_Sys.Checked)
                    {
                        double avgPmSys = logicService.GetAvgEntryBySys(entriesPm);
                        MessageBox.Show($"Átlag az esti Sys alapján: {avgPmSys}");
                    }
                    if (checkbox_Dia.Checked)
                    {
                        double avgPmDia = logicService.GetAvgEntryByDia(entriesPm);
                        MessageBox.Show($"Átlag az esti Dia alapján: {avgPmDia}");
                    }
                    if (checkbox_Pulse.Checked)
                    {
                        double avgPmPulse = logicService.GetAvgEntryByPulse(entriesPm);
                        MessageBox.Show($"Átlag az esti Pulse alapján: {avgPmPulse}");
                    }
                }
            }
            else
            {
                MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
            }
        }
        private void button_Distribution_Sys_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart1.Series.Clear();
            chart3.Series.Clear();
            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            if (entriesDay.Any())
            {
                switch (dayPart)
                {
                    case "all":
                        var dictsys = logicService.GetDistributionMapSys(entriesDay);
                        DistributionSys = chartService.DrawDistribution(dictsys);
                        var dictdia = logicService.GetDistributionMapDia(entriesDay);
                        DistributionDia = chartService.DrawDistribution(dictdia);
                        var dictpulse = logicService.GetDistributionMapPulse(entriesDay);
                        DistributionPulse = chartService.DrawDistribution(dictpulse);
                        break;
                    case "Am":
                        var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
                        var dictsysam = logicService.GetDistributionMapSys(entriesAm);
                        DistributionSys = chartService.DrawDistribution(dictsysam);
                        var dictdiaam = logicService.GetDistributionMapDia(entriesAm);
                        DistributionDia = chartService.DrawDistribution(dictdiaam);
                        var dictpulseam = logicService.GetDistributionMapPulse(entriesAm);
                        DistributionPulse = chartService.DrawDistribution(dictpulseam);
                        break;
                    case "Pm":
                        var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
                        var dictsyspm = logicService.GetDistributionMapSys(entriesPm);
                        DistributionSys = chartService.DrawDistribution(dictsyspm);
                        var dictdiapm = logicService.GetDistributionMapDia(entriesPm);
                        DistributionDia = chartService.DrawDistribution(dictdiapm);
                        var dictpulsepm = logicService.GetDistributionMapPulse(entriesPm);
                        DistributionPulse = chartService.DrawDistribution(dictpulsepm);
                        break;
                }

                if (sysOn)
                {
                    DistributionSys.Name = BAL.Constants.DistributionSys;
                    DistributionSys.Color = Color.Red;
                    DistributionSys.ChartType = SeriesChartType.Point;
                    DistributionSys.LabelBorderWidth = 3;
                    chart2.Series.Add(DistributionSys);
                }
                if (diaOn)
                {
                    DistributionDia.Name = BAL.Constants.DistributionDia;
                    DistributionDia.Color = Color.Green;
                    DistributionDia.ChartType = SeriesChartType.Point;
                    DistributionDia.LabelBorderWidth = 3;
                    chart2.Series.Add(DistributionDia);
                }
                if (pulseOn)
                {
                    DistributionPulse.Name = BAL.Constants.DistributionPulse;
                    DistributionPulse.Color = Color.Blue;
                    DistributionPulse.ChartType = SeriesChartType.Point;
                    DistributionPulse.LabelBorderWidth = 3;
                    chart2.Series.Add(DistributionPulse);
                }
            }
            else
            {
                MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
            }

        }

        private void button_Correlation_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart1.Series.Clear();
            chart3.Series.Clear();
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
            var entriesDay = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            if (entriesDay.Any())
            {
                switch (dayPart)
                {
                    case "all":
                        Correlation = chartService.DrawCorrelation(entriesDay);
                        break;
                    case "Am":
                        var entriesAm = logicService.GetEntriesByDayPart(entriesDay, true);
                        Correlation = chartService.DrawCorrelation(entriesAm);
                        break;
                    case "Pm":
                        var entriesPm = logicService.GetEntriesByDayPart(entriesDay, false);
                        Correlation = chartService.DrawCorrelation(entriesPm);
                        break;
                }
                Correlation.Name = BAL.Constants.Correracio;
                Correlation.Color = Color.Red;
                Correlation.ChartType = SeriesChartType.Point;
                Correlation.LabelBorderWidth = 3;
                chart3.Series.Add(Correlation);

            }
            else
            {
                MessageBox.Show("A kiválasztott időintervallumban nincs adat!");
            }
        }
       
}
}
