/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001896F1A50-0x00000001896F1AC0
	[CustomObfuscation] // 0x00000001896F1A50-0x00000001896F1AC0
	internal sealed class RingBuffer<T> : ICollection<T> // TypeDefIndex: 4327
	{
		// Fields
		private readonly T[] OPGUsxlGRmeLIOrmlCnDPuPpZwB;
		private readonly int ZQtXcXYFxPSVYxnpniroAAvoIDE;
		private int XdTRdkKEjodcNcozqGfjhByfKiF;
		private int tfEGuXWeUmsImwNARIOROlVwzxT;
		private int oCjExPQBVRiArAcbiSwTmwqUBqb;
		private int CfndLQKZLfKToLgDDWkALQRdHjD;
		private int wyCzBtxDiYHWdJxUIaVcrhitjEkf;
		private IEqualityComparer<T> TlxZdrFpPRDnfquVHbnQJocwbYh;
	
		// Properties
		public int Count { get => default; }
		public T this[int index] { get => default; }
		int ICollection<T>.Count { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
	
		// Nested types
		[Serializable]
		public struct vLOgAlXExYFHaIHfGajhRGVzaaOK : IEnumerator<T> // TypeDefIndex: 4328
		{
			// Fields
			private RingBuffer<T> buffer;
			private int index;
			private int version;
			private T current;
	
			// Properties
			public T oEuoSHdpAntjdgOjHGCJnoHgxjJ { get => default; }
			object psCCRGKsjuCJgdrtglKOAZgncho { get => default; }
	
			// Constructors
			internal vLOgAlXExYFHaIHfGajhRGVzaaOK(RingBuffer<T> buffer) : this() {
				this.buffer = default;
				index = default;
				version = default;
				current = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			private bool qfQPaojlFYFdGHCplpjqNGLqLCW() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public RingBuffer() {} // Dummy constructor
		public RingBuffer(int capacity) {}
	
		// Methods
		public void Enqueue(T item) {}
		public T Dequeue() => default;
		public bool Contains(T item) => default;
		public bool Remove(T item) => default;
		public bool Remove(T item, IEqualityComparer<T> comparer) => default;
		public void Clear() {}
		private int cEgiArijJRiBqzUFIvBJGMcndbO(T param_0000902e, IEqualityComparer<T> param_0000902f) => default;
		private void WsIuSULGNaERtSyIPdmzZbiuUIX(int param_00009030) {}
		private bool OAAEipODXfLJVSvQHoqXlUooanN(int param_00009031) => default;
		private int wFVcLidWOZbqTYylXfRkrAmaiDo(int param_00009032) => default;
		void ICollection<T>.Add(T item) {}
		void ICollection<T>.Clear() {}
		bool ICollection<T>.Contains(T item) => default;
		void ICollection<T>.CopyTo(T[] array, int arrayIndex) {}
		bool ICollection<T>.Remove(T item) => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}
}
