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
	[CustomClassObfuscation] // 0x00000001896A2A60-0x00000001896A2AD0
	[CustomObfuscation] // 0x00000001896A2A60-0x00000001896A2AD0
	internal class AList<T> : IList, IList<T> // TypeDefIndex: 4329
	{
		// Fields
		private const int OvvzDaSnSYZsfnTXXikHnQlgdUs = 4; // Metadata: 0x00AC4EE4
		private static readonly T[] IthCCRhsnHXHdaTkPqrssOkvoDL;
		private IEqualityComparer<T> TlxZdrFpPRDnfquVHbnQJocwbYh;
		public T[] _items;
		private int ZQtXcXYFxPSVYxnpniroAAvoIDE;
		public int _count;
		private int DkLIRtVljhkIdWrKYmmEzzPAotV;
		private bool UZyNItdYDijdcqeGsgFmlDGQPdp;
		private readonly int GZHaUyzxjQVgKnQHKqrxfgJnPDy;
		private readonly bool yiNGsSPmOzBjQufduObiVfnlZkU;
		private int wyCzBtxDiYHWdJxUIaVcrhitjEkf;
		[NonSerialized]
		private object hXfFbNklCHLuuDBVVoEKlNLfPpvH;
	
		// Properties
		public int Count { get => default; }
		public bool IsFixedSize { get => default; }
		public int Version { get => default; }
		public T this[int index] { get => default; set {} }
		bool ICollection<T>.IsReadOnly { get => default; }
		bool IList.IsReadOnly { get => default; }
		object IList.this[int index] { get => default; set {} }
		int ICollection.Count { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Nested types
		[Serializable]
		public struct gAJClBheeuqAESMTRycXWpealIw : IEnumerator<T> // TypeDefIndex: 4330
		{
			// Fields
			private AList<T> list;
			private int index;
			private int version;
			private T current;
	
			// Properties
			public T oEuoSHdpAntjdgOjHGCJnoHgxjJ { get => default; }
			object psCCRGKsjuCJgdrtglKOAZgncho { get => default; }
	
			// Constructors
			internal gAJClBheeuqAESMTRycXWpealIw(AList<T> list) : this() {
				this.list = default;
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
		public AList() {}
		public AList(int startingCapacity) {}
		public AList(int startingCapacity, int maxCapacity, int expansionIncrement) {}
		public AList(IEnumerable<T> collection) {}
		public AList(IEnumerable<T> collection, int maxCapacity, int expansionIncrement) {}
		static AList() {}
	
		// Methods
		public int Add(T item) => default;
		public bool Insert(int index, T item) => default;
		public bool Remove(T item) => default;
		public void RemoveAt(int index) {}
		public bool Contains(T item) => default;
		public bool Contains(T item, IEqualityComparer<T> comparer) => default;
		public int IndexOf(T item) => default;
		public int IndexOf(T item, IEqualityComparer<T> comparer) => default;
		public void Sort(IComparer<T> comparer) {}
		public void Sort(int index, int count, IComparer<T> comparer) {}
		public int FindIndex(Predicate<T> match) => default;
		public int FindIndex(int startIndex, int count, Predicate<T> match) => default;
		public int RemoveAll(Predicate<T> match) => default;
		public void Clear() {}
		private int SniZSVpzAYoPXCBrNHmVlaTrkAj(int param_00009058, bool param_00009059 = false /* Metadata: 0x00AC4EE2 */) => default;
		private int KQpoEMvtfaSVAMYrKZZjfhmDHIm(int param_0000905a, int param_0000905b) => default;
		private bool SSgoHVLKmdbMSiSYImMBoZFCtiP(int param_0000905c, bool param_0000905d = false /* Metadata: 0x00AC4EE3 */) => default;
		void IList<T>.Insert(int index, T item) {}
		void ICollection<T>.Add(T item) {}
		void ICollection<T>.CopyTo(T[] array, int arrayIndex) {}
		void ICollection.CopyTo(Array array, int index) {}
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		int IList.Add(object value) => default;
		bool IList.Contains(object value) => default;
		int IList.IndexOf(object value) => default;
		void IList.Insert(int index, object value) {}
		void IList.Remove(object value) {}
		private static bool ioRSOGmOmZQLbrcHvdUuCjsSYByk(object param_0000906e) => default;
	}
}
