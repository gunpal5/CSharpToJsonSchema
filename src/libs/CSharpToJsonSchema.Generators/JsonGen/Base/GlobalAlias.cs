﻿using System.Collections.Immutable;

namespace CSharpToJsonSchema.Generators.JsonGen.Base;

/// <summary>
/// Simple wrapper class around an immutable array so we can have the value-semantics needed for the incremental
/// generator to know when a change actually happened and it should run later transform stages.
/// </summary>
internal sealed class GlobalAliases : IEquatable<GlobalAliases>
{
    public static readonly GlobalAliases Empty = new(ImmutableArray<(string aliasName, string symbolName)>.Empty);

    public readonly ImmutableArray<(string aliasName, string symbolName)> AliasAndSymbolNames;

    private int _hashCode;

    private GlobalAliases(ImmutableArray<(string aliasName, string symbolName)> aliasAndSymbolNames)
    {
        AliasAndSymbolNames = aliasAndSymbolNames;
    }

    public static GlobalAliases Create(ImmutableArray<(string aliasName, string symbolName)> aliasAndSymbolNames)
    {
        return aliasAndSymbolNames.IsEmpty ? Empty : new GlobalAliases(aliasAndSymbolNames);
    }

    public static GlobalAliases Concat(GlobalAliases ga1, GlobalAliases ga2)
    {
        if (ga1.AliasAndSymbolNames.Length == 0)
            return ga2;

        if (ga2.AliasAndSymbolNames.Length == 0)
            return ga1;

        return new(ga1.AliasAndSymbolNames.AddRange(ga2.AliasAndSymbolNames));
    }

    public override int GetHashCode()
    {
        if (_hashCode == 0)
        {
            var hashCode = 0;
            foreach (var tuple in this.AliasAndSymbolNames)
                hashCode = Hash.Combine(tuple.GetHashCode(), hashCode);

            _hashCode = hashCode == 0 ? 1 : hashCode;
        }

        return _hashCode;
    }

    public override bool Equals(object? obj)
        => this.Equals(obj as GlobalAliases);

    public bool Equals(GlobalAliases? aliases)
    {
        if (aliases is null)
            return false;

        if (ReferenceEquals(this, aliases))
            return true;

        if (this.AliasAndSymbolNames == aliases.AliasAndSymbolNames)
            return true;

        return this.AliasAndSymbolNames.AsSpan().SequenceEqual(aliases.AliasAndSymbolNames.AsSpan());
    }
}