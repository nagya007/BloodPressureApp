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
                this.label1.Text = rb.Text;
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
                selectedItems = dbService.GetEntriesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);
                if (radiobutton_Sys.Checked)
                {
                  
                //    DataPoint newDatapointSys = new DataPoint();
                //    newDatapointSys.SetValueXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys));
                //    chart1.Series["Sys"].Points.Add(newDatapointSys);
                //     sys.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(),selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys).ToList());

                }
                else if (radiobutton_Dia.Checked)
                {
                  
                    // Dia.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Dia).ToList());
                }
                else if (radiobutton_Pulse.Checked)
                {
                  
                    //Pulse.Points.DataBindXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date).Distinct().ToList(), selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Pulse).ToList());
                }
                else MessageBox.Show("Nem Választotta ki hogy mit szaretne megjelaníteni!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
         {
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
            DataPoint newDatapointSys = new DataPoint();
            var graficdata = dbService.GetEntriesByDayPartAndDataType(logicService.CurrentUserId, dayPart, dataType);



            foreach (var item in graficdata)
            {
                newDatapointSys.SetValueXY(Convert.ToDateTime(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date)), item);
                chart1.Series["Sys"].Points.Add(newDatapointSys);
            }

            //newDatapointSys.SetValueXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date), graficdata.Select(entry => entry));
            //chart1.Series["Sys"].Points.Add(newDatapointSys);
            //foreach (var item in graficdata)
            //{
            //    newDatapointSys.SetValueXY(selectedItems.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Date), graficdata.Where(entry => entry.UserId == logicService.CurrentUserId).Select(entry => entry.Sys).ToList());
            //}
            //chart1.Series["Sys"].Points.Add(newDatapointSys);

            BAL.UserOutput userOut = new BAL.UserOutput();
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
