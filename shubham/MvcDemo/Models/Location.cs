using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Models
{
    public class Location
    {
        [Key]
       public int Id { get; set; }
        public string Name { get; set; }
    }
}
