using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class MCQ : Question
    {
        public MCQ(string QuestionBody, int mark, Answer[] answers, int CorrectAnswer) : base("MCQ", QuestionBody, mark, answers,CorrectAnswer)
        {
            
        }
    }
}
