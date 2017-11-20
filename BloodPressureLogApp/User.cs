using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodPressureLogApp
{
   public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string  PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public User() { }
        public User(string userName)
        {
            this.UserName = userName;
        }
        public void setUser(string fullName, string address, string phoneNumber, DateTime birthDate)
        {
            this.Name = fullName;
            this.Adress = address;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
        }
    }
}
