using System.Diagnostics;

namespace TaskTracker
{
    internal class Program
    {
        static string[] TasksArr = new string[100];
        static int taskIndex = 0;

        static void Main(string[] args)
        {
            // To do:
            /*
             - Welcome User
             - Present options to the user:
               1. Add Task
               2. View All tasks
               3. Mark completed task
               4. Remove Task
               5. Exit
            */
            //-----------

            Console.WriteLine("Hello! It's Task Tracker.");
            Console.WriteLine(
                "\nChoose what you wanna do: " +
                "\n1. Add Task" +
                "\n2. View All tasks" +
                "\n3. Mark completed task" +
                "\n4. Remove Task" +
                "\n5. Exit\n");

            while (true)
            {
                Console.WriteLine("Choose option 1-5");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        // Add task
                        AddTask();
                        break;

                    case "2":
                        // View all tasks
                        ViewTasks();
                        break;

                    case "3":
                        // Mark completed task
                        MarkComplete();
                        break;

                    case "4":
                        // Remove task
                        RemoveTask();
                        break;

                    case "5":
                        // Exit
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please Enter a Number from 1 to 5");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.WriteLine("Add Task Name: ");
            string taskTitle = Console.ReadLine();
            TasksArr[taskIndex] = taskTitle;
            Console.WriteLine("Task Added!");

            taskIndex++;
        }

        private static void ViewTasks()
        {
            Console.WriteLine("Tasks:");

            if (taskIndex == 0)
            {
                Console.WriteLine("No tasks added yet.");
            }
            else
            {
                for (int i = 0; i < taskIndex; i++)
                {
                    Console.WriteLine($"{i + 1}. {TasksArr[i]}");
                }
            }
        }

        private static void MarkComplete()
        {
            Console.WriteLine("Enter the number of the completed task:");
            string CtaskNumS = Console.ReadLine();
            int CtaskNum = Convert.ToInt32(CtaskNumS);

            if (TasksArr[CtaskNum - 1] != null && TasksArr[CtaskNum - 1].Contains(" <-Completed!"))
            {
                Console.WriteLine("This task is already marked as completed.");
            }
            else if (TasksArr[CtaskNum - 1] != null && !TasksArr[CtaskNum - 1].Equals(""))
            {
                TasksArr[CtaskNum - 1] += "  <-Completed!";
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        private static void RemoveTask()
        {
            Console.WriteLine("Enter the number of the task to remove:");
            string CtaskNumS = Console.ReadLine();
            int CtaskNum = Convert.ToInt32(CtaskNumS);
            TasksArr[CtaskNum - 1] = "";
        }
    }
}
