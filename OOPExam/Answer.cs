using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class Answer
    {
        public int AnswerID { get; set; }
        public String? AnswerText { get; set; }
        public Answer(int AnswerID, String AnswerText)
        {
            this.AnswerID = AnswerID;
            this.AnswerText = AnswerText;
        }
    }
}
