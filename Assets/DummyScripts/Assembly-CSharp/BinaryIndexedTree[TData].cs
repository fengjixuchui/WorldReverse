/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BinaryIndexedTree<TData> // TypeDefIndex: 11035
{
	// Fields
	private TData[] m_values;
	private AddAssignment _addAssign;
	private GetZero _zero;
	private int m_range;

	// Nested types
	public delegate void AddAssignment(ref TData a, TData b); // TypeDefIndex: 11036; 0x00000000-0x00000000

	public delegate TData GetZero(); // TypeDefIndex: 11037; 0x00000000-0x00000000

	// Constructors
	public BinaryIndexedTree() {} // Dummy constructor
	public BinaryIndexedTree(int range, GetZero getZeroValue, AddAssignment addAssignOperation) {}

	// Methods
	public void Clear() {}
	public TData QuerySumValue(int index) => default;
	public void UpdateValue(int index, TData value) {}
}

