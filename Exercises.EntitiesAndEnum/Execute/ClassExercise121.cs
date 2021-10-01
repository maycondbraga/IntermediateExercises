using System;
using System.Threading;
using System.Collections.Generic;
using Exercises.Compositions.Entities;
using Exercises.Compositions.Entities.Enums;

namespace Exercises.Compositions.Execute
{
    public class ClassExercise121
    {
        /// <summary>
        /// Creates Posts like a social media, with comments and likes
        /// </summary>
        public static void SocialMediaPosts()
        {
            List<Post> allPosts = new List<Post>();

            Console.WriteLine("Welcome to the Maycon's Social Media \n");

            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("\n1. AddPost \n2. RemovePost \n3. SearchPost \n4. Exit \n");

                PostMenuOption option = (PostMenuOption)Enum.Parse(typeof(PostMenuOption), Console.ReadLine());

                switch (option)
                {
                    case PostMenuOption.AddPost:
                        {
                            string addMorePost;

                            do
                            {
                                AddPost(ref allPosts);

                                Console.Write("\nWant to add more posts? (s/n) : ");
                                addMorePost = Console.ReadLine();

                                while (addMorePost.ToUpper() != "S" && addMorePost.ToUpper() != "N")
                                {
                                    Console.WriteLine("\nWrong command!");
                                    Console.Write("Want to add more posts? (s/n) : ");

                                    addMorePost = Console.ReadLine();
                                }
                            }
                            while (addMorePost.ToUpper() == "S");
                            
                            break;
                        }
                    case PostMenuOption.RemovePost:
                        {
                            string removeMorePost;

                            do
                            {
                                RemovePost(ref allPosts);

                                Console.Write("\nWant to remove more posts? (s/n) : ");
                                removeMorePost = Console.ReadLine();

                                while (removeMorePost.ToUpper() != "S" && removeMorePost.ToUpper() != "N")
                                {
                                    Console.WriteLine("\nWrong command!");
                                    Console.Write("Want to remove more posts? (s/n) : ");

                                    removeMorePost = Console.ReadLine();
                                }
                            }
                            while (removeMorePost.ToUpper() == "S");

                            break;
                        }
                    case PostMenuOption.SearchPost:
                        {
                            string searchMorePost;

                            do
                            {
                                SearchPost(ref allPosts);

                                Console.Write("\nWant to search more posts? (s/n) : ");
                                searchMorePost = Console.ReadLine();

                                while (searchMorePost.ToUpper() != "S" && searchMorePost.ToUpper() != "N")
                                {
                                    Console.WriteLine("\nWrong command!");
                                    Console.Write("Want to search more posts? (s/n) : ");

                                    searchMorePost = Console.ReadLine();
                                }
                            }
                            while (searchMorePost.ToUpper() == "S");

                            break;
                        }
                    case PostMenuOption.Exit:
                        {
                            Console.WriteLine("Finishing Application..");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid command. Select a valid option\n");
                            break;
                        }
                }
            }
            while (true);
        }

        private static void AddPost(ref List<Post> posts)
        {
            DateTime _moment;

            while (true)
            {
                Console.Write("\nEx: dd/mm/yyyy HH:mm:ss");
                Console.Write("\nTime of posting (date): ");

                if (!DateTime.TryParse(Console.ReadLine(), out _moment))
                {
                    Console.WriteLine("\nInvalid date. Format must be (dd/mm/yyyy HH:mm:ss)");
                }
                else
                {
                    break;
                }
            }

            Console.Write("\nPost title: ");
            string _title = Console.ReadLine();

            Console.Write("\nPost content: ");
            string _content = Console.ReadLine();

            Console.Write("\nLikes: ");
            int _likes = int.Parse(Console.ReadLine());

            Post post = new Post(_moment, _title, _content, _likes);

            Console.Write("\nDoes this post have any comments? (s/n) : ");
            string haveComment = Console.ReadLine();

            while (haveComment.ToUpper() != "S" && haveComment.ToUpper() != "N")
            {
                Console.WriteLine("\nWrong command!");
                Console.Write("Does this post have any comments? (s/n) : ");

                haveComment = Console.ReadLine();
            }

            if (haveComment.ToUpper() == "S")
            {
                string moreComment;

                do
                {
                    Console.Write("\nComment: ");
                    Comment _comment = new Comment(Console.ReadLine());

                    post.AddComment(_comment);

                    Console.Write("\nAdd one more comment? (s/n) : ");
                    moreComment = Console.ReadLine();

                    while (moreComment.ToUpper() != "S" && moreComment.ToUpper() != "N")
                    {
                        Console.WriteLine("\nWrong command!");
                        Console.Write("Add one more comment? (s/n) : ");

                        moreComment = Console.ReadLine();
                    }
                }
                while (moreComment.ToUpper() == "S");
            }

            posts.Add(post);
        }

        private static void RemovePost(ref List<Post> posts)
        {
            Console.WriteLine("Enter the title of the post you want to delete: \n");
            string toDelete = Console.ReadLine();
            bool isDeleted = false;

            foreach (Post post in posts)
            {
                if (post.Title == toDelete)
                {
                    posts.Remove(post);
                    isDeleted = true;

                    Console.Write("\nPost successfully deleted");
                    break;
                }
            }

            if (isDeleted == false)
            {
                Console.Write("\nPost not found, check if the title is correct");
            }
        }

        private static void SearchPost(ref List<Post> posts)
        {
            Console.WriteLine("Enter the title of the post you want to search: \n");
            string toSearch = Console.ReadLine();
            bool found = false;

            foreach (Post post in posts)
            {
                if (post.Title == toSearch)
                {
                    found = true;

                    Console.Write("\nPost found, loading..\n");
                    Console.WriteLine(post);
                    break;
                }
            }

            if (found == false)
            {
                Console.Write("\nPost not found, check if the title is correct");
            }
        }
    }
}
