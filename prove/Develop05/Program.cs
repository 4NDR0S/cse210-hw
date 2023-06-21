using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        List<Goals> goals = new List<Goals>();
        // filename = goals.txt
        int total_points = 0;  //store the total points

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

                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                number_type_goal = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (number_type_goal == 1) //Simple Goal option(1.1)
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

                if (number_type_goal == 2) //Eternal Goal option (2.1)
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

                if (number_type_goal == 3) //Checklist Goal option (3.1)
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

                } //checklist goal loop (end)

            }  //Create New Goal (end)


            //---------------------------------------------(2)
            if (number_choise == 2) //display list of goals
            {
                int i = 1;
                foreach (Goals g in goals) //display the list of goals created
                {
                    Console.Write(i + ". ");g.DisplayGoal();i++;
                    // g.DisplayGoal();
                }
            } //display list of goals (end)---------------(2)


            //--------------------------------------------(3)
            if (number_choise == 3) //save goals to a file
            {
                string filename = "";
                Console.Write("what is the filename for the goal file? ");
                filename = Console.ReadLine(); 
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{total_points}"); //total points at first

                    foreach (Goals g in goals)
                    {
                        outputFile.WriteLine(g.Save());
                    }
                }
                
                SavingAnimation(); //this display my animation for saving
            }//save goals (end)---------------------------(3)


            //---------------------------------------------(4)
            if (number_choise == 4) //load goal from a file
            {
                string filename = "";
                Console.Write("what is the filename for the goal file? ");
                filename = Console.ReadLine();
                using (StreamReader reader = new StreamReader(filename))  //reader
                {
                    string line;
                    if ((line = reader.ReadLine())!= null)
                    {
                        total_points = int.Parse(line);  //this is for read the total points at the top of the file
                    }
                    
                    while ((line = reader.ReadLine())!= null)
                    {
                        string[] parts = line.Split(":");
                        string type = parts[0];
                        string[] subparts = parts[1].Split(",");
                        string name = subparts[0];
                        string description = subparts[1];
                        int points = int.Parse(subparts[2]);

                        if (type == "SimpleGoal")  //this verify if its SimpleGoal
                        {
                            string checkmark = subparts[3];
                            SimpleGoal simple = new SimpleGoal(type, name, description, points);
                            if (checkmark == "True")  // this check is the goal was done or not
                            {
                                simple.SetCheck("X");
                            }
                            else
                            {
                                simple.SetCheck(" ");
                            }
                            goals.Add(simple);
                        }

                        if (type == "EternalGoal")  //this verify if its EternalGoal
                        {
                            EternalGoal eternal = new EternalGoal(type, name, description, points);
                            eternal.SetCheck(" "); // [ ]
                            goals.Add(eternal);
                        }

                        if (type == "ChecklistGoal")  //this verify if its ChecklistGoal
                        {
                            int bonusPoints = int.Parse(subparts[3]);
                            int timesBonus = int.Parse(subparts[4]);
                            int currently = int.Parse(subparts[5]);

                            ChecklistGoal checklist = new ChecklistGoal(type, name, description, points, timesBonus, bonusPoints, currently);
                            if (currently == timesBonus)
                            {
                                checklist.SetCheck("X");
                            }
                            else
                            {
                                checklist.SetCheck(" ");
                            }
                            goals.Add(checklist);

                         }
                    }
                } // reader (end)
                LoadingAnimation();  //this display my animation for loading
            }//load goal from a file (end)------------------------------------------------------(4)


            //------------------------------------(5)
            if (number_choise == 5) //Record Event
            {
                Console.WriteLine("Select the goal you want to record:");
                int i = 1;
                int record_choise = 0;
                foreach (Goals g in goals) //display the list of goals created
                {
                    g.GetName();
                    g.GetPoints();

                    // Console.WriteLine(i + "." + g.GetName()+ "(indice:"+goals.IndexOf(g)+")");i++; //this print me 1.{goalname}(indice:0)

                    Console.WriteLine(i + ". " + g.GetName());i++; //this print me goals with a number list
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
            }  //Record Event (end)--------------------------(5)



        }//menu loop (end)---


        //adding animations.........................................
        void SavingAnimation()
        {
            Console.Write("Saving");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(900);
            }

            Console.WriteLine();
            Console.WriteLine("The file was saved correctly!");
            Console.WriteLine();
        }
        void LoadingAnimation()
        {
            Console.Write("Loading");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(900);
            }

            Console.WriteLine();
            Console.WriteLine("The file was uploaded correctly!");
            Console.WriteLine();
        }
        //animations
    }
}
