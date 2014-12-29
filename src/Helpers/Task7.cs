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

    var postCollection = GetPostsCollection();

    postCollection.Insert(post);

    return RedirectToPost(post);
}