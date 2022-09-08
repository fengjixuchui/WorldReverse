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
	public class ObjectPoolDebuggerInstance : IObjectPoolDebugStat // TypeDefIndex: 7437
	{
		// Fields
		private Dictionary<ICollection, ObjectPoolDebugStat> _registeredPool; // 0x18
		private int _cachedAllocCount; // 0x20
		private int _cachedDeallocCount; // 0x24
	
		// Properties
		public string fullTypeName { /* [XID] */ /* 0x000000018984A5B0-0x000000018984A5F0 */ get; private set; } // 0x0000000186C2BF10-0x0000000186C2BF70 0x0000000186C2C410-0x0000000186C2C470
		public int allocCount { /* [XID] */ /* 0x000000018986AC80-0x000000018986ACA0 */ get => default; } // 0x0000000186C2BB70-0x0000000186C2BD40 
		public int deallocCount { /* [XID] */ /* 0x00000001898720C0-0x00000001898720E0 */ get => default; } // 0x0000000186C2BD40-0x0000000186C2BF10 
		public int poolCount { /* [XID] */ /* 0x00000001898798E0-0x0000000189879900 */ get => default; } // 0x0000000186C2C360-0x0000000186C2C410 
		public int inUseCount { /* [XID] */ /* 0x0000000189880E50-0x0000000189880E70 */ get => default; } // 0x0000000186C2BF70-0x0000000186C2C150 
		public int maxInUseCount { /* [XID] */ /* 0x0000000189888250-0x0000000189888270 */ get => default; } // 0x0000000186C2C150-0x0000000186C2C360 
	
		// Constructors
		public ObjectPoolDebuggerInstance() {} // Dummy constructor
		public ObjectPoolDebuggerInstance(string inTypeName, ICollection inCacheCollection) {} // 0x0000000186C2BA80-0x0000000186C2BB70
	
		// Methods
		// [XID] // 0x000000018985C120-0x000000018985C140
		public ObjectPoolDebugStat GetObjPoolDebugStat(ICollection inCollection) => default; // 0x0000000186C2AD20-0x0000000186C2AE50
		// [XID] // 0x0000000189863A10-0x0000000189863A30
		public void RegisterNewPool(ICollection inCacheCollection) {} // 0x0000000186C2B420-0x0000000186C2B5D0
		// [XID] // 0x000000018988F800-0x000000018988F820
		public static string ToCSVTitle() => default; // 0x0000000186C2B9E0-0x0000000186C2BA80
		// [XID] // 0x0000000189896DD0-0x0000000189896DF0
		public string ToCSVString() => default; // 0x0000000186C2B5D0-0x0000000186C2B9E0
		// [XID] // 0x000000018989E270-0x000000018989E290
		public void OnDumpToCSVFile(Action<string> inAction) {} // 0x0000000186C2AE50-0x0000000186C2B420
	}
}
