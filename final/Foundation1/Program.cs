using System;

class Program
{
    static void Main(string[] args)
    {

        Comment comment1 = new Comment("UserAccount123", "This is a comment.");
        Comment comment2 = new Comment("Real_Person", "This is not a comment.");
        Comment comment3 = new Comment("BasementDweller9", "The FitnessGram Pacer test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter Pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal *boop*.");
        List<Comment> Vid1Comments = [comment1, comment2, comment3];
        Comment comment4 = new Comment("Personusingcomputer", "I am making a comment.");
        Comment comment5 = new Comment("CommentMaker5", "I'm just trying to fill the space.");
        Comment comment6 = new Comment("UserAccount123", "This video needs one more comment.");
        List<Comment> Vid2Comments = [comment4, comment5, comment6];
        Comment comment7 = new Comment("NotRealPerson", "I am writing text right now.");
        Comment comment8 = new Comment("UserAccount456", "I'm hungry");
        Comment comment9 = new Comment("SomeOtherName", "i cannt spel vry gud.");
        List<Comment> Vid3Comments = [comment7, comment8, comment9];

        Video Vid1 = new Video("Crazy thing happened! (Not Clickbait)", "UserAccount123", 67, Vid1Comments);
        Video Vid2 = new Video("Crazier thing happened! (Clickbait)", "UserAccount456", 100, Vid2Comments);
        Video Vid3 = new Video("How to make a C# program", "BasementDweller9", 600, Vid3Comments);
        List<Video> VideoList = [Vid1, Vid2, Vid3];

        foreach (Video vid in VideoList)
        {
            Console.WriteLine($"Title: {vid.GetTitle()}\nAuthor: {vid.GetAuthor()}\nLength: {vid.GetLength()}\nComment count: {vid.GetCount()}");
            foreach (Comment vidComment in vid.GetComments())
            {
                Console.WriteLine($"    Author {vidComment.GetAuthor()}\n    Content: {vidComment.GetContent()}");
            }
        }
    }
}