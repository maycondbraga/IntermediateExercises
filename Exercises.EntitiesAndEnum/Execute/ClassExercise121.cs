using System;
using Exercises.EntitiesAndEnum.Entities;

namespace Exercises.EntitiesAndEnum.Execute
{
    public class ClassExercise121
    {
        /// <summary>
        /// Creates Posts like a social media, with comments and likes
        /// </summary>
        public static void CheckPosts()
        {
            DateTime _moment = DateTime.Parse("21/06/2018 13:05:44");
            string _title = "Traveling to New Zealand";
            string _content = "I'm going to visit this wonderful country!";
            int _likes = 12;

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");

            Post post1 = new Post(_moment, _title, _content, _likes);

            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Console.WriteLine(post1);
        }
    }
}
