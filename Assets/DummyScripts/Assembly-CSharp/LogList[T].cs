/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class LogList<T> : IComparable // TypeDefIndex: 27847
{
	// Fields
	protected List<T> _data;
	private string _cacheString;

	// Properties
	public int Count { get; }

	// Constructors
	protected LogList() {}

	// Methods
	public abstract string ElementToString(int eleIdx);
	public void Add(T inValue) {}
	public void GenerateCacheString() {}
	public override string ToString() => default;
	protected abstract int InternalCompareTo(object obj);
	public int CompareTo(object obj) => default;
}

