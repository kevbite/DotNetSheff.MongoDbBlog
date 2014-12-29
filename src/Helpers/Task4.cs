public ActionResult Post(int year, int month, string slug) 
{
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Slug, slug);

    Post post = postCollection.FindOne(query);

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