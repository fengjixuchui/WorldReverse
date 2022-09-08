/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class ObjectPoolDebugger // TypeDefIndex: 7438
	{
		// Fields
		private static Dictionary<System.Type, ObjectPoolDebuggerInstance> gPools; // 0x00
		private static StringBuilder sb; // 0x08
	
		// Constructors
		static ObjectPoolDebugger() {} // 0x0000000186C2CE00-0x0000000186C2CEB0
	
		// Methods
		// [XID] // 0x00000001898AD040-0x00000001898AD060
		public static ObjectPoolDebuggerInstance CreateNewDebugInstance(System.Type type, ICollection inCacheCollection, bool bGeneric) => default; // 0x0000000186C2C470-0x0000000186C2C6C0
		public static ObjectPoolDebuggerInstance CreateNewDebugInstance<T>(ICollection inCacheCollection) => default;
		// [XID] // 0x00000001898B4600-0x00000001898B4620
		public static ObjectPoolDebugStat GetOrCreateDebugInstance(System.Type type, ICollection inCacheCollection, bool bGeneric) => default; // 0x0000000186C2C9E0-0x0000000186C2CCB0
		public static ObjectPoolDebugStat GetOrCreateDebugInstance<T>(ICollection inCacheCollection) => default;
		// [XID] // 0x00000001898BC430-0x00000001898BC450
		public static string ToCSVTitle() => default; // 0x0000000186C2CCB0-0x0000000186C2CD50
		// [XID] // 0x00000001899AE450-0x00000001899AE470
		public static void DebugPrintAll(Action<string> inLogAction) {} // 0x0000000186C2C6C0-0x0000000186C2C9E0
	}
}
