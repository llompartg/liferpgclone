namespace RPGTasks.UnitTests.Values
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using RPGTasks.Values;

    class NameShould
    {
        [Test]
        public void AllowCreation()
        {
            var taskName = new Name("name");
            taskName.Value.Should().Be("name");
        }

        [Test]
        public void PreventCreationWithNullValue()
        {
            try
            {
                new Name(null);
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
                new Name("");
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
