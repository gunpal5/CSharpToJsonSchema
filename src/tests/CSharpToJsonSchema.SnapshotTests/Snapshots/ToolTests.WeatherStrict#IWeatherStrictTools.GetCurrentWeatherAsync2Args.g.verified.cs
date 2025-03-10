﻿//HintName: IWeatherStrictTools.GetCurrentWeatherAsync2Args.g.cs
// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace CSharpToJsonSchema.IntegrationTests
{
    public partial class WeatherStrictToolsExtensionsJsonSerializerContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args>? _GetCurrentWeatherAsync2Args;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args> GetCurrentWeatherAsync2Args
        #nullable enable annotations
        {
            get => _GetCurrentWeatherAsync2Args ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args>)Options.GetTypeInfo(typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args> Create_GetCurrentWeatherAsync2Args(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args>
                {
                    ObjectCreator = () => new global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => GetCurrentWeatherAsync2ArgsPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args).GetConstructor(InstanceMemberBindingFlags, binder: null, global::System.Array.Empty<global::System.Type>(), modifiers: null),
                    SerializeHandler = GetCurrentWeatherAsync2ArgsSerializeHandler,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] GetCurrentWeatherAsync2ArgsPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[2];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)obj).Location,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)obj).Location = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Location",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args).GetProperty("Location", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::CSharpToJsonSchema.IntegrationTests.Unit2>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)obj).Unit,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)obj).Unit = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Unit",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args).GetProperty("Unit", InstanceMemberBindingFlags, null, typeof(global::CSharpToJsonSchema.IntegrationTests.Unit2), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::CSharpToJsonSchema.IntegrationTests.Unit2>(options, info1);

            return properties;
        }

        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void GetCurrentWeatherAsync2ArgsSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args? value)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartObject();

            string __value_Location = ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)value).Location;
            if (__value_Location is not null)
            {
                writer.WriteString(PropName_location, __value_Location);
            }
            writer.WritePropertyName(PropName_unit);
            global::System.Text.Json.JsonSerializer.Serialize(writer, ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsync2Args)value).Unit, Unit2);

            writer.WriteEndObject();
        }
    }
}
