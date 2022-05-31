using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Commercial_ASTU.MVVM.Model
{
    internal class RequestView
    {
        public Guid ID { get; set; }
        public Button Info { get; set; }

        public Button Accept { get; set; }

        public Button Delete { get; set; }
    }
}
