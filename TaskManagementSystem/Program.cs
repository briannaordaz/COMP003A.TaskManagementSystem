namespace TaskManagementSystem;

/// <summary>
/// the main class
/// </summary>
class Program
{
    /// <summary>
    /// Main Method
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        
        List<Task> TaskList = new List<Task>(); //This creates a list for the tasks
        
        
        while (true) //while-loop so while its true the code below will continue to execute, if its false it will break
        {
            
 
            Console.WriteLine("\t Welcome to TaskManagementSystem!"); //Welcome sign 
            Console.WriteLine("Pick one of the following options: "); //tells user to pick one of the options from below
            
            Console.WriteLine("1. Add task: "); // the first menu option is to add a task
            
            Console.WriteLine("2. Edit task: "); // second menu option allows you to edit task
            
            Console.WriteLine("3. View all tasks: "); // the third menu option allows you to view all tasks
            
            Console.WriteLine("4. Delete task: "); // fourth menu that allows you to delete a task
            
            Console.WriteLine("5. Exit: "); // fifth menu, exits the menu
            
            int menuChoice = Convert.ToInt32(Console.ReadLine()); // this is where your input will be stored (the number u choose for the menu above)

           
           
            
            // menu option 1: 
            if (menuChoice == 1) // if the user chose option 1:
            {
                Console.WriteLine("Task Name: "); // tells user to input the name of the task
                string taskName = Console.ReadLine(); // this is where the name of the task will be stored in
            
                if (string.IsNullOrWhiteSpace(taskName)) //this checks if the name of the task is empty 
                {
                    Console.WriteLine("Please enter a name for the task!: "); // if the statement above is true (which means if taskName is empty) then the program will output an error saying "Please enter a name for the task"
                }
                else
                {
                    Console.WriteLine("Due Date (YYYY-MM-DD) 00:00:00 AM/PM: "); //otherwise if the statement above is false then the program will ask user to enter a due date
                     DateTime dueDate; // this is where the due date will be stored in

                     if (!DateTime.TryParse(Console.ReadLine(), out dueDate)) //if the users input is not a valid date:
                     {
                        Console.WriteLine("Please enter a valid due date!: "); // then the program will output "Please enter a valid due date"
                     }
                     else
                     {
                         Console.WriteLine("Enter Task Description: "); // tells the user to add a task description if the statement above is 
                         string taskDescription = Console.ReadLine(); // this is where the task description will be saved

                         if (string.IsNullOrWhiteSpace(taskDescription)) //if the statement is true (the description for the task is empty): 
                         {
                             Console.WriteLine("Please enter a description for the task!: "); //then the program will output: "Please enter a description for the task"
                         }
                         else
                         {
                             Console.WriteLine("Task created successfully! "); // otherwise if its false, the program will output "Task created successfully"
                             TaskList.Add(new TaskList{NameOfTask = taskName, DueDate = dueDate, Description = taskDescription}); //Adds the task to the list

                         }
                     }
                    
                    
                }
                



            }

                
            
            // Menu option 2: 
             else if (menuChoice == 2) //if user chooses option 2 from the menu 
            {
                Console.WriteLine("Edit Task: "); // then "Edit TasK:" will be displayed
                Console.WriteLine("Name of task you would like to edit: "); //and program will ask user to input the name of the task they would like to edit
                string editTask = Console.ReadLine(); //this is where the name of the task they would like to edit will be saved
                
                Task task = TaskList.Find(x => x.NameOfTask == editTask); // this will help find the name of the task they want to edit.

                if (task != null) // if the task is found (and it's not empty):
                {
                    Console.WriteLine("Which would you like to edit?"); //then the program will ask the user to choose which part of the task they would like to edit.
                    Console.WriteLine("1. Name of task: "); //if they choose 1, that means they want to edit the name of the task
                    Console.WriteLine("2. Due Date: "); //if they choose 2, then that means they want to edit the due date
                    Console.WriteLine("3. Description: "); // if they chose 3, then that means they want to edit the description
                    Console.WriteLine("Choose a number from above 1-3: "); //this will tell the user to type a number from 1 to 3 depending on what they want to change from the task
                    int editTaskChoice = Convert.ToInt32(Console.ReadLine()); //this is where the user's input for the choices above will be stored, it will also convert a string into an integer

                    if (editTaskChoice == 1) //if choice = 1
                    {
                        Console.WriteLine("Enter new task name: "); //then it will ask user to enter new task name
                        string newTaskName = Console.ReadLine(); //this is where the new task name will be stored
                        task.NameOfTask = newTaskName; //updates the old task name to the new task name
                        Console.WriteLine("New Task Name Added Successfully!"); // tells user that the name has been successfully updated
                        
                        
                    }
                    else if (editTaskChoice == 2) //if the choice = 2
                    {
                        Console.WriteLine("Enter the new due date (YYYY-MM-DD  HH:MM:SS AM/PM): "); //then the program will ask user to input the due date in a specific format. | Y=Year, M=Month, D=Day | H=Hour, M=Minute, S=Second
                        string newDateT = Console.ReadLine(); // where the new due date will be stored
                        

                        if (!DateTime.TryParse(newDateT, out DateTime newDueDate)) // DateTime.TryParse will try to convert the new due date into a valid DateTime object. if it fails then:
                        {

                            Console.WriteLine("Please enter a valid due date!: "); //the program will output "Please enter a valid due date" 
                        }
                        else 
                        {
                            task.DueDate = newDueDate; //otherwise, the program will update the old due date to the new Due Date
                            Console.WriteLine("New Due Date Added Successfully! "); //program will output "New Dude Date Added Successfully"

                        }

                    }
                    else if (editTaskChoice == 3) //if choice = 3:
                    {
                        Console.WriteLine("Enter the new description: "); //then the user will be asked to enter the new description
                        string newDescription = Console.ReadLine(); //this is where the new description will be stored in
                        
                        task.Description = newDescription; //  the old description will get updated to the new description
                        
                        Console.WriteLine("New Description Added Successfully!"); //this outputs "New description added successfully" if the statement above is true
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number 1-3: "); // if user chose a number less than 1 or a number higher than 3 then the program will output "Please enter a valid number"
                    }
                }
                else
                {
                    Console.WriteLine("Could not find Task!"); // if the task is not found (to edit) then the program will output "Could not find Task!"
                }

                
                
                
                
                
                
                ///  2. Edit Task
                ///     * Name of Task:
                ///     * Change Due date:
                ///     * Change description:
            }

            // Menu option 3:  
            else if (menuChoice == 3)  //If user chose menu option 3 then:
            {
                Console.WriteLine("All Tasks "); //"All tasks" will be displayed
                if (TaskList.Count > 0) // this checks if there is a task list 
                {
                    foreach (Task task in TaskList) //this will loop through each task the user has entered
                        task.TaskInfo(); //this will call the TaskInfo() method, which displays the: name, due date, and description of each task
                }
                else
                {
                    Console.WriteLine("No tasks found!"); //if the statement above is false (meaning there were no tasks) then the program will output "No Tasks found!"
                }
                
                
                
               
            }

             // Menu option 4: 
            else if (menuChoice == 4) //if the user chose 4 as the menu option: 
            {
                Console.WriteLine("Delete Task: "); //then the program will output "Delete Task: "

                if (TaskList.Count > 0) //This checks if there are any tasks in the TaskList

                {
                    Console.WriteLine("Name of task you want to delete: "); //if the statement above is true (meaning there are tasks) then the program will ask user to input the name of the task they wish to delete
                    string deleteTask = Console.ReadLine(); //this is where the user input will be stored (the name of the task they wish to delete)
                    
                    Task taskName = TaskList.Find(x => x.NameOfTask == deleteTask); //this will try to find the name of the task (they wish to delete) in the task List

                    if (taskName != null) //if taskName is not empty (meaning the task was found): 
                    {
                        TaskList.Remove(taskName); //then the program will delete the task
                        Console.WriteLine("Task deleted successfully!"); //program will output "Task deleted successfully!"
                    }
                    else
                    {
                        Console.WriteLine("Task cannot be found in the list!"); //otherwise if the taskName is empty (or if there is no task found with the name that the user typed) then the program will output "Task cannot be found in the list!"
                    }
                    
                }
                else
                {
                    Console.WriteLine("There are no tasks to delete!"); //if there are no tasks in the task list then the program will output "There are no tasks to delete"
                }




               

            }


            // Menu option 5: 
             else if (menuChoice == 5)  //if the menu choice is 5 then:
             {
                 Console.WriteLine("Goodbye!"); //the program will output "Goodbye"
                 break; // this exits the loop




                 
             }

             else 
            {
                Console.WriteLine("Invalid Choice! Only 1-5"); //if the users input is not 1-5 for the main menu, then the program will output "Invalid choice"
                
            }
            
            
        }




    }
}



/// PLAN: 
/// Task Management System Menu:



///  1. Add task
///  2. Edit Task
///  3. View All Tasks
///  4. Delete Task
///  5. Exit



///  1. Add Task:
///     *  Task Name:
///     * (userinput)
///     *  Task Due Date : (YYYY-MM-DD HH:MM:SS AM/PM)
///     * (userinput)
///     *  Description:
///     * (userinput)



///  2. Edit Task
///     * "Enter name of task you would like to edit: "
///     * (user input)
///     * "Which of the following would you like to edit: "
///     *  1. Change Task Name:
///     *  2. Change Due date:
///     *  3. Change description:
///     * (User Input)
///
///       * 1. Change Task Name:
///             * "New name of task: "
///             * (userInput) 
///             * "Task Name changed successfully!!"
///
///       * 2. Change Due Date:
///             * "New due date (YYYY-MM-DD HH-MM-SS AM/PM): "
///             * (userInput)
///             * "Due Date changed successfully!!"
///
///        * 3. Change Description:
///             * "New Description: "
///             * (userInput)
///             * "Description changed successfully!!"


/// 3. View All Tasks:
///    * Displays all tasks



/// 4. Delete Task:
///    * "Enter the name of the task you would like to delete: "
///    * (userInput)
///    * ~Find task by name~
///    * ~Remove task~



/// 5. Exit
///    * Console.WriteLine("Goodbye");