using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetSheff.MongoDbBlog.Models;

namespace DotNetSheff.MongoDbBlog.ViewModels
{
    public class PostsViewModel
    {
        public PostsViewModel(IEnumerable<Post> posts)
        {
            Posts = posts;
        }

        public IEnumerable<Post> Posts { get; private set; }
    }
}