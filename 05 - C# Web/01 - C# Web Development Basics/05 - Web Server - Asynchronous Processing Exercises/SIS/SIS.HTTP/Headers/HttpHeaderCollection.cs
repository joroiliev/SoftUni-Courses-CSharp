namespace SIS.HTTP.Headers
{
    using SIS.HTTP.Common;
    using System.Collections.Generic;

    public class HttpHeaderCollection :IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            this.headers.Add(header.Key, header);
        }

        public bool ContainsHeader(string key)
        {
            if (this.headers.ContainsKey(key))
            {
                return true;
            }

            return false;
        }

        public HttpHeader GetHeader(string key)
        {
            if (this.ContainsHeader(key) == true)
            {
                return this.headers[key];
            }

            return null;
        }

        public override string ToString()
        {
            return string.Join(GlobalConstraints.HttpNewLine, this.headers.Values);
        }
    }
}
