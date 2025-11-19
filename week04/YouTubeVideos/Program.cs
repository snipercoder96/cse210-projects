using System;

class Program
{
    static void Main(string[] args)
    {

        List<Videos> videoList = new List<Videos>();

        /* For each video use the video class and store comments */

        Videos video1 = new Videos();
        video1._title = "Top 10 Beginner Coding Tips in 10 Minutes";
        video1._author = "Bro Code";
        video1._length = 600;
        video1._comments = new List<Comments> // Put in a list
        {
            new Comments("Summer", "Great work explaining how to code, for years I have been coding wrong"),
            new Comments("Zane", "Thank you very much, I feel like this lesson was very instructive"),
            new Comments("Zoe", "I have been getting lost from time to time, but this lesson was explained well")
        };
        videoList.Add(video1);


        Videos video2 = new Videos();
        video2._title = "Learn C# in 12 Hours";
        video2._author = "Mosh";
        video2._length = 8640;
        video2._comments = new List<Comments>
        {
            new Comments("Marron", "00:33, That was very funny Mosh!"),
            new Comments("Alex", "This is the most complete tutorial I’ve seen"),
            new Comments("Jamie", "I finally understand classes thanks to this video")
        };
        videoList.Add(video2);


        Videos video3 = new Videos();
        video3._title = "Lists and Loops in Python";
        video3._author = "Coding with Praveen";
        video3._length = 900;
        video3._comments = new List<Comments>
        {
            new Comments("Chris", "Loops finally make sense now"),
            new Comments("Taylor", "Loved the examples, very clear"),
            new Comments("Jordan", "Can you do a follow-up on nested loops?")
        };
        videoList.Add(video3);


        Videos video4 = new Videos();
        video4._title = "Instance of a Class - Programming with Mosh";
        video4._author = "Mosh";
        video4._length = 1380;
        video4._comments = new List<Comments>
        {
            new Comments("Sam", "This helped me ace my assignment"),
            new Comments("Lee", "The explanation was so simple and clear"),
            new Comments("Dana", "I wish I had found this earlier!")
        };
        videoList.Add(video4);


        foreach (Videos video in videoList)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentsCount()}");

            video.DisplayComment();
            Console.WriteLine();
        }
    }
}