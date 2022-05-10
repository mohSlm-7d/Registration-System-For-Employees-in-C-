using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    class Enrollment
    {
        private string SID;
        private string CID;
        public Enrollment(string SID, string CID){
            this.SID = SID;
            this.CID = CID;
        }
        public void SetSID(string SID){
            this.SID = SID;
        }
        public string GetSID(){
            return this.SID;
        }
        public void SetCID(string CID){
            this.CID = CID;
        }
        public string GetCID(){
            return this.CID;
        }
    }
}
