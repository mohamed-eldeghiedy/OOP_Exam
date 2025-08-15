using System;
using System.Collections.Generic;


namespace OOP_Exam
{
    public abstract class Question
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;

        }

        public abstract void ShowQuestion();

        public object Clone()
        {
            Question clone = (Question)this.MemberwiseClone();
            clone.AnswerList = (Answer[])this.AnswerList.Clone();
            clone.RightAnswer = (Answer)this.RightAnswer.Clone();
            return clone;
        }

        public int CompareTo(Question other)
        {
            return Header.CompareTo(other.Header);
        }

        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}, RightAnswer: {RightAnswer}";
        }
    }


    public class MCQQuestion : Question
    {
        public MCQQuestion(string body, double mark, Answer[] answers, Answer reightAnswer) : base("Multiple Choice Question", body, mark)
        {
            AnswerList = answers;
            RightAnswer = reightAnswer;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("Answers:");
            foreach (var Ans in AnswerList)
            {
                Console.WriteLine(Ans);
            }
            Console.WriteLine($"Right Answer: {RightAnswer}");
        }
    }


    public class TFQuestion : Question
    { 
        public TFQuestion(string body , double mark , Answer rightAnser ) : base("True/False Question", body, mark)
        {
            AnswerList = new Answer[]
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
            RightAnswer = rightAnser;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            Console.WriteLine("Answers:");
            foreach (var Ans in AnswerList)
            {
                Console.WriteLine(Ans);
            }
            Console.WriteLine($"Right Answer: {RightAnswer}");
        }

    }
}
