﻿using System.Text.Json;
using CSharpToJsonSchema.AotTests;
using CSharpToJsonSchema.IntegrationTests.Services;
using FluentAssertions;

namespace CSharpToJsonSchema.IntegrationTests;

public class JsonSerializationTests
{
    [Fact]
    public Task ShouldDeserializeWithJsonTypeInfo()
    {
        var args = new ComplexClassSerializerTools()
        {
            Name = "Example Name",
            Age = 30,
            IsActive = true,
            CreatedAt = DateTime.UtcNow,
            Tags = new List<string> { "tag1", "tag2", "tag3" },
            Metadata = new Dictionary<string, object>
            {
                { "Key1", "Value1" },
                { "Key2", 12345 },
                { "Key3", true }
            },
            Details = new ComplexClassSerializerTools.NestedClass
            {
                Description = "Nested description",
                Value = 99.99,
                Numbers = new List<int> { 1, 2, 3, 4, 5 }
            }
        };

        var serialized = JsonSerializer.Serialize(args,
            WeatherToolsExtensionsJsonSerializerContext.Default.ComplexClassSerializerTools);
        serialized.Should().NotBeNullOrEmpty();

        var deserialized = JsonSerializer.Deserialize(serialized,
            WeatherToolsExtensionsJsonSerializerContext.Default.ComplexClassSerializerTools);

        deserialized.Should().NotBeNull();
        deserialized!.Name.Should().Be(args.Name);
        deserialized.Age.Should().Be(args.Age);
        deserialized.IsActive.Should().Be(args.IsActive);
        deserialized.CreatedAt.Should()
            .BeCloseTo(args.CreatedAt, TimeSpan.FromSeconds(1)); // Accounting for serialization precision
        deserialized.Tags.Should().BeEquivalentTo(args.Tags);
        //foreach (var key in args.Metadata.Keys)
        //{
        //    deserialized.Metadata[key].Should().Be(args.Metadata[key]);
        //}


        deserialized.Details.Should().NotBeNull();
        deserialized.Details!.Description.Should().Be(args.Details.Description);
        deserialized.Details.Value.Should().Be(args.Details.Value);
        deserialized.Details.Numbers.Should().BeEquivalentTo(args.Details.Numbers);


        return Task.CompletedTask;
    }

    [Fact]
    public async Task ShouldWorkWithService()
    {
        var service = new WeatherService();
        var calls = service.AsCalls();

        var args = new ComplexClassSerializerTools()
        {
            Name = "Example Name",
            Age = 30,
            IsActive = true,
            CreatedAt = DateTime.UtcNow,
            Tags = new List<string> { "tag1", "tag2", "tag3" },
            Metadata = new Dictionary<string, object>
            {
                { "Key1", "Value1" },
                { "Key2", 12345 },
                { "Key3", true }
            },
            Details = new ComplexClassSerializerTools.NestedClass
            {
                Description = "Nested description",
                Value = 99.99,
                Numbers = new List<int> { 1, 2, 3, 4, 5 }
            }
        };

        var args2 = new GetComplexDataTypeArgs();
        args2.Unit = Unit.Fahrenheit;
        args2.WeatherToTest = new Weather()
        {
            Description = "description",
            Location = "Location",
            Temperature = 25,
            Unit = Unit.Celsius
        };
        var serialize = JsonSerializer.Serialize(args2,
            WeatherToolsExtensionsJsonSerializerContext.Default.GetComplexDataTypeArgs);

        var dx = await calls["GetComplexDataType"].Invoke(serialize, default);

        var deserialized = JsonSerializer.Deserialize<ComplexClassSerializerTools>(dx,
            WeatherToolsExtensionsJsonSerializerContext.Default.ComplexClassSerializerTools);
        deserialized.Should().NotBeNull();
        deserialized!.Name.Should().Be(args.Name);
        deserialized.Age.Should().Be(args.Age);
        deserialized.IsActive.Should().Be(args.IsActive);
        deserialized.CreatedAt.Should()
            .BeCloseTo(args.CreatedAt, TimeSpan.FromSeconds(1)); // Accounting for serialization precision
        deserialized.Tags.Should().BeEquivalentTo(args.Tags);
        //foreach (var key in args.Metadata.Keys)
        //{
        //    deserialized.Metadata[key].Should().Be(args.Metadata[key]);
        //}


        deserialized.Details.Should().NotBeNull();
        deserialized.Details!.Description.Should().Be(args.Details.Description);
        deserialized.Details.Value.Should().Be(args.Details.Value);
        deserialized.Details.Numbers.Should().BeEquivalentTo(args.Details.Numbers);
    }

    [Fact]
    public void ShouldCreateToolWithComplexStudentClass()
    {
        var service = new StudenRecordService();
        var tools = service.AsTools();

        Tool tool = tools[0];


        var openApiSchema = (OpenApiSchema)tool.Parameters;
        tool.Description.Should().Be("Get student record for the year");
        tool.Name.Should().Be("GetStudentRecordAsync");
        openApiSchema.Properties["query"].Should().NotBeNull();

        openApiSchema.Properties["query"].Properties["fullName"].Type.Should().Be("string");
        openApiSchema.Properties["query"].Properties["fullName"].Description.Should().Be("The student's full name.");

        openApiSchema.Properties["query"].Properties["gradeFilters"].Type.Should().Be("array");
        openApiSchema.Properties["query"].Properties["gradeFilters"].Items.Type.Should().Be("string");
        openApiSchema.Properties["query"].Properties["gradeFilters"].Description.Should()
            .Be("Grade filters for querying specific grades, e.g., Freshman or Senior.");

        openApiSchema.Properties["query"].Properties["enrollmentStartDate"].Type.Should().Be("string");
        openApiSchema.Properties["query"].Properties["enrollmentStartDate"].Format.Should().Be("date-time");
        openApiSchema.Properties["query"].Properties["enrollmentStartDate"].Description.Should()
            .Be("The start date for the enrollment date range. ISO 8601 standard date");

        openApiSchema.Properties["query"].Properties["enrollmentEndDate"].Type.Should().Be("string");
        openApiSchema.Properties["query"].Properties["enrollmentEndDate"].Format.Should().Be("date-time");
        openApiSchema.Properties["query"].Properties["enrollmentEndDate"].Description.Should()
            .Be("The end date for the enrollment date range. ISO 8601 standard date");

        openApiSchema.Properties["query"].Properties["isActive"].Type.Should().Be("boolean");
        openApiSchema.Properties["query"].Properties["isActive"].Description.Should()
            .Be("The flag indicating whether to include only active students.");
    }
}