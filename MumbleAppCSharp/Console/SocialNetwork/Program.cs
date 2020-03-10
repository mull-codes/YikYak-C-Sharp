using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string email, pass;
            bool LoginState = false;

            Login tempUser;
            tempUser = new Login();
            tempUser.SetDebug(true);

            Console.WriteLine("WELCOME TO MUMBLE!");

            List<Post> PostList = new List<Post>();

            

            do
            {
                if (LoginState == true)
                {
                    int menuItem = MainMenu();
                    switch (menuItem)
                    {
                        case 1:
                            Console.WriteLine(SetTitle("--News Feed--"));
                            int ListLength = PostList.Count();
                            if (ListLength < 1)
                            {
                                Console.WriteLine("You look lonely here, write a post and show everyone you are awesome.");
                            }
                            else
                            {
                                foreach (Post myPost in PostList)
                                {
                                    Console.WriteLine(myPost.GetPost());
                                    Console.WriteLine("---------------------------------------");
                                }
                            }
                            
                            break;
                        case 2:
                            Console.WriteLine(SetTitle("--Write a Post--"));
                            Console.Write("What's on your mind?: ");
                            string input = Console.ReadLine();
                            InputFilter myFilter = new InputFilter();
                            myFilter.AddWords();
                            if (myFilter.HasProfane(input))
                            {
                                Console.WriteLine("Profanity found!");
                            }
                            else
                            {
                                Post p = new Post(input, tempUser.GetUserID());
                                PostList.Add(p);
                            }
                            /*Post p1 = new Post("Loem Ipsum is Dolar Silam.", tempUser.GetUserID());
                            Post p2 = new Post("Yummy dummy I am tired of typing.", tempUser.GetUserID());
                            Post p3 = new Post("Yanki danky doh, raw raw raw.", tempUser.GetUserID());
                            Post p4 = new Post("I am a cat, meow meown meow.", tempUser.GetUserID());
                            PostList.Add(p1);
                            PostList.Add(p2);
                            PostList.Add(p3);
                            PostList.Add(p4);*/
                            break;
                        default:
                            Console.WriteLine("Planet X\nOoops are you lost!");
                            break;
                    }
                }
                else
                {
                    do
                    {
                        Console.WriteLine(SetTitle("--Login--"));
                        Console.Write("Email: ");
                        email = Console.ReadLine();
                        Console.Write("Password: ");
                        pass = Console.ReadLine();
                        
                        //UserList.Add(tempUser);

                        if (tempUser.ValidateLogin(email, pass) == true)
                        {
                            LoginState = true;
                            Console.WriteLine("\n" + tempUser.Error() + "\n");
                            Console.WriteLine(tempUser.GetDeviceName());
                        }
                        else
                        {
                            LoginState = false;
                            Console.WriteLine("\n" + tempUser.Error() + "\n");
                        }

                    } while (LoginState == false);
                    
                }

            } while (exit == false);
        }


        static string SetTitle(string input)
        {
            string line = "+-----------------------------------------+";
            string rString = line + "\n" + input + "\n" + line + "\n";
            return rString;
        }


        static int MainMenu()
        {
            int choice;
            Console.WriteLine("\n1. News Feed");
            Console.WriteLine("2. Write a Post");
            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static int LoginMenu()
        {
            int choice;
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Register");
            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
