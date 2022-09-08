/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Discretization<TData> // TypeDefIndex: 11062
{
	// Fields
	private TData[] m_array;
	private IComparer<TData> _comparer;
	private int m_length;

	// Properties
	public int Length { get => default; }

	// Constructors
	public Discretization() {} // Dummy constructor
	public Discretization(TData[] values, IComparer<TData> keyComparer = null) {}

	// Methods
	public int GetFirstNoSmallerIndex(TData value) => default;
	public int GetMaxNoBiggerIndex(TData value) => default;
}

