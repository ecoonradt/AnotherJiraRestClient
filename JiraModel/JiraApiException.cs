using System;
using System.Collections.Generic;

namespace AnotherJiraRestClient.JiraModel
{   
    [Serializable]
    public class JiraApiException : Exception
    {
        public JiraApiException() : base() { }
        public JiraApiException(string message) : base(message) { }
        public JiraApiException(string message, Exception inner) : base(message, inner) { }

        public int ResponseStatusCode { get; internal set; }
        public string RawResponseContent { get; internal set; }
        public IEnumerable<string> ErrorMessages { get; internal set; }
    }
}
