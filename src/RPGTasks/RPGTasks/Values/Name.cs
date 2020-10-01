namespace RPGTasks.Values
{
    using System;

    public class Name
    {
        public string Value { get; }

        public Name(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
            Value = value;

        }
    }
}
