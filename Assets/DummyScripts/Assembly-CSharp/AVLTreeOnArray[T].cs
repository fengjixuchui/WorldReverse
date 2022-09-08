/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AVLTreeOnArray<T> : AVLTreeOnArray // TypeDefIndex: 11041
	where T : struct
{
	// Fields
	private readonly IComparer<T> _comparer;
	private Node[] _nodes;

	// Nested types
	private struct Node // TypeDefIndex: 11042
	{
		// Fields
		public T value;
		public int depth;
		public int parent;
		public int leftChild;
		public int rightChild;

		// Methods
		public void Clear() {}
		public override string ToString() => default;
	}

	// Constructors
	public AVLTreeOnArray() {} // Dummy constructor
	public AVLTreeOnArray(int capacity, IComparer<T> comparer) {}
	public AVLTreeOnArray(int capacity) {}

	// Methods
	public bool Insert(T value) => default;
	public bool Remove(T value) => default;
	public bool Contains(T value) => default;
	public T[] GetValues() => default;
	public void CopyValuesTo(T[] array, int index) {}
	public T GetMaximum() => default;
	public T GetMinimum() => default;
	public T GetMaximumNoGreaterThan(T reference) => default;
	public T GetMinimumNoLessThan(T reference) => default;
	public bool FindMinimumThat(ICriterion<T> criterion, out T value) {
		value = default;
		return default;
	}
	public bool FindMaximumThat(ICriterion<T> criterion, out T value) {
		value = default;
		return default;
	}
	public bool Find(ICriterion<T> criterion, out T value) {
		value = default;
		return default;
	}
	public void GetDataInBetween(T min, T max, ICollection<T> collection) {}
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
	private int Locate(int index, T value) => default;
	private int GetParentIndexToInsertNew(int entry, T value, out bool insertLeftChild) {
		insertLeftChild = default;
		return default;
	}
	private int FindMaximumNoGreaterThan(int index, T value) => default;
	private int FindMinimumNoLessThan(int index, T value) => default;
	private int FindMinimumWithCriterion(int index, ICriterion<T> criterion) => default;
	private int FindMaximumWithCriterion(int index, ICriterion<T> criterion) => default;
	private int FindWithCriterion(int index, ICriterion<T> criterion) => default;
	private void GetDataInTreeNoGreaterThan(int index, T criterion, ICollection<T> collection) {}
	private bool GetByIndex(int index, out T value) {
		value = default;
		return default;
	}
	private int CopyValuesToArray(T[] array, int destinationIndex, int nodeIndex) => default;
	private int Allocate(T value) => default;
}

