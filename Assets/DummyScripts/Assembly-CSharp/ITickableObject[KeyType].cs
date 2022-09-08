/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface ITickableObject<KeyType> // TypeDefIndex: 14447
{
	// Properties
	KeyType key { get; }
	int index { get; set; }

	// Methods
	void Tick(float deltaTime);
	void ResetObject();
}

