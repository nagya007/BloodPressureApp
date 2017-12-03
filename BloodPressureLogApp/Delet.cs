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
    public partial class Delet : Form
    {
        BAL.BusinessLogicService logicService;
        DAL.DbService dbService;

        public Delet()
        {
            InitializeComponent();
            logicService = BAL.BusinessLogicService.getInstance();
            dbService = DAL.DbService.getInstance();
        }

        private void Delet_Load(object sender, EventArgs e)
        {
            var allEntry = dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
            foreach (var entry in allEntry)
            {
                combobox_Date.Items.Add(entry.Date);
            }
        }

        private void combobox_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entry = dbService.GetEntriesByDateAndUser(Convert.ToDateTime(combobox_Date.Text), dbService.GetUserByUserName(logicService.CurrentUser));
            textbox_Sys.Text = entry.Sys.ToString();
            textbox_Dia.Text = entry.Dia.ToString();
            textbox_Pulse.Text = entry.Pulse.ToString();
        }

        private void button_Delet_Click(object sender, EventArgs e)
        {
            dbService.RemoveEntryByDateTimeAndUserId(Convert.ToDateTime(combobox_Date.Text), dbService.GetUserByUserName(logicService.CurrentUser));
            this.Close();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ha visszalép nem lesz törölve az adat!", "Visszalépés!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
