namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AcceptTopicSuggestion
    /// </summary>
    public class AcceptTopicSuggestionInput
    {
        /// <summary>
        /// The Node ID of the repository.
        /// **Upcoming Change on 2024-04-01 UTC**
        /// **Description:** `repositoryId` will be removed.
        /// **Reason:** Suggested topics are no longer supported
        /// </summary>
        public ID? RepositoryId { get; set; }

        /// <summary>
        /// The name of the suggested topic.
        /// **Upcoming Change on 2024-04-01 UTC**
        /// **Description:** `name` will be removed.
        /// **Reason:** Suggested topics are no longer supported
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}