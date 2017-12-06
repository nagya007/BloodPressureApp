namespace BloodPressureLogApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using System.Security.Cryptography;

    internal sealed class Configuration : DbMigrationsConfiguration<BloodPressureLogApp.LogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false ;
        }

        protected override void Seed(BloodPressureLogApp.LogDbContext context)
        {
            var hmacSHA256 = new HMACSHA256(Encoding.UTF8.GetBytes("JagerMeister"));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                x => x.Id,
                 new User()
                 {
                     
                     UserName = "valaki01",
                     Name = "Toth Valaki01",
                     Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("pass123"))),
                     Adress = "Varos, utca 1",
                     PhoneNumber = "+36703999999",
                     BirthDate = Convert.ToDateTime("1990-09-09")
                 },
                new User() { UserName = "kisp",   Name = "Kis Péter", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("hetzh"))), Adress = "Úri", PhoneNumber = "0630597563", BirthDate = Convert.ToDateTime("1996-07-06")},
                new User() { UserName = "nagye",  Name = "Nagy Endre", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("geriog"))), Adress = "Eger", PhoneNumber = "06308489635", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kovacsa",  Name = "Kovács András", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("egrge"))), Adress = "Gyömrõ", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "tothz",  Name = "Tóth Zoltán", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("egrgre"))), Adress = "Pest", PhoneNumber = "0630785391", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "tothka",   Name = "Tóth Zoltán", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("egrgre"))), Adress = "Pest", PhoneNumber = "06301875632", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "szantok",   Name = "Szántó Kincsõ", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("reger"))), Adress = "Buda", PhoneNumber = "063011557799", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kissb",   Name = "Kiss Bence", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("erqgrg"))), Adress = "Dunaújváros", PhoneNumber = "06305369715", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "nandorfiv", Name = "Nándorfi Viktória", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("lioépjhz"))), Adress = "Szentlõrickáta", PhoneNumber = "0630", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "nagyb",  Name = "Nagy Benedek", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("wnmcxv"))), Adress = "Pécs", PhoneNumber = "06307539641", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "fazekask",   Name = "Fazekas Krisztián", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("pgrega"))), Adress = "Kóka", PhoneNumber = "06308514996", BirthDate = Convert.ToDateTime("1996-07-06") },
                new User() { UserName = "kalcsoa",  Name = "Kalcsó Árpád", Password = Encoding.UTF8.GetString(hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes("jsrjzjsz"))), Adress = "Érd", PhoneNumber = "06301289635", BirthDate = Convert.ToDateTime("1996-07-06") });


            context.SaveChanges();

            context.Entries.AddOrUpdate(
              x => x.Id,

                    new Entry()
                    {   
                        UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-06-22 22:30"),
                        IsAm = false
                    },
                    new Entry()
                    {
                        UserId = context.Users.FirstOrDefault(u => u.UserName == "kissb").Id,
                        Sys = 120,
                        Dia = 60,
                        Pulse = 60,
                        Date = Convert.ToDateTime("2017-06-23 12:30"),
                        IsAm = false
                    },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-01 09:30"),IsAm=true},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "nagye").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-02 23:30"),IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-03 06:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "nagye").Id, Sys = 120, Dia = 60, Pulse = 60, Date = Convert.ToDateTime("2017-06-04 20:30"), IsAm = false},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "fazekask").Id, Sys = 110, Dia = 70, Pulse = 56, Date = Convert.ToDateTime("2017-06-05 23:50"), IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 118, Dia = 65, Pulse = 62, Date = Convert.ToDateTime("2017-06-06 13:30"), IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 125, Dia = 55, Pulse = 55, Date = Convert.ToDateTime("2017-06-07 09:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 105, Dia = 69, Pulse = 120, Date = Convert.ToDateTime("2017-06-08 22:30"), IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 128, Dia = 88, Pulse = 90, Date = Convert.ToDateTime("2017-06-09 04:30"), IsAm = true }, 
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 130, Dia = 45, Pulse = 50, Date = Convert.ToDateTime("2017-06-10 09:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 111, Dia = 70, Pulse = 110, Date = Convert.ToDateTime("2017-06-11 05:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 122, Dia = 62, Pulse = 100, Date = Convert.ToDateTime("2017-06-12 19:30"), IsAm = false},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 145, Dia = 68, Pulse = 60, Date = Convert.ToDateTime("2017-06-13 09:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 101, Dia = 55, Pulse = 75, Date = Convert.ToDateTime("2017-06-14 20:30"), IsAm = false},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 110, Dia = 49, Pulse = 63, Date = Convert.ToDateTime("2017-06-15 09:30"), IsAm = true }, 
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 99, Dia = 59, Pulse = 59, Date = Convert.ToDateTime("2017-06-16 19:10"), IsAm = false},
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 136, Dia = 72, Pulse = 86, Date = Convert.ToDateTime("2017-06-17 06:25"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 105, Dia = 56, Pulse = 71, Date = Convert.ToDateTime("2017-06-18 23:30"), IsAm = false },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 111, Dia = 73, Pulse = 115, Date = Convert.ToDateTime("2017-06-20 02:30"), IsAm = true },
                    new Entry() { UserId = context.Users.FirstOrDefault(u => u.UserName == "valaki01").Id, Sys = 139, Dia = 51, Pulse = 69, Date = Convert.ToDateTime("2017-06-20 21:30"), IsAm = false }


                );

        }       
    }
}
 
