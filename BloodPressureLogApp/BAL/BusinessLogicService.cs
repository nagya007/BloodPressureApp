using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace BloodPressureLogApp.BAL
{
   public class BusinessLogicService 
   {
        public string CurrentUser {get;set;}
        public string CurrentPassword {get;set;}
        static BusinessLogicService instance = null;
        public static BusinessLogicService getInstance()
        {
            if (instance == null)
            {
                instance = new BusinessLogicService();
            }
            return instance;
        }
        public string GetPasswordHash(string password)
        {
            return password + "1";
        }       
        public void AvgEntryByUserIdAndDateTime(string user_id)
        {


        }
        public bool IsAm(DateTime date1)
        {
            if (date1.Hour < 12)
            {
                return true;
            }
            else if (date1.Hour > 12)
            {
                return false;
            }
            else { return true; }

        }

    }
  

}
