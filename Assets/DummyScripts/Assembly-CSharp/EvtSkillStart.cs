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

public sealed class EvtSkillStart : BaseEvent, IAutoAllocRecycle // TypeDefIndex: 20165
{
	// Fields
	public uint skillID; // 0x30
	public float cdRatio; // 0x34
	public float costStaminaRatio; // 0x38

	// Constructors
	public EvtSkillStart() {} // 0x00000001812E9150-0x00000001812E91B0

	// Methods
	[BlackList] // 0x0000000189918BB0-0x0000000189918BF0
	// [XID] // 0x0000000189918BB0-0x0000000189918BF0
	public override void AutoAllocTypeFields() {} // 0x00000001812E8B80-0x00000001812E8C20
	[BlackList] // 0x00000001899233C0-0x0000000189923400
	// [XID] // 0x00000001899233C0-0x0000000189923400
	public override void AutoRecycleTypeFields() {} // 0x00000001812E8C20-0x00000001812E8CD0
	[BlackList] // 0x000000018992DB50-0x000000018992DB90
	// [XID] // 0x000000018992DB50-0x000000018992DB90
	public override void ReturnToObjectPool() {} // 0x00000001812E8F70-0x00000001812E9010
	// [XID] // 0x0000000189937F50-0x0000000189937F70
	public void Init(uint targetID, uint skillID, float cdRatio = 1f /* Metadata: 0x00AFD29F */, float costStaminaRatio = 0f /* Metadata: 0x00AFD2A3 */) {} // 0x00000001812E8DA0-0x00000001812E8EB0
	// [XID] // 0x000000018993FA00-0x000000018993FA20
	public override string ToString() => default; // 0x00000001812E9010-0x00000001812E9150
}

