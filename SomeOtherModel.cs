using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore3
{
    public class SomeOtherModel
    {
        [Key]
        public Guid guidId { get; set; }
    }
}
