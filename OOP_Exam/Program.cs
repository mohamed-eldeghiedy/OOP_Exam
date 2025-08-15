namespace OOP_Exam
{
    internal class Program
    {
        static void Main()
        {
            Subject math = new Subject(1, "Mathematics");

            
            FinalExam finalExam = new FinalExam(30, 2);
            finalExam.Questions.Add(
                new TFQuestion("2 + 2 = 4", 5, new Answer(1, "True"))
            );

            finalExam.Questions.Add(
                new MCQQuestion(
                    "What is the capital of France?",
                    5,
                    new Answer[]
                    {
                    new Answer(1, "Berlin"),
                    new Answer(2, "Paris"),
                    new Answer(3, "Madrid")
                    },
                    new Answer(2, "Paris")
                )
            );

            math.CreateExam(finalExam);

            Console.WriteLine(math);
            math.SubjectExam.ShowExam();
        }
    }
    
}
