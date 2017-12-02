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

namespace BloodPressureLogApp
{
    public partial class Fr_belep : Form
    {
        BAL.BusinessLogicService logicService;
        DAL.DbService dbService;

        public Fr_belep()
        {
            InitializeComponent();
            logicService = BAL.BusinessLogicService.getInstance();
            dbService = DAL.DbService.getInstance();
        }
        LogDbContext context = new LogDbContext();        
        private void bt_Reg_Click(object sender, EventArgs e)
        {
            if (!dbService.IsUserExists(tb_UserName.Text))
            {
                logicService.CurrentUser = tb_UserName.Text;
                logicService.CurrentPassword = tb_Password.Text;
              
                fr_Reg Reg = new fr_Reg();
                Reg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Már regisztrált felhasználónév válasszon másikat vagy jelentkezzen be!", "Már regisztrált", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            var users = context.Users;
            var entries = context.Entries;
            var currentUser = dbService.GetUserByUserName(tb_UserName.Text);
            if (currentUser != null && currentUser.Password == tb_Password.Text)
            {
                logicService.CurrentUser = currentUser.UserName;
                logicService.CurrentPassword = currentUser.Password;
                logicService.CurrentUserId = currentUser.Id;
                main Log = new main();
                Log.ShowDialog();
                this.Hide();

            }
            else {
                MessageBox.Show("Nincs ilyen felhasználó, vagy téves Jelszó!");
            }
        }
        private void Fr_belep_Load(object sender, EventArgs e)
        {
          
        }
    }
}
