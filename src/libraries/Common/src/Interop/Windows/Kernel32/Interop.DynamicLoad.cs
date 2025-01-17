// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static unsafe partial class Kernel32
    {
        [GeneratedDllImport(Libraries.Kernel32)]
        internal static partial IntPtr GetProcAddress(IntPtr hModule, byte* lpProcName);
    }
}
