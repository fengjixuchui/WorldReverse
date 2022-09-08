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
	public class ByteBuffer : IList<ArraySegment<byte>> // TypeDefIndex: 10665
	{
		// Fields
		private int byteCount; // 0x10
		private int startOffset; // 0x14
		private int count; // 0x18
		private ArraySegment<byte>[] buffer; // 0x20
	
		// Properties
		public ArraySegment<byte> this[int index] { /* [XID] */ /* 0x0000000189874EF0-0x0000000189874F10 */ get => default; /* [XID] */ /* 0x000000018984D520-0x000000018984D540 */ set {} } // 0x00000001868F9900-0x00000001868F9A60 0x00000001868F9A60-0x00000001868F9C20
		public int Count { /* [XID] */ /* 0x0000000189886B00-0x0000000189886B20 */ get => default; } // 0x00000001868F97C0-0x00000001868F9860 
		public int ByteCount { /* [XID] */ /* 0x000000018988DC50-0x000000018988DC70 */ get => default; } // 0x00000001868F9720-0x00000001868F97C0 
		public bool IsReadOnly { /* [XID] */ /* 0x0000000189895320-0x0000000189895340 */ get => default; } // 0x00000001868F9860-0x00000001868F9900 
	
		// Constructors
		public ByteBuffer() {} // 0x00000001868F9300-0x00000001868F9390
	
		// Methods
		// [XID] // 0x000000018991D2D0-0x000000018991D2F0
		private void Reserve(int value) {} // 0x00000001868F9110-0x00000001868F9250
		// [XID] // 0x00000001897EFBE0-0x00000001897EFC00
		public bool IsEmpty() => default; // 0x00000001868F87F0-0x00000001868F88A0
		[DebuggerHidden] // 0x000000018981DF30-0x000000018981DF70
		// [XID] // 0x000000018981DF30-0x000000018981DF70
		public IEnumerator<ArraySegment<byte>> GetEnumerator() => default; // 0x00000001868F8510-0x00000001868F8620
		// [XID] // 0x0000000189823F90-0x0000000189823FB0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001868F9250-0x00000001868F9300
		// [XID] // 0x000000018982B9D0-0x000000018982B9F0
		public int IndexOf(ArraySegment<byte> item) => default; // 0x00000001868F8620-0x00000001868F8700
		// [XID] // 0x0000000189832F90-0x0000000189832FB0
		public void Insert(int index, ArraySegment<byte> item) {} // 0x00000001868F8700-0x00000001868F87F0
		// [XID] // 0x000000018983E850-0x000000018983E870
		public void RemoveAt(int index) {} // 0x00000001868F88A0-0x00000001868F8970
		// [IDTag] // 0x0000000189854570-0x00000001898545B0
		// [XID] // 0x0000000189854570-0x00000001898545B0
		public void Add(ArraySegment<byte> item) {} // 0x00000001868F7A80-0x00000001868F7BB0
		// [XID] // 0x000000018985E720-0x000000018985E740
		public void AddRange(IEnumerable<ArraySegment<byte>> collection) {} // 0x00000001868F7170-0x00000001868F7580
		// [IDTag] // 0x0000000189865F90-0x0000000189865FD0
		// [XID] // 0x0000000189865F90-0x0000000189865FD0
		public void Add(ByteBuffer buff, int size) {} // 0x00000001868F7580-0x00000001868F7A80
		// [XID] // 0x0000000189BC4280-0x0000000189BC42A0
		public void Clear() {} // 0x00000001868F7D00-0x00000001868F7DC0
		// [XID] // 0x0000000189924B80-0x0000000189924BA0
		public bool Contains(ArraySegment<byte> item) => default; // 0x00000001868F7DC0-0x00000001868F7EA0
		// [XID] // 0x000000018987F4F0-0x000000018987F510
		public void CopyTo(ArraySegment<byte>[] array, int arrayIndex) {} // 0x00000001868F7EA0-0x00000001868F8060
		// [XID] // 0x0000000189683650-0x0000000189683670
		public bool Remove(ArraySegment<byte> item) => default; // 0x00000001868F9030-0x00000001868F9110
		// [XID] // 0x00000001898A4280-0x00000001898A42A0
		public void GetBytesFront(int size, out byte[] data) {
			data = default;
		} // 0x00000001868F8210-0x00000001868F8510
		// [IDTag] // 0x00000001898AB480-0x00000001898AB4C0
		// [XID] // 0x00000001898AB480-0x00000001898AB4C0
		public void RemoveBytesFront(int size) {} // 0x00000001868F8970-0x00000001868F8C50
		// [IDTag] // 0x00000001898B5D30-0x00000001898B5D70
		// [XID] // 0x00000001898B5D30-0x00000001898B5D70
		public void RemoveBytesFront(int size, out byte[] data) {
			data = default;
		} // 0x00000001868F8C50-0x00000001868F9030
		// [XID] // 0x0000000189848E90-0x0000000189848EB0
		private static void checkArgumentsOutOfRange(int length, int offset, int count) {} // 0x00000001868F9390-0x00000001868F9630
		// [IDTag] // 0x00000001898C7F40-0x00000001898C7F80
		// [XID] // 0x00000001898C7F40-0x00000001898C7F80
		private int GetBufferIndex(int startIndex, int offset) => default; // 0x00000001868F8060-0x00000001868F8150
		// [IDTag] // 0x00000001898D2710-0x00000001898D2750
		// [XID] // 0x00000001898D2710-0x00000001898D2750
		private int GetBufferIndex(int offset) => default; // 0x00000001868F8150-0x00000001868F8210
		// [XID] // 0x00000001898DD050-0x00000001898DD070
		private void ClearBuffer(int logicalIndex, int length) {} // 0x00000001868F7BB0-0x00000001868F7D00
		// [XID] // 0x00000001899812F0-0x0000000189981310
		private void ensureCapacityFor(int numElements) {} // 0x00000001868F9630-0x00000001868F9720
	}
}
