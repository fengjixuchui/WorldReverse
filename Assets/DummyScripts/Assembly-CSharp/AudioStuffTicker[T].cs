/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioStuffTicker<T> // TypeDefIndex: 11475
{
	// Properties
	protected List<T> list { get; private set; }

	// Constructors
	protected AudioStuffTicker(int listCapacity) {}
	protected AudioStuffTicker() {}

	// Methods
	public virtual void Add(T t) {}
	public virtual void Tick(float deltaTime) {}
	public virtual void DestroyAll() {}
	protected abstract void Added(T t);
	protected abstract void Tick(float deltaTime, T t);
	protected abstract bool IsFinished(T t);
	protected abstract void Terminate(T t, bool natural);
	protected abstract void Removed(T t);
	protected abstract void Destroyed();
}

