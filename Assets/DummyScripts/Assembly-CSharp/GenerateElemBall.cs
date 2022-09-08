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
public class GenerateElemBall : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16569
{
	// Fields
	private DropElemBallType _dropType; // 0x68
	private SimpleSafeUInt32 configIDRawNum; // 0x6C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _ratio; // 0x78
	private SimpleSafeFloat baseEnergyRawNum; // 0x80

	// Properties
	public DropElemBallType dropType { /* [XID] */ /* 0x00000001898F4EC0-0x00000001898F4EE0 */ get => default; /* [XID] */ /* 0x00000001898FC5F0-0x00000001898FC610 */ private set {} } // 0x00000001835B5DC0-0x00000001835B5E60 0x00000001835B7AA0-0x00000001835B7B50
	public uint configID { /* [XID] */ /* 0x0000000189904070-0x0000000189904090 */ get => default; /* [XID] */ /* 0x000000018990B650-0x000000018990B670 */ private set {} } // 0x00000001835B5500-0x00000001835B55D0 0x00000001835B49A0-0x00000001835B4A80
	public ConfigBornType born { /* [XID] */ /* 0x0000000189913300-0x0000000189913320 */ get => default; /* [XID] */ /* 0x000000018991AAB0-0x000000018991AAD0 */ private set {} } // 0x00000001835B55D0-0x00000001835B5670 0x00000001835B7CE0-0x00000001835B7D90
	public DynamicFloat ratio { /* [XID] */ /* 0x0000000189922320-0x0000000189922340 */ get => default; /* [XID] */ /* 0x0000000189929AA0-0x0000000189929AC0 */ private set {} } // 0x00000001835B5350-0x00000001835B53F0 0x00000001835B64F0-0x00000001835B65A0
	public float baseEnergy { /* [XID] */ /* 0x0000000189931020-0x0000000189931040 */ get => default; /* [XID] */ /* 0x0000000189938490-0x00000001899384B0 */ private set {} } // 0x00000001835B69C0-0x00000001835B6AA0 0x00000001835B4D50-0x00000001835B4E30
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899CBE80-0x00000001899CBEA0 */ get => default; } // 0x00000001835B7130-0x00000001835B71D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899D33D0-0x00000001899D33F0 */ get => default; } // 0x00000001835B6610-0x00000001835B66B0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001899DA920-0x00000001899DA940 */ get => default; } // 0x00000001835B53F0-0x00000001835B5490 

	// Constructors
	public GenerateElemBall() {} // 0x00000001835B7ED0-0x00000001835B7FA0

	// Methods
	// [XID] // 0x000000018993FE80-0x000000018993FEA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835B7B50-0x00000001835B7CE0
	// [XID] // 0x0000000189947520-0x0000000189947540
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835B72A0-0x00000001835B73A0
	// [XID] // 0x000000018994ECA0-0x000000018994ECC0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F7A */) => default; // 0x00000001835B6DA0-0x00000001835B6E80
	// [XID] // 0x0000000189956220-0x0000000189956240
	public override int GetHashNum() => default; // 0x00000001835B5280-0x00000001835B5350
	// [XID] // 0x000000018995DD10-0x000000018995DD30
	public override void InitEmpty() {} // 0x00000001835B66B0-0x00000001835B67F0
	[BlackList] // 0x0000000189965510-0x0000000189965550
	// [XID] // 0x0000000189965510-0x0000000189965550
	public override bool FromJson(JSONNode node) => default; // 0x00000001835B5EE0-0x00000001835B6260
	// [XID] // 0x000000018996F880-0x000000018996F8A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001835B43C0-0x00000001835B49A0
	[BlackList] // 0x00000001899775A0-0x00000001899775E0
	// [XID] // 0x00000001899775A0-0x00000001899775E0
	public static new GenerateElemBall ParseFromJson(JSONNode node) => default; // 0x00000001835B6EE0-0x00000001835B7130
	// [XID] // 0x0000000189981F40-0x0000000189981F60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F7B */, bool useObjectPool = false /* Metadata: 0x00AF3F7F */) => default; // 0x00000001835B6AA0-0x00000001835B6DA0
	// [XID] // 0x00000001899897A0-0x00000001899897C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F80 */, bool useObjectPool = false /* Metadata: 0x00AF3F84 */) => default; // 0x00000001835B5750-0x00000001835B5BE0
	// [XID] // 0x0000000189991010-0x0000000189991030
	public static new GenerateElemBall ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F85 */, bool useObjectPool = false /* Metadata: 0x00AF3F89 */) => default; // 0x00000001835B6260-0x00000001835B6480
	[BlackList] // 0x0000000189998A90-0x0000000189998AD0
	// [XID] // 0x0000000189998A90-0x0000000189998AD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835B4A80-0x00000001835B4D50
	// [XID] // 0x00000001899A32B0-0x00000001899A32D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835B7600-0x00000001835B7AA0
	[BlackList] // 0x00000001899AAD40-0x00000001899AAD80
	// [XID] // 0x00000001899AAD40-0x00000001899AAD80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835B68D0-0x00000001835B69C0
	// [XID] // 0x00000001899B5500-0x00000001899B5520
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001835B7D90-0x00000001835B7E30
	// [XID] // 0x00000001899BCC90-0x00000001899BCCB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001835B5BE0-0x00000001835B5D40
	// [XID] // 0x00000001899C4660-0x00000001899C4680
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001835B7480-0x00000001835B7600
	[BlackList] // 0x00000001899E22C0-0x00000001899E2300
	// [XID] // 0x00000001899E22C0-0x00000001899E2300
	public override void AutoAllocTypeFields() {} // 0x00000001835B4E30-0x00000001835B4ED0
	[BlackList] // 0x00000001899EC790-0x00000001899EC7D0
	// [XID] // 0x00000001899EC790-0x00000001899EC7D0
	public override void AutoRecycleTypeFields() {} // 0x00000001835B4ED0-0x00000001835B50F0
	[BlackList] // 0x00000001899F7010-0x00000001899F7050
	// [XID] // 0x00000001899F7010-0x00000001899F7050
	public override void ReturnToObjectPool() {} // 0x00000001835B7E30-0x00000001835B7ED0
}

