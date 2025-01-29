using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class PracticalExam : Exam
    {

        MCQ[] MCQ { get; set; }
        public PracticalExam(int Time, int QuestionNo) : base(Time, QuestionNo)
        {
            MCQ = new MCQ[QuestionNo];

            for (int j=1;j<=QuestionNo;j++)
            {
                Console.WriteLine($"Please enter Question {j} Body");
                String QuestionBody=Console.ReadLine()??" blank Question";
                Console.WriteLine("Please enter Question Mark");
                int QuestionMark = int.Parse(Console.ReadLine());

                Console.WriteLine("Choices of the Question");
                Answer[] answers = new Answer[3];
                for (int i=1;i<=3;i++)
                {
                    Console.WriteLine($"please enter choice number {i}");
                    String answertext = Console.ReadLine();
                    answers[i-1] = new Answer(i, answertext);
                }
                Console.WriteLine("please enter the right choice number");
                int rightchoice=int.Parse(Console.ReadLine());

                MCQ[j-1] = new MCQ(QuestionBody,QuestionMark,answers,rightchoice);
            }
            Console.WriteLine("Do you want to take the exam? /n 1 for Yes 2 for No");
            int takeexam=int.Parse(Console.ReadLine());
            if (takeexam == 1)
            {
                ShowExam();
            }


        }

        public override void ShowExam()
        {
            int[] useranswers = new int[QuestionsNo];

            for (int i = 0; i < QuestionsNo; i++)
            {
                Console.WriteLine(MCQ[i].QuestionBody);
                for (int j=0;j<=2;j++)
                {
                    Console.WriteLine($"{j+1} ) {MCQ[i]?.answers?[j].AnswerText}");
                    
                }
                Console.WriteLine("please enter your answer");
                int useranswer=int.Parse(Console.ReadLine());
                useranswers[i] = useranswer;
            }

            for (int i = 0; i < QuestionsNo; i++)
            {
                Console.WriteLine(MCQ[i].QuestionBody);
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine($"{j + 1} ) {MCQ[i]?.answers?[j].AnswerText}");

                }
                Console.WriteLine($"your answer {MCQ[i].answers?[useranswers[i]].AnswerText}");
                Console.WriteLine($"correct answer {MCQ[i]?.answers?[MCQ[i].CorrectAnswer].AnswerText}");
                
            }

        }
    }
}
