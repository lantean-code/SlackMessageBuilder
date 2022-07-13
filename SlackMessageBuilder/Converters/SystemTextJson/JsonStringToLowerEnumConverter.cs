#if SYSTEMTEXTJSON || DEBUG
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SlackMessageBuilder.Converters.SystemTextJson
{
    internal class JsonStringToLowerEnumConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsEnum;
        }

        private static readonly Type _converterType = typeof(Converter<>);

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type type = _converterType.MakeGenericType(typeToConvert);
            var converter = (JsonConverter?)Activator.CreateInstance(type);

            return converter;
        }

        private sealed class Converter<T> : JsonConverter<T> where T : struct
        {
            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var value = reader.GetString();

                Enum.TryParse<T>(value, true, out var result);

                return result;
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString().ToLowerInvariant());
            }
        }
    }
}
#endif