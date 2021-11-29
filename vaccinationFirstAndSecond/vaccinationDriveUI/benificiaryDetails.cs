using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccinationDriveUI
{
    class benificiaryDetails
    {
        public int registrationNumber { get; set; }
        public string name { get; set; }
        public long mobileNumber { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public List<vaccineDetails> vaccinationDetails { get; set; }
        public benificiaryDetails(string name, long mobileNo, string address, int age, string gender, int registerno)
        {
            this.name = name;
            this.mobileNumber = mobileNo;
            this.address = address;
            this.age = age;
            this.gender = gender;
            this.registrationNumber = registerno++;


        }


    }
}
       

        
        


        
       
        


