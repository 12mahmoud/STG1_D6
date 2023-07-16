namespace STG1_D6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ q1 = new MCQ(1, "how many players in soccer team?", 15, new string[] { "10", "11", "12" });
            Console.WriteLine( q1.show());

            MCQ q2 = new MCQ(2);
            q2.Body = "Who is the current prisdent of USA?";
            q2.Mark = 5;
            q2.Answers = new string[] { "biden", "tramp","obama" };
            Console.WriteLine( q2.show());

            TFQUESTIONS q3 = new TFQUESTIONS(3,"Egypt has 25 governorates",5);
            Console.WriteLine(q3.show());


        }
    }
}