/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class WeakAction<T1, THandler> : WeakAction // TypeDefIndex: 11096
{
	// Constructors
	protected WeakAction() {}

	// Methods
	public virtual void Invoke(T1 param1) {}
	protected abstract void Invoke(T1 param1, THandler handler);
}

