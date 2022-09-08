/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class AudioEmitterLifetime // TypeDefIndex: 11481
{
	// Properties
	public abstract bool finished { get; }

	// Constructors
	protected AudioEmitterLifetime() {} // 0x0000000182630AE0-0x0000000182630B40

	// Methods
	public abstract void Tick(float deltaTime);
	public abstract void Reset();
}

