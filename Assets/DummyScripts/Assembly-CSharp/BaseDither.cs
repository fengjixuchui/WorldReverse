/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseDither // TypeDefIndex: 32043
{
	// Properties
	public virtual bool CanBeDestroy { /* [XID] */ /* 0x0000000189B69760-0x0000000189B69780 */ get; } // 0x0000000184400840-0x00000001844008E0 

	// Constructors
	protected BaseDither() {} // 0x00000001844008E0-0x0000000184400940

	// Methods
	public abstract void Destroy();
	public abstract float UpdateDither(float deltaTime);
}

