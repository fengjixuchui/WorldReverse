/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct Slice<T> : IEnumerable<T> // TypeDefIndex: 11026
{
	// Fields
	private const int DEFAULT_CAPACITY = 128; // Metadata: 0x00AE8B34
	private static T[] _underlay;
	private static AVLTreeOnArray<Partition, bool> _partitions;
	private Partition _partition;

	// Properties
	public static Slice<T> empty { get => default; }
	public T this[int index] { get => default; set {} }
	public int offset { get => default; }
	public int length { get => default; }

	// Nested types
	private class ComparisonWrapper : IComparer<T> // TypeDefIndex: 11027
	{
		// Properties
		public Comparison<T> comparison { get; set; }

		// Constructors
		public ComparisonWrapper() {}

		// Methods
		public int Compare(T x, T y) => default;
	}

	public struct Enumerator : IEnumerator<T> // TypeDefIndex: 11028
	{
		// Fields
		private readonly Slice<T> _host;
		private int _index;

		// Properties
		object IEnumerator.Current { get => default; }
		public T Current { get => default; }

		// Constructors
		public Enumerator(Slice<T> host) : this() {
			_host = default;
			_index = default;
		}

		// Methods
		public void Dispose() {}
		public bool MoveNext() => default;
		public void Reset() {}
	}

	private struct Partition // TypeDefIndex: 11029
	{
		// Properties
		public static Partition<T> empty { get => default; }
		public int start { get; set; }
		public int size { get; set; }

		// Methods
		public static void Part(Partition<T> original, int size, out Partition<T> aPart, out Partition<T> bPart) {
			aPart = default;
			bPart = default;
		}
		public static Partition<T> Merge(Partition<T> aPart, Partition<T> bPart) => default;
		public override int GetHashCode() => default;
		public override bool Equals(object obj) => default;
		public override string ToString() => default;
		public static bool operator ==(Partition<T> lhs, Partition<T> rhs) => default;
		public static bool operator !=(Partition<T> lhs, Partition<T> rhs) => default;
	}

	private class PartitionComparer : IComparer<Partition> // TypeDefIndex: 11030
	{
		// Constructors
		public PartitionComparer() {}

		// Methods
		public int Compare(Partition<T> x, Partition<T> y) => default;
	}

	private class PartitionSizeAndAvailabilityCriterion : ICriterion<Partition, bool> // TypeDefIndex: 11031
	{
		// Properties
		public int necessarySize { get; set; }

		// Constructors
		public PartitionSizeAndAvailabilityCriterion() {}

		// Methods
		public bool Match(Partition<T> param1, bool param2) => default;
	}

	private class PartitionEndPositionCriterion : ICriterion<Partition, bool> // TypeDefIndex: 11032
	{
		// Properties
		public int endPosition { get; set; }

		// Constructors
		public PartitionEndPositionCriterion() {}

		// Methods
		public bool Match(Partition<T> param1, bool param2) => default;
	}

	// Constructors
	static Slice() {
		_underlay = default;
		_partitions = default;
	}

	// Methods
	public static int BinarySearch(Slice<T> array, T value) => default;
	public static int BinarySearch(Slice<T> array, T value, IComparer<T> comparer) => default;
	public static int BinarySearch(Slice<T> array, int index, int length, T value) => default;
	public static int BinarySearch(Slice<T> array, int index, int length, T value, IComparer<T> comparer) => default;
	public static void Clear(Slice<T> array, int index, int length) {}
	public static Slice<TOutput> ConvertAll<TInput, TOutput>(Slice<TInput> array, Converter<TInput, TOutput> converter) => default;
	public static void Copy(Slice<T> sourceArray, Slice<T> destinationArray) {}
	public static void Copy(Slice<T> sourceArray, Slice<T> destinationArray, int length) {}
	public static void Copy(Slice<T> sourceArray, int sourceIndex, Slice<T> destinationArray, int destinationIndex, int length) {}
	public static bool Exists(Slice<T> array, Predicate<T> match) => default;
	public static T Find(Slice<T> array, Predicate<T> match) => default;
	public static Slice<T> FindAll(Slice<T> array, Predicate<T> match) => default;
	public static int FindIndex(Slice<T> array, Predicate<T> match) => default;
	public static int FindIndex(Slice<T> array, int startIndex, Predicate<T> match) => default;
	public static int FindIndex(Slice<T> array, int startIndex, int count, Predicate<T> match) => default;
	public static T FindLast(Slice<T> array, Predicate<T> match) => default;
	public static int FindLastIndex(Slice<T> array, Predicate<T> match) => default;
	public static int FindLastIndex(Slice<T> array, int startIndex, Predicate<T> match) => default;
	public static int FindLastIndex(Slice<T> array, int startIndex, int count, Predicate<T> match) => default;
	public static void ForEach(Slice<T> array, Action<T> action) {}
	public static int IndexOf(Slice<T> array, T value) => default;
	public static int IndexOf(Slice<T> array, T value, int startIndex) => default;
	public static int IndexOf(Slice<T> array, T value, int startIndex, int count) => default;
	public static int LastIndexOf(Slice<T> array, T value) => default;
	public static int LastIndexOf(Slice<T> array, T value, int startIndex) => default;
	public static int LastIndexOf(Slice<T> array, T value, int startIndex, int count) => default;
	public static void Resize(ref Slice<T> array, int newSize) {}
	public static void Reverse(Slice<T> array) {}
	public static void Reverse(Slice<T> array, int index, int length) {}
	public static void Sort(Slice<T> array) {}
	public static void Sort(Slice<T> array, Comparison<T> comparison) {}
	public static void Sort(Slice<T> array, IComparer<T> comparer) {}
	public static void Sort(Slice<T> array, int index, int length) {}
	public static void Sort(Slice<T> array, int index, int length, IComparer<T> comparer) {}
	public static bool TrueForAll(Slice<T> array, Predicate<T> match) => default;
	public static void Prepare(int targetCapacity) {}
	public static Slice<T> Request(int length) => default;
	public static void Recycle(Slice<T> slice) {}
	public override bool Equals(object obj) => default;
	public override int GetHashCode() => default;
	public Enumerator GetEnumerator() => default;
	IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	public void CopyTo(T[] array) {}
	public void CopyTo(Slice<T> array) {}
	public void CopyTo(T[] array, int index) {}
	public void CopyTo(Slice<T> array, int index) {}
	public T[] ToArray() => default;
	public override string ToString() => default;
	private static void Boot(int targetCapacity) {}
	private static void Expand(int targetCapacity) {}
	private static void GetLastPartition(out Partition partition, out bool availability) {
		partition = default;
		availability = default;
	}
	public static bool operator ==(Slice<T> lhs, Slice<T> rhs) => default;
	public static bool operator !=(Slice<T> lhs, Slice<T> rhs) => default;
}

