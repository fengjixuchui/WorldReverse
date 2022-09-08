/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCameraMoveClear : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20078
{
	// Fields
	private int _shotType; // 0x30

	// Properties
	public int shotType { /* [XID] */ /* 0x00000001899E4E20-0x00000001899E4E40 */ get => default; } // 0x000000018303BCC0-0x000000018303BD60 

	// Constructors
	public EvtCameraMoveClear() {} // 0x000000018303C000-0x000000018303C0D0

	// Methods
	[BlackList] // 0x00000001899C57B0-0x00000001899C57F0
	// [XID] // 0x00000001899C57B0-0x00000001899C57F0
	public override void AutoAllocTypeFields() {} // 0x000000018303BB70-0x000000018303BC10
	[BlackList] // 0x00000001899CFFB0-0x00000001899CFFF0
	// [XID] // 0x00000001899CFFB0-0x00000001899CFFF0
	public override void AutoRecycleTypeFields() {} // 0x000000018303BC10-0x000000018303BCC0
	[BlackList] // 0x00000001899DA2C0-0x00000001899DA300
	// [XID] // 0x00000001899DA2C0-0x00000001899DA300
	public override void ReturnToObjectPool() {} // 0x000000018303BF60-0x000000018303C000
	// [XID] // 0x00000001899EC270-0x00000001899EC290
	public void Init(uint targetID, int sShotType) {} // 0x000000018303BDC0-0x000000018303BEA0
}

