using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal interface IExam
    {
        public int Time { get; set; }
        public int QuestionsNo { get; set; }

        public void ShowExam();
    }
}
