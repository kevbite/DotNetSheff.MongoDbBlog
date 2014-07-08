using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DotNetSheff.MongoDbBlog.Models;
using DotNetSheff.MongoDbBlog.ViewModels;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace DotNetSheff.MongoDbBlog.Controllers
{
    public class BlogController : Controller
    {
        private static MongoCollection<Post> GetPostsCollection()
        {
            // Task 3
            // Create connection to local mongodb instance and return the Post collection
            throw new NotImplementedException();
        }
        
         // Get /
        [HttpGet]
        public ViewResult Posts()
        {
            var postsCollection = GetPostsCollection();

            var sortBy = SortBy<Post>.Descending(x => x.Id);

            List<Post> posts = postsCollection.FindAll()
                .SetSortOrder(sortBy)
                .SetLimit(5)
                .ToList();

            return View(new PostsViewModel(posts));
        }
        
        // GET /{year}/{month}/{slug}
        [HttpGet]
        public ActionResult Post(int year, int month, string slug)
        {
            // Task 4
            // Fetch the post by its slug.
            Post post = null;
            throw new NotImplementedException();


            if (post == null)
            {
                return HttpNotFound();
            }

            var creationTime = post.Id.CreationTime;

            if (creationTime.Year != year || creationTime.Month != month)
            {
                return RedirectToPost(post);
            }

            return View(post);
        }

       
        // GET /tag/{tag}
        [HttpGet]
        public ActionResult PostsByTag(string tag)
        {
            // Task 5
            // Fetch all posts by a given tag and order by id desc (object id includes a datetime stamp).
            List<Post> post = null;
            throw new NotImplementedException();           
            

            return View(new PostsByTagViewModel(tag, post));
        }

        // GET /Blog/EditPost/{id}
        [HttpGet]
        public ActionResult EditPost(ObjectId id)
        {
            // Task 6
            // Fetch post back by id.
            Post post = null;
            throw new NotImplementedException();
            
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

        // GET /Blog/EditPost/{id}
        [HttpPost]
        public ActionResult EditPost(ObjectId id, string title, string slug, string body)
        {
            // Task 6
            // Update the post with the new title, slug and body. 
            throw new NotImplementedException();
            
            var postCollection = GetPostsCollection(); 
            var post = postCollection.FindOneById(id);

            return RedirectToPost(post);
        }

        // GET /Blog/CreatePost
        [HttpGet]
        public ActionResult CreatePost()
        {
            return View();
        }
        
        // POST /Blog/CreatePost
        [HttpPost]
        public ActionResult CreatePost(Post post) 
        {
            post.Id = ObjectId.GenerateNewId(); 

            // Task 7
            // Insert the new post in to the post collection.
            throw new NotImplementedException();
            
            return RedirectToPost(post);
        }

        // GET /Blog/DeletePost/{id}
        [HttpGet]
        public ActionResult DeletePost(ObjectId id /* blog post Id */)
        {
            // Task 8
            // Remove post from collection
            throw new NotImplementedException();

            return RedirectToAction("Posts");
        }

        // POST /Blog/AddBlogComment/{id}
        [HttpPost]
        public ActionResult AddBlogComment(ObjectId id /* blog post Id */, Comment comment)
        {
            comment.Id = ObjectId.GenerateNewId();

            // Task 9
            // Add comment to the post.comments array
            throw new NotImplementedException();

            var postCollection = GetPostsCollection();
            var post = postCollection.FindOneById(id);

            return RedirectToPost(post);
        }

        // POST /Blog/AddPostTag/{id}
        [HttpPost]
        public ActionResult AddPostTag(ObjectId id /* blog post Id */, string tag)
        {
            // Task 10
            // Add a tag to a post
            throw new NotImplementedException();

            var postCollection = GetPostsCollection();
            var post = postCollection.FindOneById(id);

            return RedirectToPost(post);  
        }

        // GET /Blog/RemovePostTag/{id}
        [HttpGet]
        public ActionResult RemovePostTag(ObjectId id, string tag)
        {
            // Task 11
            // Remove a tag from a post
            throw new NotImplementedException();

            var postCollection = GetPostsCollection();
            var post = postCollection.FindOneById(id);

            return RedirectToPost(post);
        }

        private ActionResult RedirectToPost(Post post)
        {
            var creationTime = post.Id.CreationTime;

            return RedirectToAction("Post", new { slug = post.Slug, year = creationTime.Year, month = creationTime.Month });
        }
    }
}