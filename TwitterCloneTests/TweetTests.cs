using System;
using simpleConsoleApp;
using Xunit;

namespace TwitterCloneTests
{
    public class TweetTests
    {
        [Fact]
        public void ParseTweet_WhenValidTweet_ReturnsTweet()
        {
            //Arrange
            var tweet = new Tweet();
            var expectedResult = "hi";
            //Act
            var result = tweet.ParseTweet(expectedResult);
            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ParseTweet_WhenInvalidTweet_ReturnError()
        {
            //Arrange
            var tweet = new Tweet();
            var expectedResult = "Please enter a tweet between 1 and 20 characters long";
            var invalidUserInput = "fghjchftghgdghertyujkl";
            //Act
            var result = tweet.ParseTweet(invalidUserInput);
            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
