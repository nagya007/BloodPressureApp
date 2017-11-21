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
            if(dateTimePicker2.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                sys.Points.DataBindXY(selectedItems.Select(entry => entry.Sys).ToList(), selectedItems.Select(entry => entry.Date).Distinct().ToList());
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null)
            {
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                sys.Points.DataBindXY(selectedItems.Select(entry => entry.Sys).ToList(), selectedItems.Select(entry => entry.Date).Distinct().ToList());
            }
        }
    }
}
