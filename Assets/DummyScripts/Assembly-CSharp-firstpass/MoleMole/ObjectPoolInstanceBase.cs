/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public abstract class ObjectPoolInstanceBase : ObjectPoolProxy // TypeDefIndex: 7443
	{
		// Fields
		protected ConcurrentHashSet<object> _set; // 0x10
		protected readonly bool _isStaticPool; // 0x18
		protected bool useHash; // 0x19
		protected bool isCollection; // 0x1A
		protected MethodInfo clearMethod; // 0x20
		public bool needRecordAllocationHistory; // 0x28
		private Dictionary<object, Stack<AllocationHistory>> allocateHistory; // 0x30
	
		// Properties
		protected abstract ICollection _debugCache { get; }
		public int debugRecycleSetElementCount { /* [XID] */ /* 0x00000001898F9F50-0x00000001898F9F70 */ get; } // 0x0000000186C2E110-0x0000000186C2E1D0 
		public int cacheCount { /* [XID] */ /* 0x00000001899019F0-0x0000000189901A10 */ get; } // 0x0000000186C2E040-0x0000000186C2E110 
		public ObjectPoolDebugStat debugger { /* [XID] */ /* 0x00000001899181D0-0x0000000189918210 */ get; /* [XID] */ /* 0x0000000189922A30-0x0000000189922A70 */ protected set; } // 0x0000000186C2E1D0-0x0000000186C2E230 0x0000000186C2E230-0x0000000186C2E290
	
		// Nested types
		private struct AllocationHistory // TypeDefIndex: 7444
		{
			// Fields
			public int allocateType; // 0x00
			public string callstack; // 0x08
	
			// Constructors
			public AllocationHistory(int inat) {
				allocateType = default;
				callstack = default;
			} // 0x0000000186C1E780-0x0000000186C1E790
		}
	
		// Constructors
		protected ObjectPoolInstanceBase() {} // Dummy constructor
		protected ObjectPoolInstanceBase(bool staticPool = false /* Metadata: 0x00ADE9F5 */) {} // 0x0000000186C2DF80-0x0000000186C2E040
	
		// Methods
		// [XID] // 0x0000000189909020-0x0000000189909040
		private void ConditionalRecordHistory(object o, int allocateType) {} // 0x0000000186C2CEB0-0x0000000186C2D0C0
		// [XID] // 0x0000000189910630-0x0000000189910650
		public static bool IsOverride(MethodInfo method) => default; // 0x0000000186C2D390-0x0000000186C2D470
		// [XID] // 0x000000018992D020-0x000000018992D040
		protected void InitializeDebugInfo(System.Type type, bool bGeneric) {} // 0x0000000186C2D190-0x0000000186C2D390
		// [XID] // 0x0000000189934730-0x0000000189934750
		protected void OnAllocateElement(object element) {} // 0x0000000186C2D470-0x0000000186C2D5F0
		// [XID] // 0x000000018993C270-0x000000018993C290
		protected void PreDeallocate() {} // 0x0000000186C2DE90-0x0000000186C2DF80
		// [XID] // 0x00000001899436B0-0x00000001899436D0
		protected void OnDeallocateElement(object instance) {} // 0x0000000186C2D700-0x0000000186C2DE90
		// [XID] // 0x000000018994AD70-0x000000018994AD90
		protected void OnClearAll() {} // 0x0000000186C2D5F0-0x0000000186C2D700
		// [XID] // 0x0000000189952760-0x0000000189952780
		protected virtual void Init(System.Type t, bool bGeneric) {} // 0x0000000186C2D0C0-0x0000000186C2D190
		public abstract void ReleaseAllCache();
	}
}
