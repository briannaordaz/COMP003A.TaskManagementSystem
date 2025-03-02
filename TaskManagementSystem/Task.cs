namespace TaskManagementSystem;

/// <summary>
/// Task Class 
/// </summary>
public class Task
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
        get { return _nameOfTask; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) {_nameOfTask = value;}
            else throw new ArgumentException("The task name cannot be empty.");
            
        }
    }

    /// <summary>
    /// this is a public property for the due date of the task 
    /// </summary>
    public DateTime? DueDate
    {
        get { return _dueDate; }
        set
        {
            _dueDate = value; 
        }
        
    }

    /// <summary>
    /// this is a public property for the description of the task
    /// </summary>
    public string Description
    {
        get { return _descriptionOfTask; } 
        set { _descriptionOfTask = value; }
    }
}