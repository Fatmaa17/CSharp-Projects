namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of questions for the quiz
            string[] questions = new string[3]
            {
                "1. What's the capital of Italy?",
                "2. What's the red planet?",
                "3. What's the largest animal?"
            };

            // Array of correct answers corresponding to the questions
            string[] answs = new string[3]
            {
                "Roma",
                "Mars",
                "Whale"
            };

            int correctAnsws = 0; // Counter for correct answers

            // Welcome message for the player
            Console.WriteLine("Welcome to this simple game" +
                "\nPlease answer the following questions to win\n\n\n");

            // Loop through each question and get the user's answer
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswer = Console.ReadLine();

                try
                {
                    // Check if the user's answer is correct
                    bool result = IsAnswerCorrect(userAnswer, answs[i]);

                    if (result)
                    {
                        Console.WriteLine("Correct!");
                        correctAnsws++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect Answer. The correct answer is {answs[i]}.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions during answer validation
                    Console.WriteLine(ex.Message);
                }
            }

            // Display the final score
            Console.WriteLine($"\n\n\nYour Score is: {correctAnsws} out of {questions.Length}");
            Console.WriteLine("\n\nGame Done :'))");
        }

        // Method to check if the user's answer matches the correct answer
        private static bool IsAnswerCorrect(string userInput, string correctAnswr)
        {
            // Validate that the input is not empty or null
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer can't be empty.");
            }

            // Return true if the answer is correct, false otherwise(case-insensitive)
            return userInput.Equals(correctAnswr, StringComparison.OrdinalIgnoreCase);
        }
    }
}
