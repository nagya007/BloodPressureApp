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
        DAL.DbService dbService = DAL.DbService.getInstance();
        LogDbContext context = new LogDbContext();
        //Series sys = null;
        //Series dia = null;
        //Series pulse = null;
        string dayPart;
       // string sysdiapuls;
        IQueryable<Entry> selectedItems;

        public main()
        {
            InitializeComponent();
            //sys = chart1.Series.Add("Sys");
            //dia = chart1.Series.Add("Dia");
            //pulse = chart1.Series.Add("Pulse");
            //chart1.Series[1].ChartType = SeriesChartType.Line;
            //chart1.Series[1].BorderWidth=5;
            //chart1.Series[1].BorderColor =Color.Red;
            //chart1.Series[2].ChartType = SeriesChartType.Line;
            //chart1.Series[2].BorderWidth = 5;
            //chart1.Series[1].BorderColor = Color.Azure;
            //chart1.Series[3].ChartType = SeriesChartType.Line;
            //chart1.Series[3].BorderWidth = 5;
            //chart1.Series[1].BorderColor = Color.DarkGreen;
                     
        }
         

       
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "radiobutton_Sys":
                        sysdiapuls = "Sys";
                        break;
                    case "Dia":
                        sysdiapuls = "radiobutton_Dia";
                        sysdiapuls = "Dia";
                        break;
                    case "radiobutton_Pulse":
                        sysdiapuls = "Pulse";
                        break;
                }
                this.label1.Text = rb.Text;
                dbService.WrireXml(context.Users, context.Entries, logicService.CurrentUser);
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
                      
            if(dateTimePicker2.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                if (radiobutton_Sys.Checked)
                {
                    DataPoint newDatapointSys = new DataPoint();

                    newDatapointSys.SetValueXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys).ToList());
                    chart1.Series["Sys"].Points.Add(newDatapointSys);
                    //  sys.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(),selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys).ToList());

                }
                else if (radiobutton_Dia.Checked)
                {
                   // Dia.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Dia).ToList());
                } else if (radiobutton_Pulse.Checked)
                {
                    //Pulse.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Pulse).ToList());
                }
                else MessageBox.Show("Nem Választotta ki hogy mit szaretne megjelaníteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //sys.XAxisType = AxisType.Primary;
            //sys.XValueType = ChartValueType.Date;
            if (dateTimePicker1.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                
                if (radiobutton_Sys.Checked)
                {
              //      sys.Points.DataBindXY( selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry =>entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys).ToList());
                }
                else if (radiobutton_Dia.Checked)
                {
                //    dia.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Dia).ToList());
                }
                else if (radiobutton_Pulse.Checked)
                {
                  //  pulse.Points.DataBindXY(selectedItems.Where(entry => entry.UserId==logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Pulse).ToList());
                }
                else MessageBox.Show("Nem Választotta ki hogy mit szaretne megjelaníteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_mutat_Click(object sender, EventArgs e)
        {
             
        }
    }
}
