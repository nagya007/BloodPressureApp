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
    }
}
