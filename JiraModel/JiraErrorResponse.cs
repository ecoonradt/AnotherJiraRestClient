using System.Collections.Generic;

namespace AnotherJiraRestClient.JiraModel
{
    internal class JiraErrorResponse
    {
        public IEnumerable<string> errorMessages { get; set; }
    }
}