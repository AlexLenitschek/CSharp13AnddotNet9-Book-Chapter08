using Packt.Shared;

namespace Exercise_NumbersAsWordsXunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test0()
        {
            // Arrange: 
            int input = 0;
            string expected = "zero";

            // Act:
            string actual = NumberToString.ToWords(input);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test99()
        {
            // Arrange: 
            int input = 99;
            string expected = "ninetynine";

            // Act:
            string actual = NumberToString.ToWords(input);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test8765()
        {
            // Arrange: 
            int input = 8765;
            string expected = "eightthousand sevenhundred sixtyfive";

            // Act:
            string actual = NumberToString.ToWords(input);

            // Assert:
            Assert.Equal(expected, actual);
        }
    }
}