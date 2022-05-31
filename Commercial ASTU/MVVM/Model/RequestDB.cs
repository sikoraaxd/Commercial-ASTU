using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commercial_ASTU.MVVM.Model
{
    internal class RequestDB
    {
        [Key]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Guid InstituteID { get; set; }
        public Guid CafedraID { get; set; }
        public Guid TeacherID { get; set; }
        public double Hours { get; set; }
        public string Disciplines { get; set; }
    }
}
