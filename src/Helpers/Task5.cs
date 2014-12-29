public ActionResult PostsByTag(string tag)
{
    var postCollection = GetPostsCollection();

    var query = Query<Post>.EQ(x => x.Tags, tag);
    var sortBy = SortBy<Post>.Descending(x => x.Id);

    List<Post> post = postCollection.Find(query)
        .SetSortOrder(sortBy)
        .SetLimit(5)
        .ToList();

    return View(new PostsByTagViewModel(tag, post));
}