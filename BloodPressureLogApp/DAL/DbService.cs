﻿using System;
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
        LogDbContext context;
        DbSet<User> users;
        DbSet<Entry> entries;
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
        public bool IsUserExists(string username)
        {
            return this.users.Any(user => user.UserName == username);
        }
        public User GetUserByUserName(string username)
        {
            return this.users.FirstOrDefault(user => user.UserName == username);
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
        public bool RemoveEntryByDateTimeAndUserId(DateTime date1,int user_id)
        {   var result = entries.SingleOrDefault(entries => entries.UserId == user_id && entries.Date == date1);
            
                if(result!=null)
            {
                entries.Remove(result);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateEntryByDateAndUserId(int user_id, DateTime date1, int sys, int dia, int pulse)
        {
           
                var result = this.entries.SingleOrDefault(entries  => entries.UserId == user_id && entries.Date==date1);
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
        public IEnumerable<DateTime> GetDateListBetweenTwoDates(DateTime date1, DateTime date2)
        {
            List<DateTime> dates = new List<DateTime>();
            return dates.Where(d => d >= date1 && d < date2);
        }
      
       


    }
}
