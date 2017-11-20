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
                 new User("valaki01")
                 {
                     Id = 0,
                     
                     Name = "Toth Valaki01",
                     Password = "pass123",
                     Adress = "Varos, utca 1",
                     PhoneNumber = "+36703999999",
                     BirthDate = Convert.ToDateTime("1990-09-09")
                 },
                new User("kisp") { Id = 1,  Name = "Kis Péter", Password = "hetzh", Adress = "Úri", PhoneNumber = "0630597563", BirthDate = Convert.ToDateTime("1996-07-06")},
                new User("nagye") { Id = 2, Name = "Nagy Endre", Password = "geriog", Adress = "Eger", PhoneNumber = "06308489635", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("kovacsa") { Id = 3, Name = "Kovács András", Password = "egrge", Adress = "Gyömrõ", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("tothz") { Id = 4, Name = "Tóth Zoltán", Password = "egrgre", Adress = "Pest", PhoneNumber = "0630785391", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("tothz") { Id = 5,  Name = "Tóth Zoltán", Password = "egrgre", Adress = "Pest", PhoneNumber = "06301875632", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("szantok") { Id = 6,  Name = "Szántó Kincsõ", Password = "reger", Adress = "Buda", PhoneNumber = "063011557799", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("kissb") { Id = 7,  Name = "Kiss Bence", Password = "erqgrg", Adress = "Dunaújváros", PhoneNumber = "06305369715", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("nandorfiv") { Id = 8, Name = "Nándorfi Viktória", Password = "lioépjhz", Adress = "Szentlõrickáta", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("nagyb") { Id = 9,  Name = "Nagy Benedek", Password = "wnmcxv", Adress = "Pécs", PhoneNumber = "06307539641", BirthDate = Convert.ToDateTime("1996-07-06 22:30") },
                new User("fazekask") { Id = 10,  Name = "Fazekas Krisztián", Password = "pgrega", Adress = "Kóka", PhoneNumber = "06308514996", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User("kalcsoa") { Id = 11,  Name = "Kalcsó Árpád", Password = "jsrjzjsz", Adress = "Érd", PhoneNumber = "06301289635", BirthDate = Convert.ToDateTime("1996-07-06") });


            context.Entries.AddOrUpdate(
                x => x.Id,

                    new Entry()
                    {
                        UserId = 1,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-04-25 22:30")
                    },
                    new Entry()
                    {
                        UserId = 2,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-05-26 12:30")
                    },
                    new Entry() { UserId = 1, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-27 09:30"),IsAm=true},
                    new Entry() { UserId = 3, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-07-28 23:30"),IsAm = false },
                    new Entry() { UserId = 1, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-08-29 06:30"), IsAm = true },
                    new Entry() { UserId = 4, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-09-24 20:30"), IsAm = false},
                    new Entry() { UserId = 2, Sys = 110, Dia = 70, Pulse = 56, Date = Convert.ToDateTime("2017-06-11 23:50"), IsAm = false }


                );

        }       
    }
}
 
