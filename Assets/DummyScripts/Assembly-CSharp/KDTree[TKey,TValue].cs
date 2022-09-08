/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class KDTree<TKey, TValue> // TypeDefIndex: 20954
{
	// Fields
	public const int KDTREE_NODE_NUM = 4; // Metadata: 0x00AFE6E4
	private const int DEFAULT_DIMENSION = -1; // Metadata: 0x00AFE6E8
	private const float TREE_MIN_BOUNDS = -10000f; // Metadata: 0x00AFE6EC
	private const float TREE_MAX_BOUNDS = 10000f; // Metadata: 0x00AFE6F0
	private readonly IKeyExtractor _keyExtractor;
	private readonly INodeExtractor _nodeExtractor;
	public KDTreeNode _root;

	// Nested types
	public interface INodeExtractor // TypeDefIndex: 20955
	{
		// Methods
		int MaxDimensionNum();
		float GetDimension(TKey key, int dim);
		TKey SetDimension(TKey key, int dim, float value);
		bool ContainValue(TKey min, TKey max, TValue pos);
	}

	public interface IKeyExtractor // TypeDefIndex: 20956
	{
		// Methods
		TKey ExtractKey(TValue data);
	}

	public delegate float GetDimensionDelegate(TValue value, int dim); // TypeDefIndex: 20957; 0x00000000-0x00000000

	public class KDTreeNode // TypeDefIndex: 20958
	{
		// Fields
		public int splitDimension;
		public float splitPos;
		public TValue[] valueList;
		private int curCount;
		public TKey minPos;
		public TKey maxPos;
		public KDTreeNode<TKey, TValue> parentNode;
		public KDTreeNode<TKey, TValue> leftNode;
		public KDTreeNode<TKey, TValue> rightNode;

		// Constructors
		public KDTreeNode() {}

		// Methods
		public void ReplaceNode(KDTreeNode<TKey, TValue> node1, KDTreeNode<TKey, TValue> node2) {}
		public KDTreeNode<TKey, TValue> GetBrotherNode() => default;
		public bool IsLeaf() => default;
		public void AddValue(TValue value) {}
		public void RemoveValue(TValue value) {}
		public void MergeList(TValue[] lst, int begin, int count) {}
		public void PrintList(GetDimensionDelegate<TKey, TValue> getDim) {}
		public int SortList(GetDimensionDelegate<TKey, TValue> getDim) => default;
		public void ClearList() {}
		public int ListCount() => default;
		public void ResetToLeaf() {}
		public void Reset() {}
	}

	// Constructors
	public KDTree() {} // Dummy constructor
	public KDTree(IKeyExtractor keyExtractor, INodeExtractor nodeExtractor) {}

	// Methods
	private void InitRoot() {}
	public KDTreeNode AllocateNode() => default;
	public void DeallocateNode(KDTreeNode node) {}
	public void Add(TValue value) {}
	public void AddNode(KDTreeNode node, TValue value) {}
	protected float GetDimension(TValue value, int dim) => default;
	private KDTreeNode GetChildNode(KDTreeNode node, TValue value) => default;
	private void CombineNode(KDTreeNode node) {}
	public void RemoveNode(KDTreeNode node, TValue value) {}
	public void RemoveNodeAndParent(KDTreeNode node) {}
	public void Remove(TValue node) {}
	public void Clear() {}
	public void ClearNode(KDTreeNode node) {}
	private int ComputeSplitDimension2(KDTreeNode node) => default;
	private int ComputeSplitDimension(KDTreeNode node) => default;
	private void SplitNode(KDTreeNode node) {}
	public int RangeQuery(TKey inputMin, TKey inputMax, TValue[] collection, int colLen) => default;
}

