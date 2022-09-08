/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AVLTreeOnArray<TKey, TData> : AVLTreeOnArray // TypeDefIndex: 11039
	where TKey : struct
	where TData : struct
{
	// Fields
	private readonly IComparer<TKey> _keyComparer;
	private Node[] _nodes;

	// Nested types
	private struct Node // TypeDefIndex: 11040
	{
		// Fields
		public TKey key;
		public TData data;
		public int depth;
		public int parent;
		public int leftChild;
		public int rightChild;

		// Methods
		public void Clear() {}
	}

	// Constructors
	public AVLTreeOnArray() {} // Dummy constructor
	public AVLTreeOnArray(int capacity, IComparer<TKey> keyComparer) {}
	public AVLTreeOnArray(int capacity) {}

	// Methods
	public bool Insert(TKey key, TData data) => default;
	public bool Remove(TKey key) => default;
	public bool ContainsKey(TKey key) => default;
	public bool TryGetData(TKey key, out TData data) {
		data = default;
		return default;
	}
	public bool UpdateData(TKey key, TData data) => default;
	public TKey[] GetKeys() => default;
	public TData[] GetData() => default;
	public void CopyKeysTo(TKey[] array, int index) {}
	public void CopyDataTo(TData[] array, int index) {}
	public void GetMaximum(out TKey key, out TData data) {
		key = default;
		data = default;
	}
	public void GetMinimum(out TKey key, out TData data) {
		key = default;
		data = default;
	}
	public bool GetMaximumNoGreaterThan(TKey reference, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	public bool GetMinimumNoLessThan(TKey reference, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	public bool FindMinimumThat(ICriterion<TKey, TData> criterion, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	public bool FindMaximumThat(ICriterion<TKey, TData> criterion, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	public bool Find(ICriterion<TKey, TData> criterion, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	public void GetDataInBetween(TKey min, TKey max, ICollection<TData> collection) {}
	protected override void Clear(int index) {}
	protected override int GetNodeArrayLength() => default;
	protected override int ReadParent(int index) => default;
	protected override int ReadDepth(int index) => default;
	protected override int ReadLeftChild(int index) => default;
	protected override int ReadRightChild(int index) => default;
	protected override void WriteParent(int index, int parent) {}
	protected override void WriteDepth(int index, int depth) {}
	protected override void WriteLeftChild(int index, int leftChild) {}
	protected override void WriteRightChild(int index, int rightChild) {}
	protected override void Expand(int horizon) {}
	protected override void SwapValues(int lhs, int rhs) {}
	protected override void Move(int from, int to) {}
	private int Locate(int index, TKey key) => default;
	private int GetParentIndexToInsertNew(int entry, TKey key, out bool insertLeftChild) {
		insertLeftChild = default;
		return default;
	}
	private int FindMaximumNoGreaterThan(int index, TKey key) => default;
	private int FindMinimumNoLessThan(int index, TKey key) => default;
	private int FindMinimumWithCriterion(int index, ICriterion<TKey, TData> criterion) => default;
	private int FindMaximumWithCriterion(int index, ICriterion<TKey, TData> criterion) => default;
	private int FindWithCriterion(int index, ICriterion<TKey, TData> criterion) => default;
	private void GetDataInTreeNoGreaterThan(int index, TKey criterion, ICollection<TData> collection) {}
	private bool GetByIndex(int index, out TKey key, out TData data) {
		key = default;
		data = default;
		return default;
	}
	private int CopyKeysToArray(TKey[] array, int destinationIndex, int nodeIndex) => default;
	private int CopyDataToArray(TData[] array, int destinationIndex, int nodeIndex) => default;
	private int Allocate(TKey key, TData data) => default;
}

