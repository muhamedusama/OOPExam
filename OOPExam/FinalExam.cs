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

            #region MCQ Questions
            for (int j = 0; j < QuestionNo; j++)
            {
                Console.WriteLine($"Please enter Question MCQ {j + 1} Body");
                String QuestionBody = Console.ReadLine() ?? " blank Question";
                Console.WriteLine("Please enter Question Mark");
                int QuestionMark = int.Parse(Console.ReadLine());

                Console.WriteLine("Choices of the Question");
                Answer[] answers = new Answer[3];
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine($"please enter choice number {i + 1}");
                    String answertext = Console.ReadLine();
                    answers[i] = new Answer(i, answertext);
                }
                Console.WriteLine("please enter the right choice number");
                int rightchoice = int.Parse(Console.ReadLine());

                MCQ[j] = new MCQ(QuestionBody, QuestionMark, answers, rightchoice);
            }
            #endregion

            #region true or False
            for (int j = 0; j < QuestionNo; j++)
            {
                Console.WriteLine($"Please enter Question True Or False {j + 1} Body");
                String QuestionBody = Console.ReadLine() ?? " blank Question";
                Console.WriteLine("Please enter Question Mark");
                int QuestionMark = int.Parse(Console.ReadLine());
                Answer[] answers = new Answer[2];
                
                Console.WriteLine("please enter the right choice number \n 1 for True 2 for False");
                int rightchoice = int.Parse(Console.ReadLine());

                TrueOrFalse[j] = new TrueOrFalse(QuestionBody, QuestionMark, answers, rightchoice);
            }
            #endregion


            Console.WriteLine("Do you want to take the exam? \n 1 for Yes 2 for No");
            int takeexam = int.Parse(Console.ReadLine());
            if (takeexam == 1)
            {
                ShowExam();
            }

        }

        public override void ShowExam()
        {
            #region MCQ
            int[] useranswersmcq = new int[QuestionsNo * 2];
            int counter = 0;
            for (int i = 0; i < QuestionsNo; i++)
            {
                Console.WriteLine(MCQ[i].QuestionBody);
                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine($"{j + 1} ) {MCQ[i]?.answers?[j].AnswerText}");

                }
                Console.WriteLine("please enter your answer");
                int useranswer = int.Parse(Console.ReadLine());
                useranswersmcq[i] = useranswer;
            }
           
            for (int i = 0; i < QuestionsNo; i++)
            {
                Console.WriteLine(MCQ[i].QuestionBody);
               
                Console.WriteLine($"your answer {MCQ[i].answers?[useranswersmcq[i] - 1].AnswerText}");
                Console.WriteLine($"correct answer {MCQ[i]?.answers?[MCQ[i].CorrectAnswer - 1].AnswerText}");
                if (MCQ[i].answers?[useranswersmcq[i] - 1].AnswerText== MCQ[i]?.answers?[MCQ[i].CorrectAnswer - 1].AnswerText)
                {
                    counter += MCQ[i].Mark;
                }
            }
            #endregion

            #region True Or False
            int[] useranswerstrueorfalse = new int[QuestionsNo];

            for (int i = 0; i < QuestionsNo; i++)
            {
                
            }
            for (int i = 0; i < QuestionsNo; i++)
            {
                Console.WriteLine(TrueOrFalse[i].QuestionBody);

                Console.WriteLine("please enter your answer \n 1 for True and 2 for False");
                int useranswer = int.Parse(Console.ReadLine());
                useranswerstrueorfalse[i] = useranswer;

                Console.WriteLine($"your answer {useranswerstrueorfalse[i]}");
                Console.WriteLine($"correct answer {TrueOrFalse[i].CorrectAnswer}");
                if(useranswerstrueorfalse[i]== TrueOrFalse[i].CorrectAnswer)
                {
                    counter += TrueOrFalse[i].Mark;
                }

            }
            Console.WriteLine($"Your Grade is {counter}");
            Console.WriteLine("Thank You");
            #endregion
        }
    }
}
