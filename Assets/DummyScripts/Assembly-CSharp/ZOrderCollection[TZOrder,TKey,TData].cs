/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ZOrderCollection<TZOrder, TKey, TData> // TypeDefIndex: 11082
{
	// Fields
	private readonly BinaryTree<TZOrder, TData> _objectTree;
	private readonly IComparer<TZOrder> _zOrderComparer;
	private readonly IZOrderConverter _zOrderConverter;
	private readonly IKeyExtractor _keyExtractor;
	private readonly BinaryTree<TZOrder, TData> _searchFunc;

	// Properties
	public int count { get; private set; }

	// Nested types
	public interface IZOrderConverter // TypeDefIndex: 11083
	{
		// Methods
		TZOrder Convert(TKey key);
	}

	public interface IKeyExtractor // TypeDefIndex: 11084
	{
		// Methods
		TKey ExtractKey(TData data);
	}

	public interface IDataUpdater // TypeDefIndex: 11085
	{
		// Methods
		TData Update(TData previousData);
	}

	// Constructors
	public ZOrderCollection() {} // Dummy constructor
	public ZOrderCollection(IComparer<TZOrder> zOrderComparer, IZOrderConverter zOrderConverter, IKeyExtractor keyExtractor, BinaryTree<TZOrder, TData> searchFunc) {}

	// Methods
	public bool Add(TData data) => default;
	public bool Add(TKey key, TData data) => default;
	public bool Update(TKey previousKey, IDataUpdater updater) => default;
	public bool Remove(TKey key) => default;
	public bool Contains(TKey key) => default;
	public void RangeQuery(TKey kMin, TKey kMax, ICollection<TData> collection) {}
	public void RangeQueryNew(TKey kMin, TKey kMax, ICollection<TData> collection) {}
	public void Clear() {}
	private TZOrder GetZOrder(TKey key) => default;
	private TZOrder GetZOrder(TData data) => default;
}

