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

public sealed class EvtEntityActive : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20092
{
	// Fields
	public uint entityRuntimeID; // 0x30
	public bool active; // 0x34
	public bool recoverFromSleep; // 0x35

	// Constructors
	public EvtEntityActive() {} // 0x0000000183538930-0x0000000183538990

	// Methods
	[BlackList] // 0x000000018966C980-0x000000018966C9C0
	// [XID] // 0x000000018966C980-0x000000018966C9C0
	public override void AutoAllocTypeFields() {} // 0x00000001835383A0-0x0000000183538440
	[BlackList] // 0x0000000189677800-0x0000000189677840
	// [XID] // 0x0000000189677800-0x0000000189677840
	public override void AutoRecycleTypeFields() {} // 0x0000000183538440-0x00000001835384F0
	[BlackList] // 0x0000000189681FF0-0x0000000189682030
	// [XID] // 0x0000000189681FF0-0x0000000189682030
	public override void ReturnToObjectPool() {} // 0x0000000183538770-0x0000000183538810
	// [XID] // 0x000000018998CE20-0x000000018998CE40
	public void Init(uint entityRuntimeID, bool active, bool recoverFromSleep) {} // 0x00000001835385C0-0x00000001835386B0
	// [XID] // 0x00000001896944F0-0x0000000189694510
	public override string ToString() => default; // 0x0000000183538810-0x0000000183538930
}

