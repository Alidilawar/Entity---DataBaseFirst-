using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new DataBaseFirstDemoEntities();
            var Post = new Post
            {
                Body = "Body",
                DataPublished = DateTime.Now,
                Title = "title",
               
            };

            Context.Posts.Add(Post);
            Context.SaveChanges();
        }
    }
}
