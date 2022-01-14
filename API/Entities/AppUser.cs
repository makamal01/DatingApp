using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        //fields
        //Naming this in this order and Manner is important
        public int Id { get; set; } //primary Key
        public string UserName { get; set; }
        
    }
}