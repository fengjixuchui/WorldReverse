/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class FixedStack<T> : IDisposable // TypeDefIndex: 31403
{
	// Fields
	protected T[] _stack;
	protected bool[] _occupied;
	protected bool _useTag;
	protected FixedStackTag[] _tags;
	protected int _pushTop;
	protected int _realTop;
	public Action<T, int, T, int> onChanged;
	protected bool _checkAnyValueChange;
	protected const int DEFAULT_CAPACITY = 6; // Metadata: 0x00B1267C

	// Properties
	public int capacity { get => default; }
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public virtual T value { get => default; }

	// Constructors
	public FixedStack() {} // Dummy constructor
	public FixedStack(int capacity, bool useTag = false /* Metadata: 0x00B12661 */, Action<T, int, T, int> onChanged = null) {}

	// Methods
	public static FixedStack<T> CreateDefault(T initValue, bool useTag = false /* Metadata: 0x00B12662 */, Action<T, int, T, int> onChanged = null) => default;
	public virtual void Reinit() {}
	protected virtual void OnChanged(T oldValue, int oldStackIx, T newValue, int newStackIx) {}
	public void Reserve(int capacity) {}
	private void SeekPushPos(int startAt = 0 /* Metadata: 0x00B12663 */) {}
	private void SeekRealTop(bool silent = false /* Metadata: 0x00B12667 */) {}
	public virtual int Push(T value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B12668 */, bool silent = false /* Metadata: 0x00B1266C */) => default;
	public virtual void Push(int ix, T value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B1266D */, bool silent = false /* Metadata: 0x00B12671 */) {}
	public int PushAbove(int aboveIx, T value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B12672 */, bool silent = false /* Metadata: 0x00B12676 */) => default;
	public void TryPop(int ix) {}
	public void Pop(int ix) {}
	protected void Set(int ix, T value, FixedStackTag tag = FixedStackTag.NoTag /* Metadata: 0x00B12677 */, bool silent = false /* Metadata: 0x00B1267B */) {}
	public T Get(int ix) => default;
	public bool IsOccupied(int ix) => default;
	public int GetRealTopIndex() => default;
	public void Dispose() {}
}

