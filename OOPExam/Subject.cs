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

        public void CreateExam(Exam x)
        {
            Console.WriteLine("osama");
          
        }
    }
}
