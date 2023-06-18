using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        List<Goals> goals = new List<Goals>();
        string fileName = "myFile.txt";
        int total_points = 0;

        int number_choise = 0;
        while (number_choise != 6)  //menu loop
        {
            Console.WriteLine($"You have {total_points} points.");// you have 0 points.
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            number_choise = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number_choise == 1)  //Create New Goal
            {
                int number_type_goal = 0;
                //para crear un nuevo goal
                
                // escribir: cual es el nombre del goal
                // string z = Console.ReadLine()
                // dependiendo del type de goal, crear uno nuevo

                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                number_type_goal = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (number_type_goal == 1) //Simple Goal option(1)
                {
                    string goal_type = "SimpleGoal"; // this is the type of the goal
                    string goal_name = "";
                    string goal_description = "";
                    int goal_points = 0;
                    

                    Console.Write("what is the name of the goal? ");
                    goal_name = Console.ReadLine();
                    Console.Write("what is a short desciption of it? ");
                    goal_description = Console.ReadLine();
                    Console.Write("what is the amount of points associated with this goal? ");
                    goal_points = int.Parse(Console.ReadLine());

                    SimpleGoal simple_g = new SimpleGoal(goal_type, goal_name, goal_description, goal_points);
                    simple_g.SetCheck(" "); // [ ]
                    goals.Add(simple_g); // add to the display list
                    

                } // //simple goal loop

                if (number_type_goal == 2) //Eternal Goal option (2)
                {
                    string goal_type = "EternalGoal"; // this is the type of the goal
                    string goal_name = "";
                    string goal_description = "";
                    int goal_points = 0;

                    Console.Write("what is the name of the goal? ");
                    goal_name = Console.ReadLine();
                    Console.Write("what is a short desciption of it? ");
                    goal_description = Console.ReadLine();
                    Console.Write("what is the amount of points associated with this goal? ");
                    goal_points = int.Parse(Console.ReadLine());

                    EternalGoal eternal_g = new EternalGoal(goal_type, goal_name, goal_description, goal_points);
                    eternal_g.SetCheck(" "); // [ ]
                    goals.Add(eternal_g); // add to the display list

                } //eternal goal loop

                if (number_type_goal == 3) //Checklist Goal option (3)
                {
                    string goal_type = "ChecklistGoal"; // this is the type of the goal
                    string goal_name = "";
                    string goal_description = "";
                    int goal_points = 0;
                    int goal_timesBonus = 0;
                    int goal_bonusPoints = 0;
                    int currently_count = 0;

                    Console.Write("what is the name of the goal? ");
                    goal_name = Console.ReadLine();
                    Console.Write("what is a short desciption of it? ");
                    goal_description = Console.ReadLine();
                    Console.Write("what is the amount of points associated with this goal? ");
                    goal_points = int.Parse(Console.ReadLine());
                    Console.Write("How many time does this goal need to be accomplished for a bonus? ");
                    goal_timesBonus = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    goal_bonusPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal checklist_g = new ChecklistGoal(goal_type, goal_name, goal_description, goal_points,goal_timesBonus, goal_bonusPoints, currently_count);
                    checklist_g.SetCheck(" "); // [ ]
                    checklist_g.CurrentlyPoints(0);
                    goals.Add(checklist_g); // add to the display list

                } //checklist goal loop

            }  //Create New Goal

            if (number_choise == 2) //display list of goals
            {
                foreach (Goals g in goals) //display the list of goals created
                {
                    g.DisplayGoal();
                }
            } //display list of goals

            if (number_choise == 3) //save goals
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine($"{total_points}");  //total points
                    }
                // string fileName = "myFile.txt";
                foreach (Goals g in goals)
                {
                    string type = g.GetType();
                    string name = g.GetName();
                    string description = g.GetDescription();
                    int points = g.GetPoints();

                    // Console.WriteLine($"{type}:{name},{description},{points}"); //this is the order to save in the file
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine($"{type}:{name},{description},{points}");
                    }

                }
            }//save goals

            if (number_choise == 5) //Record Event
            {
                int i = 1;
                int record_choise = 0;
                foreach (Goals g in goals) //display the list of goals created
                {
                    g.GetName();
                    g.GetPoints();

                    // Console.WriteLine(i + "." + g.GetName()+ "(indice:"+goals.IndexOf(g)+")");i++; //this print me 1.{goalname}(indice:0)

                    Console.WriteLine(i + "." + g.GetName());i++; //this print me goals with a number list
                }

                Console.Write("Which goal did you accomplish? ");
                    record_choise = int.Parse(Console.ReadLine());
                    string type = "";
                    int points = 0;
                    int Currently_p = 0;
                    int new_currently = 0;
                    // int times_bonus = 0;

                    if (record_choise <= goals.Count)
                    {
                        type = goals[record_choise-1].GetType();
                        if (type == "SimpleGoal")
                        {
                            if (goals[record_choise-1].GetCheck() != "X") // this check if the goal was done or not
                            {
                            goals[record_choise-1].SetCheck("X");  // this will mark my goal as done
                            points = goals[record_choise-1].GetPoints();
                            total_points = total_points + points;
                            Console.WriteLine($"Congratulations! You have earned {goals[record_choise-1].GetPoints()} points!");
                            }
                            else 
                            {
                                Console.WriteLine("Congratulations! You already accomplished this goal!"); //if the goal has already been accomplished, print this message
                            }
                        }

                        if (type == "EternalGoal")
                        {
                            points = goals[record_choise-1].GetPoints();
                            total_points = total_points + points;
                            Console.WriteLine($"Congratulations! You have earned {goals[record_choise-1].GetPoints()} points!");
                        }

                        if (type == "ChecklistGoal")
                        {
                            if (goals[record_choise-1].GetCheck() != "X") // this check if the goal was done or not
                            {
                                points = goals[record_choise-1].GetPoints();
                                total_points = total_points + points;
                                Currently_p = goals[record_choise-1].GetCurrentlyPoints();
                                new_currently = Currently_p + 1;
                                goals[record_choise-1].CurrentlyPoints(new_currently);

                                if (new_currently == goals[record_choise-1].TimesForBonus()) // this check if you completed the required times to get the bonus
                                {
                                    Console.WriteLine($"Congratulations! You have earned {goals[record_choise-1].BonusPoints()} points!");
                                    goals[record_choise-1].SetCheck("X");
                                    total_points = total_points + goals[record_choise-1].BonusPoints();
                                }
                                else
                                {
                                    Console.WriteLine($"Congratulations! You have earned {goals[record_choise-1].GetPoints()} points!");
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Congratulations! You already accomplished this goal!"); //if the goal has already been accomplished, print this message
                            }

                        }

                        // Console.WriteLine($"Congratulations! You have earned {goals[record_choise-1].GetPoints()} points!");
                        Console.WriteLine($"You now have {total_points} points.");

                        // Console.WriteLine(goals[record_choise-1].GetPoints()); //this only print how many points have the activity selected
                        Console.WriteLine();
                    }
            }  //Record Event



        }//menu loop


    }
}




class EternalGoal : Goals
{
    public EternalGoal(string type, string name, string description, int points) : base (type, name, description, points)
    {

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_check}] {_name} ({_description})");
    }

    // public override void displayGoalDone()
    // {
    //     Console.WriteLine($"[✓] {_name} ({_description})");
    // }
}


class ChecklistGoal : Goals
{
    // private int _timesForBonus;
    // private int _bonusPoints;
    // private int _currently;
    public ChecklistGoal(string type, string name, string description, int points, int timesForBonus, int bonusPoints, int currently) : base (type, name, description, points, timesForBonus, bonusPoints, currently)
    {
       
    }


    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_check}] {_name} ({_description}) -- Currently completed: {_currently}/{_timesForBonus}");
    }
}