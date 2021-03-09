﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
   public class Contact : BaseEntity
    {
        public string FullName { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }    
        public string Email { get; set; }  
    }
}
