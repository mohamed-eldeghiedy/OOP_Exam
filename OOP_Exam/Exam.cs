using System;
using System.Collections.Generic;


namespace OOP_Exam
{
    public abstract class Exam 
    {

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();
    }


    public class  FinalExam :Exam
    {
        public FinalExam(int time, int numberOfQuestion): base(time, numberOfQuestion)
        {
        }


        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam - Time: {Time} minutes");
            double totalMarks = 0;
            double userMarks = 0;

            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.Write("Please enter your answer (AnswerId): ");
                int userAnswerId = int.Parse(Console.ReadLine()!);

                if (question.RightAnswer.AnswerId == userAnswerId)
                {
                    userMarks += question.Mark;
                   
                }
                totalMarks += question.Mark;

            }

            Console.WriteLine($"Total Marks: {totalMarks}");
        }

    }


    public class PracticalExam : Exam
    { 
      public PracticalExam(int time, int numberOfQuestion) : base(time, numberOfQuestion)
        {
        }
        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam - Time: {Time} minutes");
           
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.Write("Please enter your answer (AnswerId): ");
                int userAnswerId = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"Correct Answer: {question.RightAnswer}");
            }
           
        }

    }
}
