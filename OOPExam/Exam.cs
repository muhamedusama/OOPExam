using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    abstract internal class Exam
    {
        public int Time { get; set; }
        public int QuestionsNo { get; set; }

        protected Exam(int Time,int QuestionNo)
        {
            this.Time = Time;
            this.QuestionsNo = QuestionNo;
        }
        public abstract void ShowExam();
    }
}
