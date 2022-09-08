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
	public static class ObjectPoolUtilityOld // TypeDefIndex: 7450
	{
		// Fields
		private static IObjectPoolCluster _cluster; // 0x00
	
		// Constructors
		static ObjectPoolUtilityOld() {} // 0x0000000186C32180-0x0000000186C321E0
	
		// Methods
		// [XID] // 0x0000000189959C90-0x0000000189959CB0
		public static void DebugPrintAll(Action<string> inLogAction) {} // 0x0000000186C31DE0-0x0000000186C31EA0
		// [XID] // 0x00000001899616C0-0x00000001899616E0
		public static void ReplaceCluster(IObjectPoolCluster inCluster) {} // 0x0000000186C320B0-0x0000000186C32180
		// [XID] // 0x0000000189968C10-0x0000000189968C30
		public static void Init() {} // 0x0000000186C31EA0-0x0000000186C31FB0
		public static T Allocate<T>()
			where T : class, new() => default;
		// [IDTag] // 0x0000000189970380-0x00000001899703C0
		// [XID] // 0x0000000189970380-0x00000001899703C0
		public static void Deallocate(object objInstance) {} // 0x0000000186C31BF0-0x0000000186C31CE0
		public static void Deallocate<T>(ref T objInstance)
			where T : class, new() {}
		// [XID] // 0x000000018997AEB0-0x000000018997AED0
		public static void ReplaceAllocator(System.Type t, Func<object> inAllocator) {} // 0x0000000186C31FB0-0x0000000186C320B0
		// [XID] // 0x0000000189982860-0x0000000189982880
		public static object Allocate(System.Type t) => default; // 0x0000000186C31B00-0x0000000186C31BF0
		// [IDTag] // 0x000000018998A110-0x000000018998A150
		// [XID] // 0x000000018998A110-0x000000018998A150
		public static void Deallocate(System.Type t, object obj) {} // 0x0000000186C31CE0-0x0000000186C31DE0
	}
}
