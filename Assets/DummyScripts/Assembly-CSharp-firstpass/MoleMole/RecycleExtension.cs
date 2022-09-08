/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class RecycleExtension // TypeDefIndex: 7490
	{
		// Fields
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		public static bool isChildThread; // 0xFFFFFFFF
		private static LockFreeQueue[] _recycleWaitList; // 0x00
		private static Queue<object> _recycleList; // 0x08
		private static int _frame; // 0x10
		private static int _lastFrame; // 0x14
		private const int _listNum = 4; // Metadata: 0x00ADE9FF
	
		// Nested types
		private struct RecycleTickNode : IDisposable // TypeDefIndex: 7491
		{
			// Constructors
			public RecycleTickNode(bool t = false /* Metadata: 0x00ADEA03 */) {} // 0x0000000186C3BBF0-0x0000000186C3BC00
	
			// Methods
			// [XID] // 0x0000000189643B60-0x0000000189643B80
			void IDisposable.Dispose() {} // 0x0000000186C3BB50-0x0000000186C3BBF0
		}
	
		// Constructors
		static RecycleExtension() {} // 0x0000000186C3B8F0-0x0000000186C3BB50
	
		// Methods
		// [XID] // 0x0000000189634D60-0x0000000189634D80
		public static void Collect() {} // 0x0000000186C3B460-0x0000000186C3B690
		public static void RecycleAutoAllocRecycleTypeField<T>(ref T inReusable)
			where T : class, IAutoAllocRecycle, new() {}
		public static T PoolAllocation<T>()
			where T : class, new() => default;
		// [XID] // 0x000000018963C3C0-0x000000018963C3E0
		public static void Tick() {} // 0x0000000186C3B690-0x0000000186C3B8F0
		public static T AllocateAutoAllocRecycleType<T>()
			where T : class, IAutoAllocRecycle, new() => default;
		public static void RecycleAutoAllocRecycleType<T>(T inReusable)
			where T : class, IAutoAllocRecycle {}
		public static T AllocateAutoAllocRecycleType<T>(IObjectPoolCluster objectPoolCluster)
			where T : class, IAutoAllocRecycleJobThread, new() => default;
		public static void RecycleAutoAllocRecycleType<T>(T inReusable, IObjectPoolCluster objectPoolCluster)
			where T : class, IAutoAllocRecycleJobThread {}
	}
}
