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
using MiHoYo.SDK.Protobuf;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Collections
{
	public sealed class RepeatedField<T> : IList<T>, IList, MiHoYo.SDK.Protobuf.IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>> // TypeDefIndex: 5226
	{
		// Fields
		private static readonly T[] EmptyArray;
		private T[] array;
		private int count;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
		public T this[int index] { get => default; set {} }
		bool IList.IsFixedSize { get => default; }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
		object IList.this[int index] { get => default; set {} }
	
		// Constructors
		public RepeatedField() {}
		static RepeatedField() {}
	
		// Methods
		public RepeatedField<T> Clone() => default;
		public void AddEntriesFrom(MiHoYo.SDK.Protobuf.CodedInputStream input, MiHoYo.SDK.Protobuf.FieldCodec<T> codec) {}
		public int CalculateSize(MiHoYo.SDK.Protobuf.FieldCodec<T> codec) => default;
		private int CalculatePackedDataSize(MiHoYo.SDK.Protobuf.FieldCodec<T> codec) => default;
		public void WriteTo(MiHoYo.SDK.Protobuf.CodedOutputStream output, MiHoYo.SDK.Protobuf.FieldCodec<T> codec) {}
		private void EnsureSize(int size) {}
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public void AddRange(IEnumerable<T> values) {}
		public void Add(IEnumerable<T> values) {}
		public IEnumerator<T> GetEnumerator() => default;
		public override bool Equals(object obj) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public override int GetHashCode() => default;
		public bool Equals(RepeatedField<T> other) => default;
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public override string ToString() => default;
		void ICollection.CopyTo(Array array, int index) {}
		int IList.Add(object value) => default;
		bool IList.Contains(object value) => default;
		int IList.IndexOf(object value) => default;
		void IList.Insert(int index, object value) {}
		void IList.Remove(object value) {}
	}
}
