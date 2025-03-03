namespace TaskManagementSystem;

/// <summary>
/// Task abstract Class 
/// </summary>
public abstract class Task
{
    
    /// <summary>
    /// private fields for the name of the task, due date, and description of task.
    /// This will ensure that the user will not have access to the information easily.
    /// </summary>
    private string _nameOfTask;
    private DateTime? _dueDate;
    private string _descriptionOfTask;

    /// <summary>
    /// this is a public property for the name of the task
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public string NameOfTask
    {
        get { return _nameOfTask; } //this will provide access to the private field "private string _nameOfTask;"
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) //this will check if the value is not empty,whitespace, or null 
            {_nameOfTask = value;} //if it's not empty, whitespace, or null, then it will assign the value to the private field "private string _nameOfTask;"
            else throw new ArgumentException("The task name cannot be empty."); //otherwise if its empty, null, or whitespace, then it will throw an exception saying "Task name cannot be empty."
            
        }
    }

    /// <summary>
    /// this is a public property for the due date of the task
    /// "DateTime?" will store the dates and times if the user decides to include it
    /// </summary>
    public DateTime? DueDate 
    {
        get { return _dueDate; } //this will provide access to the private field "private DateTime? _dueDate;"
        set
        {
            _dueDate = value; //this will assign value to the private field "private DateTime? _dueDate;" when the property is being set
        }
        
    }

    /// <summary>
    /// this is a public property for the description of the task
    /// </summary>
    public string Description
    {
        get { return _descriptionOfTask; } //this will provide access to the private field "private string _descriptionOfTask ;"
        set { _descriptionOfTask = value; } //this will assign value to the private field "private string _descriptionOfTask" when the property is being set
    }

    /// <summary>
    /// added an abstract method that will be implemented by a derived class
    /// </summary>
    public abstract void TaskInfo();
}