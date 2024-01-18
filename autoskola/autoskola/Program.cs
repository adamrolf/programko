

using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Vybírej z A/B/C");
            Console.WriteLine("Pro ukončení napiš //konec//. Pro nový test //Enter//");
            Console.WriteLine("Zmáčkni //Enter// pro další otázku\n");

            int numberOfQuestions = GetNumberOfQuestions();
            double successRate = RunQuiz(numberOfQuestions);

            Console.Clear();
            Console.WriteLine("Konec testu");
            Console.WriteLine($"Počet správných odpovědí: {successRate}/{numberOfQuestions}");
            Console.WriteLine($"Úspěšnost: {successRate / numberOfQuestions * 100}%");

            Console.WriteLine("\nPro ukončení napiš 'konec'. Pro započetí nového testu zmáčkni // Enter//");
            string endInput = Console.ReadLine();

            if (endInput.ToLower() == "konec")
            {
                break;
            }

            Console.Clear();
        }
    }

    static int GetNumberOfQuestions()
    {
        int numberOfQuestions;
        while (true)
        {
            Console.WriteLine("Kolik otázek si přeješ zodpovědět?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numberOfQuestions) && numberOfQuestions > 0)
            {
                Console.Clear();
                return numberOfQuestions;
            }

            Console.WriteLine("Neplatný vstup. Musíš zadat číslo");
        }
    }

    static double RunQuiz(int numberOfQuestions)
    {
        double correctAnswers = 0;

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine($"{i + 1}/{numberOfQuestions}");
            string[] questionOptions = GetQuestionOptions();
            string correctOption = DisplayOptions(questionOptions);
            string userAnswer = GetUserAnswer();

            if (userAnswer.ToLower() == "konec")
            {
                break;
            }

            if (userAnswer == correctOption)
            {
                Console.WriteLine("Richtig!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Špatně, správně bylo za: {correctOption}: {questionOptions[Array.IndexOf(questionOptions, correctOption) + 1]}");
            }

            Console.ReadLine(); 
            Console.Clear();
        }

        return correctAnswers;
    }

    static string[] GetQuestionOptions()
    {
        string[] questions = File.ReadAllLines("questions.data");
        Random random = new Random();
        int questionIndex = random.Next(0, questions.Length);

        return questions[questionIndex].Split('|');
    }

    static string DisplayOptions(string[] options)
    {
        for (int i = 1; i < options.Length; i++)
        {
            char optionLetter = (char)('A' + i - 1);
            Console.WriteLine($"{optionLetter}: {options[i]}");
        }

        return options[1];
    }

    static string GetUserAnswer()
    {
        string userAnswer;
        while (true)
        {
            Console.Write("Odpověď: ");
            userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == "A" || userAnswer == "B" || userAnswer == "C" || userAnswer == "KONEC")
            {
                return userAnswer;
            }

            Console.WriteLine("Neplatná vstup. Zadej A/B/C");
        }
    }
}
