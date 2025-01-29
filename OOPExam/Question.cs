using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract internal class Question
    {
        public String? QuestionHeader { get; set; }
        public String? QuestionBody { get; set; }
        public int  Mark { get; set; }
        public Answer[]? answers {  get; set; }

        public int CorrectAnswer { get; set; }  
        
        protected Question(String QuestionHeader,String QuestionBody,int mark, Answer[] answers,int CorrectAnswer)
        {
            this.QuestionHeader = QuestionHeader;
            this.QuestionBody = QuestionBody;
            this.Mark = mark;
            this.answers = answers;
            this.CorrectAnswer = CorrectAnswer;
        }
    }
}
