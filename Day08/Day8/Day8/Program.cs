using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Program
    {
        static void Main()
        {

            //====================Choose One=======================//
            ChooseOne question = new ("Which of the following is a reserved keyword in C#?", 4, "d");
            AnswerList anss = new ();
            anss.Add(new Answer("A- abstract"));
            anss.Add(new Answer("B- as"));
            anss.Add(new Answer("C- foreach"));
            anss.Add(new Answer("D- All of the above."));
            
            //====================True and False=======================//
            TrueAndFalse questionTF = new ("Dynamic polymorphism is implemented by abstract classes and virtual functions.", 5, "t");
            AnswerList ansTF = new ();
            ansTF.Add(new Answer(" True"));
            ansTF.Add(new Answer(" False"));

            //====================Choose All=======================//
            ChooseAll questionAll = new ("Which of the following is true about try block in C#", 8, "a,c");
            AnswerList answers = new ();
            answers.Add(new Answer("A- A try block identifies a block of code for which particular exceptions is activated."));
            answers.Add(new Answer("B- It is not followed by one or more catch blocks."));
            answers.Add(new Answer("C- It is followed by one or more catch blocks."));
            answers.Add(new Answer("D- None of the above"));
            
            //====================Dictionary=======================//
            Dictionary<Question, AnswerList> QuesAnsDic = new ();
            QuesAnsDic.Add(question,anss);
            QuesAnsDic.Add(questionTF,ansTF);
            QuesAnsDic.Add(questionAll,answers);

            //====================QList To be saved to file=======================//
            QuestionList QuesList = new();
            for (int i = 0; i < QuesAnsDic.Count; i++)
            {
                QuesList.Add(QuesAnsDic.Keys.ElementAt(i));
            }
            int finalMark=new();
            for (int i = 0; i < QuesList.Count; i++)
            {
                finalMark += QuesList.ElementAt(i).Marks;
            }



            //====================Main Functions=======================//
            string chooseExam;
            do
            {

                Console.WriteLine("Enter (1) For Final Exam, or (2) For Practice Exam: ");
                chooseExam = Console.ReadLine();

                Exam Exam;

                if (chooseExam == "1")
                {
                    Exam = new FinalExam(20, QuesAnsDic.Count, QuesAnsDic);
                    Exam.ShowExam();
                    if (Exam.Correction() > finalMark / 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine($"Your Degree is : ({Exam.Correction()}) / From Total : ({finalMark})");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    QuesList.save();

                }
                else if (chooseExam == "2")
                {
                    Exam = new PracticeExam(10, QuesAnsDic.Count, QuesAnsDic);
                    Exam.ShowExam();
                    if (Exam.Correction() > finalMark / 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine($"Your Degree is : ({Exam.Correction()}) / From Total : ({finalMark})");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Exam);
                    QuesList.save();
                }

            } while (chooseExam != "2" || chooseExam != "1");


        }
    }
}
