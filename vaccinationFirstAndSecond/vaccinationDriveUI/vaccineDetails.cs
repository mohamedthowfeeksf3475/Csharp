using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaccinationDriveUI
{
    class vaccineDetails
    {
        public vaccineTypes vaccineType { get; set; }
        public string dosage { get; set; }
        public DateTime vaccinatedDate { get; set; }
        public vaccineDetails(vaccineTypes vaccineType, DateTime vaccinatedDate)
        {
            this.vaccineType = vaccineType;
            this.vaccinatedDate = vaccinatedDate;

        }
    }
        public enum vaccineTypes
        {
            Covaxin,
            Covishield,
            sputnic
        }


    
    

}
