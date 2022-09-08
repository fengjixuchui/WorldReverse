/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

// [DebuggerDisplay] // 0x0000000189B2D5C0-0x0000000189B2D5F0
public sealed class PacketQueue<T> // TypeDefIndex: 31804
{
	// Fields
	private T[] m_items;
	private readonly ReaderWriterLockSlim m_lock;
	private int m_size;
	private int m_head;

	// Properties
	public int Count { get => default; }
	public int Capacity { get => default; }

	// Constructors
	public PacketQueue() {} // Dummy constructor
	public PacketQueue(int initialCapacity) {}

	// Methods
	public void Enqueue(T item) {}
	public void Enqueue(IEnumerable<T> items) {}
	public void EnqueueFirst(T item) {}
	private void SetCapacity(int newCapacity) {}
	public bool TryDequeue(out T item) {
		item = default;
		return default;
	}
	public int TryDrain(IList<T> addTo) => default;
	public T TryPeek(int offset) => default;
	public bool Contains(T item) => default;
	public T[] ToArray() => default;
	public void Clear() {}
}

