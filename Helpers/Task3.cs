private static MongoCollection<Post> GetPostsCollection()
{
    var mongoClient = new MongoClient();
            
    var server = mongoClient.GetServer();
            
    var database = server.GetDatabase("dotnetsheff");
            
    var collection = database.GetCollection<Post>("posts");
            
    return collection;
}