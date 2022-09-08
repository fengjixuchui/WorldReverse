/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	internal class DenseHashTable<TKey, TValue> // TypeDefIndex: 10517
	{
		// Fields
		private const float HT_OCCUPANCY_FLT = 0.8f; // Metadata: 0x00AE76B5
		private const float HT_EMPTY_FLT = 0.32000002f; // Metadata: 0x00AE76B9
		private const int HT_MIN_BUCKETS = 32; // Metadata: 0x00AE76BD
		private const int MAX_SIZE = 0; // Metadata: 0x00AE76C1
		private const int ILLEGAL_BUCKET = -1; // Metadata: 0x00AE76C5
		private IDenseHashTableKey<TKey, TValue> _key;
		private IDenseHashTableHashCode<TKey> _hashCode;
		private IDenseHashTableComparer<TKey> _comparer;
		private TValue[] _valueSet;
		private TValue _emptyValue;
		private TValue _deletedValue;
		private int _numBuckets;
		private int _numElements;
		private int _numDeleted;
		private int _capacity;
		private int _shrinkThreshold;
		private int _enlargeThreshold;
		private bool _considerShrink;
	
		// Properties
		public int Size { get => default; }
		public bool Empty { get => default; }
		public int BucketCount { get => default; }
		public int MaxBucketCount { get => default; }
		public Iterator Begin { get => default; }
		public Iterator End { get => default; }
		public Iterator Enumerator { get => default; }
		public TValue EmptyValue { get => default; }
	
		// Nested types
		public struct Iterator // TypeDefIndex: 10518
		{
			// Fields
			private DenseHashTable<TKey, TValue> _ht;
			private int _start;
			private int _pos;
			private int _end;
	
			// Properties
			public bool Valid { get => default; }
			public TValue Value { get => default; }
	
			// Constructors
			public Iterator(DenseHashTable<TKey, TValue> h, int start, int end, bool advance) : this() {
				_ht = default;
				_start = default;
				_pos = default;
				_end = default;
			}
	
			// Methods
			public void Reset() {}
			public override bool Equals(object obj) => default;
			public override int GetHashCode() => default;
			private void AdvancePast() {}
			public static explicit operator int(Iterator<TKey, TValue> it) => default;
			public static Iterator<TKey, TValue> operator ++(Iterator<TKey, TValue> it) => default;
			public static bool operator ==(Iterator<TKey, TValue> left, Iterator<TKey, TValue> right) => default;
			public static bool operator !=(Iterator<TKey, TValue> left, Iterator<TKey, TValue> right) => default;
		}
	
		// Constructors
		public DenseHashTable() {} // Dummy constructor
		public DenseHashTable(TValue emptyValue, TValue deletedValue, IDenseHashTableKey<TKey, TValue> keyGetter, int n = 0 /* Metadata: 0x00AE76A9 */) {}
		public DenseHashTable(TValue emptyValue, TValue deletedValue, IDenseHashTableKey<TKey, TValue> keyGetter, IDenseHashTableHashCode<TKey> hashCodeGetter, IDenseHashTableComparer<TKey> comparer, int n = 0 /* Metadata: 0x00AE76AD */) {}
	
		// Methods
		private static uint Jump(uint numProbes) => default;
		public void Resize(int req_elements) {}
		public void Clear(bool resize) {}
		public Iterator Find(ref TKey key) => default;
		public TValue GetValue(ref Iterator it) => default;
		public void SetValue(ref Iterator it, ref TValue obj) {}
		public bool FindOrInsert(ref TValue obj, out Iterator it) {
			it = default;
			return default;
		}
		public bool Insert(ref TValue obj) => default;
		public int Erase(ref TKey key) => default;
		private long FindResult(int first, int second) => default;
		private int FindFirst(long result) => default;
		private int FindSecond(long result) => default;
		private bool CheckEmpty(ref Iterator it) => default;
		private bool CheckEmpty(int bucknum) => default;
		private bool CheckEmpty(ref TValue value) => default;
		private bool CheckDeleted(ref Iterator it) => default;
		private bool CheckDeleted(int bucknum) => default;
		private bool CheckDeleted(ref TValue value) => default;
		private bool CompareKey(ref TKey key1, ref TKey key2) => default;
		private bool CompareValue(ref TValue value1, ref TValue value2) => default;
		private void ResetThresholds() {}
		private uint GetHashCode(ref TValue value) => default;
		private TValue GetValue(int pos) => default;
		private void SetValue(int pos, ref TValue obj) {}
		private void SetEmpty(int bucknum) {}
		private void SetEmpty(ref Iterator it) {}
		private void SetDeleted(int bucknum) {}
		private void SetDeleted(ref Iterator it) {}
		private void SetEmptyRange(int start, int end) {}
		private int MinSize(int num_elts, int min_buckets_wanted) => default;
		private bool MaybeShrink() => default;
		private bool ResizeDelta(int delta, int min_buckets_wanted = 0 /* Metadata: 0x00AE76B1 */) => default;
		private void ExpandArray(int resize_to) {}
		private long FindPosition(ref TKey key, uint hash) => default;
		private long FindPosition(ref TKey key) => default;
		private bool InsertNoResize(ref TValue obj) => default;
	}
}
