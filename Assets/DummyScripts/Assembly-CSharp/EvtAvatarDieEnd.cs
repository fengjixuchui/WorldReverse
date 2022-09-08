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

public sealed class EvtAvatarDieEnd : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20060
{
	// Fields
	public uint entityId; // 0x30
	public DieReason reason; // 0x34

	// Nested types
	public enum DieReason // TypeDefIndex: 20061
	{
		Default = 0,
		Drop = 1,
		Swim = 2
	}

	// Constructors
	public EvtAvatarDieEnd() {} // 0x000000018226F930-0x000000018226F9A0

	// Methods
	[BlackList] // 0x000000018962AC00-0x000000018962AC40
	// [XID] // 0x000000018962AC00-0x000000018962AC40
	public override void AutoAllocTypeFields() {} // 0x000000018226F3D0-0x000000018226F470
	[BlackList] // 0x0000000189635910-0x0000000189635950
	// [XID] // 0x0000000189635910-0x0000000189635950
	public override void AutoRecycleTypeFields() {} // 0x000000018226F470-0x000000018226F520
	[BlackList] // 0x000000018963FC70-0x000000018963FCB0
	// [XID] // 0x000000018963FC70-0x000000018963FCB0
	public override void ReturnToObjectPool() {} // 0x000000018226F790-0x000000018226F830
	// [XID] // 0x000000018964A410-0x000000018964A430
	public void Init(uint entityId, DieReason rea = DieReason.Default /* Metadata: 0x00AFD202 */) {} // 0x000000018226F5F0-0x000000018226F6D0
	// [XID] // 0x0000000189651B80-0x0000000189651BA0
	public override string ToString() => default; // 0x000000018226F830-0x000000018226F930
}

