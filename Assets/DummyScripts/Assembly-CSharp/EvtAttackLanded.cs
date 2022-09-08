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

public sealed class EvtAttackLanded : BaseEvent, IAutoAllocRecycle, IEvtWithOtherID, IEvtWithHitCollision, IEvtWithAttackResult, IEvtWithRemoteID // TypeDefIndex: 20052
{
	// Fields
	private uint _attackerID; // 0x30
	private uint _attackeeID; // 0x34
	private AttackResult _attackResult; // 0x38

	// Constructors
	public EvtAttackLanded() {} // 0x000000018320F110-0x000000018320F170

	// Methods
	[BlackList] // 0x0000000189AA55A0-0x0000000189AA55E0
	// [XID] // 0x0000000189AA55A0-0x0000000189AA55E0
	public override void AutoAllocTypeFields() {} // 0x000000018320E290-0x000000018320E330
	[BlackList] // 0x0000000189AAFDB0-0x0000000189AAFDF0
	// [XID] // 0x0000000189AAFDB0-0x0000000189AAFDF0
	public override void AutoRecycleTypeFields() {} // 0x000000018320E330-0x000000018320E3E0
	[BlackList] // 0x0000000189ABA900-0x0000000189ABA940
	// [XID] // 0x0000000189ABA900-0x0000000189ABA940
	public override void ReturnToObjectPool() {} // 0x000000018320EF70-0x000000018320F010
	// [XID] // 0x0000000189AC5350-0x0000000189AC5370
	public void Init(uint targetID, uint attackerID, uint attackeeID, AttackResult attackResult) {} // 0x000000018320E5F0-0x000000018320E790
	// [XID] // 0x0000000189ACC800-0x0000000189ACC820
	public override void Clear() {} // 0x000000018320EA60-0x000000018320EB40
	// [XID] // 0x0000000189AD4570-0x0000000189AD4590
	public override string ToString() => default; // 0x000000018320F010-0x000000018320F110
	// [XID] // 0x0000000189ADBF00-0x0000000189ADBF20
	public uint GetOtherID() => default; // 0x000000018320EB40-0x000000018320EBE0
	// [XID] // 0x0000000189AE3850-0x0000000189AE3870
	public uint GetAttackerID() => default; // 0x000000018320E450-0x000000018320E4F0
	// [XID] // 0x0000000189AEB0F0-0x0000000189AEB110
	public AttackResult GetAttackResult() => default; // 0x000000018320EBE0-0x000000018320EDB0
	// [XID] // 0x0000000189AF2A40-0x0000000189AF2A60
	public AttackResult.HitCollsion? GetHitCollision() => default; // 0x000000018320E790-0x000000018320EA60
	// [XID] // 0x0000000189AFA340-0x0000000189AFA360
	public uint GetRemoteID() => default; // 0x000000018320E550-0x000000018320E5F0
	// [XID] // 0x0000000189B01920-0x0000000189B01940
	public uint GetSenderID() => default; // 0x000000018320EE10-0x000000018320EEB0
}

