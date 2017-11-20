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
    public partial class fr_Reg : Form
    {
        public fr_Reg()
        {
          
            InitializeComponent();
        }
        BAL.BusinessLogicService logicService = BAL.BusinessLogicService.getInstance();
        DAL.DbService dbService = DAL.DbService.getInstance();
        private void bt_Save_Click(object sender, EventArgs e)
        {
            User newUser = new User(logicService.CurrentUser);
            newUser.Password = logicService.GetPasswordHash(logicService.CurrentPassword);
            newUser.setUser(tb_Name.Text,tb_Addres.Text,tb_PhoneNumber.Text, dtp_BirhDate.Value);
            dbService.AddUser(newUser);
            this.Close();
        }
        private void bt_Back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ha visszalép nem lesz mentve a regisztrációja!", "Visszalépés!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else {  }
            
        }
    }
}
