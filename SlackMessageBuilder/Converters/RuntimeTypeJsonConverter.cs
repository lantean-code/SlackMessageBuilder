using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder.Converters
{
    internal class RuntimeTypeJsonConverter : JsonConverterFactory
    {
        private static readonly HashSet<Type> _typesToConvert = new HashSet<Type>
        {
            typeof(IActionsElement),
            typeof(IBlockElement),
            typeof(IContextElement),
            typeof(IInputElement),
            typeof(ISectionElement),
            typeof(TextObject),
            typeof(SlackMessage),
            typeof(Attachment)
        };

        public override bool CanConvert(Type typeToConvert)
        {
            return _typesToConvert.Contains(typeToConvert);
        }

        private static readonly Type _runtimeConverterType = typeof(RuntimeTypeConverter<>);

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var type = _runtimeConverterType.MakeGenericType(typeToConvert);
            return (JsonConverter?)Activator.CreateInstance(type);
        }

        private sealed class RuntimeTypeConverter<T> : JsonConverter<T>
        {
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                var inputType = value?.GetType() ?? typeof(T);
                JsonSerializer.Serialize(writer, value, inputType, options);
            }
        }
    }
}