/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAISoundBroadcast : EvtAISound, IAutoAllocRecycle // TypeDefIndex: 20045
{
	// Fields
	public uint sourceID; // 0x48
	public uint sourceCampID; // 0x4C
	public uint sourceAIGroupID; // 0x50
	public uint threatTargetID; // 0x54
	public Vector3 threatTargetPos; // 0x58

	// Constructors
	public EvtAISoundBroadcast() {} // 0x0000000182BD78C0-0x0000000182BD7920

	// Methods
	[BlackList] // 0x000000018997E1C0-0x000000018997E200
	// [XID] // 0x000000018997E1C0-0x000000018997E200
	public override void AutoAllocTypeFields() {} // 0x0000000182BD7400-0x0000000182BD74A0
	[BlackList] // 0x0000000189989150-0x0000000189989190
	// [XID] // 0x0000000189989150-0x0000000189989190
	public override void AutoRecycleTypeFields() {} // 0x0000000182BD74A0-0x0000000182BD7560
	[BlackList] // 0x0000000189993D90-0x0000000189993DD0
	// [XID] // 0x0000000189993D90-0x0000000189993DD0
	public override void ReturnToObjectPool() {} // 0x0000000182BD7820-0x0000000182BD78C0
	// [XID] // 0x000000018997ADB0-0x000000018997ADD0
	public void Init(uint pSourceID, uint pSourceCampID, uint pSourceAIGroupID, Vector3 pSourcePosition, uint pThreatID, Vector3 pThreatTargetPos) {} // 0x0000000182BD75C0-0x0000000182BD7760
}

