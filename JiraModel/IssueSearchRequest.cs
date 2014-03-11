using System.Collections.Generic;

namespace AnotherJiraRestClient.JiraModel
{
    internal class IssueSearchRequest
    {
        public string jql { get; set; }
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public IEnumerable<string> fields { get; set; }
    }
}