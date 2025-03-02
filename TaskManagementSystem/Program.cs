namespace TaskManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice;
        
        List<Task> TaskList = new List<Task>();
        
        List<Task> tasks = new List<Task>();
        
        while (true)
        {
            Console.WriteLine("Welcome to TaskManagementSystem!");
            Console.WriteLine("Pick one of the following options: ");
            
            Console.WriteLine("1. Add task: ");
            
            Console.WriteLine("2. Edit task: ");
            
            Console.WriteLine("3. View all tasks: ");
            
            Console.WriteLine("4. Delete task: ");
            
            Console.WriteLine("5. Exit: ");
            
            menuChoice = Console.ReadLine();
            
            if (menuChoice == "1")
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
                             TaskList.Add(new Task{NameOfTask = taskName, DueDate = dueDate, Description = taskDescription});

                         }
                     }
                    
                    
                }
                



            }

                
            

             if (menuChoice == "2")
            {
                
            }

             if (menuChoice == "3")
            {
                
            }

            else if (menuChoice == "4")
            {

            }


             if (menuChoice == "5")
            {
                Console.WriteLine("Goodbye!");
                
            }
             else 
             {
                Console.WriteLine("Please enter a valid choice!! (1-5)"); 
             }

            
        }
        

        
    }
}