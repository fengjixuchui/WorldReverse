/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct UnitySync // TypeDefIndex: 11510
{
	// Fields
	private static readonly UnitySync _empty; // 0x00

	// Properties
	public static UnitySync empty { /* [XID] */ /* 0x000000018969E120-0x000000018969E140 */ get => default; } // 0x000000018303C130-0x000000018303C250 
	public SyncId syncId { /* [XID] */ /* 0x00000001896A5170-0x00000001896A51B0 */ get; private set; } // 0x000000018303C320-0x000000018303C3B0 0x000000018303C3B0-0x000000018303C430
	public Transform transform { /* [XID] */ /* 0x00000001896B6CE0-0x00000001896B6D20 */ get; private set; } // 0x000000018303C0D0-0x000000018303C130 0x000000018303C250-0x000000018303C320

	// Constructors
	static UnitySync() {
		_empty = default;
	} // 0x000000018303C430-0x000000018303C750
	public UnitySync(GameObject go) : this() {

	} // 0x000000018303C750-0x000000018303C930
	public UnitySync(Component component) : this() {

	} // 0x000000018303C930-0x000000018303C960
}

