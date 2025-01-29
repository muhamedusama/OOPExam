namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the type of the exam (1 for Practical | 2 for final)");
            int examtype = int.Parse(Console.ReadLine());
            Exam exam;

            Console.WriteLine("Please enter the time for the Exam");
            int examtime=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Questions");
            int QuestionNo=int.Parse(Console.ReadLine());

            if (examtype == 1)
            {
                exam = new PracticalExam(examtime,QuestionNo);
            }
            //else
            //{
            //     exam = new FinalExam(examtime,QuestionNo);
            //}





        }
    }
}
