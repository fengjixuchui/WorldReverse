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
public class TurnDirectionToPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16379
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _toPos; // 0x68
	private SimpleSafeFloat minAngleRawNum; // 0x70
	private SimpleSafeFloat maxAngleRawNum; // 0x74

	// Properties
	public ConfigBornType toPos { /* [XID] */ /* 0x0000000189B2B4F0-0x0000000189B2B510 */ get => default; /* [XID] */ /* 0x0000000189B32A20-0x0000000189B32A40 */ private set {} } // 0x00000001827530B0-0x0000000182753150 0x0000000182751AC0-0x0000000182751B70
	public float minAngle { /* [XID] */ /* 0x0000000189B3A330-0x0000000189B3A350 */ get => default; /* [XID] */ /* 0x0000000189B41D30-0x0000000189B41D50 */ private set {} } // 0x0000000182752B40-0x0000000182752C20 0x00000001827522E0-0x00000001827523C0
	public float maxAngle { /* [XID] */ /* 0x0000000189B496A0-0x0000000189B496C0 */ get => default; /* [XID] */ /* 0x0000000189B50D40-0x0000000189B50D60 */ private set {} } // 0x0000000182751BF0-0x0000000182751CD0 0x00000001827536C0-0x00000001827537A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BD39B0-0x0000000189BD39D0 */ get => default; } // 0x0000000182752ED0-0x0000000182752F70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189BDB360-0x0000000189BDB380 */ get => default; } // 0x00000001827523C0-0x0000000182752460 

	// Constructors
	public TurnDirectionToPos() {} // 0x0000000182753840-0x00000001827538F0

	// Methods
	// [XID] // 0x0000000189B584F0-0x0000000189B58510
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182753580-0x00000001827536C0
	// [XID] // 0x0000000189B5FEA0-0x0000000189B5FEC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182752FD0-0x00000001827530B0
	// [XID] // 0x0000000189B675E0-0x0000000189B67600
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF399C */) => default; // 0x0000000182752A60-0x0000000182752B40
	// [XID] // 0x0000000189B6E800-0x0000000189B6E820
	public override int GetHashNum() => default; // 0x0000000182751380-0x0000000182751450
	// [XID] // 0x0000000189B760B0-0x0000000189B760D0
	public override void InitEmpty() {} // 0x0000000182752460-0x0000000182752590
	[BlackList] // 0x0000000189B7D560-0x0000000189B7D5A0
	// [XID] // 0x0000000189B7D560-0x0000000189B7D5A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182751CD0-0x0000000182752050
	// [XID] // 0x0000000189B87F80-0x0000000189B87FA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827508E0-0x0000000182750D00
	[BlackList] // 0x0000000189B8F170-0x0000000189B8F1B0
	// [XID] // 0x0000000189B8F170-0x0000000189B8F1B0
	public static new TurnDirectionToPos ParseFromJson(JSONNode node) => default; // 0x0000000182752C80-0x0000000182752ED0
	// [XID] // 0x0000000189B996A0-0x0000000189B996C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF399D */, bool useObjectPool = false /* Metadata: 0x00AF39A1 */) => default; // 0x0000000182752760-0x0000000182752A60
	// [XID] // 0x0000000189BA0C30-0x0000000189BA0C50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39A2 */, bool useObjectPool = false /* Metadata: 0x00AF39A6 */) => default; // 0x00000001827515A0-0x00000001827518E0
	// [XID] // 0x0000000189BA8290-0x0000000189BA82B0
	public static new TurnDirectionToPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39A7 */, bool useObjectPool = false /* Metadata: 0x00AF39AB */) => default; // 0x0000000182752050-0x0000000182752270
	[BlackList] // 0x0000000189BAF760-0x0000000189BAF7A0
	// [XID] // 0x0000000189BAF760-0x0000000189BAF7A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182750D00-0x0000000182750FD0
	// [XID] // 0x0000000189BB9C40-0x0000000189BB9C60
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182753230-0x0000000182753580
	[BlackList] // 0x0000000189BC1C50-0x0000000189BC1C90
	// [XID] // 0x0000000189BC1C50-0x0000000189BC1C90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182752670-0x0000000182752760
	// [XID] // 0x0000000189BCC320-0x0000000189BCC340
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001827518E0-0x0000000182751A40
	[BlackList] // 0x00000001895E7C50-0x00000001895E7C90
	// [XID] // 0x00000001895E7C50-0x00000001895E7C90
	public override void AutoAllocTypeFields() {} // 0x0000000182750FD0-0x0000000182751070
	[BlackList] // 0x00000001895F22D0-0x00000001895F2310
	// [XID] // 0x00000001895F22D0-0x00000001895F2310
	public override void AutoRecycleTypeFields() {} // 0x0000000182751070-0x00000001827511F0
	[BlackList] // 0x00000001895FCAD0-0x00000001895FCB10
	// [XID] // 0x00000001895FCAD0-0x00000001895FCB10
	public override void ReturnToObjectPool() {} // 0x00000001827537A0-0x0000000182753840
}

