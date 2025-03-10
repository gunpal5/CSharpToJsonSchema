// ReSharper disable once CheckNamespace
namespace CSharpToJsonSchema;

/// <summary>
/// 
/// </summary>
[AttributeUsage(AttributeTargets.Interface)]
[System.Diagnostics.Conditional("GENERATE_JSON_SCHEMA_ATTRIBUTES")]
public sealed class GenerateJsonSchemaAttribute : Attribute
{
    /// <summary>
    /// 
    /// </summary>
    public bool Strict { get; set; }
    
    /// <summary>
    /// Generate Google Function Tools extensions for Google_GenerativeAI SDK
    /// </summary>
    public bool GoogleFunctionTool { get; set; }
}