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
        Series sys = null;
        


        IQueryable<Entry> selectedItems;

        public main()
        {
            InitializeComponent();
            sys = chart1.Series.Add("Sys");
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sys.XAxisType = AxisType.Primary;
            sys.XValueType= ChartValueType.Date;
            if(dateTimePicker2.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                if (radiobutton_Sys.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList(),selectedItems.Select(entry => entry.Sys).ToList());
                  
                }
                else if (radiobutton_Dia.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList(), selectedItems.Select(entry => entry.Sys).ToList());
                } else if (radiobutton_Pulse.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList(), selectedItems.Select(entry => entry.Sys).ToList());
                }
                else MessageBox.Show("Nem Választotta ki hogy mit szaretne megjelaníteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            sys.XAxisType = AxisType.Primary;
            sys.XValueType = ChartValueType.Date;
            if (dateTimePicker1.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                
                if (radiobutton_Sys.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList()), selectedItems.Select(entry => entry.Sys).ToList());
                }
                else if (radiobutton_Dia.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList(), selectedItems.Select(entry => entry.Sys).ToList());
                }
                else if (radiobutton_Pulse.Checked)
                {
                    sys.Points.DataBindXY(selectedItems.Select(entry => entry.Date).Distinct().ToList(), selectedItems.Select(entry => entry.Sys).ToList());
                }
                else MessageBox.Show("Nem Választotta ki hogy mit szaretne megjelaníteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
