using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("HTML Tutorial for Beginners", "Kevin Stratvert", 2345);
        Video video2 = new Video("How to Program in C#", "Brackeys", 707);
        Video video3 = new Video("Python for Beginners", "Mosh", 3605);

        video1.storeComment(new Comment("Aygol", "You have taught me more than my teacher did."));
        video1.storeComment(new Comment("wncjan", "Leaning HTML many years ago was rather easy as I had been making text documents with SGML and Script."));
        video1.storeComment(new Comment("geraldmuriithi4398", "This is the best Teacher, I have ever come across over the internet!"));

        video2.storeComment(new Comment("ReactJSX", "I am so glad we have tutorials like this."));
        video2.storeComment(new Comment("b3nn3t3", "This is actually really helpful, thanks!"));
        video2.storeComment(new Comment("BoostedEcho", "This is perfect. You have the perfect energy and voice for teaching"));

        video3.storeComment(new Comment("mayeshafahmida3578", "My first python class. I am sill learning from you."));
        video3.storeComment(new Comment("morhogeg", "Mosh is the best programming teacher on YouTube"));
        video3.storeComment(new Comment("shafiurrahaman3396","Hey, thank you for taking the time to make this vid!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.Report();
            Console.WriteLine();
        }
    }
}