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

public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, IEquatable<MapField<TKey, TValue>>, IDictionary // TypeDefIndex: 26301
{
	// Fields
	private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;
	private readonly LinkedList<KeyValuePair<TKey, TValue>> list;

	// Properties
	bool IsFixedSize { get => default; }
	ICollection Keys { get => default; }
	ICollection Values { get => default; }
	bool IsSynchronized { get => default; }
	object SyncRoot { get => default; }
	object this[object key] { get => default; set {} }
	public TValue this[TKey key] { get => default; set {} }
	public ICollection<TKey> Keys { get => default; }
	public ICollection<TValue> Values { get => default; }
	public int Count { get => default; }
	public bool IsReadOnly { get => default; }

	// Nested types
	private class DictionaryEnumerator : IDictionaryEnumerator // TypeDefIndex: 26302
	{
		// Fields
		private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

		// Properties
		public object Current { get => default; }
		public DictionaryEntry Entry { get => default; }
		public object Key { get => default; }
		public object Value { get => default; }

		// Constructors
		public DictionaryEnumerator() {} // Dummy constructor
		internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator) {}

		// Methods
		public bool MoveNext() => default;
		public void Reset() {}
	}

	public sealed class Codec // TypeDefIndex: 26303
	{
		// Fields
		private readonly FieldCodec<TKey> keyCodec;
		private readonly FieldCodec<TValue> valueCodec;
		private readonly uint mapTag;

		// Properties
		internal uint MapTag { get => default; }

		// Nested types
		internal class MessageAdapter : MessageBase // TypeDefIndex: 26304
		{
			// Fields
			private static readonly byte[] ZeroLengthMessageStreamData;
			private readonly Codec<TKey, TValue> codec;

			// Properties
			internal TKey Key { get; set; }
			internal TValue Value { get; set; }
			public override MessageDescriptor Descriptor { get => default; }
			public override string ClassName { get => default; }
			public override string FullClassName { get => default; }
			public override ushort CmdId { get => default; }

			// Constructors
			public MessageAdapter() {} // Dummy constructor
			internal MessageAdapter(Codec<TKey, TValue> codec) {}
			static MessageAdapter() {}

			// Methods
			public override void Reset() {}
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {}
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {}
			public override void MergeFrom(CodedInputStream input) {}
			public override void WriteTo(CodedOutputStream output) {}
			public override int CalculateSize() => default;
			protected override void InternalSetInPool(bool value) {}
		}

		// Constructors
		public Codec() {} // Dummy constructor
		public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag) {}
	}

	private class MapView<T> : ICollection<T>, ICollection // TypeDefIndex: 26305
	{
		// Fields
		private readonly MapField<TKey, TValue> parent;
		private readonly Func<KeyValuePair<TKey, TValue>, T> projection;
		private readonly Func<T, bool> containsCheck;

		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public bool IsSynchronized { get => default; }
		public object SyncRoot { get => default; }

		// Constructors
		public MapView() {} // Dummy constructor
		internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck) {}

		// Methods
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public IEnumerator<T> GetEnumerator() => default;
		public bool Remove(T item) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public void CopyTo(Array array, int index) {}
	}

	// Constructors
	public MapField() {}

	// Methods
	public MapField<TKey, TValue> Clone() => default;
	public void Add(TKey key, TValue value) {}
	public bool ContainsKey(TKey key) => default;
	private bool ContainsValue(TValue value) => default;
	public bool Remove(TKey key) => default;
	public bool TryGetValue(TKey key, out TValue value) {
		value = default;
		return default;
	}
	public void Add(IDictionary<TKey, TValue> entries) {}
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
	IEnumerator IEnumerable.GetEnumerator() => default;
	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) {}
	public void Clear() {}
	public void Reset() {}
	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => default;
	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) {}
	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => default;
	public override bool Equals(object other) => default;
	public override int GetHashCode() => default;
	public bool Equals(MapField<TKey, TValue> other) => default;
	public void AddEntriesFrom(CodedInputStream input, Codec codec) {}
	public void WriteTo(CodedOutputStream output, Codec codec) {}
	public int CalculateSize(Codec codec) => default;
	public override string ToString() => default;
	void IDictionary.Add(object key, object value) {}
	bool IDictionary.Contains(object key) => default;
	IDictionaryEnumerator IDictionary.GetEnumerator() => default;
	void IDictionary.Remove(object key) {}
	void ICollection.CopyTo(Array array, int index) {}
}

