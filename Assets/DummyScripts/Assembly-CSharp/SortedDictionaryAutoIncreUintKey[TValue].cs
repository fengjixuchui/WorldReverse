/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SortedDictionaryAutoIncreUintKey<TValue> : SortedDictionary<uint, TValue> // TypeDefIndex: 31979
{
	// Fields
	private uint _nextAddKey;

	// Constructors
	public SortedDictionaryAutoIncreUintKey() {}

	// Methods
	public uint GetNextMaxKey() => default;
	public void AddCustom(uint key, TValue value) {}
	public void ClearCustom() {}
	public List<uint> DumpKeys() => default;
	public List<TValue> DumpValues() => default;
}

