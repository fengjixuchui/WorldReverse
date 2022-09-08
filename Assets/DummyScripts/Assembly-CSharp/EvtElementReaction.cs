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

public sealed class EvtElementReaction : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID // TypeDefIndex: 20091
{
	// Fields
	public uint reactorID; // 0x30
	public ElementReactionSourceType reactionSourceType; // 0x34
	public ElementType sourceElementType; // 0x38
	public uint sourceElementCasterID; // 0x3C
	public ElementType reactorElementType; // 0x40
	public ElementReactionType elementReactionType; // 0x44

	// Constructors
	public EvtElementReaction() {} // 0x0000000184917880-0x00000001849178E0

	// Methods
	[BlackList] // 0x0000000189636F20-0x0000000189636F60
	// [XID] // 0x0000000189636F20-0x0000000189636F60
	public override void AutoAllocTypeFields() {} // 0x00000001849171B0-0x0000000184917250
	[BlackList] // 0x00000001896412C0-0x0000000189641300
	// [XID] // 0x00000001896412C0-0x0000000189641300
	public override void AutoRecycleTypeFields() {} // 0x0000000184917250-0x0000000184917300
	[BlackList] // 0x000000018964BD90-0x000000018964BDD0
	// [XID] // 0x000000018964BD90-0x000000018964BDD0
	public override void ReturnToObjectPool() {} // 0x0000000184917680-0x0000000184917720
	// [XID] // 0x0000000189656450-0x0000000189656470
	public void Init(uint targetID, uint reactorID, ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ElementType reactorElementType, ElementReactionType elementReactionType) {} // 0x00000001849173D0-0x0000000184917520
	// [XID] // 0x000000018965DBB0-0x000000018965DBD0
	public uint GetOtherID() => default; // 0x0000000184917520-0x00000001849175C0
	// [XID] // 0x0000000189665220-0x0000000189665240
	public override string ToString() => default; // 0x0000000184917720-0x0000000184917880
}

