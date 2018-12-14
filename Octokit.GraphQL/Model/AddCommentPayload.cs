namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddComment
    /// </summary>
    public class AddCommentPayload : QueryableValue<AddCommentPayload>
    {
        internal AddCommentPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The edge from the subject's comment connection.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `commentEdge` will change from `IssueCommentEdge!` to `IssueCommentEdge`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public IssueCommentEdge CommentEdge => this.CreateProperty(x => x.CommentEdge, Octokit.GraphQL.Model.IssueCommentEdge.Create);

        /// <summary>
        /// The subject
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `subject` will change from `Node!` to `Node`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public INode Subject => this.CreateProperty(x => x.Subject, Octokit.GraphQL.Model.Internal.StubINode.Create);

        /// <summary>
        /// The edge from the subject's timeline connection.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `timelineEdge` will change from `IssueTimelineItemEdge!` to `IssueTimelineItemEdge`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public IssueTimelineItemEdge TimelineEdge => this.CreateProperty(x => x.TimelineEdge, Octokit.GraphQL.Model.IssueTimelineItemEdge.Create);

        internal static AddCommentPayload Create(Expression expression)
        {
            return new AddCommentPayload(expression);
        }
    }
}