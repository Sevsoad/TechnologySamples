using System;

namespace GofPatterns.StructuralPatterns.Bridge
{
    public abstract class CommentPosterBridge
    {
        public ICommentProvider _commentProvider;              

        public abstract string GetComment();
    }

    public class FunnyCommentPoster : CommentPosterBridge
    {
        public FunnyCommentPoster(ICommentProvider commentProvider)
        {
            _commentProvider = commentProvider;
        }

        public override string GetComment()
        {
            return _commentProvider.GetCommentText() + "))))0000000)))))";
        }
    }

    public class PoliteCommentPoster : CommentPosterBridge
    {
        private string phraseFromPoliteService = "\n p.s. Sorry about that.";

        public PoliteCommentPoster(ICommentProvider commentProvider)
        {
            _commentProvider = commentProvider;
        }

        public override string GetComment()
        {
            return _commentProvider.GetCommentText() + phraseFromPoliteService;
        }
    }
}
