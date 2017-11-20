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
    public class Entry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool IsAm { get; set; }
        public int Sys { get; set; }
        public int Dia { get; set; }
        public int Pulse { get; set; }        
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public Entry() { }
        public Entry(int id)
        {
            this.Id = id;
        }
        public void entrysetup(DateTime date, int sys, int dia,int pulse,bool isam)
        {
            this.Date = date;
            this.Sys = sys;
            this.Dia = dia;
            this.Pulse = pulse;
            this.IsAm = isam;
        }
        public void entryUserId(int userId)
        {
            this.UserId = userId;
        }
    }
   
    
    
}
