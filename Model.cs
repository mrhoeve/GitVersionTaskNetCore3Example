using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore3
{
    public class Model
    {
        [Key]
        public string Naam { get; set; }
    }
}
