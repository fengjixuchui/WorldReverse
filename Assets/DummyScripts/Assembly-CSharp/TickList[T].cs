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

public class TickList<T> // TypeDefIndex: 14452
	where T : class, ITickWithGlobalAndDeltaTime
{
	// Fields
	private HashList<T> _list;
	private List<T> _toAdd;
	private List<T> _toRemove;

	// Constructors
	public TickList() {}

	// Methods
	public void Destroy() {}
	public void Tick(float globalTime, float deltaTime) {}
	public void Add(T item) {}
	public void Remove(T item) {}
}

