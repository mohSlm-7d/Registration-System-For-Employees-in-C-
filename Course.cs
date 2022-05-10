using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    class Course: Record
    {        
        private int CreditHrs;
        public Course(String ID, string Name, int CreditHrs){
            this.ID = ID;
            this.Name = Name;
            this.CreditHrs = CreditHrs;
        }
        public void SetCreditHrs(int CreditHrs){
            this.CreditHrs = CreditHrs;
        }
        public int GetCreditHrs(){
            return this.CreditHrs;
        }
    }
}
