using Xunit;

namespace DiscordBot.xUnit.Tests
{
    public class UyilityTests
    {
        [Fact]
        public void MyFirstTest()
        {
            const int expected = 5;

            var actual = Utilities.MyUtility(expected);

            Assert.Equal(expected, actual);
        }
    }
    
}
