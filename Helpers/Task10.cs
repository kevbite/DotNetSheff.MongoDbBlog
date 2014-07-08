[HttpPost]
public ActionResult AddPostTag(ObjectId id /* blog post Id */, string tag)
{
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Id, id);
    var update = Update<Post>.AddToSet(x => x.Tags, tag);

    postCollection.Update(query, update);

    var post = postCollection.FindOneById(id);

    return RedirectToPost(post);  
}