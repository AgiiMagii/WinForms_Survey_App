using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Views
{
    public class QuestionView
    {
        public long Id_Question { get; set; }
        public string Question1 { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public byte CorrectAnswer { get; set; }
    }
}
