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
    public partial class Add : Form
    {
        BAL.BusinessLogicService logicService;
        DAL.DbService dbService;
       
        
        public Add()
        {
            InitializeComponent();
            logicService = BAL.BusinessLogicService.getInstance();
            dbService = DAL.DbService.getInstance();
        
        }
        LogDbContext context = new LogDbContext();
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textbox_Sys.Text)&& !String.IsNullOrEmpty(textbox_Dia.Text)&& !String.IsNullOrEmpty(textbox_Pulse.Text))
            {
                Entry newEntry = new Entry();
                newEntry.Date = DateTime.Now;
                newEntry.Sys = int.Parse(textbox_Sys.Text);
                newEntry.Dia = int.Parse(textbox_Dia.Text);
                newEntry.Pulse = int.Parse(textbox_Pulse.Text);
                newEntry.UserId = logicService.CurrentUserId;
                newEntry.IsAm = logicService.IsAm(DateTime.Now);
                dbService.AddEntry(newEntry);
                this.Close();
            }           
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Nem lesznek mentve az adatok", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
           
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
