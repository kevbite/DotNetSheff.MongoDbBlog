[HttpPost]
public ActionResult AddBlogComment(ObjectId id /* blog post Id */, Comment comment)
{
    comment.Id = ObjectId.GenerateNewId();
                
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Id, id);
    var update = Update<Post>.Push(x => x.Comments, comment);

    postCollection.Update(query, update);

    var post = postCollection.FindOneById(id);

    return RedirectToPost(post);
}