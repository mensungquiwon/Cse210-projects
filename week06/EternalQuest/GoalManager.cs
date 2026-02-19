using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public GoalManager()
        {
            
        }

        public void Start()
        {
            _goals.Clear();
            _score = 0;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.");
        }

        public void ListGoalNames()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
        }

        public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet.");
                return;
            }
            

            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string choice = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;

                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;

                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    if (!int.TryParse(Console.ReadLine(), out int target) || target <= 0)
                    {
                        Console.WriteLine("Invalid target. Goal not created.");
                        return;
                    }
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    if (!int.TryParse(Console.ReadLine(), out int bonus) || bonus < 0)
                    {
                        Console.WriteLine("Invalid bonus. Goal not created.");
                        return;
                    }
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;

                default:
                    Console.WriteLine("Invalid choice. Goal not created.");
                    break;
            }
        }
        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You have no goals yet. Create one first.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }

            Console.Write("Which goal did you accomplish? ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Invalid choice. No event recorded.");
                return;
            }

            Goal selectedGoal = _goals[choice - 1];

            
            bool wasComplete = selectedGoal.IsComplete();


            selectedGoal.RecordEvent();

            // Base points from the goal (stored as string in the base)
            int basePoints = 0;
            int.TryParse(selectedGoal.GetPoints(), out basePoints);

            int earned = 0;

            // Scoring rules by type:
            if (selectedGoal is EternalGoal)
            {
                // Eternal: award base points every time
                earned = basePoints;
            }
            else if (selectedGoal is SimpleGoal)
            {
                // Simple: award once when it transitions to complete
                if (!wasComplete && selectedGoal.IsComplete())
                {
                    earned = basePoints;
                }
            }
            else if (selectedGoal is ChecklistGoal checklist)
            {
                // Checklist: award base points every time
                earned = basePoints;

                if (!wasComplete && checklist.IsComplete() && checklist.AmountCompleted == checklist.Target)
                {
                    earned += checklist.Bonus;
                }
            }

            _score += earned;
            Console.WriteLine($"Congratulations!  You earned {earned} points. You now have {_score} points.");
        }

        public void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved.");
        }

        public void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found. No goals loaded.");
                return;
            }
            else
            {
                Console.WriteLine("Loading goals...");
            }

            _goals.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
        
                string scoreLine = reader.ReadLine();
                if (!int.TryParse(scoreLine, out _score))
                {
                    _score = 0;
                }

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                
                    string[] parts = line.Split('|');
                    if (parts.Length < 4) continue;

                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];

                    switch (type)
                    {
                        case "SimpleGoal":
                        {
                            bool isComplete = parts.Length >= 5 && bool.Parse(parts[4]);
                            _goals.Add(new SimpleGoal(name, description, points, isComplete));
                            break;
                        }
                        case "EternalGoal":
                        {
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        }
                        case "ChecklistGoal":
                        {
                            // ChecklistGoal|Name|Desc|Points|Target|Bonus|AmountCompleted
                            if (parts.Length >= 7 &&
                                int.TryParse(parts[4], out int target) &&
                                int.TryParse(parts[5], out int bonus) &&
                                int.TryParse(parts[6], out int amountCompleted))
                            {
                                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                            }
                            else
                            {
    
                                if (int.TryParse(parts[4], out int t) && int.TryParse(parts[5], out int b))
                                {
                                    _goals.Add(new ChecklistGoal(name, description, points, t, b));
                                }
                            }
                            break;
                        }
                        default:
                            Console.WriteLine($"Unknown goal type in file: {type}");
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded.");
        }
    }
}