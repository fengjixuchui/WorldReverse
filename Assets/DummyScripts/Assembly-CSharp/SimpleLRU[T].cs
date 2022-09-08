/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SimpleLRU<T> // TypeDefIndex: 31408
	where T : class
{
	// Fields
	private T[] _arr;
	public int count;

	// Properties
	public T this[int ix] { get => default; }

	// Constructors
	public SimpleLRU() {} // Dummy constructor
	public SimpleLRU(int count) {}

	// Methods
	public void AddCapacity() {}
	public void Touch(T entry, out T outdated) {
		outdated = default;
	}
	public void Clear() {}
	public void RemoveEntry(T entry) {}
	public void MarkClear(int ix) {}
	public void Rebuild() {}
}

