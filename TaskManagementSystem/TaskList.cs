namespace TaskManagementSystem;

public class TaskList : Task
{
    
    /// <summary>
    /// public method that overrides the base class
    /// this will display the name of the task, due date, and description of the task
    /// </summary>
    public override void TaskInfo()
    {
        Console.WriteLine("Task: " + NameOfTask + " " + DueDate + " " + Description);
    }
}