using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all the videos
        List<Video> videos = new List<Video>();

        // ----- Video 1 -----
        Video video1 = new Video("Learning C# Classes", "CodeWithJayson", 600);
        video1.AddComment(new Comment("Sarah", "This really helped me understand classes, thanks!"));
        video1.AddComment(new Comment("Ethan", "The examples were super clear."));
        video1.AddComment(new Comment("Mia", "Can you do one on inheritance next?"));
        videos.Add(video1);

        // ----- Video 2 -----
        Video video2 = new Video("Pizza Review: Detroit Style", "JaysPizzaLab", 480);
        video2.AddComment(new Comment("Spencer", "Now I’m hungry…"));
        video2.AddComment(new Comment("Lily", "That crust looks amazing."));
        video2.AddComment(new Comment("Mark", "You should do a gluten-free version!"));
        videos.Add(video2);

        // ----- Video 3 -----
        Video video3 = new Video("Rafting the Snake River", "AdventureTime", 720);
        video3.AddComment(new Comment("Alex", "Those views are incredible."));
        video3.AddComment(new Comment("Nora", "Was the water super cold?"));
        video3.AddComment(new Comment("Ben", "Adding this to my bucket list."));
        videos.Add(video3);

        // Optional: a 4th video if you want
        Video video4 = new Video("Study With Me: Coding Session", "FocusBuddy", 3600);
        video4.AddComment(new Comment("Jane", "This helped me stay focused for an hour."));
        video4.AddComment(new Comment("Leo", "Love the chill background music."));
        video4.AddComment(new Comment("Olivia", "Please make a 2-hour version!"));
        videos.Add(video4);

        // ----- Display all videos and their comments -----
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title:   {video.Title}");
            Console.WriteLine($"Author:  {video.Author}");
            Console.WriteLine($"Length:  {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }

        // Keep the console window open if needed
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
