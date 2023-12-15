using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    class Student: Record
    {        
        private string Gender;
        private int BirthYear;
        public Student(String ID, string Name, string Gender, int BirthYear=2021){
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.BirthYear = BirthYear;
        }        
        public void SetGender(String Gender){
            this.Gender = Gender;
        }
        public string GetGender(){
            return this.Gender;
        }
        public void SetBirthYear(int BirthYear){
            this.BirthYear = BirthYear;
        }
        public int GetBirthYear(){
            return this.BirthYear;
        }
        
    }
    
}
