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
	public class RingBuffer : LockFreeCollection, IEnumerable // TypeDefIndex: 10587
	{
		// Fields
		private int _head; // 0x10
		private int _end; // 0x14
		private int _capacity; // 0x18
		private object[] _array; // 0x20
	
		// Properties
		public override int Capacity { /* [XID] */ /* 0x00000001898E5620-0x00000001898E5640 */ get => default; /* [XID] */ /* 0x000000018996BA70-0x000000018996BA90 */ set {} } // 0x000000018689FAF0-0x000000018689FB90 0x000000018689FD80-0x000000018689FE60
		public override int Count { /* [XID] */ /* 0x00000001899734B0-0x00000001899734D0 */ get => default; } // 0x000000018689FB90-0x000000018689FC40 
		public override bool IsSynchronized { /* [XID] */ /* 0x0000000189999160-0x0000000189999180 */ get => default; } // 0x000000018689FC40-0x000000018689FCE0 
		public override object SyncRoot { /* [XID] */ /* 0x000000018987D310-0x000000018987D330 */ get => default; } // 0x000000018689FCE0-0x000000018689FD80 
	
		// Nested types
		public struct Enumerator : IEnumerator // TypeDefIndex: 10588
		{
			// Fields
			private object[] array; // 0x00
			private int index; // 0x08
	
			// Properties
			public object Current { /* [XID] */ /* 0x00000001898F4740-0x00000001898F4760 */ get => default; } // 0x000000018689EA70-0x000000018689EAA0 
	
			// Constructors
			public Enumerator(object[] array) : this() {
				this.array = default;
				index = default;
			} // 0x000000018689E920-0x000000018689EA70
	
			// Methods
			// [XID] // 0x000000018988B9A0-0x000000018988B9C0
			public bool MoveNext() => default; // 0x000000018689E860-0x000000018689E910
			// [XID] // 0x00000001898D60D0-0x00000001898D60F0
			public void Reset() {} // 0x000000018689E910-0x000000018689E920
		}
	
		// Constructors
		public RingBuffer() {} // Dummy constructor
		static RingBuffer() {} // 0x000000018689FA00-0x000000018689FA50
		public RingBuffer(int capacity) {} // 0x000000018689FA50-0x000000018689FAF0
	
		// Methods
		// [XID] // 0x0000000189989EB0-0x0000000189989ED0
		public override bool Push(object item) => default; // 0x000000018689F650-0x000000018689F860
		// [XID] // 0x0000000189905A20-0x0000000189905A40
		public override object Pop() => default; // 0x000000018689F440-0x000000018689F650
		// [XID] // 0x0000000189999280-0x00000001899992A0
		public override void Clear() {} // 0x000000018689F090-0x000000018689F260
		// [XID] // 0x00000001898F6A80-0x00000001898F6AA0
		public override void CopyTo(Array array, int index) {} // 0x000000018689F260-0x000000018689F320
		// [XID] // 0x00000001899A85A0-0x00000001899A85C0
		new IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018689F860-0x000000018689F920
		// [XID] // 0x00000001899AFD30-0x00000001899AFD50
		public Enumerator GetEnumerator() => default; // 0x000000018689F320-0x000000018689F440
	}
}
