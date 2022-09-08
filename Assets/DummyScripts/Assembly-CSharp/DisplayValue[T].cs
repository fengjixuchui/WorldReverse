/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DisplayValue<T> : IDisposable // TypeDefIndex: 31396
	where T : IComparable
{
	// Fields
	private T _floor;
	private T _ceiling;
	private T _value;
	private Action<T, T> _changeDelegate;

	// Properties
	public T value { get => default; }

	// Constructors
	public DisplayValue() {} // Dummy constructor
	public DisplayValue(T floor, T ceiling, T init) {}

	// Methods
	public void Pub(T newValue) {}
	public void SubAttach(Action<T, T> changeCallback, ref T curValue, ref T floor, ref T ceiling) {}
	public void SubDetach(Action<T, T> changeCalback) {}
	public void Dispose() {}
}

