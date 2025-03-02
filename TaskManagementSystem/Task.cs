namespace TaskManagementSystem;

public class Task
{
    private string _nameOfTask;
    private string _DueDate;
    private string _descriptionOfTask;

    public string NameOfTask
    {
        get { return _nameOfTask; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) {_nameOfTask = value;}
            else throw new ArgumentException("The task name cannot be empty.");
            
        }
    }

    public string DueDate
    {
        get { return _DueDate; }
        set { _DueDate = value; }
        
    }
}