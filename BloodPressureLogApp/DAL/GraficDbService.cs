using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BloodPressureLogApp.DAL
{
    public class GraficDbService
    {
        LogDbContext context;
        DbSet<User> users;
        DbSet<Entry> entries;

        public GraficDbService()
        {
            context = new LogDbContext();
            this.users = context.Users;
            this.entries = context.Entries;
        }

        static GraficDbService instance = null;

        public static GraficDbService getInstance()
        {
            if (instance==null)
            {
                instance = new GraficDbService();
            }
            return instance;
        }
    }
}
