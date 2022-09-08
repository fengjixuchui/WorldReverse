/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DynamicActorValue<T> : IDisposable // TypeDefIndex: 31397
{
	// Fields
	private T _value;
	private Action<T, T> _changeDelegate;

	// Properties
	public T Value { get => default; }

	// Constructors
	public DynamicActorValue() {} // Dummy constructor
	public DynamicActorValue(T value) {}

	// Methods
	public void Pub(T newValue) {}
	public void SubAttach(Action<T, T> changeCallback, ref T curValue) {}
	public void SubDetach(Action<T, T> changeCallback) {}
	public void Dispose() {}
}

