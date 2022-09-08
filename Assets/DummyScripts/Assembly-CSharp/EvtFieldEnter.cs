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

public sealed class EvtFieldEnter : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20112
{
	// Fields
	public uint runtimeId; // 0x30
	public TriggerFlag flag; // 0x34
	public ConfigLocalTrigger config; // 0x38

	// Constructors
	public EvtFieldEnter() {} // 0x000000018355A7A0-0x000000018355A800

	// Methods
	[BlackList] // 0x00000001899D8BF0-0x00000001899D8C30
	// [XID] // 0x00000001899D8BF0-0x00000001899D8C30
	public override void AutoAllocTypeFields() {} // 0x000000018355A210-0x000000018355A2B0
	[BlackList] // 0x00000001899E33D0-0x00000001899E3410
	// [XID] // 0x00000001899E33D0-0x00000001899E3410
	public override void AutoRecycleTypeFields() {} // 0x000000018355A2B0-0x000000018355A360
	[BlackList] // 0x00000001899EDAE0-0x00000001899EDB20
	// [XID] // 0x00000001899EDAE0-0x00000001899EDB20
	public override void ReturnToObjectPool() {} // 0x000000018355A600-0x000000018355A6A0
	// [XID] // 0x00000001899F81F0-0x00000001899F8210
	public void Init(uint targetID, uint runtimeId, TriggerFlag flag = TriggerFlag.None /* Metadata: 0x00AFD25E */, ConfigLocalTrigger config = null) {} // 0x000000018355A430-0x000000018355A540
	// [XID] // 0x00000001899FF840-0x00000001899FF860
	public override string ToString() => default; // 0x000000018355A6A0-0x000000018355A7A0
}

