namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of DeleteBranchProtectionRule
    /// </summary>
    public class DeleteBranchProtectionRulePayload : QueryableValue<DeleteBranchProtectionRulePayload>
    {
        public DeleteBranchProtectionRulePayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        internal static DeleteBranchProtectionRulePayload Create(Expression expression)
        {
            return new DeleteBranchProtectionRulePayload(expression);
        }
    }
}