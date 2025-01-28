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
        public IExam SubjectExam { get; set; }

        public void CreateExam(IExam x)
        {
            SubjectExam = x;
        }
    }
}
