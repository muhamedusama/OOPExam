using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class Subject
    {
        public int ID { get; set; }
        public String? SubjectName { get; set; }
        public Exam? SubjectExam { get; set; }

        public Subject(int ID, String?SubjectName)
        {
            this.ID = ID;
            this.SubjectName = SubjectName;
        }

        public Exam CreateExam(int x,int examtime,int QuestionNo)
        {
            if (x == 1)
            {
                return new PracticalExam(examtime, QuestionNo);
            }
            else
            {
                return new FinalExam(examtime, QuestionNo);
            }

        }
    }
}
