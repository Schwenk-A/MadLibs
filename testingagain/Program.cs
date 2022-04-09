using System;
using System.Collections.Generic;

namespace testingagain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < Console.WindowHeight/2; i++)
            {
                Console.WriteLine();
            }
            var centered = "My Centered Text";
            var amountToPad = (Console.WindowWidth / 2) + centered.Length / 2;

            Console.WriteLine(centered.PadLeft(amountToPad));

            Console.CursorVisible = false; 

            Console.ReadLine();

            //var selectedStoryType = Introduction();

            //var selectedStoryArray = GetStoryArrayNumbers(selectedStoryType);

            //var collectedUserinput = MadLibInsertWords(selectedStoryArray);

            //StoryOutCome(selectedStoryType, collectedUserinput);


        }
        public static string Introduction()
        {
            Console.WriteLine("Welcome to my version of MadLibs. \n " +
            "Let's make a story but first... \n " +
            "Would you like a story about Adventure or about TrueCoders?");

            string storyType;
            do
            {
                storyType = Console.ReadLine().ToLower();
                Console.WriteLine((storyType == "adventure") ? "Let's get this adventure started!" :
                (storyType == "truecoders") ? "Oohh TrueCoders, good pick let's go!" : "I didn't catch that try again");

            } while (storyType != "adventure" && storyType != "truecoders");

            return storyType;
        }

        public static int[] GetStoryArrayNumbers(string storyType )
        {       
            if ( storyType == "truecoders")
            {
                return new int[]{ 3, 4, 4, 2, 1, 2, 0, 4, 5, 5 };
            }
            else
            {
                return null;
            }             
        }

        public static List<string> MadLibInsertWords(int[] getStoryArrayNumbers)
        {
            var responses = new List<string>();
            string[] MadLibNames = { "Noun", "Verb", "Adjective","Person's name","object","emotion" };

            foreach (var number in getStoryArrayNumbers)
            {
                   
                   Console.WriteLine($"Please enter a {MadLibNames[number]}");
                   responses.Add(Console.ReadLine());
                
                
            }
                return responses;
        }

        public static void StoryOutCome(string storyType, List<string> userinput)
        {    //possible way to center the text for the story 
            //string s = "Hello|World";
           // Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            //Console.WriteLine(s);

            if (storyType == "truecoders")
            {
               Console.WriteLine($"A street urchin named {userinput[0]} has stolen the prized " +
                   $"TrueCoder {userinput[1]}.\n You must stop them! You quickly grab a weapon " +
                   $"to your right! \n it is only a {userinput[2]} and it sure is {userinput[3]} but " +
                   $"it will have to do, you {userinput[4]} after him. The street urchin stops out " +
                   $"of no where and turns with a {userinput[5]} kind of look in his eye. " +
                   $"He yells- I have the great power of {userinput[6]}! Nothing can stop me! " +
                   $"You have no choice but to use your weapon and fight him.\n In the fight you " +
                   $"break someones precious {userinput[7]} but who cares... " +
                   $"in the end you win this heroic battle. \n You are as {userinput[8]} " +
                   $"as you can be! \n You see the stolen prize and you are overcome " +
                   $"with{userinput[9]}....you start to laugh...nothing can stop you now."); 
            }
            else
            {
                Console.WriteLine("There was an error with your story...sorry"); 
            }        
        }
    }
    
}
