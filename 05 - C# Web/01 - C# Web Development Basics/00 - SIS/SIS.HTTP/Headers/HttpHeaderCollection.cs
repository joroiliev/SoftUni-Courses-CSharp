﻿namespace SIS.HTTP.Headers
{
    using SIS.HTTP.Common;
    using System.Collections.Generic;

    public class HttpHeaderCollection : IHttpHeaderCollection
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
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            return this.headers.GetValueOrDefault(key, null);
        }

        public override string ToString()
        {
            return string.Join(GlobalConstraints.HttpNewLine, this.headers.Values);
        }
    }
}