using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GofPatterns.StructuralPatterns.Bridge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICommentProvider sqlCommentProvdier = new CommentProviderSql();
            ICommentProvider webCommentProvdier = new CommentProviderWeb();

            CommentPosterBridge funnyCommentPosterSql = new FunnyCommentPoster(sqlCommentProvdier);
            CommentPosterBridge politeCommentPosterWeb = new PoliteCommentPoster(webCommentProvdier);

            //So we have 4 possible combinations now here, right?

            System.Diagnostics.Trace
                .WriteLine(funnyCommentPosterSql.GetComment());

            System.Diagnostics.Trace
                .WriteLine(politeCommentPosterWeb.GetComment());
        }
    }
}
