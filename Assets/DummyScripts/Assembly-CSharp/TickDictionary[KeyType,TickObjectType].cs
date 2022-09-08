/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TickDictionary<KeyType, TickObjectType> // TypeDefIndex: 14449
	where TickObjectType : ITickableObject<KeyType>
{
	// Fields
	private List<TickObjectType> _tickObjList;
	private Dictionary<KeyType, TickObjectType> _tickObjDic;
	private int _count;

	// Properties
	public int count { get => default; }
	public TickObjectType this[int index] { get => default; }

	// Constructors
	public TickDictionary() {}

	// Methods
	public static TickDictionary<KeyType, TickObjectInnerType> Create<TickObjectInnerType>()
		where TickObjectInnerType : ITickableObject<KeyType> => default;
	public bool Has(KeyType key) => default;
	public void Add(TickObjectType obj) {}
	public void Remove(TickObjectType obj) {}
	public int Remove(int index) => default;
	public int Remove(KeyType key) => default;
	public TickObjectType Get(KeyType key) => default;
	public void Clear() {}
}

