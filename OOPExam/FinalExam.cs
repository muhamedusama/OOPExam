using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class FinalExam : Exam
    {
        MCQ [] MCQ {  get; set; }
        TrueOrFalse [] TrueOrFalse { get; set; }
        public FinalExam(int Time, int QuestionNo) : base(Time, QuestionNo)
        {
            MCQ = new MCQ[QuestionNo];
            TrueOrFalse = new TrueOrFalse[QuestionNo]; 
        }

        public override void ShowExam()
        {
            for (int i = 0; i < MCQ.Length; i++)
            {
                Console.Write(MCQ[i]);
            }
            for (int i = 0; i < TrueOrFalse.Length; i++)
            {
                Console.Write(MCQ[i]);
            }
        }
    }
}
