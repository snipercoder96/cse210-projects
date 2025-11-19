/* Keep track of the name of the person who made the comment and the text of the comment.
*/

class Comments
{
    public string _names;
    public string _comment;

    public Comments(string names, string comment)
    {
        _names = names;
        _comment = comment;
    }

    public string DisplayNameComment()
    {
        return $"{_names} - {_comment}";
    }
}