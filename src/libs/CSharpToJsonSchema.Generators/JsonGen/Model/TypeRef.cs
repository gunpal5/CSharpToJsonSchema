﻿using System.Diagnostics;
using CSharpToJsonSchema.Generators.JsonGen.Helpers;
using Microsoft.CodeAnalysis;

namespace CSharpToJsonSchema.Generators.JsonGen.Model;

/// <summary>
/// An equatable value representing type identity.
/// </summary>
[DebuggerDisplay("Name = {Name}")]
public sealed class TypeRef : IEquatable<TypeRef>
{
    public TypeRef(ITypeSymbol type)
    {
        Name = type.Name;
        FullyQualifiedName = type.GetFullyQualifiedName();
        IsValueType = type.IsValueType;
        TypeKind = type.TypeKind;
        SpecialType = type.OriginalDefinition.SpecialType;
    }

    public string Name { get; }

    /// <summary>
    /// Fully qualified assembly name, prefixed with "global::", e.g. global::System.Numerics.BigInteger.
    /// </summary>
    public string FullyQualifiedName { get; }

    public bool IsValueType { get; }
    public TypeKind TypeKind { get; }
    public SpecialType SpecialType { get; }

    public bool CanBeNull => !IsValueType || SpecialType is SpecialType.System_Nullable_T;

    public bool Equals(TypeRef? other) => other != null && FullyQualifiedName == other.FullyQualifiedName;
    public override bool Equals(object? obj) => Equals(obj as TypeRef);
    public override int GetHashCode() => FullyQualifiedName.GetHashCode();
}