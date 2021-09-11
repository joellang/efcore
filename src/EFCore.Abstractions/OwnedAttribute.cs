// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Marks a type as owned. All references to this type will be configured as owned entity types.
    /// </summary>
    /// <remarks>
    ///     See <see href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</see> for more information.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class OwnedAttribute : Attribute
    {
    }
}
