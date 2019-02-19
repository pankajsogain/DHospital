﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DHospital.Models
{
    [Table("User_Category")]
    public class User_Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}