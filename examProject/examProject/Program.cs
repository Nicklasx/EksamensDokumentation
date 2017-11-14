using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace examProject
{
    class Program
    {
        //velkomst
        public static void Welcome()
        {
            Console.WriteLine("Hello there");
            Console.WriteLine("wanna play a game");
            Console.WriteLine("1: Yes 2: No");
        }
        static void Main(string[] args)
        {
            /* while loops paramenter */
            bool game = true;
            bool beginGame = true;
            bool wrongAnswer = true;
            bool wrongAnswer2 = true;
            bool wrongAnswer3 = true;
            bool wrongAnswer4 = true;

            //hvor stort mit array skal være
            int arrayLenght = 4;

            //class fortælle hvad min class skal inholde
            Question firstQuestion = new Question();
            firstQuestion.questionText = "What color is a smulf?";
            firstQuestion.answers = "1: blue, 2: green, 3: yellow, 4: black";
            firstQuestion.answerBox = "Write your answer: ";
            firstQuestion.rightAnswer = "you're right!";
            firstQuestion.wrongAnswer = "That's not the answer";

            Question secondQuestion = new Question();
            secondQuestion.questionText = "What is the default amount of ram in a pc today?";
            secondQuestion.answers = "1: 4Gb ram, 2: 6Gb ram, 3: 8Gb ram, 4: 16Gb ram";

            Question thirdQuestion = new Question();
            thirdQuestion.questionText = "What is the name of the newest i7 cpu?";
            thirdQuestion.answers = "1: i7-4770, 2: i7-7700, 3: i7.8700, 4: i7-6700";

            Question fourthQuestion = new Question();
            fourthQuestion.questionText = "Insert question?";
            fourthQuestion.answers = "1: This is not it, 2: This is the one, 3: This is not it, 4: This is not it";

            //array over spørgsmål
            string[] questions = new string[arrayLenght];
            questions[0] = firstQuestion.questionText;
            questions[1] = secondQuestion.questionText;
            questions[2] = thirdQuestion.questionText;
            questions[3] = fourthQuestion.questionText;

            //array over svar
            string[] answers = new string[arrayLenght];
            answers[0] = firstQuestion.answers;
            answers[1] = secondQuestion.answers;
            answers[2] = thirdQuestion.answers;
            answers[3] = fourthQuestion.answers;

            //over ordnet loop
            while (game)
            {
                //loop til startet af spillet
                //tager fra velkomst til efter dit svar
                while (beginGame)
                {
                    //clear console
                    Console.Clear();
                    //kalder min function Welcom
                    Welcome();
                    //lave en besked med teksten "Write your answer: "
                    Console.Write(firstQuestion.answerBox);

                    //laver et try catch så du ikke kan skrive forkert
                    try
                    {
                        //formatere string til int
                        int startAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        //hvis startAnswer == 1 køre den videre
                        if (startAnswer == 1)
                        {
                            //hvad der sker når man skriver 1
                            Console.WriteLine("Then let's play!");
                            Thread.Sleep(1000);
                            beginGame = false;
                        }
                        else if (startAnswer == 2)
                        {
                            Console.WriteLine("Then why did you start?");
                            Console.ReadKey();
                            return;
                        } else
                        {
                            Console.WriteLine("Thats not an option");
                            Thread.Sleep(1000);
                        }
                    }
                    //catch hvis det du har svaret ikke er en gyldig svar mulighed
                    catch
                    {
                        Console.WriteLine("That was not an option");
                        Thread.Sleep(1000);
                    }
                }
                //loop for det først spørgsmål hvis man svare forkert hoppe den tilbage til samme spørgsmål
                while (wrongAnswer)
                {
                    Console.Clear();
                    Console.WriteLine(questions[0]);
                    Console.WriteLine(answers[0]);
                    Console.Write(firstQuestion.answerBox);

                    try
                    {

                        int firstAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (firstAnswer == 1)
                        {
                            Console.WriteLine(firstQuestion.rightAnswer);
                            Thread.Sleep(1000);
                            wrongAnswer = false;
                        }
                        else
                        {
                            Console.WriteLine(firstQuestion.wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That was not an option");
                        Thread.Sleep(1000);
                    }
                }
                //loop for det andet spørgsmål hvis man svare forkert hoppe den tilbage til samme spørgsmål
                while (wrongAnswer2)
                {
                    Console.Clear();
                    Console.WriteLine(questions[1]);
                    Console.WriteLine(answers[1]);
                    Console.Write(firstQuestion.answerBox);

                    try
                    {
                        int secondAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (secondAnswer == 4)
                        {
                            Console.WriteLine(firstQuestion.rightAnswer);
                            Thread.Sleep(1000);
                            wrongAnswer2 = false;
                        }
                        else
                        {
                            Console.WriteLine(firstQuestion.wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That was not an option");
                        Thread.Sleep(1000);
                    }
                }
                //loop for det tredje spørgsmål hvis man svare forkert hoppe den tilbage til samme spørgsmål
                while (wrongAnswer3)
                {
                    Console.Clear();
                    Console.WriteLine(questions[2]);
                    Console.WriteLine(answers[2]);
                    Console.Write(firstQuestion.answerBox);

                    try
                    {
                        int thirdAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (thirdAnswer == 3)
                        {
                            Console.WriteLine(firstQuestion.rightAnswer);
                            Thread.Sleep(1000);
                            wrongAnswer3 = false;
                        }
                        else
                        {
                            Console.WriteLine(firstQuestion.wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That was not an option");
                        Thread.Sleep(1000);
                    }
                }
                //loop for det fjerde spørgsmål hvis man svare forkert hoppe den tilbage til samme spørgsmål
                while (wrongAnswer4)
                {
                    Console.Clear();
                    Console.WriteLine(questions[3]);
                    Console.WriteLine(answers[3]);
                    Console.Write(firstQuestion.answerBox);

                    try
                    {
                        int fourthAnswer = int.Parse(Console.ReadLine().ToLower().Trim());

                        if (fourthAnswer == 2)
                        {
                            Console.WriteLine(firstQuestion.rightAnswer);
                            Console.WriteLine("The program is now done");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine(firstQuestion.wrongAnswer);
                            Thread.Sleep(1000);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("That was not an option");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        /// <summary>
        /// Dette er min class som er lavet så jeg bare kan kalde dem og give dem den value de skal have
        /// </summary>
                public class Question
                {
                    public string questionText;
                    public string answers;
                    public string answerBox;
                    public string rightAnswer;
                    public string wrongAnswer;
                }
    }
}
