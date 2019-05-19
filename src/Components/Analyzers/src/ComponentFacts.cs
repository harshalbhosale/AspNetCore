// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Analyzers
{
    internal static class ComponentFacts
    {
        public static bool IsAnyParameter(ComponentSymbols symbols, IPropertySymbol property)
        {
            if (symbols == null)
            {
                throw new ArgumentNullException(nameof(symbols));
            }

            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            return property.GetAttributes().Any(a =>
            {
                return a.AttributeClass == symbols.ParameterAttribute || a.AttributeClass == symbols.CascadingParameterAttribute;
            });
        }

        public static bool IsParameter(ComponentSymbols symbols, IPropertySymbol property)
        {
            if (symbols == null)
            {
                throw new ArgumentNullException(nameof(symbols));
            }

            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            return property.GetAttributes().Any(a => a.AttributeClass == symbols.ParameterAttribute);
        }

        public static bool IsCascadingParameter(ComponentSymbols symbols, IPropertySymbol property)
        {
            if (symbols == null)
            {
                throw new ArgumentNullException(nameof(symbols));
            }

            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            return property.GetAttributes().Any(a => a.AttributeClass == symbols.CascadingParameterAttribute);
        }
    }
}