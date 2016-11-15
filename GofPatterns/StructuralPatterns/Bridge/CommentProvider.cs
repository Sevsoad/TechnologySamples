using System;

namespace GofPatterns.StructuralPatterns.Bridge
{
    public interface ICommentProvider
    {
        string GetCommentText();
    }

    public class CommentProviderSql : ICommentProvider
    {
        public string GetCommentText()
        {
            return "Comment from DB. ";
        }
    }

    public class CommentProviderWeb : ICommentProvider
    {
        public string GetCommentText()
        {
            return "Comment from web. ";
        }
    }
}
