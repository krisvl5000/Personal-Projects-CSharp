using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Hello_Softuni
{
    class Player
    {
        public Player(string name, int points, int gold)
        {
            Name = name;
            Points = points;
            Gold = gold;
        }

        public string Name { get; set; }

        public int Points { get; set; }

        public int Gold { get; set; }
    }

    class Question
    {
        public Question(int number, int correctAnswer)
        {
            Number = number;
            CorrectAnswer = correctAnswer;
        }

        public int Number { get; set; }

        public List<string> AnswerList { get; set; }
            = new List<string>();

        public int CorrectAnswer { get; set; }

        public string QuestionName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int questionCounter = 0;
            int points = 0;
            int gold = 0;

            //=============================================================
            Random random = new Random();

            List<Question> questions = new List<Question>();

            string question1 = "In what year was Bulgaria founded?";
            int question1AnswerIndex = random.Next(1, 5);// trying to set up
            //randomzed indexes, not implemented yet

            string question2 = "What is the name of the founder of Bulgaria?";
            string question3 = "What car brand has a logo, consisting of four rings?";
            string question4 = "Roughly how many kilometres away from earth is the moon?";
            string question5 = "Where is the MMA fighter Conor McGregor from?";

            string question6 = "What is Cynophobia the fear of?"; // fear of dogs
            string question7 = "Who is the author of Jurassic Park?"; // Michael Crichton
            string question8 = "What is the world's most expensive spice by weight?";// saffron
            string question9 = "Which of the following countries uses" +
                " Shilling as a currency?";//Kenya
            string question10 = "What is the fastest land animal?"; // cheetah

            string question11 = "Who plays Heisenberg in Breaking Bad?"; // Brian Cranston

            //-------------------------------------------------------------
            // Creating the tenth question and options

            var question11Answers = new List<string>()
            {
                "Brian Cranston", "Leonardo Di Caprio", "Jason Statham",
                "Silverster Stalone"
            };

            Question questionObject11 = new Question(11, 1);
            questionObject11.AnswerList = question11Answers;
            questionObject11.QuestionName = question11;

            questions.Add(questionObject11);

            //-------------------------------------------------------------
            // Creating the tenth question and options

            var question10Answers = new List<string>()
            {
                "Black Mamba", "Leopard", "Cheetah", "Eagle"
            };

            Question questionObject10 = new Question(10, 3);
            questionObject10.AnswerList = question10Answers;
            questionObject10.QuestionName = question10;

            questions.Add(questionObject10);

            //-------------------------------------------------------------
            // Creating the nineth question and options

            var question9Answers = new List<string>()
            {
                "Ethiopia", "Venezuela", "Argentina", "Kenya"
            };

            Question questionObject9 = new Question(6, 4);
            questionObject9.AnswerList = question9Answers;
            questionObject9.QuestionName = question9;

            questions.Add(questionObject9);

            //-------------------------------------------------------------
            // Creating the eighth question and options

            var question8Answers = new List<string>()
            {
                "Anise", "Saffron", "Basil", "Bergamot"
            };

            Question questionObject8 = new Question(8, 2);
            questionObject8.AnswerList = question8Answers;
            questionObject8.QuestionName = question8;

            questions.Add(questionObject8);

            //-------------------------------------------------------------
            // Creating the seventh question and options

            var question7Answers = new List<string>()
            {
                "Dean Koontz", "Jackie Collins", "Osamu Tezuka", "Michael Crichton"
            };

            Question questionObject7 = new Question(7, 4);
            questionObject7.AnswerList = question7Answers;
            questionObject7.QuestionName = question7;

            questions.Add(questionObject7);

            //-------------------------------------------------------------
            // Creating the sixth question and options

            var question6Answers = new List<string>()
            {
                "Dogs", "Clowns", "All animals", "Certain foods"
            };

            Question questionObject6 = new Question(6, 1);
            questionObject6.AnswerList = question6Answers;
            questionObject6.QuestionName = question6;

            questions.Add(questionObject6);

            //-------------------------------------------------------------
            // Creating the first question and options

            var question1Answers = new List<string>()
            {
                "year 245", "year 681", "year 1023", "year 1574"
            };

            Question questionObject1 = new Question(1, 2);
            questionObject1.AnswerList = question1Answers;
            questionObject1.QuestionName = question1;

            questions.Add(questionObject1);

            //--------------------------------------------------------------
            // Creating the second question and options

            var question2Answers = new List<string>()
            {
                "Kubrat", "Tervel", "Asparuh", "Krum"
            };

            Question questionObject2 = new Question(2, 3);
            questionObject2.AnswerList = question2Answers;
            questionObject2.QuestionName = question2;

            questions.Add(questionObject2);

            //--------------------------------------------------------------
            // Creating the third question and options

            var question3Answers = new List<string>()
            {
                "Audi", "Bentley", "Lada", "Hyundai"
            };

            Question questionObject3 = new Question(3, 1);
            questionObject3.AnswerList = question3Answers;
            questionObject3.QuestionName = question3;

            questions.Add(questionObject3);

            //--------------------------------------------------------------
            // Creating the fourth question and options

            var question4Answers = new List<string>()
            {
                "15 000", "35 000", "380 000", "1 000 000"
            };

            Question questionObject4 = new Question(4, 3);
            questionObject4.AnswerList = question4Answers;
            questionObject4.QuestionName = question4;

            questions.Add(questionObject4);

            //--------------------------------------------------------------
            // Creating the fifth question and options

            var question5Answers = new List<string>()
            {
                "Bulgaria", "Chile", "Brazil", "Ireland"
            };

            Question questionObject5 = new Question(5, 4);
            questionObject5.AnswerList = question5Answers;
            questionObject5.QuestionName = question5;

            questions.Add(questionObject5);

            //==============================================================

            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();

            Console.WriteLine($"Welcome to the start of your journey, {playerName}!");

            Player player = new Player(playerName, points, gold);

            Console.WriteLine("Do you want to see the tutorial (yes or no)?");

            Console.WriteLine();

            string seeTutorial = Console.ReadLine();

            while (true)
            {
                if (seeTutorial == "yes")
                {
                    Tutorial();
                    break;
                }
                else if (seeTutorial == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, type yes or no");
                    seeTutorial = Console.ReadLine();
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Would you like to play the limited gamemode, or endless?");

            string limitedOrEndless = Console.ReadLine();

            if (limitedOrEndless == "limited")
            {
                Limited(questions, player);

                TripleSpace();

                TrophySystem(player);
            }
            else if (limitedOrEndless == "endless")
            {
                Endless(questions, player);

                TripleSpace();

                TrophySystem(player);
            }
            else
            {
                while (limitedOrEndless != "limited" || limitedOrEndless != "endless")
                {
                    Console.WriteLine("Wrong input, try again!");
                    limitedOrEndless = Console.ReadLine();

                    if (limitedOrEndless == "limited")
                    {
                        Limited(questions, player);

                        TripleSpace();

                        TrophySystem(player);

                        return;

                    }
                    else if (limitedOrEndless == "endless")
                    {
                        Endless(questions, player);

                        TripleSpace();

                        TrophySystem(player);

                        return;
                    }
                }
            }

        }



        static void TripleSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }



        static void Tutorial()
        {
            Console.WriteLine();
            Console.WriteLine("The rules are as follows:");
            Console.WriteLine("You get score and gold for every right answer.");
            Console.WriteLine("If you have more than 30 gold you can pay 30");
            Console.WriteLine("to have a second chance if you got a question wrong.");
            Console.WriteLine("Don't worry, the score is what matters in the end.");
            Console.WriteLine();
        }



        // Make it so it's a percentage of the correct answers given for better accuracy
        static void TrophySystem(Player player)
        {
            if (player.Points >= 500)
            {
                Console.WriteLine("Flawless Score! You earned a diamond trophy!");
            }
            else if (player.Points >= 250)
            {
                Console.WriteLine("Amazing! You earned a Gold trophy!");
            }
            else if (player.Points >= 200)
            {
                Console.WriteLine("Nice! You got a silver trophy!");
            }
            else if (player.Points >= 150)
            {
                Console.WriteLine("You got a bronze trophy!");
            }

            TripleSpace();
        }





        static void Limited(List<Question> questions, Player player)
        {
            Console.WriteLine("How many rounds do you want to play?");

            string rounds = Console.ReadLine();

            // Not implement yet, make it request an int until it gets one
            //------------------------------------------------------------- Start
            bool isNumber = true;

            foreach (var character in rounds)
            {
                if (!char.IsDigit(character))
                {
                    isNumber = false;
                    break;
                }
            }

            int roundsCount;
            while (true)
            {
                if (!isNumber)
                {
                    Console.WriteLine("You need to type a number!");
                    rounds = Console.ReadLine();
                }
                else
                {
                    roundsCount = int.Parse(rounds);
                    break;
                }
            }

            //------------------------------------------------------------- End
            Console.WriteLine("Alright, let's get started!");

            for (int i = 1; i <= roundsCount; i++)
            {
                StartTheGame(questions, player);

            }

            //implement an endgame method
            Console.WriteLine($"Congrats, you finished the game " +
                $"with {player.Gold} gold and {player.Points} score!");
            return;
        }





        static void Endless(List<Question> questions, Player player)
        {
            Console.WriteLine("Alright, let's get started!");

            string stopOrCont;
            do
            {
                StartTheGame(questions, player);

                Console.WriteLine("Do you wish to continue with the next question?");

                TripleSpace();
                TripleSpace();
                TripleSpace();

                stopOrCont = Console.ReadLine();

                if (stopOrCont == "no")
                {
                    TripleSpace();
                    Console.WriteLine("Enough for now :)");
                    return;
                }
                else if (stopOrCont == "yes")
                {
                    if (questions.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Out of questions!");
                        Console.WriteLine($"Congrats, you finished the game " +
                        $"with {player.Gold} gold and {player.Points} score!");

                        TrophySystem(player);
                        return;
                    }

                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    stopOrCont = Console.ReadLine();
                }


            } while (stopOrCont != "no");

            Console.WriteLine("You ended the game.");


        }





        static void StartTheGame(List<Question> questions, Player player)
        {
            //--------------------------------------------------------------
            // Creating random indices

            Random random = new Random();

            if (questions.Count == 0)
            {
                //game ends, create an endgame method
                Console.WriteLine("Out of questions!");
                return;
            }

            int questionIndex = random.Next(0, questions.Count);
            Question questionToAsk = questions[questionIndex];

            TripleSpace();

            if (IsIndexInRange(questions, questionIndex))
            {
                Console.WriteLine($"{questionToAsk.QuestionName}");
                Console.WriteLine();

                int counter = 0;
                foreach (var answer in questionToAsk.AnswerList)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {answer}");
                }

                Console.WriteLine();
                Console.WriteLine("Write the number of the answer you think is correct:");
                TripleSpace();
                TripleSpace();
                TripleSpace();
                Console.WriteLine();

                string answerGiven = Console.ReadLine();

                if (IsAnswerCorrect(questionToAsk, answerGiven)) //correct answer
                {
                    Console.WriteLine();
                    Console.WriteLine("Correct answer, you won 50 points and 10 gold!");
                    player.Points += 50;
                    player.Gold += 10;
                }
                else //wrong answer
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong answer!");

                    if (player.Gold >= 30)
                    {
                        Console.WriteLine("Do you want to have another shot?");

                        string anotherShot = Console.ReadLine();

                        if (anotherShot == "yes")
                        {
                            Console.WriteLine("30 Gold paid for a second chance!");

                            answerGiven = Console.ReadLine();

                            player.Gold -= 30;

                            Console.WriteLine();

                            if (IsAnswerCorrect(questionToAsk, answerGiven))
                            {
                                Console.WriteLine("Correct answer, you won 50 points and 10 gold!");
                                player.Points += 50;
                                player.Gold += 10;
                            }
                        }
                        else if (anotherShot == "no")
                        {
                            return;
                        }

                        // Not implemented yet
                        // ---------------------------------------------------------

                        else
                        {
                            while (anotherShot != "yes" && anotherShot != "no")
                            {
                                TripleSpace();
                                Console.WriteLine("Invalid input! Type yes or no");
                                anotherShot = Console.ReadLine();
                            }

                            if (anotherShot == "yes") //remove if it doesnt work,
                                                      //reused code, start 
                            {
                                Console.WriteLine("30 Gold paid for a second chance!");

                                answerGiven = Console.ReadLine();

                                player.Gold -= 30;

                                Console.WriteLine();

                                if (IsAnswerCorrect(questionToAsk, answerGiven))
                                {
                                    Console.WriteLine("Correct answer, you won 50 points and 10 gold!");
                                    player.Points += 50;
                                    player.Gold += 10;
                                }
                            }
                            else if (anotherShot == "no")
                            {
                                questions.Remove(questionToAsk);
                                return;
                            }                       // end

                        }

                        //----------------------------------------------------------
                    }


                }

                questions.Remove(questionToAsk);
            }
            else
            {
                Console.WriteLine("Out of questions");
                return; //the game finishes
            }
        }





        static bool IsAnswerCorrect(Question questionToAsk, string answerGiven)
        {
            return int.Parse(answerGiven) == questionToAsk.CorrectAnswer;
        }





        static bool IsIndexInRange(List<Question> questions, int questionIndex)
        {
            return questionIndex >= 0 && questionIndex < questions.Count;
        }
    }
}