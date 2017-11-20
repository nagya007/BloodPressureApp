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
    public partial class form_login : Form
    {
        BAL.BusinessLogicService logicService = BAL.BusinessLogicService.getInstance();
        DAL.DbService dbService = DAL.DbService.getInstance();
        LogDbContext context = new LogDbContext();
        public form_login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
