using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity;
using System.Xml.XPath;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;



namespace BloodPressureLogApp.DAL
{
    class DbService
    {
      public  LogDbContext context;
      public  DbSet<User> users;
      public    DbSet<Entry> entries;
       // IQueryable<Entry> filterdEntries;
        static DbService instance = null;
        public DbService()
        {
            context = new LogDbContext();
            this.users = context.Users;
            this.entries = context.Entries;
        }
        public static DbService getInstance()
        {
            if (instance == null)
            {
                instance = new DbService();
            }
            return instance;
        }
        public bool AddUser(User user)
        {
            if (this.users.Add(user).Equals(user))
            {
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public bool AddEntry(Entry entry)
        {
            if (this.entries.Add(entry).Equals(entry))
            {
                context.SaveChanges();
                return true;
            }
            return false;

        }
        public IQueryable<Entry> FindAllEntriesOfUser(User user)
        {
            return entries.Where(entry => entry.UserId == user.Id).OrderBy(entry => entry.Date);
        }
        public IQueryable<Entry> GetEntryiesByDayPart(User user, bool isAm)
        {
            return this.entries.Where(entry => entry.UserId == user.Id && entry.IsAm == isAm);
        }
       
        public IQueryable<Entry> GetEntryiesByDayPart2(IQueryable<Entry> entries,bool isAm)
        {
            return entries.Where(entry => entry.IsAm == isAm);
        }
        public IQueryable<Entry> GetEntriesByDateRangeAndUser(DateTime date1, DateTime date2, User user)
        {
            return this.entries.Where(entry => (entry.UserId == user.Id && entry.Date >= date1 && entry.Date <= date2));
        }
        public Entry GetEntriesByDateAndUser(DateTime date1, User user)
        {
            return this.entries.First(entry => (entry.UserId == user.Id && entry.Date == date1));
        }
        public User GetUserByUserName(string username)
        {
            return this.users.FirstOrDefault(u => u.UserName == username);
        }
        public bool IsUserExists(String username)
        {
            return this.users.Any(u => u.UserName == username);
        }
        public bool RemoveEntryByDateTimeAndUserId(DateTime date1, User user)
        { var result = this.entries.SingleOrDefault(entries => entries.UserId == user.Id && entries.Date == date1);

            if (result != null)
            {
                entries.Remove(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateEntryByDateAndUserId(User user, DateTime date1, int sys, int dia, int pulse)
        {

            var result = this.entries.SingleOrDefault(entries => entries.UserId == user.Id && entries.Date == date1);
            if (result != null)
            {
                result.Sys = sys;
                result.Dia = dia;
                result.Pulse = pulse;
                context.SaveChanges();

                return true;

            }
            return false;
        }

        
        
    }
}
