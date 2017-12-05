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
    public partial class UpdateEntry : Form
    {

        BAL.BusinessLogicService logicService;
        DAL.DbService dbService;
     
        public UpdateEntry()
        {
            InitializeComponent();
            logicService = BAL.BusinessLogicService.getInstance();
            dbService = DAL.DbService.getInstance();
        }

        private void UpdateEntry_Load(object sender, EventArgs e)
        {
          var allEntry=  dbService.FindAllEntriesOfUser(dbService.GetUserByUserName(logicService.CurrentUser));
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

        private void button_Save_Click(object sender, EventArgs e)
        {  if (!String.IsNullOrEmpty(textbox_Sys.Text) && !String.IsNullOrEmpty(textbox_Dia.Text) && !String.IsNullOrEmpty(textbox_Pulse.Text) && !String.IsNullOrEmpty(combobox_Date.Text))
            {
                dbService.UpdateEntryByDateAndUserId(dbService.GetUserByUserName(logicService.CurrentUser), Convert.ToDateTime(combobox_Date.Text), int.Parse(textbox_Sys.Text), int.Parse(textbox_Dia.Text), int.Parse(textbox_Pulse.Text));
                this.Close();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ha visszalép nem lesz mentve a módosítása!", "Visszalépés!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void textbox_Sys_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textbox_Dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void textbox_Pulse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
