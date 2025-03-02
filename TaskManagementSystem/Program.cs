namespace TaskManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice;
        
        while (true)
        {
            Console.WriteLine("Welcome to TaskManagementSystem!");
            Console.WriteLine("Pick one of the following options: ");
            
            Console.WriteLine("1. Add task: ");
            
            Console.WriteLine("2. Edit task: ");
            
            Console.WriteLine("3. View all tasks: ");
            
            Console.WriteLine("4. Delete task: ");
            
            Console.WriteLine("5. Other: ");
            
            Console.WriteLine("6. Exit: ");
            
            menuChoice = Console.ReadLine();
            
            if (menuChoice == "1")
            {
                Console.WriteLine("Task Name: ");
                string taskName = Console.ReadLine();
            
                Console.WriteLine("");
            }

            if (menuChoice == "2")
            {
                
            }

            if (menuChoice == "3")
            {
                
            }

            if (menuChoice == "4")
            {
                
            }

            if (menuChoice == "5")
            {
                
            }

            if (menuChoice == "6")
            {
                
            }
        }
        

        
    }
}