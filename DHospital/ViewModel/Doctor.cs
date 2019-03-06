using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DHospital.ViewModel
{
    [Table("Doctor_Details")]
    public class Doctors
    {
      public string Doctor_FullName { get; set;}
      public string UIN { get; set; }
      public DateTime YOE { get; set;}
      public DateTime Date_of_Birth { get; set;}
      public string Gendar { get; set;}
        [Key]
        public int Id { get; set;}
        public byte[] profile_photo { get; set;}
    }
}