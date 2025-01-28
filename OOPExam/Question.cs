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
    }
}
