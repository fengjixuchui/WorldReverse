/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class ObjectPoolWarmupNoGen // TypeDefIndex: 12180
{
    // Methods
    // [XID] // 0x00000001899CDAE0-0x00000001899CDB00
    public static void WarmupObjectPool()
    {
        var baseComponentDict = System.Type.GetTypeFromHandle(System.Type.GetTypeHandle(typeof(Dictionary<int, BaseComponent>)));
        ObjectPoolUtility.ReplaceAllocator(baseComponentDict, new Func<Dictionary<int, BaseComponent>>(() => { return new Dictionary<int, BaseComponent>(100); }));

        var baseComponentPluginDict = System.Type.GetTypeFromHandle(System.Type.GetTypeHandle(typeof(Dictionary<int, BaseComponentPlugin>)));
        ObjectPoolUtility.ReplaceAllocator(baseComponentPluginDict, new Func<Dictionary<int, BaseComponentPlugin>>(() => { return new Dictionary<int, BaseComponentPlugin>(100); }));

        var baseComponentList = System.Type.GetTypeFromHandle(System.Type.GetTypeHandle(typeof(List<int>)));
        ObjectPoolUtility.ReplaceAllocator(baseComponentList, new Func<List<int>>(() => { return new List<int>(100); }));

    } // 0x0000000182D4E6B0-0x0000000182D4E950
}

