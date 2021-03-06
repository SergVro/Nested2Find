﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using EPiServer.Find.Api.Querying;
using EPiServer.Find.Helpers;

namespace Nested2Find.Api.Querying.Filters
{
    [JsonConverter(typeof(NestedFilterConverter))]
    public class NestedFilter : Filter
    {
        public NestedFilter(string path, Filter filter)
        {
            path.ValidateNotNullArgument("path");
            filter.ValidateNotNullArgument("filter");

            Path = path;
            Filter = filter;
        }

        public string Path { get; set; }

        public Filter Filter { get; set; }
    }
}
