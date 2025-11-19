/* Class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. 
Each video also has responsibility to store a list of comments, and should have a method to return the number of comments.

*/

class Videos
{
    public string _title;
    public string _author;
    public int _length; // Must be in seconds
    public List<Comments> _comments = new List<Comments>();

    public int GetCommentsCount()
    {
        int lengthOfComment = _comments.Count;
        return lengthOfComment;
    }

    public void DisplayComment()
    {
        foreach (Comments comment in _comments)
        {
            Console.WriteLine(comment.DisplayNameComment());
        }
    }


}