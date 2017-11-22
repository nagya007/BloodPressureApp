using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BloodPressureLogApp.BAL
{
    class GraficLogicService
    {   static GraficLogicService instance = null;
        public static GraficLogicService getInstance()
        {
            if (instance == null)
            {
                instance = new GraficLogicService();
            }
            return instance;
        }
       
      
    }
}
