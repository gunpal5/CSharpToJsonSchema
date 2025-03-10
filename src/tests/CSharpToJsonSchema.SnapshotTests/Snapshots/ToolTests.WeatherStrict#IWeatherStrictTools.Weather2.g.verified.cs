﻿//HintName: IWeatherStrictTools.Weather2.g.cs
// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace CSharpToJsonSchema.IntegrationTests
{
    public partial class WeatherStrictToolsExtensionsJsonSerializerContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2>? _Weather2;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2> Weather2
        #nullable enable annotations
        {
            get => _Weather2 ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2>)Options.GetTypeInfo(typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2> Create_Weather2(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::CSharpToJsonSchema.IntegrationTests.Weather2>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::CSharpToJsonSchema.IntegrationTests.Weather2>
                {
                    ObjectCreator = () => new global::CSharpToJsonSchema.IntegrationTests.Weather2(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => Weather2PropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2).GetConstructor(InstanceMemberBindingFlags, binder: null, global::System.Array.Empty<global::System.Type>(), modifiers: null),
                    SerializeHandler = Weather2SerializeHandler,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::CSharpToJsonSchema.IntegrationTests.Weather2>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] Weather2PropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[4];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Location,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Location = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Location",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2).GetProperty("Location", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<double>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Temperature,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Temperature = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Temperature",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2).GetProperty("Temperature", InstanceMemberBindingFlags, null, typeof(double), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<double>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::CSharpToJsonSchema.IntegrationTests.Unit2>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Unit,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Unit = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Unit",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2).GetProperty("Unit", InstanceMemberBindingFlags, null, typeof(global::CSharpToJsonSchema.IntegrationTests.Unit2), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::CSharpToJsonSchema.IntegrationTests.Unit2>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2),
                Converter = null,
                Getter = static obj => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Description,
                Setter = static (obj, value) => ((global::CSharpToJsonSchema.IntegrationTests.Weather2)obj).Description = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Description",
                JsonPropertyName = null,
                AttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.Weather2).GetProperty("Description", InstanceMemberBindingFlags, null, typeof(string), global::System.Array.Empty<global::System.Type>(), null),
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info3);

            return properties;
        }

        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void Weather2SerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::CSharpToJsonSchema.IntegrationTests.Weather2? value)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartObject();

            string __value_Location = ((global::CSharpToJsonSchema.IntegrationTests.Weather2)value).Location;
            if (__value_Location is not null)
            {
                writer.WriteString(PropName_location, __value_Location);
            }
            writer.WriteNumber(PropName_temperature, ((global::CSharpToJsonSchema.IntegrationTests.Weather2)value).Temperature);
            writer.WritePropertyName(PropName_unit);
            global::System.Text.Json.JsonSerializer.Serialize(writer, ((global::CSharpToJsonSchema.IntegrationTests.Weather2)value).Unit, Unit2);
            string __value_Description = ((global::CSharpToJsonSchema.IntegrationTests.Weather2)value).Description;
            if (__value_Description is not null)
            {
                writer.WriteString(PropName_description, __value_Description);
            }

            writer.WriteEndObject();
        }
    }
}
