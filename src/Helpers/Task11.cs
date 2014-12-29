[HttpGet]
public ActionResult RemovePostTag(ObjectId id, string tag)
{
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Id, id);
    var update = Update<Post>.Pull(x => x.Tags, tag);

    postCollection.Update(query, update);

    var post = postCollection.FindOneById(id);

    return RedirectToPost(post);
}