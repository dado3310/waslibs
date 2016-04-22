﻿using System;
using System.Net;

namespace AppStudio.DataProviders.Core
{
    internal class HttpRequestSettings
    {
        public HttpRequestSettings()
        {
            this.Headers = new WebHeaderCollection();
        }

        public Uri RequestedUri { get; set; }

        public string UserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0)";

        public WebHeaderCollection Headers { get; private set; }
    }
}
