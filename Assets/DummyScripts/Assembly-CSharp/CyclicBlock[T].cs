/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CyclicBlock<T> : CyclicBlock // TypeDefIndex: 11060
{
	// Fields
	private readonly OutflowDataBehaviour _dataBehaviour;
	private readonly OutflowDebugBehaviour _debugBehaviour;
	private readonly double _expandFactor;
	private T[] _array;
	private int _offset;
	private int _count;

	// Properties
	public int capacity { get => default; }
	public int count { get => default; }
	public bool empty { get => default; }
	public bool full { get => default; }
	public T this[int index] { get => default; set {} }
	public T first { get => default; }
	public T last { get => default; }

	// Nested types
	private static class Texts // TypeDefIndex: 11061
	{
		// Fields
		public const string OVERFLOW_MESSAGE = "Buffer overflow."; // Metadata: 0x00AE8B60
		public const string UNDERFLOW_MESSAGE = "Buffer underflow."; // Metadata: 0x00AE8B74
		private const string MESSAGE_STEM_BEGIN = "Buffer "; // Metadata: 0x00AE8B89
		private const string MESSAGE_STEM_END = "flow."; // Metadata: 0x00AE8B94
	}

	// Constructors
	public CyclicBlock() {} // Dummy constructor
	public CyclicBlock(int capacity, OutflowDataBehaviour outflowDataBehaviour, OutflowDebugBehaviour outflowDebugBehaviour, double expandFactor) {}
	public CyclicBlock(int capacity) {}

	// Methods
	public bool AddFirst(T item) => default;
	public bool AddLast(T item) => default;
	public bool RemoveFirst() => default;
	public bool RemoveLast() => default;
	public void DebugInspect() {}
	private int OffsetIndex(int index) => default;
	private bool BreakEmpty(T item) => default;
	private void DebugReactOnOutflow(bool isOverflow) {}
	private T[] AllocExpandedArray() => default;
}

