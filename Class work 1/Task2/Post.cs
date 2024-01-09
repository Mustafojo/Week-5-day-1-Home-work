using System.Runtime.CompilerServices;

public class Post
{
    public string Text;
    public int Likes;
    public List<string> Comments;
    List<string> posts = new List<string>();
    public void SetPost(string text)
    {
        posts.Add(text);
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }
    public string GetInfo()
    {
        return $"Text = {Text} \nLikes = {Likes} \nComments: \n{posts}";
    }
    public void Cout()
    {
        foreach (var item in Comments)
        {
            System.Console.WriteLine(item);
        }
    }

}