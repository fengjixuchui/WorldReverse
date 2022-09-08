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

public sealed class RepeatedMessageField<T> : RepeatedField<T>, IDeepCloneable<RepeatedMessageField<T>> // TypeDefIndex: 26311
	where T : MessageBase, IDeepCloneable<T>
{
	// Fields
	private List<T> values;

	// Properties
	public override T this[int index] { get => default; set {} }
	public override int Count { get => default; }
	public override bool IsReadOnly { get => default; }

	// Constructors
	public RepeatedMessageField() {}

	// Methods
	public void CopyFrom(RepeatedMessageField<T> other) {}
	public RepeatedMessageField<T> Clone() => default;
	public RepeatedMessageField<T> ShallowCopy(MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00B0BDCB */) => default;
	public void AddReferenceMask(MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00B0BDCF */) {}
	public void DeleteReferenceMask(MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00B0BDD3 */) {}
	public override void Add(T item) {}
	public override void AddRange(IEnumerable<T> values) {}
	public override void Clear() {}
	public override void Reset() {}
	public override bool Contains(T item) => default;
	public override void CopyTo(T[] array, int arrayIndex) {}
	[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
	public override IEnumerator<T> GetEnumerator() => default;
	public override int IndexOf(T item) => default;
	public override void Insert(int index, T item) {}
	public override bool Remove(T item) => default;
	public override void RemoveAt(int index) {}
	public void WriteTo(CodedOutputStream output, FieldCodec<T> codec) {}
	public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec) {}
	public int CalculateSize(FieldCodec<T> codec) => default;
	private int CalculatePackedDataSize(FieldCodec<T> codec) => default;
	public override void CopyTo(Array array, int index) {}
}

