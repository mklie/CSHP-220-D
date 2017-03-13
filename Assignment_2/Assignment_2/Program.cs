using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            Console.WriteLine("Users with hello password:");
            users.Where(p => p.Password == "hello").ToList().ForEach(p => Console.WriteLine(p.Name+"'s password is "+p.Password));

            users.RemoveAll(p => p.Password == p.Name.ToLower());
            
            users.Remove(users.FirstOrDefault(p => p.Password == "hello"));

            Console.WriteLine("Users left without hello password:");
            users.ForEach(p => Console.WriteLine(p.Name + "'s password is " + p.Password));







            Console.ReadLine();



        }
    }
}
