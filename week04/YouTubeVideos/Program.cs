using System;

class Program
{
    static void Main(string[] args)
    {



        Comment comment1 = new Comment();
        comment1._name = "Samuel Doe";
        comment1._text = "This is exactly what young people in Liberia need to hear.";

        Comment comment2 = new Comment();
        comment2._name = "Alex Johnson";
        comment2._text = "This video really motivated me to start learning programming seriously.";

        Comment comment3 = new Comment();
        comment3._name = "Blessing Kollie";
        comment3._text = "Very clear explanation. I finally inderstand variables now!";

        Comment comment4 = new Comment();
        comment4._name = "David James";
        comment4._text = "“Your story really encouraged me to keep pushing even when life gets hard.";

        Comment comment5 = new Comment();
        comment5._name = "Prince Moi";
        comment5._text = "Your explanation of freelancing platforms was very helpful.";
        
        Comment comment6 = new Comment();
        comment6._name = "Cynthia K";
        comment6._text = "This video gave me the confidence to start learning tech skills for real";
        
        Comment comment7 = new Comment();
        comment7._name = "Basee Wesseh";
        comment7._text = "I’ve been looking for practical advice, and this video finally delivered";
        
        Comment comment8 = new Comment();
        comment8._name = "Hage Ledlum";
        comment8._text = "I’m saving this video to watch again later—so much motivation in one place.";
        
        Comment comment9 = new Comment();
        comment9._name = "Frank John";
        comment9._text = "Thank you for being honest about your struggles. It made the message more powerful.";
        
        Comment comment11 = new Comment();
        comment11._name = "Eramus P.";
        comment11._text = "I didn’t know coding could create so many opportunities. This opened my eyes!";
        



        Video movies1 = new Video();
        movies1._title = "How Coding Changed My Life in Africa";
        movies1._author = "Tech With Sam";
        movies1._length = 780;
        movies1._comments.Add(comment1);
        movies1._comments.Add(comment2);
        movies1._comments.Add(comment3);
        movies1.DisplayComments();


        Video movies2 = new Video();
        movies2._title = "Beginner Python Tutorial - 15 Minutes";
        movies2._author = "CodeFast Academy";
        movies2._length = 900;
        movies2._comments.Add(comment4);
        movies2._comments.Add(comment5);
        movies2._comments.Add(comment6);
        movies2.DisplayComments();


        Video movies3 = new Video();
        movies3._title = "How to Make Money Online with Tech Skills";
        movies3._author = "Digital Growth Hub";
        movies3._length = 1200;
        movies3._comments.Add(comment7);
        movies3._comments.Add(comment8);
        movies3._comments.Add(comment9);
        movies3._comments.Add(comment11);
        movies3.DisplayComments();


        List<Video> _videos = new List<Video>();
        _videos.Add(movies1);
        _videos.Add(movies2);
        _videos.Add(movies3);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            video.DisplayComments();
        }
    }
}