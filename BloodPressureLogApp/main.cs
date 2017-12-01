using System;
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
        string dataType;
        Series Sys = new Series();
        Series Dia = new Series();
        Series Pulse = new Series();
        BAL.XmlHandler xhandler = new BAL.XmlHandler();
        IQueryable<Entry> selectedItems;
        public main()
        {
            InitializeComponent();   
        }       
        private void radioButton_CheckedChangedDayPart(object sender, EventArgs e)
        {  
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radiobutton_Day":
                     var entriesDay=  dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                        Sys =chartService.Draw(entriesDay, BAL.Constants.SYS);
                        chart1.Series["Sys"] = Sys;
                        Sys.IsVisibleInLegend = false;
                        Dia = chartService.Draw(entriesDay, BAL.Constants.DIA);
                        chart1.Series["Dia"] = Dia;
                        Dia.IsVisibleInLegend = false;
                        Pulse= chartService.Draw(entriesDay, BAL.Constants.PULSE);
                        chart1.Series["Pulse"] = Pulse;
                        Pulse.IsVisibleInLegend = false;
                        break;
                    case "radiobutton_Am":
                        var entriesAm = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser),true);
                         Sys = chartService.Draw(entriesAm, BAL.Constants.SYS);
                        chart1.Series["Sys"] = Sys;
                        Sys.IsVisibleInLegend = false;
                         Dia = chartService.Draw(entriesAm, BAL.Constants.DIA);
                        chart1.Series["Dia"] = Dia;
                        Dia.IsVisibleInLegend = false;
                         Pulse = chartService.Draw(entriesAm, BAL.Constants.PULSE);
                        chart1.Series["Pulse"] = Pulse;
                        Pulse.IsVisibleInLegend = false;
                        break;
                    case"radiobutton_Pm":
                        var entriesPm = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                         Sys = chartService.Draw(entriesPm, BAL.Constants.SYS);
                        chart1.Series["Sys"] = Sys;
                        Sys.IsVisibleInLegend = false;
                         Dia = chartService.Draw(entriesPm, BAL.Constants.DIA);
                        chart1.Series["Dia"] = Dia;
                        Dia.IsVisibleInLegend = false;
                         Pulse = chartService.Draw(entriesPm, BAL.Constants.PULSE);
                        chart1.Series["Pulse"] = Pulse;
                        Pulse.IsVisibleInLegend = false;
                        break;
                }
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker2.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
             }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
         {
            if (dateTimePicker1.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
            }
        }
        private void button_mutat_Click(object sender, EventArgs e)
        {
          
           /*/ if (dayPart == "all")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    DateTime minDate = entriesSys.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesSys.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesSys, BAL.Constants.SYS));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.SYS;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.SYS;
                    chart1.Series[0].Color = Color.Blue;
                }
                if (checkbox_Dia.Checked)
                {

                    var entriesDia = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    DateTime minDate = entriesDia.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesDia.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesDia, BAL.Constants.DIA));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.DIA;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.DIA;
                    chart1.Series[0].Color = Color.Red;
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    DateTime minDate = entriesPulse.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesPulse.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesPulse, BAL.Constants.PULSE));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.PULSE;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.PULSE;
                    chart1.Series[0].Color = Color.Green;
                }
            }
            if (dayPart == "Am")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                    DateTime minDate = entriesSys.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesSys.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

                    chart1.Series["0"] = new Series();
                    chart1.Series.Add(chartService.Draw(entriesSys, BAL.Constants.SYS));
                    chart1.Series["0"].ChartType = SeriesChartType.Line;
                    chart1.Series["0"].Name = BAL.Constants.SYS;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.SYS;
                    chart1.Series["0"].Color = Color.Blue;
                }
                if (checkbox_Dia.Checked)
                {

                  //  var entriesDia = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                    var dateentriesdia = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value, dbService.GetUserByUserName(logicService.CurrentUser));
                    var entriesDia = dbService.GetEntryiesByDayPart2(dateentriesdia,true);
                    DateTime minDate = dateentriesdia.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = dateentriesdia.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

                    chart1.Series["0"] = new Series();
                    chart1.Series.Add(chartService.Draw(entriesDia, BAL.Constants.DIA));
                    chart1.Series["0"].ChartType = SeriesChartType.Line;
                    chart1.Series["0"].Name = BAL.Constants.DIA;
                    chart1.ChartAreas["Dia"].AxisY.Name = BAL.Constants.DIA;
                    chart1.Series["0"].Color = Color.Red;
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                  
                    DateTime minDate = entriesPulse.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesPulse.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

                    chart1.Series["0"] = new Series();
                    chart1.Series.Add(chartService.Draw(entriesPulse, BAL.Constants.PULSE));
                    chart1.Series["0"].ChartType = SeriesChartType.Line;
                    chart1.Series["0"].Name = BAL.Constants.PULSE;
                    chart1.ChartAreas["0"].AxisY.Name = BAL.Constants.PULSE;
                    chart1.Series["0"].Color = Color.Green;
                }
            }
            if (dayPart == "Pm")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    DateTime minDate = entriesSys.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesSys.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesSys, BAL.Constants.SYS));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.SYS;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.SYS;
                    chart1.Series[0].Color = Color.Blue;
                }
                if (checkbox_Dia.Checked)
                {

                    var entriesDia = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    DateTime minDate = entriesDia.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesDia.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesDia, BAL.Constants.DIA));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.DIA;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.DIA;
                    chart1.Series[0].Color = Color.Red;
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    DateTime minDate = entriesPulse.OrderBy(entry => entry.Date).First().Date;
                    DateTime maxDate = entriesPulse.OrderByDescending(entry => entry.Date).First().Date;

                    chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
                    chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                    chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();


                    chart1.Series.Add(chartService.Draw(entriesPulse, BAL.Constants.PULSE));
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.Series[0].Name = BAL.Constants.PULSE;
                    chart1.ChartAreas[0].AxisY.Name = BAL.Constants.PULSE;
                    chart1.Series[0].Color = Color.Green;
                }
            }/*/
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
          if (dayPart == "all")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    double minAllSys = logicService.GetMinEntryBySys(entriesSys);
                    MessageBox.Show($"Minimum az összes Sys alapján: {minAllSys}");
                }
                if (checkbox_Dia.Checked)
                {

                    var entriesDia = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    double minAllDia = logicService.GetMinEntryByDia(entriesDia);
                    MessageBox.Show($"Minimum az összes Dia alapján: {minAllDia}");
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
                    double minAllPulse = logicService.GetMinEntryByPulse(entriesPulse);
                    MessageBox.Show($"Minimum az összes Pulse alapján: {minAllPulse}");
                }
            }
            if (dayPart == "Am")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                    double minAmPSys = logicService.GetMinEntryBySys(entriesSys);
                    MessageBox.Show($"Minimum a reggeli Sys alapján: {minAmPSys}");
                }
                if (checkbox_Dia.Checked)
                {

                    var entriesDia = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                    double minAmDia = logicService.GetMinEntryByDia(entriesDia);
                    MessageBox.Show($"Minimum a reggeli Dia alapján: {minAmDia}");
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), true);
                    double minAmPulse = logicService.GetMinEntryByPulse(entriesPulse);
                    MessageBox.Show($"Minimum a reggeli Pulse alapján: {minAmPulse}");
                }
            }
            if (dayPart == "Pm")
            {
                if (checkbox_Sys.Checked)
                {

                    var entriesSys = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    double minPmSys = logicService.GetMinEntryBySys(entriesSys);
                    MessageBox.Show($"Minimum az esti Sys alapján: {minPmSys}");
                }
                if (checkbox_Dia.Checked)
                {

                    var entriesDia = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    double minPmDia = logicService.GetMinEntryByDia(entriesDia);
                    MessageBox.Show($"Minimum az esti Dia alapján: {minPmDia}");
                }
                if (checkbox_Pulse.Checked)
                {

                    var entriesPulse = dbService.GetEntryiesByDayPart(dbService.GetUserByUserName(logicService.CurrentUser), false);
                    double minPmPulse = logicService.GetMinEntryByPulse(entriesPulse);
                    MessageBox.Show($"Minimum az esti  alapján: {minPmPulse}");

                }
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
            UpdateEntry Remove = new UpdateEntry();
            Remove.ShowDialog();
        }

        private void checkbox_Serise_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
