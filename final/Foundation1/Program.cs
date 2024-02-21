class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.Comments.Add(new Comment("Commenter A", "Nice video!"));
        video1.Comments.Add(new Comment("Commenter B", "Great content!"));
        video1.Comments.Add(new Comment("Commenter C", "Interesting topic!"));
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.Comments.Add(new Comment("Commenter X", "I learned a lot from this video."));
        video2.Comments.Add(new Comment("Commenter Y", "Very informative!"));
        videos.Add(video2);

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}