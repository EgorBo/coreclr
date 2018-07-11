// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal unsafe partial class Sys
    {
        [DllImport(JitHelpers.QCall)]
        internal static extern void DoubleToStringWindows(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign);
    }
}
