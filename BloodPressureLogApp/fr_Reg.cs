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
            if (!String.IsNullOrEmpty(tb_Addres.Text) && !String.IsNullOrEmpty(tb_Name.Text) && !String.IsNullOrEmpty(tb_PhoneNumber.Text))
            {

                User newUser = new User();
                newUser.UserName = logicService.CurrentUser;
                newUser.Password = logicService.GetPasswordHash(logicService.CurrentPassword);
                newUser.Name = tb_Name.Text;
                newUser.Adress = tb_Addres.Text;
                newUser.PhoneNumber = tb_PhoneNumber.Text;
                newUser.BirthDate = dtp_BirhDate.Value;
                dbService.AddUser(newUser);
                this.Close();
            }
            else
            {
                MessageBox.Show("Valamelyik mező üresen maradt!", "Hiányos adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
