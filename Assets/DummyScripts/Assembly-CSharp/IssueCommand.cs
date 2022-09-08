/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class IssueCommand : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16727
{
	// Fields
	private SimpleSafeInt32 commandIDRawNum; // 0x68
	private SimpleSafeFloat durationRawNum; // 0x6C

	// Properties
	public int commandID { /* [XID] */ /* 0x000000018998F5C0-0x000000018998F5E0 */ get => default; /* [XID] */ /* 0x0000000189997020-0x0000000189997040 */ private set {} } // 0x00000001849A49F0-0x00000001849A4AC0 0x00000001849A4E90-0x00000001849A4F70
	public float duration { /* [XID] */ /* 0x000000018999EBB0-0x000000018999EBD0 */ get => default; /* [XID] */ /* 0x00000001899A6590-0x00000001899A65B0 */ private set {} } // 0x00000001849A2D10-0x00000001849A2DF0 0x00000001849A3390-0x00000001849A3470
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A30890-0x0000000189A308B0 */ get => default; } // 0x00000001849A4760-0x00000001849A4800 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A38230-0x0000000189A38250 */ get => default; } // 0x00000001849A3D50-0x00000001849A3DF0 

	// Constructors
	public IssueCommand() {} // 0x00000001849A50B0-0x00000001849A5110

	// Methods
	// [XID] // 0x00000001899ADD40-0x00000001899ADD60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849A4D80-0x00000001849A4E90
	// [XID] // 0x00000001899B54A0-0x00000001899B54C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849A4860-0x00000001849A4910
	// [XID] // 0x00000001899BCBF0-0x00000001899BCC10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF445E */) => default; // 0x00000001849A43D0-0x00000001849A44B0
	// [XID] // 0x00000001899C45E0-0x00000001899C4600
	public override int GetHashNum() => default; // 0x00000001849A2E70-0x00000001849A2F40
	// [XID] // 0x00000001899CBE40-0x00000001899CBE60
	public override void InitEmpty() {} // 0x00000001849A3DF0-0x00000001849A3EF0
	[BlackList] // 0x00000001899D3350-0x00000001899D3390
	// [XID] // 0x00000001899D3350-0x00000001899D3390
	public override bool FromJson(JSONNode node) => default; // 0x00000001849A36D0-0x00000001849A3A50
	// [XID] // 0x00000001899DD720-0x00000001899DD740
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849A23F0-0x00000001849A2780
	[BlackList] // 0x00000001899E5440-0x00000001899E5480
	// [XID] // 0x00000001899E5440-0x00000001899E5480
	public static new IssueCommand ParseFromJson(JSONNode node) => default; // 0x00000001849A4510-0x00000001849A4760
	// [XID] // 0x00000001899EF790-0x00000001899EF7B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF445F */, bool useObjectPool = false /* Metadata: 0x00AF4463 */) => default; // 0x00000001849A40D0-0x00000001849A43D0
	// [XID] // 0x00000001899F6FD0-0x00000001899F6FF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4464 */, bool useObjectPool = false /* Metadata: 0x00AF4468 */) => default; // 0x00000001849A3090-0x00000001849A3390
	// [XID] // 0x00000001899FE750-0x00000001899FE770
	public static new IssueCommand ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4469 */, bool useObjectPool = false /* Metadata: 0x00AF446D */) => default; // 0x00000001849A3A50-0x00000001849A3C70
	[BlackList] // 0x0000000189A05F90-0x0000000189A05FD0
	// [XID] // 0x0000000189A05F90-0x0000000189A05FD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849A2780-0x00000001849A2A50
	// [XID] // 0x0000000189A10170-0x0000000189A10190
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849A4AC0-0x00000001849A4D80
	[BlackList] // 0x0000000189A17750-0x0000000189A17790
	// [XID] // 0x0000000189A17750-0x0000000189A17790
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849A3FD0-0x00000001849A40D0
	// [XID] // 0x0000000189A21E70-0x0000000189A21E90
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001849A4F70-0x00000001849A5010
	// [XID] // 0x0000000189A292C0-0x0000000189A292E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001849A3470-0x00000001849A35D0
	[BlackList] // 0x0000000189A3F9C0-0x0000000189A3FA00
	// [XID] // 0x0000000189A3F9C0-0x0000000189A3FA00
	public override void AutoAllocTypeFields() {} // 0x00000001849A2A50-0x00000001849A2AF0
	[BlackList] // 0x0000000189A49E40-0x0000000189A49E80
	// [XID] // 0x0000000189A49E40-0x0000000189A49E80
	public override void AutoRecycleTypeFields() {} // 0x00000001849A2AF0-0x00000001849A2C00
	[BlackList] // 0x0000000189A54770-0x0000000189A547B0
	// [XID] // 0x0000000189A54770-0x0000000189A547B0
	public override void ReturnToObjectPool() {} // 0x00000001849A5010-0x00000001849A50B0
}

