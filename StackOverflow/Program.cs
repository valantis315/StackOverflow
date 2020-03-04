using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post();
            var post2 = new Post();

            post1.Title = "Test Title";
            post1.Description = "Blah blah blah";
            post1.Timestamp=DateTime.Now;

            post1.Upvote();
            post1.Upvote();
            post1.Upvote();
            post1.Upvote();
            post1.Downvote();
            post1.ShowPost();

            post2.Title = "Test Title for article 2";
            post2.Description = "Blah2 blah2 blah2";
            post2.Timestamp = DateTime.Now;
            post2.Downvote();
            post2.Downvote();
            post2.Downvote();

            post2.ShowPost();
        }
    }
}
