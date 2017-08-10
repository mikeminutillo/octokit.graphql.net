namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddComment
    /// </summary>
    public class AddCommentPayload : QueryEntity
    {
        public AddCommentPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The edge from the subject's comment connection.
        /// </summary>
        public IssueCommentEdge CommentEdge => this.CreateProperty(x => x.CommentEdge, Octokit.GraphQL.IssueCommentEdge.Create);

        /// <summary>
        /// The subject
        /// </summary>
        public INode Subject => this.CreateProperty(x => x.Subject, Octokit.GraphQL.Internal.StubINode.Create);

        /// <summary>
        /// The edge from the subject's timeline connection.
        /// </summary>
        public IssueTimelineItemEdge TimelineEdge => this.CreateProperty(x => x.TimelineEdge, Octokit.GraphQL.IssueTimelineItemEdge.Create);

        internal static AddCommentPayload Create(IQueryProvider provider, Expression expression)
        {
            return new AddCommentPayload(provider, expression);
        }
    }
}