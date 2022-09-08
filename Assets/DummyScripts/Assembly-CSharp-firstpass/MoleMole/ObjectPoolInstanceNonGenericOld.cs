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
	public class ObjectPoolInstanceNonGenericOld : ObjectPoolInstanceBase // TypeDefIndex: 7453
	{
		// Fields
		protected Func<object> _allocator; // 0x40
		protected Stack<object> _cache; // 0x48
		private SlimCritalSectionChecker _critalSectionChecker; // 0x50
		private int _preferCapacity; // 0x58
		private bool _usePreferCapacityWhenReleaseCache; // 0x5C
	
		// Properties
		protected override ICollection _debugCache { /* [XID] */ /* 0x00000001899F4D80-0x00000001899F4DA0 */ get => default; } // 0x0000000186C2F180-0x0000000186C2F220 
	
		// Constructors
		public ObjectPoolInstanceNonGenericOld() {} // Dummy constructor
		public ObjectPoolInstanceNonGenericOld(System.Type type, Func<object> inAllocator) {} // 0x0000000186C2F010-0x0000000186C2F180
	
		// Methods
		// [XID] // 0x00000001899FC300-0x00000001899FC320
		protected override void Init(System.Type t, bool bGeneric) {} // 0x0000000186C2EB00-0x0000000186C2EC00
		// [XID] // 0x0000000189A038B0-0x0000000189A038D0
		public void ReplaceAllocator(Func<object> inAllocator) {} // 0x0000000186C2ED40-0x0000000186C2EDF0
		// [XID] // 0x0000000189A0ADB0-0x0000000189A0ADD0
		public void Expand(int inCapacity, bool needPreAllocate) {} // 0x0000000186C2E9B0-0x0000000186C2EB00
		// [IDTag] // 0x0000000189A126F0-0x0000000189A12730
		// [XID] // 0x0000000189A126F0-0x0000000189A12730
		public object Allocate() => default; // 0x0000000186C2E290-0x0000000186C2E4B0
		// [IDTag] // 0x0000000189A1C7C0-0x0000000189A1C800
		// [XID] // 0x0000000189A1C7C0-0x0000000189A1C800
		public object Allocate(ref bool isNew) => default; // 0x0000000186C2E4B0-0x0000000186C2E6E0
		// [XID] // 0x0000000189A26D00-0x0000000189A26D20
		public void Deallocate(object instance) {} // 0x0000000186C2E7A0-0x0000000186C2E9B0
		// [XID] // 0x0000000189A2E4B0-0x0000000189A2E4D0
		public override void ReleaseAllCache() {} // 0x0000000186C2EC00-0x0000000186C2ED40
		// [XID] // 0x0000000189A35D40-0x0000000189A35D60
		public int CachePoolCount() => default; // 0x0000000186C2E6E0-0x0000000186C2E7A0
		// [XID] // 0x0000000189A3D350-0x0000000189A3D370
		public override string ToString() => default; // 0x0000000186C2EDF0-0x0000000186C2EF10
	}
}
