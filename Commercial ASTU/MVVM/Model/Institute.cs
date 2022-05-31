using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_ASTU.MVVM.Model
{
    internal class Institute
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; } 
    }
}
