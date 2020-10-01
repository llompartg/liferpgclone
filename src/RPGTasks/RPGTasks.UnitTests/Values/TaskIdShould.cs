namespace RPGTasks.UnitTests.Values
{
    using FluentAssertions;
    using NUnit.Framework;
    using RPGTasks.Values;
    using System;

    class TaskIdShould
    {
        [Test]
        public void AllowCreation()
        {
            var taskId = new TaskId("id");
            taskId.Value.Should().Be("id");
        }

        [Test]
        public void PreventCreationWithNullValue()
        {
            try
            {
                new TaskId(null);
            }
            catch (ArgumentNullException ex)
            {
                ex.ParamName.Should().Be("value");
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void PreventCreationWithEmptyValue()
        {
            try
            {
                new TaskId("");
            }
            catch (ArgumentException ex)
            {
                ex.ParamName.Should().Be("value");
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
