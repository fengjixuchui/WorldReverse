/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class LateTickList<T> // TypeDefIndex: 14443
	where T : class, ILateTickable
{
	// Fields
	private HashList<T> _list;
	private List<T> _toAdd;
	private List<T> _toRemove;

	// Constructors
	public LateTickList() {}

	// Methods
	public void Destroy() {}
	public void LateTick(float deltaTime) {}
	public void Add(T item) {}
	public void Remove(T item) {}
}

