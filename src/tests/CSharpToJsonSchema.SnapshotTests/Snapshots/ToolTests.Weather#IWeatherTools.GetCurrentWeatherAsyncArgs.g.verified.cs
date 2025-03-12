﻿//HintName: IWeatherTools.GetCurrentWeatherAsyncArgs.g.cs
// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace CSharpToJsonSchema.IntegrationTests
{
    public partial class WeatherToolsExtensionsJsonSerializerContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs>? _GetCurrentWeatherAsyncArgs;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs> GetCurrentWeatherAsyncArgs
        #nullable enable annotations
        {
            get => _GetCurrentWeatherAsyncArgs ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs>)Options.GetTypeInfo(typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs> Create_GetCurrentWeatherAsyncArgs(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs>
                {
                    ObjectCreator = () => new global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => GetCurrentWeatherAsyncArgsPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs).GetConstructor(InstanceMemberBindingFlags, binder: null, global::System.Array.Empty<global::System.Type>(), modifiers: null),
                    SerializeHandler = GetCurrentWeatherAsyncArgsSerializeHandler,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] GetCurrentWeatherAsyncArgsPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[2];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)obj).Location,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)obj).Location = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Location",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs).GetProperty("Location", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::CSharpToJsonSchema.IntegrationTests.Unit>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)obj).Unit,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)obj).Unit = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Unit",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs).GetProperty("Unit", InstanceMemberBindingFlags, null, typeof(global::CSharpToJsonSchema.IntegrationTests.Unit), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::CSharpToJsonSchema.IntegrationTests.Unit>(options, info1);

            return properties;
        }

        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void GetCurrentWeatherAsyncArgsSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs? value)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartObject();

            string __value_Location = ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)value).Location;
            if (__value_Location is not null)
            {
                writer.WriteString(PropName_location, __value_Location);
            }
            writer.WritePropertyName(PropName_unit);
            global::System.Text.Json.JsonSerializer.Serialize(writer, ((global::CSharpToJsonSchema.IntegrationTests.GetCurrentWeatherAsyncArgs)value).Unit, Unit);

            writer.WriteEndObject();
        }
    }
}
