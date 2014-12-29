[HttpGet]
public ActionResult DeletePost(ObjectId id /* blog post Id */)
{
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Id, id);

    postCollection.Remove(query);

    return RedirectToAction("Posts");
}