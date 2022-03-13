using System;
using ActivityPost.Entities;

namespace ActivityPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                46
                );
            post1.addComent(new Comment("Have a nice trip"));
            post1.addComent(new Comment("Wow that's awesome!"));

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
               );
            post2.addComent(new Comment("Good night"));
            post2.addComent(new Comment("May the force be with you"));


            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
