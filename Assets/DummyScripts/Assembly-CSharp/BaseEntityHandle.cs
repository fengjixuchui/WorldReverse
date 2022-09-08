/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct BaseEntityHandle // TypeDefIndex: 19857
{
	// Fields
	private uint runtimeID; // 0x00
	private BaseEntity _entityRef; // 0x08

	// Properties
	public BaseEntity entityRef { /* [XID] */ /* 0x00000001899818E0-0x0000000189981900 */ get => default; } // 0x000000018464CB50-0x000000018464CD40 
	public BaseEntity entity { /* [XID] */ /* 0x00000001899891D0-0x00000001899891F0 */ get => default; /* [XID] */ /* 0x0000000189991900-0x0000000189991920 */ set {} } // 0x000000018464CD40-0x000000018464CDE0 0x000000018464CAA0-0x000000018464CB50

	// Constructors
	public BaseEntityHandle(BaseEntity inEntity) : this() {
		runtimeID = default;
		_entityRef = default;
	} // 0x000000018464CDE0-0x000000018464CE10

	// Methods
	// [XID] // 0x0000000189998450-0x0000000189998470
	public bool IsValid() => default; // 0x000000018464C8D0-0x000000018464CAA0
	// [XID] // 0x000000018999FC50-0x000000018999FC70
	public bool IsActive() => default; // 0x000000018464C800-0x000000018464C8D0
}

