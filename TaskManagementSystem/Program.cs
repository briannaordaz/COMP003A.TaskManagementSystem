namespace TaskManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        
        List<Task> TaskList = new List<Task>();
        
        
        while (true)
        {
            
 
            Console.WriteLine("\t Welcome to TaskManagementSystem!");
            Console.WriteLine("Pick one of the following options: ");
            
            Console.WriteLine("1. Add task: ");
            
            Console.WriteLine("2. Edit task: ");
            
            Console.WriteLine("3. View all tasks: ");
            
            Console.WriteLine("4. Delete task: ");
            
            Console.WriteLine("5. Exit: ");
            
            int menuChoice = Convert.ToInt32(Console.ReadLine());

           
           
            
            // menu option 1: 
            if (menuChoice == 1)
            {
                Console.WriteLine("Task Name: ");
                string taskName = Console.ReadLine();
            
                if (string.IsNullOrWhiteSpace(taskName))
                {
                    Console.WriteLine("Please enter a name for the task!: ");
                }
                else
                {
                    Console.WriteLine("Due Date (YYYY-MM-DD): ");
                     DateTime dueDate;

                     if (!DateTime.TryParse(Console.ReadLine(), out dueDate))
                     {
                        Console.WriteLine("Please enter a valid due date!: ");
                     }
                     else
                     {
                         Console.WriteLine("Enter Task Description: ");
                         string taskDescription = Console.ReadLine();

                         if (string.IsNullOrWhiteSpace(taskDescription))
                         {
                             Console.WriteLine("Please enter a description for the task!: ");
                         }
                         else
                         {
                             Console.WriteLine("Task created successfully! ");
                             TaskList.Add(new TaskList{NameOfTask = taskName, DueDate = dueDate, Description = taskDescription});

                         }
                     }
                    
                    
                }
                



            }

                
            
            // Menu option 2: 
             else if (menuChoice == 2)
            {
                Console.WriteLine("Edit Task: ");
                
                
                
                
                ///  2. Edit Task
                ///     * Name of Task:
                ///     * Change Due date:
                ///     * Change description:
            }

            // Menu option 3: 
            else if (menuChoice == 3)
            {
                Console.WriteLine("All Tasks ");
                if (TaskList.Count > 0)
                {
                    foreach (Task task in TaskList)
                        task.TaskInfo();
                }
                
                
                
                /// 3. View All Tasks:
                ///    * Displays all tasks
            }

             // Menu option 4: 
            else if (menuChoice == 4)
            {
                Console.WriteLine("Delete Task: ");
                
                foreach (Task task in TaskList)
                
                TaskList.Remove(task);


                // 4. Delete Task:
                ///    * Find task by name:
                ///    * Removing task

            }


            // Menu option 5: 
             else if (menuChoice == 5)
             {
                 Console.WriteLine("Goodbye!");
                 break;




                 /// 5. Exit
                 ///    * Console.WriteLine("Goodbye");
             }

             else 
            {
                Console.WriteLine("Invalid Choice! Only 1-5");
                
            }
            
            
        }




    }
}