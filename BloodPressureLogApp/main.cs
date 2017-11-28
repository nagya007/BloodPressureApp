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
        BAL.XmlHandler xhandler = new BAL.XmlHandler();
        IQueryable<Entry> selectedItems;
        public main()
        {
            InitializeComponent();
            
                     
        }       
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radiobutton_Sys":
                        dataType = "sys";
                        break;
                    case "radiobutton_Dia":
                        dataType = "dia";
                        break;
                    case "radiobutton_Pulse":
                        dataType = "pulse";
                        break;
                }
               
               // dbService.WrireXml(context.Users, context.Entries, logicService.CurrentUser);
            }

        }
        private void radioButton_CheckedChangedDayPart(object sender, EventArgs e)
        {  
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case"radiobutton_Day":
                        dayPart = "all";
                      
                        break;
                    case"radiobutton_Am":
                        dayPart = "am";
                        break;
                    case"radiobutton_Pm":
                        dayPart = "pm";
                        break;
                }
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker2.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value,logicService.CurrentUserId);
             }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
         {
            if (dateTimePicker1.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRangeAndUser(dateTimePicker1.Value, dateTimePicker2.Value,logicService.CurrentUserId);
            }
        }
        private void button_mutat_Click(object sender, EventArgs e)
        {
            var entries = dbService.GetEntryiesByDayPart(50, true);
            DateTime minDate = entries.OrderBy(entry => entry.Date).First().Date;
            DateTime maxDate = entries.OrderByDescending(entry => entry.Date).First().Date;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;
            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();

            chart1.Series.Clear();
            chart1.Series.Add(chartService.Draw(entries, BAL.Constants.SYS));
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Name = BAL.Constants.SYS;
            chart1.ChartAreas[0].AxisY.Name = BAL.Constants.SYS;
            chart1.Series[0].Color = Color.Blue;



            userOut.User = dbService.GetUserByUserName(logicService.CurrentUser);
            userOut.AllUserData = dbService.FindAllEntriesOfUser(userOut.User).ToList();
            // string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
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
        
    }
}
