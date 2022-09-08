/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class ObjectPoolDebugStat : IObjectPoolDebugStat // TypeDefIndex: 7436
	{
		// Fields
		public bool forbidBalanceAllocateDealloateCheck; // 0x10
		private int _allocCount; // 0x20
		private int _deallocCount; // 0x24
		private ICollection cacheCollection; // 0x30
	
		// Properties
		public string fullTypeName { /* [XID] */ /* 0x00000001897E4F90-0x00000001897E4FD0 */ get; private set; } // 0x0000000186C2AA20-0x0000000186C2AA80 0x0000000186C2AC60-0x0000000186C2ACC0
		public int allocCount { /* [XID] */ /* 0x00000001897F7240-0x00000001897F7260 */ get => default; } // 0x0000000186C2A8E0-0x0000000186C2A980 
		public int deallocCount { /* [XID] */ /* 0x00000001897FE890-0x00000001897FE8B0 */ get => default; } // 0x0000000186C2A980-0x0000000186C2AA20 
		public int poolCount { /* [XID] */ /* 0x0000000189805F60-0x0000000189805F80 */ get => default; } // 0x0000000186C2ABA0-0x0000000186C2AC60 
		public int inUseCount { /* [XID] */ /* 0x000000018980D770-0x000000018980D790 */ get => default; } // 0x0000000186C2AA80-0x0000000186C2AB40 
		public int maxInUseCount { /* [XID] */ /* 0x0000000189814E50-0x0000000189814E90 */ get; /* [XID] */ /* 0x000000018981FA70-0x000000018981FAB0 */ private set; } // 0x0000000186C2AB40-0x0000000186C2ABA0 0x0000000186C2ACC0-0x0000000186C2AD20
	
		// Constructors
		public ObjectPoolDebugStat() {} // Dummy constructor
		public ObjectPoolDebugStat(string inFullTypeName, ICollection inCacheCollection) {} // 0x0000000186C2A830-0x0000000186C2A8E0
	
		// Methods
		// [XID] // 0x0000000189829F10-0x0000000189829F30
		public void Clear() {} // 0x0000000186C2A460-0x0000000186C2A500
		// [XID] // 0x0000000189831410-0x0000000189831430
		public void OnAlloc() {} // 0x0000000186C2A500-0x0000000186C2A680
		// [XID] // 0x0000000189838C40-0x0000000189838C60
		public void OnDealloc() {} // 0x0000000186C2A680-0x0000000186C2A830
	}
}
