using System;

class Program
{
    static void Main(string[] args)
    {
       // Set 3-4 videos with 3-4 comments
        Video video01 = new Video("Financial Freedom 2024", "Author01", 660);
        video01.AddComment("User1", "Thanks!");
        video01.AddComment("User2", "I learned a lot!");
        video01.AddComment("User3", "What do you by mortgage?");

        Video video02 = new Video("Basic Programming", "Author02", 720);
        video02.AddComment("User4", "This is very helpful!");
        video02.AddComment("User5", "Can you give additional tutorial?");
        video02.AddComment("User6", "This is cool.");

        Video video03 = new Video("The Art of Reading Books", "Author03", 1200);
        video03.AddComment("User7", "Awesome content!");
        video03.AddComment("User8", "I'm a bookworm myself");
        video03.AddComment("User9", "Can you provide free book links?ty");

        Video video04 = new Video("Project Management in 30mins.", "Author04", 1800);
        video04.AddComment("User10", "Love it!");
        video04.AddComment("User11", "Too short");
        video04.AddComment("User12", "Appreciate the stories.");

        // Put videos on the list
        List<Video> videos = new List<Video> { video01, video02, video03, video04 };

        // Put in variable video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._Title);
            Console.WriteLine("Author: " + video._Author);
            Console.WriteLine("Length (seconds): " + video._LengthSeconds);
            Console.WriteLine("Number of Comments: " + video._GetNumComments());

            // Display all comments for the video
            Console.WriteLine("Comments:");
            foreach (var comment in video._Comments)
            {
                Console.WriteLine($"{comment._CommenterName}: {comment._CommentText}");
            }
            Console.WriteLine("\n");
        }
    }
}