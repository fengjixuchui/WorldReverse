/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
    public static class ComponentHelper // TypeDefIndex: 31386
    {
        // Fields
        private static Dictionary<System.Type, ComponentMetaInfo> _metaInfos; // 0x00

        // Nested types
        public struct ComponentMetaInfo // TypeDefIndex: 31387
        {
            // Fields
            public bool hasTick; // 0x00
            public bool hasLateTick; // 0x01
            public EventID[] selfOnEventIDs; // 0x08
            public EventID[] selfOnEventResolvedIDs; // 0x10
            public EventID[] selfListenEventIDs; // 0x18
            public ScriptDataFieldInfo[] scriptDataFieldInfos; // 0x20

            // Methods
            // [XID] // 0x0000000189B7F850-0x0000000189B7F870
            public void SetScriptDataFieldInfos(ScriptDataFieldInfo[] infos) { } // 0x0000000181AEA4C0-0x0000000181AEA4F0
        }

        public struct ScriptDataFieldInfo // TypeDefIndex: 31388
        {
            // Fields
            public FieldInfo fieldInfo; // 0x00
            public bool needSerilize; // 0x08
        }

        // Constructors
        static ComponentHelper() { } // 0x0000000181ADED10-0x0000000181ADEDA0

        // Methods
        // [XID] // 0x0000000189A65CC0-0x0000000189A65CE0
        public static void AddMetaInfo(System.Type t, ComponentMetaInfo metaInfo) { } // 0x0000000181ADDD60-0x0000000181ADDEA0
                                                                                      // [XID] // 0x00000001899E7410-0x00000001899E7430
        public static bool HasMetaInfo(System.Type t) => default; // 0x0000000181ADEC20-0x0000000181ADED10
                                                                  // [XID] // 0x0000000189B61B70-0x0000000189B61B90
        public static ComponentMetaInfo GetMetaInfo(System.Type t) => default; // 0x0000000181ADEA80-0x0000000181ADEC20
                                                                               // [XID] // 0x0000000189B69800-0x0000000189B69820
        public static void Clear() { } // 0x0000000181ADDEA0-0x0000000181ADDF80
                                       // [XID] // 0x00000001896DA530-0x00000001896DA550
        public static ComponentMetaInfo FillComponentMetaInfo(System.Type curType, System.Type baseType) => default; // 0x0000000181ADDF80-0x0000000181ADE580
                                                                                                                     // [XID] // 0x00000001896F7D70-0x00000001896F7D90
        private static int[] GetEventIDsIncludingBase(System.Type curType, BaseComponent.HandleEventType handleEventType) => default; // 0x0000000181ADE580-0x0000000181ADEA80
    }
}
