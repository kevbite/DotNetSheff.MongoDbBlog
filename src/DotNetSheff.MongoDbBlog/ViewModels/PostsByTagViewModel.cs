using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetSheff.MongoDbBlog.Models;

namespace DotNetSheff.MongoDbBlog.ViewModels
{
    public class PostsByTagViewModel
    {
        public PostsByTagViewModel(string tag, IEnumerable<Post> posts)
        {
            Tag = tag;
            Posts = posts;
        }

        public string Tag { get; private set; }

        public IEnumerable<Post> Posts { get; private set; }
    }
}