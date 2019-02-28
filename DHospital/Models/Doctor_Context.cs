using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DHospital.ViewModel;

namespace DHospital.Models
{
    public class Doctor_Context:DbContext
    {
     public DbSet<Doctors> GetDoctors { get; set; }
    }
}