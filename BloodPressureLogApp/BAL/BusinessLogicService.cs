using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;

namespace BloodPressureLogApp.BAL
{
    public enum Procedure
    {
        Add,
        Remove,
        Update,
    };
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
        public double GetAvgEntryByDia(IQueryable<Entry>avgEntries)
        {
          return  avgEntries.Average(avg => avg.Dia );
        }
        public double GetAvgEntryBySys(IQueryable<Entry> avgEntries)
        {
           return  avgEntries.Average(avg => avg.Sys);
        }
        public double GetAvgEntryByPulse(IQueryable<Entry> avgEntries)
        {
          return  avgEntries.Average(avg => avg.Pulse);
        }
        public double GetMinEntryBySys(IQueryable<Entry>minEntry)
        {
          return  minEntry.Min(entries => entries.Sys);
        }
        public double GetMinEntryByDia(IQueryable<Entry> minEntry)
        {
          return  minEntry.Min(entries => entries.Dia);
        }
        public double GetMinEntryByPulse(IQueryable<Entry> minEntry)
        {
          return  minEntry.Min(entries => entries.Pulse);
        }
        public double GetMaxEntryBySys(IQueryable<Entry> maxEntry)
        {
         return   maxEntry.Max(entries => entries.Sys);
        }
        public double GetMaxEntryByDia(IQueryable<Entry> maxEntry)
        {
          return  maxEntry.Max(entries => entries.Dia);
        }
        public double GetMaxEntryByPulse(IQueryable<Entry> maxEntry)
        {
          return  maxEntry.Max(entries => entries.Pulse);
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
        public IQueryable<Entry> Get(IQueryable<Entry> entris)
        {
            var OrdersByCustomer = from so in db.SalesOrders
                                   group so by so.CustomerId into TotaledOrders
                                   select new
                                   {
                                       CustomerId = TotaledOrders.Key,
                                       TotaledValue = TotaledOrders.Sum(s => s.TotalValue),
                                       Orders = TotaledOrders.ToList()
                                   };


        }
        public List<double> GetSysDistribution(IQueryable<Entry> entries)
        {
            var distValues = entries.GroupBy(e => e.Sys);
            var dist = distValues.Count(e => e.Sys);
        }


































    }
  }
