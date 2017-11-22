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
        public int CurrentUserId { get; set; }
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
        public void GetAvgEntryByDia(IQueryable<Entry>avgEntries)
        {
          avgEntries.Average(avg => avg.Dia );
        }
        public void GetAvgEntryBySys(IQueryable<Entry> avgEntries)
        {
            avgEntries.Average(avg => avg.Sys);
        }
        public void GetAvgEntryByPulse(IQueryable<Entry> avgEntries)
        {
            avgEntries.Average(avg => avg.Pulse);
        }
        public void GetMinEntryBySys(IQueryable<Entry>minEntry)
        {
            minEntry.Min(min => min.Sys);
        }
        public void GetMinEntryByDia(IQueryable<Entry> minEntry)
        {
            minEntry.Min(min => min.Dia);
        }
        public void GetMinEntryByPulse(IQueryable<Entry> minEntry)
        {
            minEntry.Min(min => min.Pulse);
        }
        public void GetMaxEntryBySys(IQueryable<Entry> maxEntry)
        {
            maxEntry.Max(max => max.Sys);
        }
        public void GetMaxEntryByDia(IQueryable<Entry> maxEntry)
        {
            maxEntry.Max(max => max.Dia);
        }
        public void GetMaxEntryByPulse(IQueryable<Entry> maxEntry)
        {
            maxEntry.Max(max => max.Pulse);
        }
        public bool IsAm(DateTime date1)
        {
            if (date1.Hour < 12)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public IQueryable<Entry> GetEntriesByDayPart(IQueryable<Entry> rangeEntries, bool isAm)
        {
            return rangeEntries.Where(entry => entry.IsAm == isAm);
        }        
    }
  }
