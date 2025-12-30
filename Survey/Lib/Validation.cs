using Survey.Properties;
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
        
        
        //public static bool IsInputTextValid(string text)
        //{
        //    if (string.IsNullOrWhiteSpace(text) || text.Length < 1 || text.Length < 50)
        //    {
        //        return false;
        //    }
        //    return true;

        //}
        //public static bool IsQuestionValid(string longText)
        //{
        //    if (string.IsNullOrWhiteSpace(longText) || longText.Length < 1 || longText.Length > 250)
        //    {
        //        return false;
        //    }
        //    return true;

        //}
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
        public List<string> TestValidation(Test test)
        {
            List<string> results = new List<string>();

            if (test.Name.Length < 2 || test.Author.Length < 2)
            {
                results.Add(Messages.Error_TextTooShort);
            }
            if (test.Name.Length > 50 || test.Author.Length > 50)
            {
                results.Add(Messages.Error_TextTooLong);
            }
            return results;
        }
        public List<string> QuestionValidation(Question question)
        {
            List<string> results = new List<string>();
            if (question.Question1.Length < 2 ||
                question.Answer1.Length < 1 ||
                question.Answer2.Length < 1 ||
                question.Answer3.Length < 1 ||
                question.Answer4.Length <1)
            {
                results.Add(Messages.Error_TextTooShort);
            }
            if (question.Question1.Length > 250 ||
                question.Answer1.Length > 50 ||
                question.Answer2.Length > 50 ||
                question.Answer3.Length > 50 ||
                question.Answer4.Length > 50)
            {
                results.Add(Messages.Error_TextTooLong);
            }
            return results;
        }
    }
}
