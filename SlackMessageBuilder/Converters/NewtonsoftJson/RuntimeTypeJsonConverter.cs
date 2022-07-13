#if NEWTONSOFTJSON || DEBUG
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SlackMessageBuilder.Converters.NewtonsoftJson
{
    internal class RuntimeTypeJsonConverter : JsonConverter
    {
        private static readonly HashSet<Type> _typesToConvert = new HashSet<Type>
        {
            typeof(IActionsElement),
            typeof(IBlockElement),
            typeof(IContextElement),
            typeof(IInputElement),
            typeof(ISectionElement),
            typeof(TextObject),
            typeof(SlackMessageBase),
            typeof(AttachmentBase)
        };

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            var type = value?.GetType();
            if (type is null)
            {
                return;
            }
            serializer.Serialize(writer, value, type);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return _typesToConvert.Contains(objectType);
        }
    }
}
#endif