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
public class AddServerBuff : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16669
{
	// Fields
	private SimpleSafeUInt32 sBuffIdRawNum; // 0x68
	private SimpleSafeFloat timeRawNum; // 0x6C

	// Properties
	public uint sBuffId { /* [XID] */ /* 0x000000018995ABF0-0x000000018995AC10 */ get => default; /* [XID] */ /* 0x0000000189962730-0x0000000189962750 */ private set {} } // 0x0000000184C5D930-0x0000000184C5DA00 0x0000000184C5D260-0x0000000184C5D340
	public float time { /* [XID] */ /* 0x0000000189969B00-0x0000000189969B20 */ get => default; /* [XID] */ /* 0x00000001899718A0-0x00000001899718C0 */ private set {} } // 0x0000000184C5F360-0x0000000184C5F440 0x0000000184C5F0D0-0x0000000184C5F1B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899FCFB0-0x00000001899FCFD0 */ get => default; } // 0x0000000184C5EB10-0x0000000184C5EBB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A04450-0x0000000189A04470 */ get => default; } // 0x0000000184C5E100-0x0000000184C5E1A0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189A0BB50-0x0000000189A0BB70 */ get => default; } // 0x0000000184C5D1C0-0x0000000184C5D260 

	// Constructors
	public AddServerBuff() {} // 0x0000000184C5F4E0-0x0000000184C5F540

	// Methods
	// [XID] // 0x0000000189979150-0x0000000189979170
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184C5F1B0-0x0000000184C5F2C0
	// [XID] // 0x00000001899801C0-0x00000001899801E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184C5EC80-0x0000000184C5ED30
	// [XID] // 0x0000000189987A10-0x0000000189987A30
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF428E */) => default; // 0x0000000184C5E780-0x0000000184C5E860
	// [XID] // 0x000000018998F620-0x000000018998F640
	public override int GetHashNum() => default; // 0x0000000184C5D0F0-0x0000000184C5D1C0
	// [XID] // 0x0000000189997040-0x0000000189997060
	public override void InitEmpty() {} // 0x0000000184C5E1A0-0x0000000184C5E2A0
	[BlackList] // 0x000000018999EBD0-0x000000018999EC10
	// [XID] // 0x000000018999EBD0-0x000000018999EC10
	public override bool FromJson(JSONNode node) => default; // 0x0000000184C5DA80-0x0000000184C5DE00
	// [XID] // 0x00000001899A9440-0x00000001899A9460
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184C5C750-0x0000000184C5CAE0
	[BlackList] // 0x00000001899B0F30-0x00000001899B0F70
	// [XID] // 0x00000001899B0F30-0x00000001899B0F70
	public static new AddServerBuff ParseFromJson(JSONNode node) => default; // 0x0000000184C5E8C0-0x0000000184C5EB10
	// [XID] // 0x00000001899BB370-0x00000001899BB390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF428F */, bool useObjectPool = false /* Metadata: 0x00AF4293 */) => default; // 0x0000000184C5E480-0x0000000184C5E780
	// [XID] // 0x00000001899C2EE0-0x00000001899C2F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4294 */, bool useObjectPool = false /* Metadata: 0x00AF4298 */) => default; // 0x0000000184C5D490-0x0000000184C5D790
	// [XID] // 0x00000001899CA280-0x00000001899CA2A0
	public static new AddServerBuff ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4299 */, bool useObjectPool = false /* Metadata: 0x00AF429D */) => default; // 0x0000000184C5DE00-0x0000000184C5E020
	[BlackList] // 0x00000001899D1AE0-0x00000001899D1B20
	// [XID] // 0x00000001899D1AE0-0x00000001899D1B20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184C5CAE0-0x0000000184C5CDB0
	// [XID] // 0x00000001899DBFF0-0x00000001899DC010
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184C5EE10-0x0000000184C5F0D0
	[BlackList] // 0x00000001899E3950-0x00000001899E3990
	// [XID] // 0x00000001899E3950-0x00000001899E3990
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184C5E380-0x0000000184C5E480
	// [XID] // 0x00000001899EE000-0x00000001899EE020
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184C5F2C0-0x0000000184C5F360
	// [XID] // 0x00000001899F5850-0x00000001899F5870
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184C5D790-0x0000000184C5D8B0
	[BlackList] // 0x0000000189A134A0-0x0000000189A134E0
	// [XID] // 0x0000000189A134A0-0x0000000189A134E0
	public override void AutoAllocTypeFields() {} // 0x0000000184C5CDB0-0x0000000184C5CE50
	[BlackList] // 0x0000000189A1D6E0-0x0000000189A1D720
	// [XID] // 0x0000000189A1D6E0-0x0000000189A1D720
	public override void AutoRecycleTypeFields() {} // 0x0000000184C5CE50-0x0000000184C5CF60
	[BlackList] // 0x0000000189A27BE0-0x0000000189A27C20
	// [XID] // 0x0000000189A27BE0-0x0000000189A27C20
	public override void ReturnToObjectPool() {} // 0x0000000184C5F440-0x0000000184C5F4E0
}

