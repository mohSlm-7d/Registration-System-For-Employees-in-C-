using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    class Record
    {
        protected string ID;
        protected string Name;
        public Record()
        {
            
        }
        public void SetID(String ID)
        {
            this.ID = ID;
        }
        public String GetID()
        {
            return this.ID;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
