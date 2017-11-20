using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.Properties
{
  public  class Singleton
    {
        private static Singleton uniqueInstance = null;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }

        internal class getInstance : Singleton
        {
            public getInstance()
            {
            }
        }
    }
}
