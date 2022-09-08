/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class WeakAction<THandler> : WeakAction // TypeDefIndex: 11095
{
	// Constructors
	protected WeakAction() {}

	// Methods
	public virtual void Invoke() {}
	protected abstract void Invoke(THandler handler);
}

