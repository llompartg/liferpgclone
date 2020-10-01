namespace RPGTasks.Values
{
    using System;

    public class TaskId
    {
        public string Value { get; }

        public TaskId(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
            Value = value;
        }
    }
}
