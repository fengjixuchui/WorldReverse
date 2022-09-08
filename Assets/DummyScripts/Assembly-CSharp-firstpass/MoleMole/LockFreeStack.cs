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
	public class LockFreeStack : LockFreeCollection, IEnumerable // TypeDefIndex: 10578
	{
		// Fields
		private LockFreeNode _head; // 0x10
		private int _count; // 0x18
		private int _capacity; // 0x1C
	
		// Properties
		public override int Capacity { /* [XID] */ /* 0x00000001898B7630-0x00000001898B7650 */ get => default; /* [XID] */ /* 0x00000001898BEC40-0x00000001898BEC60 */ set {} } // 0x0000000189BFCBB0-0x0000000189BFCC50 0x0000000189BFCCF0-0x0000000189BFCDC0
		public override int Count { /* [XID] */ /* 0x00000001898C6620-0x00000001898C6640 */ get => default; } // 0x0000000189BFCC50-0x0000000189BFCCF0 
	
		// Nested types
		public struct Enumerator : IEnumerator // TypeDefIndex: 10579
		{
			// Fields
			private LockFreeNode head; // 0x00
			private LockFreeNode node; // 0x08
	
			// Properties
			public object Current { /* [XID] */ /* 0x00000001899288B0-0x00000001899288D0 */ get => default; } // 0x0000000189BE13C0-0x0000000189BE13F0 
	
			// Constructors
			public Enumerator(LockFreeNode head) : this() {
				this.head = default;
				node = default;
			} // 0x0000000189BE11E0-0x0000000189BE1300
	
			// Methods
			// [XID] // 0x0000000189919920-0x0000000189919940
			public bool MoveNext() => default; // 0x0000000189BE0F00-0x0000000189BE0FE0
			// [XID] // 0x0000000189955120-0x0000000189955140
			public void Reset() {} // 0x0000000189BE1090-0x0000000189BE1140
		}
	
		// Constructors
		public LockFreeStack() {} // Dummy constructor
		public LockFreeStack(int capacity = -1 /* Metadata: 0x00AE7B88 */) {} // 0x0000000189BFCA90-0x0000000189BFCBB0
	
		// Methods
		// [XID] // 0x00000001898CDBF0-0x00000001898CDC10
		public override bool Push(object item) => default; // 0x0000000189BFC7E0-0x0000000189BFC9D0
		// [XID] // 0x00000001898D55D0-0x00000001898D55F0
		public override object Pop() => default; // 0x0000000189BFC560-0x0000000189BFC7E0
		// [XID] // 0x00000001898DD070-0x00000001898DD090
		new IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BFC9D0-0x0000000189BFCA90
		// [XID] // 0x00000001898DCF50-0x00000001898DCF70
		public Enumerator GetEnumerator() => default; // 0x0000000189BFC450-0x0000000189BFC560
		// [XID] // 0x00000001898EC470-0x00000001898EC490
		public override void Clear() {} // 0x0000000189BFC270-0x0000000189BFC390
		// [XID] // 0x00000001898F3D00-0x00000001898F3D20
		public override void CopyTo(Array array, int index) {} // 0x0000000189BFC390-0x0000000189BFC450
	}
}
