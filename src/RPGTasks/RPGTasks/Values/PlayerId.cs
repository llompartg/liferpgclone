namespace RPGTasks.Values
{
    using System;

    public class PlayerId
    {
        public string Value { get; }

        public PlayerId(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
            Value = value;
        }
    }
}
