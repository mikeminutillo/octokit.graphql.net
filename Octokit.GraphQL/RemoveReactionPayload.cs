namespace Octokit.GraphQL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of RemoveReaction
    /// </summary>
    public class RemoveReactionPayload : QueryEntity
    {
        public RemoveReactionPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The reaction object.
        /// </summary>
        public Reaction Reaction => this.CreateProperty(x => x.Reaction, Octokit.GraphQL.Reaction.Create);

        /// <summary>
        /// The reactable subject.
        /// </summary>
        public IReactable Subject => this.CreateProperty(x => x.Subject, Octokit.GraphQL.Internal.StubIReactable.Create);

        internal static RemoveReactionPayload Create(IQueryProvider provider, Expression expression)
        {
            return new RemoveReactionPayload(provider, expression);
        }
    }
}