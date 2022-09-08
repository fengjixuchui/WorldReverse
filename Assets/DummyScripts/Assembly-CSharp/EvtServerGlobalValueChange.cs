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

public sealed class EvtServerGlobalValueChange : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20159
{
	// Fields
	public uint key; // 0x30
	public float toValue; // 0x34

	// Constructors
	public EvtServerGlobalValueChange() {} // 0x000000018266DD90-0x000000018266DDF0

	// Methods
	[BlackList] // 0x0000000189840990-0x00000001898409D0
	// [XID] // 0x0000000189840990-0x00000001898409D0
	public override void AutoAllocTypeFields() {} // 0x000000018266D840-0x000000018266D8E0
	[BlackList] // 0x000000018984AF10-0x000000018984AF50
	// [XID] // 0x000000018984AF10-0x000000018984AF50
	public override void AutoRecycleTypeFields() {} // 0x000000018266D8E0-0x000000018266D990
	[BlackList] // 0x00000001898550D0-0x0000000189855110
	// [XID] // 0x00000001898550D0-0x0000000189855110
	public override void ReturnToObjectPool() {} // 0x000000018266DC10-0x000000018266DCB0
	// [XID] // 0x000000018985F3B0-0x000000018985F3D0
	public void Init(uint targetID, uint key, float toValue) {} // 0x000000018266DA60-0x000000018266DB50
	// [XID] // 0x0000000189866B90-0x0000000189866BB0
	public override string ToString() => default; // 0x000000018266DCB0-0x000000018266DD90
}

