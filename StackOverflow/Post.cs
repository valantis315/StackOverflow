using System;

namespace StackOverflow
{
    public class Post
    {
        private int _currentVote;
        public int CurrentVote => _currentVote;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }

        public void Upvote()
        {
            ++_currentVote;
        }
        public void Downvote()
        {
            --_currentVote;
        }

        public void ShowPost()
        {
            Console.WriteLine("Date Posted: " + Timestamp.ToLongDateString());
            Console.WriteLine(Title);
            Console.WriteLine();
            Console.WriteLine(Description);
            Console.WriteLine();
            Console.WriteLine("Votes: " + CurrentVote);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
        }

    }
}