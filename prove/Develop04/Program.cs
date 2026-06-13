using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        List<string> ReflectionPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        List<string> RefelctionQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        List<string> ListingPrompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
        
        while (keepRunning == true)
        {
            AskMenuChoice:
            int userChoice = 0;
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Start screaming activity\n  5. Quit\nSelect a choice from the menu: ");
            try //Basic input validation
            {
                userChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input is not an acceptable option. Please try again.");
                goto AskMenuChoice;
            }

            switch (userChoice)
            {
                case 1:
                    int userDuration = AskDuration();
                    Breathing BreathingInst = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", userDuration);
                    Console.WriteLine(BreathingInst.StartMessage());
                    BreathingInst.PromptUserBreathing();
                    Console.WriteLine(BreathingInst.EndMessage());
                    break;
                case 2:
                    userDuration = AskDuration();
                    Reflection ReflectingInst = new Reflection( "Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userDuration, ReflectionPrompts, RefelctionQuestions);
                    Console.WriteLine(ReflectingInst.StartMessage());
                    ReflectingInst.MakeUserReflect();
                    Console.WriteLine(ReflectingInst.EndMessage());
                    break;
                case 3:
                    userDuration = AskDuration();
                    Listing ListingInst = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userDuration, ListingPrompts);
                    Console.WriteLine(ListingInst.StartMessage());
                    ListingInst.ListThings();
                    Console.WriteLine(ListingInst.EndMessage());
                    break;
                case 4:
                    userDuration = AskDuration();
                    Screaming ScreamingInst = new Screaming("Screaming Activity", "This activity will help you relax by allowing you to release a blood-curdling shriek fueled by all the negative emotions that you may have.", userDuration);
                    Console.WriteLine(ScreamingInst.StartMessage());
                    ScreamingInst.PromptUserScreaming();
                    Console.WriteLine(ScreamingInst.EndMessage());
                    break;
                case 5:
                    Console.WriteLine("Exiting.");
                    keepRunning = false;
                    break;
                default:
                    break;
            }
        }
    }

    static int AskDuration()
    {
        AskDurationAgain:
        Console.Write("How long (in seconds) would you like this activity to last? ");
        try
        {
            int userDuration = int.Parse(Console.ReadLine()); 
            return userDuration;               
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is not an acceptable option. Please try again.");
            goto AskDurationAgain;
        }
    }
}