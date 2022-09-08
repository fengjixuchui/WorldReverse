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
	public class LockFreeQueue : LockFreeCollection, IEnumerable // TypeDefIndex: 10576
	{
		// Fields
		private LockFreeNode _head; // 0x10
		private LockFreeNode _tail; // 0x18
		private int _count; // 0x20
		private int _capacity; // 0x24
	
		// Properties
		public override int Count { /* [XID] */ /* 0x00000001898749F0-0x0000000189874A10 */ get => default; } // 0x0000000189BFC100-0x0000000189BFC1A0 
		public override int Capacity { /* [XID] */ /* 0x0000000189892380-0x00000001898923A0 */ get => default; /* [XID] */ /* 0x0000000189899DF0-0x0000000189899E10 */ set {} } // 0x0000000189BFC060-0x0000000189BFC100 0x0000000189BFC1A0-0x0000000189BFC270
	
		// Nested types
		public struct Enumerator : IEnumerator // TypeDefIndex: 10577
		{
			// Fields
			private LockFreeNode head; // 0x00
			private LockFreeNode node; // 0x08
			private LockFreeNode tail; // 0x10
			private bool start; // 0x18
	
			// Properties
			public object Current { /* [XID] */ /* 0x00000001898A0FD0-0x00000001898A0FF0 */ get => default; } // 0x0000000189BE1300-0x0000000189BE13C0 
	
			// Constructors
			public Enumerator(LockFreeNode head, LockFreeNode tail) : this() {
				this.head = default;
				node = default;
				this.tail = default;
				start = default;
			} // 0x0000000189BE11D0-0x0000000189BE11E0
	
			// Methods
			// [XID] // 0x00000001898A8520-0x00000001898A8540
			public bool MoveNext() => default; // 0x0000000189BE0FE0-0x0000000189BE1090
			// [XID] // 0x00000001898B00F0-0x00000001898B0110
			public void Reset() {} // 0x0000000189BE1140-0x0000000189BE11D0
		}
	
		// Constructors
		public LockFreeQueue() {} // Dummy constructor
		public LockFreeQueue(int capacity = -1 /* Metadata: 0x00AE7B84 */) {} // 0x0000000189BFBF40-0x0000000189BFC060
	
		// Methods
		// [XID] // 0x0000000189865FD0-0x0000000189865FF0
		public override bool Push(object item) => default; // 0x0000000189BFBC80-0x0000000189BFBE60
		// [XID] // 0x0000000189883690-0x00000001898836B0
		public override object Pop() => default; // 0x0000000189BFBAD0-0x0000000189BFBC80
		// [XID] // 0x0000000189892280-0x00000001898922A0
		public override void Clear() {} // 0x0000000189BFB790-0x0000000189BFB8B0
		// [XID] // 0x00000001899C0DF0-0x00000001899C0E10
		public override void CopyTo(Array array, int index) {} // 0x0000000189BFB8B0-0x0000000189BFB970
		// [XID] // 0x00000001898837B0-0x00000001898837D0
		new IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189BFBE60-0x0000000189BFBF40
		// [XID] // 0x000000018988AFF0-0x000000018988B010
		public Enumerator GetEnumerator() => default; // 0x0000000189BFB970-0x0000000189BFBAD0
	}
}
