using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace DotNetSheff.MongoDbBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new List<string>();
            this.Comments = new List<Comment>();
        }

        public ObjectId Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public List<string> Tags { get; set; }

        public List<Comment> Comments { get; set; }
    }
}