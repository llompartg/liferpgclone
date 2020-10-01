namespace RPGTasks.UnitTests.Values
{
    using FluentAssertions;
    using NUnit.Framework;
    using RPGTasks.Values;
    using System;

    class PlayerIdShould
    {
        [Test]
        public void AllowCreation()
        {
            var playerId = new PlayerId("id");
            playerId.Value.Should().Be("id");
        }

        [Test]
        public void PreventCreationWithNullValue()
        {
            try
            {
                new PlayerId(null);
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
                new PlayerId("");
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
