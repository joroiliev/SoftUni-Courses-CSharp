namespace SIS.HTTP.Requests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SIS.HTTP.Common;
    using SIS.HTTP.Enums;
    using SIS.HTTP.Exceptions;
    using SIS.HTTP.Extensions;
    using SIS.HTTP.Headers;

    public class HttpRequest : IHttpRequest
    {
        private const char HttpRequestUrlQuerySeparator = '?';

        private const char HttpRequestUrlFragmentSeparator = '#';

        private const string HttpRequestHeaderNameValueSeparator = ": ";

        private const string HttpRequestCookiesSeparator = "; ";

        private const char HttpRequestCookieNameValueSeparator = '=';

        private const char HttpRequestParameterSeparator = '&';

        private const char HttpRequestParameterNameValueSeparator = '=';

        public HttpRequest(string requestString)
        {
            this.FormData = new Dictionary<string, object>();
            this.QueryData = new Dictionary<string, object>();
            this.Headers = new HttpHeaderCollection();

            this.ParseRequest(requestString);
        }

        public string Path  { get; private set; }

        public string Url { get; private set; }

        public Dictionary<string, object> FormData { get; }

        public Dictionary<string, object> QueryData { get; }

        public IHttpHeaderCollection Headers { get; }

        public HttpRequestMethod RequestMethod { get; private set; }

        private void ParseRequest(string requestString)
        {
            string[] splitRequestContent = requestString
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            string[] requestLine = splitRequestContent[0].Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!this.IsValidRequestLine(requestLine))
            {
                throw new BadRequestException();
            }

            this.ParseRequestMethod(requestLine);
            this.ParseRequestUrl(requestLine);
            this.ParseRequestPath();

            this.ParseHeaders(splitRequestContent.Skip(1).ToArray());
            this.ParseRequestParameters(splitRequestContent[splitRequestContent.Length - 1]);
        }

        private void ParseQueryParameters()
        {
            if (!this.Url.Contains('?'))
            {
                return;
            }

            string queryString = this.Url
                        .Split(new[] { '?', '#' }, StringSplitOptions.None)[1];

            if (string.IsNullOrWhiteSpace(queryString))
            {
                return;
            }

            string[] queryParameters = queryString.Split('&');

            if (!this.IsValidRequestQueryString(queryString, queryParameters))
            {
                throw new BadRequestException();
            }

            foreach (var queryParameter in queryParameters)
            {
                string[] parameterArguments = queryParameter
                    .Split('=', StringSplitOptions.RemoveEmptyEntries);

                this.QueryData.Add(parameterArguments[0], parameterArguments[1]);
            }

        }

        private void ParseFormDataParameters(string formData)
        {
            if (string.IsNullOrEmpty(formData))
            {
                return;
            }

            string[] formDataArgs = formData.Split(HttpRequestParameterSeparator);

            foreach (var param in formDataArgs)
            {
                string[] paramArgs = param.Split(HttpRequestParameterNameValueSeparator, StringSplitOptions.RemoveEmptyEntries);

                this.FormData.Add(paramArgs[0], paramArgs[1]);
            }
        }

        private void ParseRequestParameters(string formData)
        {
            this.ParseQueryParameters();
            this.ParseFormDataParameters(formData);
        }

        private void ParseHeaders(string[] requestContent)
        {
            for (int i = 0; i < requestContent.Length; i++)
            {
                if (string.IsNullOrEmpty(requestContent[i]))
                {
                    break;
                }

                string[] headerArgs = requestContent[1].Split(HttpRequestHeaderNameValueSeparator);

                string key = headerArgs[0];
                string value = headerArgs[1];

                HttpHeader header = new HttpHeader(key, value);
                this.Headers.Add(header);
            }

            if (!this.Headers.ContainsHeader(GlobalConstraints.HostHeaderKey))
            {
                throw new BadRequestException();
            }
        }

        private void ParseRequestPath()
        {
            this.Path =
                this.Url.Split(new[] { HttpRequestUrlQuerySeparator, HttpRequestUrlFragmentSeparator }, StringSplitOptions.RemoveEmptyEntries)[0];
        }

        private void ParseRequestUrl(string[] requestLine)
        {
            this.Url = requestLine[1];
        }

        private bool IsValidRequestLine(string[] requestLine)
        {
            if (requestLine.Length != 3)
            {
                return false;
            }

            if (requestLine[2] != GlobalConstraints.HttpOneProtocolFragment)
            {
                return false;
            }

            return true;
        }

        private bool IsValidRequestQueryString(string queryString, string[] queryParameters)
        {
            if (string.IsNullOrEmpty(queryString))
            {
                return false;
            }

            if (queryParameters.Length <= 0)
            {
                return false;
            }

            return true;
        }

        private void ParseRequestMethod(string[] requestLine)
        {
            bool parseMethodResult = Enum.TryParse<HttpRequestMethod>(requestLine[0].Capitalize(), out HttpRequestMethod parsedMethod);

            if (!parseMethodResult) throw new BadRequestException();

            this.RequestMethod = parsedMethod;
        }
    }
}