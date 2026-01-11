using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Views
{
    public class TestView
    {
        public long Id_Test { get; set; }
        public string Name { get; set; }
        public Nullable<short> Duration { get; set; }
        public string Author { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

       
    }
}
