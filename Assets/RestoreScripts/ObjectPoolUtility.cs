/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
    public static class ObjectPoolUtility // TypeDefIndex: 7459
    {
        // Fields
        [ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
        public static bool isMainThread; // 0xFFFFFFFF
        private static IObjectPoolCluster _cluster; // 0x00

        // Properties
        public static IObjectPoolCluster threadSharedCluster { /* [XID] */ /* 0x0000000189B23010-0x0000000189B23030 */ get => _cluster; } // 0x0000000186C32A10-0x0000000186C32AC0 
        public static IObjectPoolCluster cluster { /* [XID] */ /* 0x0000000189B6C270-0x0000000189B6C290 */ get => _cluster; } // 0x0000000186C32960-0x0000000186C32A10 

        // Nested types
        public struct MarkMainThread : IDisposable // TypeDefIndex: 7460
        {
            // Methods
            // [XID] // 0x0000000189B73970-0x0000000189B73990
            public void Dispose() { } // 0x0000000186C22760-0x0000000186C22770
        }

        // Methods
        // [XID] // 0x0000000189B2A700-0x0000000189B2A720
        public static void DebugPrintAll(Action<string> inLogAction) { } // 0x0000000186C32590-0x0000000186C32650
                                                                         // [XID] // 0x0000000189B31C10-0x0000000189B31C30
        private static bool IsInMainThread() => default; // 0x0000000186C32730-0x0000000186C327D0
                                                         // [XID] // 0x0000000189B39050-0x0000000189B39070
        public static void ReplaceCluster(IObjectPoolCluster inCluster)
        {
            _cluster = inCluster;
        } // 0x0000000186C328B0-0x0000000186C32960
          // [XID] // 0x0000000189B40D40-0x0000000189B40D60
        public static void Init()
        {
            ReplaceCluster(ObjectPoolNonGenericCluster.instance);
        } // 0x0000000186C32650-0x0000000186C32730
        public static T Allocate<T>()
            where T : class, new() => default;
        // [IDTag] // 0x0000000189B48510-0x0000000189B48550
        // [XID] // 0x0000000189B48510-0x0000000189B48550
        public static void Deallocate(object objInstance) { } // 0x0000000186C32460-0x0000000186C32590
        public static void Deallocate<T>(ref T objInstance)
            where T : class, new()
        { }
        // [XID] // 0x0000000189B52BD0-0x0000000189B52BF0
        public static void ReplaceAllocator(System.Type t, Func<object> inAllocator) { } // 0x0000000186C327D0-0x0000000186C328B0
                                                                                         // [XID] // 0x0000000189B5A5C0-0x0000000189B5A5E0
        public static object Allocate(System.Type t) => default; // 0x0000000186C321E0-0x0000000186C32320
                                                                 // [IDTag] // 0x0000000189B61AA0-0x0000000189B61AE0
                                                                 // [XID] // 0x0000000189B61AA0-0x0000000189B61AE0
        public static void Deallocate(System.Type t, object obj) { } // 0x0000000186C32320-0x0000000186C32460
    }
}
