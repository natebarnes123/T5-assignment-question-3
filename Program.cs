namespace T5_assignment_question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Topic 5 question 3
            string answer1, answer2, answer3, answer4;
            int totalScore;
            Console.WriteLine("Hello, you will now write my quiz.");
            Console.WriteLine("Begin.");
            Console.WriteLine();
            Console.WriteLine("Question 1: What is Iron Mans real name?");
            answer1 = Console.ReadLine();

            if (answer1.ToLower() == "tony stark")
            {
                Console.WriteLine("Correct, tony stark is iron man");
                totalScore = 1;
            }
            else
            {
                Console.WriteLine("Who is that? Thats not iron man");
            }
            Console.WriteLine();
            Console.WriteLine("Question 2: What is 5 * 3 / 3?");
            answer2 = Console.ReadLine();
                
            if (answer2 == "5")
            {
                Console.WriteLine("Correct, 5 is the right answer.");
                totalScore = 2;
            }
            else
            {
                Console.WriteLine("Incorrect, remember to multiply then divide.");
            }
            Console.WriteLine();
            Console.WriteLine("Question 3: Which of these people are famous for their role in the show fresh prince.");
            Console.WriteLine("A. peter parker");
            Console.WriteLine("B. nate barnes");
            Console.WriteLine("C. taylor swift");
            Console.WriteLine("D. will smith");
            answer3 = Console.ReadLine();

            if (answer3.ToLower() == "will smith" || answer3.ToLower() == "D")
            {
                Console.WriteLine("Correct, will smith is amazing at acting and played that role perfectly.");
                totalScore = 3;
            }
            else if (answer3.ToLower() == "A" || answer3.ToLower() == "peter parker")
            {
                Console.WriteLine("Thats spiderman not the fresh prince!");
            }
            else if ( answer3.ToLower() == "B" || answer3.ToLower() == "nate barnes")
            {
                Console.WriteLine("Thats a parkside student, incorrect answer");
            }
            else if (answer3.ToLower() == "C" || answer3.ToLower() == "taylor swift")
            {
                Console.WriteLine("Incorrect, thats the most famous singer in the world");
            }
            else
            {
                Console.WriteLine("Thats not an option");
            }
            Console.WriteLine();
            Console.WriteLine("Question 4: How many states does America have?");
            answer4 = Console.ReadLine();

            if (answer4 == "50")
            {
                Console.WriteLine("Correct, there is currently 50 states in America");
                totalScore = 4;
            }
            else if (answer4 == "52")
            {
                Console.WriteLine("Incorrect, America had 52 states back in 1959, im talking about currently.");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.WriteLine();
            Console.WriteLine(" Congratulations, you got " + totalScore + " answers correct.");



        }
    }
}
