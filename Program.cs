using System;
using System.Collections.Generic;


namespace Hangman
{
    class Program
    {
        //private List<WordList>

        static void Main(string[] args)
        {
            List<string> wordlist = new List<string>()
            {

              "Coding", "Microsoft", "Hello"
            };
            //needs to be implimented in a class

            Random getanswer = new Random();
            var newword = getanswer.Next(wordlist.Count);
            string word = wordlist[newword];
            char[] answer = word.ToCharArray();
            int length = word.Length;
            var guesscount = 6;
            int guesses;
            char[] response = new char [answer.Length];
          
            




            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine($"In order to win, you must guess by entering letters. You have {guesscount} wrong guesses remaining.");
            Console.WriteLine($"The word has: {length} letters.");
            Console.WriteLine("Please enter your first guess:");

            guesses = 0;
            while(guesscount > guesses)
            {
                
                foreach (char input in answer)
                {
                    
                    for (var g = 0; g < answer.Length; g++) 
                    
                        //int i;
                        //response[] = g;
                    
                    //for (var i = 0; i < response.Length[g]; i++) ; //this is ment to contain the user input and place it into an array to compare to the answer array
                      
                            response[g] = Convert.ToChar(Console.ReadLine());
                            if (response[g] == input)
                            {
                                Console.WriteLine("Correct, please choose another letter");
                            }
                            else
                            {
                                guesscount--;
                                Console.WriteLine($"Incorrect, you have {guesscount} guesses remaining");

                            }
                            if (response == answer) //working on implimentation of victory and loss conditions
                    {
                        Console.WriteLine($"You guessed the word, the word is {getanswer}");
                          }
                            if(guesscount == 0)
                    {
                        Console.WriteLine($"You have {guesscount} remaining, please play again");
                    }
                            
                    

                }

            }
            
                            


         
            
            }

    }
}
