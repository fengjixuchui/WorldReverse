/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct EntityHandle<T> // TypeDefIndex: 19858
	where T : BaseEntity
{
	// Fields
	private uint runtimeID;
	private T _entityRef;

	// Properties
	public T entityRef { get => default; }
	public T entity { get => default; set {} }

	// Constructors
	public EntityHandle(T inEntity) : this() {
		runtimeID = default;
		_entityRef = default;
	}

	// Methods
	public bool IsValid() => default;
	public bool IsActive() => default;
}

