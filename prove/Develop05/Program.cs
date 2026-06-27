using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = [];
        bool keepRunning = true;
        int pointsTotal = 0;
        string savefilePath = "savefile.txt";

        while (keepRunning == true)
        {
            AskMenuChoice:
            int userChoice = 0;
            Console.Write($"You have {pointsTotal} Points.\n\nMenu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Give up and delete it all\n    7. Quit\nSelect a choice from the menu: ");
            try
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
                    int goalChoice = 0;
                    AskGoalMenuChoice:
                    Console.Write("The types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\nWhich type of goal would you like to create? ");
                    try
                    {
                        goalChoice = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Your input is not an acceptable option. Please try again.");
                        goto AskGoalMenuChoice;
                    }
                    Console.Write("What is the name of your Goal? ");
                    string newObjective = Console.ReadLine();
                    int newPointsPossible = 0;
                    int newRepetitionCount = 0;
                    switch (goalChoice)
                    {
                        case 2:
                            goalList.Append(new Eternal(newObjective, 0));
                            break;
                        case 1:
                            Console.Write("What is the amount of points associated with this goal? ");
                            newPointsPossible = int.Parse(Console.ReadLine());
                            goalList.Append(new Simple(newObjective, 0, newPointsPossible));
                            break;
                        case 3: 
                            Console.Write("What is the amount of points associated with this goal? ");
                            newPointsPossible = int.Parse(Console.ReadLine());
                            Console.Write("How many times can this goal be repeated? ");
                            newRepetitionCount = int.Parse(Console.ReadLine());
                            goalList.Append(new Checklist(newObjective, 0, newPointsPossible, newRepetitionCount));
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    foreach (Goal item in goalList)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case 3:
                    foreach (Goal item in goalList)
                    {
                        item.ExportGoal(savefilePath);
                    }
                    Console.WriteLine("Goals saved.");
                    break;
                case 4:
                    int simpleIterCount = 1;
                    int eternalIterCount = 1;
                    int checklistIterCount = 1;
                    string newGoal = File.ReadAllText(savefilePath);
                    string[] newGoalList = newGoal.Split(",")[..^1];
                    foreach (string item in newGoalList)
                    {
                        string goalType = item.Split("|")[0];
                        if (goalType == "Simple")
                        {
                            Simple workingSimple = new Simple("", 0, 0);
                            workingSimple.ImportGoal(savefilePath, simpleIterCount);
                            goalList.Add(new Simple(workingSimple.GetObjective(), workingSimple.GetPointsPossible(), workingSimple.GetPointsEarned()));
                            simpleIterCount++;
                        }
                        else if (goalType == "Eternal")
                        {
                            Eternal workingEternal = new Eternal("0", 0);
                            workingEternal.ImportGoal(savefilePath, eternalIterCount);
                            goalList.Add(new Eternal(workingEternal.GetObjective(), workingEternal.GetPointsEarned()));
                            eternalIterCount++;
                        }
                        else if (goalType == "Checklist")
                        {
                            Checklist workingChecklist = new Checklist("0", 0, 0, 0);
                            workingChecklist.ImportGoal(savefilePath, checklistIterCount);
                            goalList.Add(new Checklist(workingChecklist.GetObjective(), workingChecklist.GetPointsPossible(), workingChecklist.GetPointsEarned(), workingChecklist.GetRepetitionCount()));
                            checklistIterCount++;
                        }
                    }
                    Console.WriteLine("Goals loaded");
                    break;
                case 5:
                    Console.Write("What type of goal did you progress towards? ");
                    string advancedGoalType = Console.ReadLine();
                    Console.Write("What goal did you advance towards? ");
                    string advancedGoal = Console.ReadLine();
                    switch (advancedGoalType)
                    {
                        case "Simple":
                            foreach (Simple item in goalList)
                            {
                                if (advancedGoal == item.GetObjective() && item.GetPointsEarned() != item.GetPointsPossible())
                                {
                                    item.SetPointsEarned(item.GetPointsPossible());
                                    pointsTotal += item.GetPointsEarned();
                                }                                
                            }
                            break;
                        case "Eternal":
                            foreach (Eternal item in goalList)
                            {
                                if (advancedGoal == item.GetObjective())
                                {
                                    Console.Write("How many points do you want to add?");
                                    int pointsToAdd = int.Parse(Console.ReadLine());
                                    item.SetPointsEarned(pointsToAdd);
                                    pointsTotal += item.GetPointsEarned();
                                }
                            }
                            break;
                        case "Checklist":
                            foreach (Checklist item in goalList)
                            {
                                if (advancedGoal == item.GetObjective() && item.GetRepetitionCount() > 0)
                                {
                                    item.SetPointsEarned(item.GetPointsPossible());
                                    pointsTotal += item.GetPointsEarned();
                                    item.SetRepetitionCount(item.GetRepetitionCount() - 1);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    goalList = [];
                    File.Delete("savefile.txt");
                    Console.WriteLine("Goals deleted.");
                    break;
                case 7:
                    Console.WriteLine("Exiting.");
                    keepRunning = false;
                    break;
                default:
                    break;
            }
        }
    }
}