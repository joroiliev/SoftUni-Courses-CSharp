﻿namespace SIS.HTTP.Cookies
{
    using System.Collections.Generic;

    public class HttpCookieCollection : IHttpCookieCollection
    {
        private const string HttpCookieSeparator = "; ";

        private readonly Dictionary<string, HttpCookie> cookies;

        public HttpCookieCollection()
        {
            this.cookies = new Dictionary<string, HttpCookie>();
        }

        public void Add(HttpCookie cookie)
        {
            this.cookies.Add(cookie.Key, cookie);
        }

        public bool ContainsCookie(string key)
        {
            return this.cookies.ContainsKey(key);
        }

        public HttpCookie GetCookie(string key)
        {
            return this.cookies.GetValueOrDefault(key, null);
        }

        public bool HasCookies()
        {
            return this.cookies.Count > 0;
        }

        public override string ToString()
        {
            return string.Join(HttpCookieSeparator, this.cookies.Values);
        }
    }
}
