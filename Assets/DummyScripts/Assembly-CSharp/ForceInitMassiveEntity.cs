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
public class ForceInitMassiveEntity : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16581
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x68
	private SimpleSafeFloat radiusRawNum; // 0x70
	private SimpleSafeFloat angleRawNum; // 0x74
	private SimpleSafeFloat heightRawNum; // 0x78

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x00000001898B88A0-0x00000001898B88C0 */ get => default; /* [XID] */ /* 0x00000001898BFFA0-0x00000001898BFFC0 */ private set {} } // 0x00000001815BEAF0-0x00000001815BEB90 0x00000001815C0FC0-0x00000001815C1070
	public float radius { /* [XID] */ /* 0x00000001898C7880-0x00000001898C78A0 */ get => default; /* [XID] */ /* 0x00000001898CEF30-0x00000001898CEF50 */ private set {} } // 0x00000001815C08D0-0x00000001815C09B0 0x00000001815C1070-0x00000001815C1150
	public float angle { /* [XID] */ /* 0x00000001898D6960-0x00000001898D6980 */ get => default; /* [XID] */ /* 0x00000001898DE580-0x00000001898DE5A0 */ private set {} } // 0x00000001815BEBF0-0x00000001815BECD0 0x00000001815BF930-0x00000001815BFA10
	public float height { /* [XID] */ /* 0x00000001898E5DA0-0x00000001898E5DC0 */ get => default; /* [XID] */ /* 0x00000001898ED6A0-0x00000001898ED6C0 */ private set {} } // 0x00000001815C0D80-0x00000001815C0E60 0x00000001815C0530-0x00000001815C0610
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189979170-0x0000000189979190 */ get => default; } // 0x00000001815C0610-0x00000001815C06B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189980200-0x0000000189980220 */ get => default; } // 0x00000001815BFAF0-0x00000001815BFB90 

	// Constructors
	public ForceInitMassiveEntity() {} // 0x00000001815C1290-0x00000001815C1340

	// Methods
	// [XID] // 0x00000001898F4EA0-0x00000001898F4EC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001815C0E60-0x00000001815C0FC0
	// [XID] // 0x00000001898FC5D0-0x00000001898FC5F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001815C0710-0x00000001815C07F0
	// [XID] // 0x0000000189904050-0x0000000189904070
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FDA */) => default; // 0x00000001815C01A0-0x00000001815C0280
	// [XID] // 0x000000018990B630-0x000000018990B650
	public override int GetHashNum() => default; // 0x00000001815BE9B0-0x00000001815BEA80
	// [XID] // 0x00000001899132E0-0x0000000189913300
	public override void InitEmpty() {} // 0x00000001815BFB90-0x00000001815BFCD0
	[BlackList] // 0x000000018991AA70-0x000000018991AAB0
	// [XID] // 0x000000018991AA70-0x000000018991AAB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001815BF390-0x00000001815BF710
	// [XID] // 0x0000000189925140-0x0000000189925160
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001815BDDE0-0x00000001815BE320
	[BlackList] // 0x000000018992C760-0x000000018992C7A0
	// [XID] // 0x000000018992C760-0x000000018992C7A0
	public static new ForceInitMassiveEntity ParseFromJson(JSONNode node) => default; // 0x00000001815C02E0-0x00000001815C0530
	// [XID] // 0x0000000189936BD0-0x0000000189936BF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FDB */, bool useObjectPool = false /* Metadata: 0x00AF3FDF */) => default; // 0x00000001815BFEA0-0x00000001815C01A0
	// [XID] // 0x000000018993E7B0-0x000000018993E7D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FE0 */, bool useObjectPool = false /* Metadata: 0x00AF3FE4 */) => default; // 0x00000001815BED50-0x00000001815BF130
	// [XID] // 0x0000000189945D80-0x0000000189945DA0
	public static new ForceInitMassiveEntity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FE5 */, bool useObjectPool = false /* Metadata: 0x00AF3FE9 */) => default; // 0x00000001815BF710-0x00000001815BF930
	[BlackList] // 0x000000018994D230-0x000000018994D270
	// [XID] // 0x000000018994D230-0x000000018994D270
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001815BE320-0x00000001815BE5F0
	// [XID] // 0x0000000189957BC0-0x0000000189957BE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001815C09B0-0x00000001815C0D80
	[BlackList] // 0x000000018995F450-0x000000018995F490
	// [XID] // 0x000000018995F450-0x000000018995F490
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001815BFDB0-0x00000001815BFEA0
	// [XID] // 0x0000000189969B20-0x0000000189969B40
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001815C1150-0x00000001815C11F0
	// [XID] // 0x00000001899718C0-0x00000001899718E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001815BF130-0x00000001815BF290
	[BlackList] // 0x0000000189987A70-0x0000000189987AB0
	// [XID] // 0x0000000189987A70-0x0000000189987AB0
	public override void AutoAllocTypeFields() {} // 0x00000001815BE5F0-0x00000001815BE690
	[BlackList] // 0x0000000189992790-0x00000001899927D0
	// [XID] // 0x0000000189992790-0x00000001899927D0
	public override void AutoRecycleTypeFields() {} // 0x00000001815BE690-0x00000001815BE820
	[BlackList] // 0x000000018999D290-0x000000018999D2D0
	// [XID] // 0x000000018999D290-0x000000018999D2D0
	public override void ReturnToObjectPool() {} // 0x00000001815C11F0-0x00000001815C1290
}

