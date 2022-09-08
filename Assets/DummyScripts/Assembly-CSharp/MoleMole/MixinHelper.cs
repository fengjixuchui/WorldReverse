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
	public static class MixinHelper // TypeDefIndex: 31621
	{
		// Fields
		private static System.Type _baseAbilityMixinType; // 0x00
		private static BindingFlags _bindingFlags; // 0x08
		private static Dictionary<System.Type, MixinMetaInfo> _metaInfos; // 0x10
		private static Dictionary<int, string> _eventTypeToEventGetterName; // 0x18
	
		// Nested types
		public struct MixinMetaInfo // TypeDefIndex: 31622
		{
			// Fields
			public bool hasTick; // 0x00
			public bool hasOnEvent; // 0x01
			public bool hasOnEventRemote; // 0x02
			public bool hasOnEventResolved; // 0x03
			public bool hasListenEvent; // 0x04
			public int[] selfOnEventIDs; // 0x08
			public int[] selfOnEventRemoteIDs; // 0x10
			public int[] selfOnEventResolvedIDs; // 0x18
			public int[] selfListenEventIDs; // 0x20
		}
	
		// Constructors
		static MixinHelper() {} // 0x0000000184C626E0-0x0000000184C62C80
	
		// Methods
		// [XID] // 0x0000000189B7AE40-0x0000000189B7AE60
		public static MixinMetaInfo GetMetaInfo(System.Type t) => default; // 0x0000000184C62060-0x0000000184C626E0
		// [XID] // 0x0000000189B98870-0x0000000189B98890
		private static int[] GetEventIDsIncludingBase(System.Type curType, BaseAbilityMixin.HandleEventType eventType) => default; // 0x0000000184C61D20-0x0000000184C62060
	}
}
