using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string QuestionHeader, string QuestionBody, int mark, Answer[] answers,int CorrectAnswer) : base(QuestionHeader, QuestionBody, mark, answers,CorrectAnswer)
        { }
    }
}
