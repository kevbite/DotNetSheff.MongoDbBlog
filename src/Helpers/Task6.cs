[HttpGet]
public ActionResult EditPost(ObjectId id)
{
    var postCollection = GetPostsCollection();

    Post post = postCollection.FindOneById(id);

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
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Id, id);

    var update = Update<Post>.Set(x => x.Title, title)
        .Set(x => x.Slug, slug)
        .Set(x => x.Body, body);

    postCollection.Update(query, update);

    var post = postCollection.FindOneById(id);

    return RedirectToPost(post);
}