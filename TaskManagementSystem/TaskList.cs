namespace TaskManagementSystem;

/// <summary>
/// public class named "TaskList" that inherits from the base class "Task"
/// </summary>
public class TaskList : Task
{
    
    /// <summary>
    /// public method that overrides the base class
    /// this will display the name of the task, due date, and description of the task
    /// </summary>
    public override void TaskInfo()
    {
        Console.WriteLine("Task Name: " + " " + NameOfTask + " " + " *****" + " " + "Date/Time: " + " " + DueDate + " " + "***** " + "Description: " + " "+ Description);
    }
}

