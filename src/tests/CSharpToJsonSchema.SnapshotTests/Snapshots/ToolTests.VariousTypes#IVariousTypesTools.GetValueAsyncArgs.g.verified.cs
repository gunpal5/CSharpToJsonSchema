﻿//HintName: IVariousTypesTools.GetValueAsyncArgs.g.cs
// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace CSharpToJsonSchema.IntegrationTests
{
    public partial class VariousTypesToolsExtensionsJsonSerializerContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs>? _GetValueAsyncArgs;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        #nullable disable annotations // Marking the property type as nullable-oblivious.
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs> GetValueAsyncArgs
        #nullable enable annotations
        {
            get => _GetValueAsyncArgs ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs>)Options.GetTypeInfo(typeof(global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs> Create_GetValueAsyncArgs(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs>
                {
                    ObjectCreator = () => new global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => GetValueAsyncArgsPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    ConstructorAttributeProviderFactory = static () => typeof(global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs).GetConstructor(InstanceMemberBindingFlags, binder: null, global::System.Array.Empty<global::System.Type>(), modifiers: null),
                    SerializeHandler = GetValueAsyncArgsSerializeHandler,
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] GetValueAsyncArgsPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[0];

            return properties;
        }

        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void GetValueAsyncArgsSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::CSharpToJsonSchema.IntegrationTests.GetValueAsyncArgs? value)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }
            
            writer.WriteStartObject();


            writer.WriteEndObject();
        }
    }
}
