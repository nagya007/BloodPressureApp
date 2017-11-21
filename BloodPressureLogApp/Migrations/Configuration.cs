namespace BloodPressureLogApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BloodPressureLogApp.LogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false ;
        }

        protected override void Seed(BloodPressureLogApp.LogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                x => x.Id,
                 new User()
                 {
                     
                     UserName = "valaki01",
                     Name = "Toth Valaki01",
                     Password = "pass123",
                     Adress = "Varos, utca 1",
                     PhoneNumber = "+36703999999",
                     BirthDate = Convert.ToDateTime("1990-09-09")
                 },
                new User() { UserName = "kisp",   Name = "Kis Péter", Password = "hetzh", Adress = "Úri", PhoneNumber = "0630597563", BirthDate = Convert.ToDateTime("1996-07-06")},
                new User() { UserName = "nagye",  Name = "Nagy Endre", Password = "geriog", Adress = "Eger", PhoneNumber = "06308489635", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kovacsa",  Name = "Kovács András", Password = "egrge", Adress = "Gyömrõ", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "tothz",  Name = "Tóth Zoltán", Password = "egrgre", Adress = "Pest", PhoneNumber = "0630785391", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "tothka",   Name = "Tóth Zoltán", Password = "egrgre", Adress = "Pest", PhoneNumber = "06301875632", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "szantok",   Name = "Szántó Kincsõ", Password = "reger", Adress = "Buda", PhoneNumber = "063011557799", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kissb",   Name = "Kiss Bence", Password = "erqgrg", Adress = "Dunaújváros", PhoneNumber = "06305369715", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "nandorfiv", Name = "Nándorfi Viktória", Password = "lioépjhz", Adress = "Szentlõrickáta", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "nagyb",  Name = "Nagy Benedek", Password = "wnmcxv", Adress = "Pécs", PhoneNumber = "06307539641", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "fazekask",   Name = "Fazekas Krisztián", Password = "pgrega", Adress = "Kóka", PhoneNumber = "06308514996", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kalcsoa",  Name = "Kalcsó Árpád", Password = "jsrjzjsz", Adress = "Érd", PhoneNumber = "06301289635", BirthDate = Convert.ToDateTime("1996-07-06") });


            context.SaveChanges();

            context.Entries.AddOrUpdate(
              x => x.Id,

                    new Entry()
                    {   
                        UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-04-25 22:30"),
                        IsAm = false
                    },
                    new Entry()
                    {
                        UserId = context.Users.FirstOrDefault(u => u.UserName == "kissb").Id,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-05-26 12:30"),
                        IsAm = false
                    },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-27 09:30"),IsAm=true},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "nagye").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-07-28 23:30"),IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-08-29 06:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "nagye").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-09-24 20:30"), IsAm = false},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "fazekask").Id, Sys = 110, Dia = 70, Pulse = 56, Date = Convert.ToDateTime("2017-06-11 23:50"), IsAm = false }


                );

        }       
    }
}
 
