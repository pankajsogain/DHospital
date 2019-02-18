using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHospital.ViewModel
{
    public class Doctor
    {      
       public Guid Reg_No { get; set; }
       public int Doctor_Id {get; set;}
       public string Doctor_FullName { get; set; }
       public string UIN { get; set;}
       public string YOE { get; set; } // year of experiance
       public DateTime Date_of_Birth { get; set; }
       public string Gendar { get; set;}
    }
}