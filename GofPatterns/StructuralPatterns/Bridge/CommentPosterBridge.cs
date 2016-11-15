using System;

namespace GofPatterns.StructuralPatterns.Bridge
{
    public class CommentPoster
    {
        public ICommentProvider _commentProvider;

        public CommentPoster(ICommentProvider commentProvider)
        {
            _commentProvider = commentProvider;
        }

        public virtual string GetComment()
        {
            return _commentProvider.GetCommentText();
        }
    }

    public class FunnyCommentPoster : CommentPoster
    {
        public FunnyCommentPoster(ICommentProvider commentProvider) : base(commentProvider)
        {
        }

        public override string GetComment()
        {
            return _commentProvider.GetCommentText() + "))))0000000)))))";
        }
    }

    public class PoliteCommentPoster : CommentPoster
    {
        private string phraseFromPoliteService = "\n p.s. Sorry about that.";

        public PoliteCommentPoster(ICommentProvider commentProvider) : base(commentProvider)
        {
        }

        public override string GetComment()
        {
            return _commentProvider.GetCommentText() + phraseFromPoliteService;
        }
    }
}
