MongoDB Coding Session [![Build status](https://ci.appveyor.com/api/projects/status/sd967sfmndo2y24x/branch/master?svg=true)](https://ci.appveyor.com/project/kevbite/dotnetsheff-mongodbblog/branch/master)
====================

MongoDB Coding Session by @kev_bite

C# Helper objects
OrderBy, OrderBy<>, Query, Query<>, Update, Update<>

http://docs.mongodb.org/ecosystem/tutorial/use-csharp-driver/#csharp-driver-tutorial

Don't use Linq driver support.

Task 1: Setup MongoDb
- Extract mongodb-win32-x86_64-2008plus-2.6.3.zip to c:\mongodb
- Create C:\data\db directory
- Run c:\mongodb\bin\mongod.exe
- Connect to the mongod instance using mongo.exe (run c:\mongodb\bin\mongo.exe)

Task 2: Import Data
- Run the following command from the command prompt
c:\mongodb\bin\mongoimport.exe -d dotnetsheff -c posts < posts.json

- The following should be displayed "imported 8 objects"


Task 3: Setup the c# connection to mongodb
- Fill the the blank on the GetPostsCollection method
- Hit the following url "/"

Task 4: Add a query to view a post by its slug
- Hit the following url "/2014/7/talks-required-at-dotnetsheff"

Task 5: Add a query that fetches all posts with a given tag and orders them by Id desc
- Hit the following url "/tag/mongodb"

Task 6: Allow editing of posts
- Write both fetch and update queries within EditPost()
- Hit the following url "/Blog/EditPost/53bbb430a8c16d2a2c208fcb"
- Edit post

Task 7: Allow creation of new posts.
- Write the query to insert the new post within CreatePost()
- Hit the following url "/Blog/CreatePost"
- Create a new blog post.

Task 8: Allow deletion of a blog post
- write the query to remove the post of the collection
- hit the following url "/Blog/DeletePost/53bbb430a8c16d2a2c208fcb" deletes a post

Task 9: Allow adding of post comments
- Write the query to add a comment document to the post object
- Post a comment on a blog post

Task 10: Allow adding of tags to a post
- Write the query to add a tag to the post object
- add a tag to post

Task 11: Allow adding of tags to a post
- Write the query to remove a tag to the post object.
- remove a tag to post

Task 12: Add indexes on the post collection to make querying more efficient
- Add index on slug
- Add index on tags collection


