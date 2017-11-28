using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodPressureLogApp
{
    public partial class AddUpdateRemove : Form
    {
        BAL.BusinessLogicService logicService;
        DAL.DbService dbService;
        BAL.UserOutput userOut = new BAL.UserOutput();
        public AddUpdateRemove()
        {
            InitializeComponent();
            logicService = BAL.BusinessLogicService.getInstance();
            dbService = DAL.DbService.getInstance();
           
        }
        LogDbContext context = new LogDbContext();
        private void button_Add_Click(object sender, EventArgs e)
        {
            Entry newEntry = new Entry();
            newEntry.Date = DateTime.Now;
            newEntry.Sys =int.Parse(textbox_Sys.Text);
            newEntry.Dia = int.Parse(textbox_Dia.Text);
            newEntry.Pulse = int.Parse(textbox_Pulse.Text);
            newEntry.UserId = logicService.CurrentUserId;
            newEntry.IsAm = logicService.IsAm(DateTime.Now);
            dbService.AddEntry(newEntry);
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            dbService.UpdateEntryByDateAndUserId(userOut.User,Convert.ToDateTime(combobox_Date), int.Parse(textbox_Sys.Text), int.Parse(textbox_Dia.Text), int.Parse(textbox_Pulse.Text));
            context.SaveChanges();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            dbService.RemoveEntryByDateTimeAndUserId(Convert.ToDateTime(combobox_Date), userOut.User);
        }
    }
}
