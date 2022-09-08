/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class OnceAtMostPerFrame<T> // TypeDefIndex: 14715
{
	// Fields
	private T _value;
	private int lastUpdatedAt;

	// Properties
	public T Value { get; }

	// Constructors
	public OnceAtMostPerFrame(T value) {}
	public OnceAtMostPerFrame() {}

	// Methods
	public abstract T Update(T previousValue);
}

