using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Lib
{
    public class Validation
    {
        
        
        public static bool IsInputTextValid(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length < 1 || text.Length < 50)
            {
                return false;
            }
            return true;

        }
        public static bool IsQuestionValid(string longText)
        {
            if (string.IsNullOrWhiteSpace(longText) || longText.Length < 1 || longText.Length > 250)
            {
                return false;
            }
            return true;

        }
        
        public static bool IsInputTextValidSoFar(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length == 0) return true;
            if (text.Length > 50) return false;
            return true;
        }
        public static bool IsQuestionValidSoFar(string longText)
        {
            if (string.IsNullOrEmpty(longText) || longText.Length == 0) return true;
            if (longText.Length > 250) return false;
            return true;
        }
    }
}
