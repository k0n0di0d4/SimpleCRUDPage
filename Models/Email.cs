using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Email { 
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string EmailContent { get; set; }
    
    }
}