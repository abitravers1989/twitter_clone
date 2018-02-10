using System;
namespace simpleConsoleApp
{
    public class Tweet
    {
        public string ParseTweet(string tweet)
        {
            if(tweet.Length > 20){
                return "Please enter a tweet between 1 and 20 characters long";
            }

            return tweet;//"tweet";
            
        }
    }
}
