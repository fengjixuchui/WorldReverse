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

public sealed class EvtBuffRemove : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20074
{
	// Fields
	public AbilityState abilityState; // 0x30
	public uint sourceID; // 0x38

	// Constructors
	public EvtBuffRemove() {} // 0x0000000182B7F9A0-0x0000000182B7FA00

	// Methods
	[BlackList] // 0x00000001898ED000-0x00000001898ED040
	// [XID] // 0x00000001898ED000-0x00000001898ED040
	public override void AutoAllocTypeFields() {} // 0x0000000182B7F420-0x0000000182B7F4C0
	[BlackList] // 0x00000001898F7B10-0x00000001898F7B50
	// [XID] // 0x00000001898F7B10-0x00000001898F7B50
	public override void AutoRecycleTypeFields() {} // 0x0000000182B7F4C0-0x0000000182B7F570
	[BlackList] // 0x0000000189902290-0x00000001899022D0
	// [XID] // 0x0000000189902290-0x00000001899022D0
	public override void ReturnToObjectPool() {} // 0x0000000182B7F7F0-0x0000000182B7F890
	// [XID] // 0x000000018990CB50-0x000000018990CB70
	public void Init(uint targetID, uint sourceID, AbilityState abilityState) {} // 0x0000000182B7F640-0x0000000182B7F730
	// [XID] // 0x00000001899142A0-0x00000001899142C0
	public override string ToString() => default; // 0x0000000182B7F890-0x0000000182B7F9A0
}

