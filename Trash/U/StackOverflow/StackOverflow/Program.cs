using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Post();
            obj.Title = "First SO Post";
            obj.Description = "Test Description";
            obj.DateTime = DateTime.Now;
            Console.WriteLine("Upvoting thrice");
            for (int a =1; a<=3;a=a+1)
            {
                obj.upvote();
            }
            Console.WriteLine($"Current vote{obj.display()}");
            Console.WriteLine($"Now trying downvote");
            obj.downvote();
            Console.WriteLine($"Current vote{obj.display()}");
            Console.WriteLine($"Title {obj.Title}");
            Console.WriteLine($"Description {obj.Description}");
            Console.WriteLine($"Create time {obj.DateTime}");
            Console.ReadLine();
        }
    }
}
