#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using SlackMessageBuilder.Converters.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SlackMessageBuilder
{
    public static class SlackJsonSerializerSettings
    {
        public static JsonSerializerSettings Settings { get; } = new JsonSerializerSettings();

        static SlackJsonSerializerSettings()
        {
            Settings.NullValueHandling = NullValueHandling.Ignore;
            Settings.Converters.Add(new DateTimeDateJsonConverter());
            Settings.Converters.Add(new JsonStringToLowerEnumConverter());
            Settings.Converters.Add(new RuntimeTypeJsonConverter());
            Settings.Converters.Add(new TimeSpanTimeJsonConverter());
        }
    }
}
#endif