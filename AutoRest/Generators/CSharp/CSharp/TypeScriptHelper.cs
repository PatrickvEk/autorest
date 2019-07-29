// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.Rest.Generator.ClientModel;
using Microsoft.Rest.Generator.Logging;
using Microsoft.Rest.Generator.Utilities;

namespace Microsoft.Rest.Generator.CSharp
{
    public static class TypeScriptHelper
    {

        public static string FixType(this string typeName)
        {
            string fixedName = typeName
                .Replace("IList<", "Array<").Replace("?", "")
                .Replace("bool", "boolean")
                ;

            return fixedName;
        }
    }
}
