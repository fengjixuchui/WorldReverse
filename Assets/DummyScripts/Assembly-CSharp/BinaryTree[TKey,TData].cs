/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BinaryTree<TKey, TData> // TypeDefIndex: 11043
{
	// Fields
	private readonly IComparer<TKey> _keyComparer;
	private Node _rootNode;

	// Nested types
	public interface IZOrderSearch // TypeDefIndex: 11044
	{
		// Methods
		void cutRange(TKey p, out TKey litmax, out TKey bitmin);
		bool testInRange(TKey p);
		void SetMinMax(TKey min, TKey max);
	}

	private class Node // TypeDefIndex: 11045
	{
		// Fields
		public TKey key;
		public TData data;
		public int depth;
		public Node<TKey, TData> parent;
		public Node<TKey, TData> leftChild;
		public Node<TKey, TData> rightChild;

		// Properties
		public bool isLeftChild { get => default; }
		public bool isRightChild { get => default; }
		public int leftChildDepth { get => default; }
		public int rightChildDepth { get => default; }

		// Constructors
		public Node() {}

		// Methods
		public static void SwapValues(Node<TKey, TData> lhs, Node<TKey, TData> rhs) {}
		public void UpdateDepth() {}
		public void SetLeftChild(Node<TKey, TData> child) {}
		public void SetRigthChild(Node<TKey, TData> child) {}
		public void ReleaseLeftChild() {}
		public void ReleaseRightChild() {}
		public Node<TKey, TData> GetSibling() => default;
		public void DetachFromParent() {}
		public void Clear() {}
		public int CalcBalanceFactor() => default;
	}

	// Constructors
	public BinaryTree(IComparer<TKey> keyComparer) {}
	public BinaryTree() {}

	// Methods
	public bool Insert(TKey key, TData data) => default;
	public bool Remove(TKey key) => default;
	public void Clear() {}
	public bool ContainsKey(TKey key) => default;
	public bool TryGetData(TKey key, out TData data) {
		data = default;
		return default;
	}
	public bool UpdateData(TKey key, TData data) => default;
	public void GetDataInBetween(TKey min, TKey max, ICollection<TData> collection) {}
	public void GetZOrderRange(TKey min, TKey max, ICollection<TData> collection, IZOrderSearch zorderSearch) {}
	private void _InnerGetZorderRangeSearch(Node cur, TKey min, TKey max, ICollection<TData> collection, IZOrderSearch zorderSearch) {}
	private Node LocateNode(Node entry, TKey key) => default;
	private bool TryGetData(Node entry, TKey key, out TData data) {
		data = default;
		return default;
	}
	private Node GetParentNodeToInsertNew(Node entry, TKey key, out bool insertLeftChild) {
		insertLeftChild = default;
		return default;
	}
	private void Rebalance(Node node) {}
	private void RotateLeft(Node node) {}
	private void RotateRight(Node node) {}
	private void RotateRightThenLeft(Node node) {}
	private void RotateLeftThenRight(Node node) {}
	private void RelocateRootNode() {}
	private Node FindMinimum(Node node) => default;
	private Node FindMaximum(Node node) => default;
	private Node FindMinimumNoLessThan(Node node, TKey key) => default;
	private void GetDataInTreeNoGreaterThan(Node node, TKey criterion, ICollection<TData> collection) {}
	private void Clear(Node node) {}
	private Node AllocateNode(TKey key, TData data) => default;
	private void DeallocateNode(Node node) {}
}

