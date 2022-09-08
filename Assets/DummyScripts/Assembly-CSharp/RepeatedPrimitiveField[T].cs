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

public sealed class RepeatedPrimitiveField<T> : RepeatedField<T>, IList, IEquatable<RepeatedPrimitiveField<T>>, IDeepCloneable<RepeatedPrimitiveField<T>> // TypeDefIndex: 26309
{
	// Fields
	private static readonly T[] EmptyArray;
	private const int MinArraySize = 8; // Metadata: 0x00B0BDC7
	private T[] array;
	private int count;

	// Properties
	public override int Count { get => default; }
	public override bool IsReadOnly { get => default; }
	public override T this[int index] { get => default; set {} }

	// Constructors
	public RepeatedPrimitiveField() {}
	static RepeatedPrimitiveField() {}

	// Methods
	public RepeatedPrimitiveField<T> Clone() => default;
	public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec) {}
	public int CalculateSize(FieldCodec<T> codec) => default;
	private int CalculatePackedDataSize(FieldCodec<T> codec) => default;
	public void WriteTo(CodedOutputStream output, FieldCodec<T> codec) {}
	private void EnsureSize(int size) {}
	public override void Add(T item) {}
	public override void Clear() {}
	public override void Reset() {}
	public override bool Contains(T item) => default;
	public override void CopyTo(T[] array, int arrayIndex) {}
	public override void CopyTo(Array array, int index) {}
	public override bool Remove(T item) => default;
	public override void AddRange(IEnumerable<T> values) {}
	public void Add(IEnumerable<T> values) {}
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	public override IEnumerator<T> GetEnumerator() => default;
	public override bool Equals(object obj) => default;
	public override int GetHashCode() => default;
	public bool Equals(RepeatedPrimitiveField<T> other) => default;
	public override int IndexOf(T item) => default;
	public override void Insert(int index, T item) {}
	public override void RemoveAt(int index) {}
}

