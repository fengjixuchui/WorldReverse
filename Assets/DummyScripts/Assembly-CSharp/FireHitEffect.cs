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
public class FireHitEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16349
{
	// Fields
	private string _hitEntity; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHitScene _hitScene; // 0x70

	// Properties
	public string hitEntity { /* [XID] */ /* 0x00000001899F5910-0x00000001899F5930 */ get => default; /* [XID] */ /* 0x00000001899FD0D0-0x00000001899FD0F0 */ private set {} } // 0x0000000181BE0060-0x0000000181BE0100 0x0000000181BE05D0-0x0000000181BE0680
	public ConfigHitScene hitScene { /* [XID] */ /* 0x0000000189A04530-0x0000000189A04550 */ get => default; /* [XID] */ /* 0x0000000189A0BC50-0x0000000189A0BC70 */ private set {} } // 0x0000000181BDFDF0-0x0000000181BDFE90 0x0000000181BE0C80-0x0000000181BE0D30
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A96D40-0x0000000189A96D60 */ get => default; } // 0x0000000181BE0930-0x0000000181BE09D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A9E1B0-0x0000000189A9E1D0 */ get => default; } // 0x0000000181BDFD50-0x0000000181BDFDF0 
	protected override bool RemoteCheckTargetExists { /* [XID] */ /* 0x0000000189AA5B80-0x0000000189AA5BA0 */ get => default; } // 0x0000000181BDEF50-0x0000000181BDEFF0 

	// Constructors
	public FireHitEffect() {} // 0x0000000181BE1250-0x0000000181BE12B0

	// Methods
	// [XID] // 0x0000000189A13500-0x0000000189A13520
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181BE0FE0-0x0000000181BE1110
	// [XID] // 0x0000000189A1A630-0x0000000189A1A650
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181BE0A30-0x0000000181BE0B30
	// [XID] // 0x0000000189A21F30-0x0000000189A21F50
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF38A4 */) => default; // 0x0000000181BE04F0-0x0000000181BE05D0
	// [XID] // 0x0000000189A29360-0x0000000189A29380
	public override int GetHashNum() => default; // 0x0000000181BDEE80-0x0000000181BDEF50
	// [XID] // 0x0000000189A308F0-0x0000000189A30910
	public override void InitEmpty() {} // 0x0000000181BDFE90-0x0000000181BDFF80
	[BlackList] // 0x0000000189A382F0-0x0000000189A38330
	// [XID] // 0x0000000189A382F0-0x0000000189A38330
	public override bool FromJson(JSONNode node) => default; // 0x0000000181BDF6D0-0x0000000181BDFA50
	// [XID] // 0x0000000189A42A90-0x0000000189A42AB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181BDE520-0x0000000181BDE850
	[BlackList] // 0x0000000189A49F80-0x0000000189A49FC0
	// [XID] // 0x0000000189A49F80-0x0000000189A49FC0
	public static new FireHitEffect ParseFromJson(JSONNode node) => default; // 0x0000000181BE06E0-0x0000000181BE0930
	// [XID] // 0x0000000189A54830-0x0000000189A54850
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38A5 */, bool useObjectPool = false /* Metadata: 0x00AF38A9 */) => default; // 0x0000000181BE01F0-0x0000000181BE04F0
	// [XID] // 0x0000000189A5C2A0-0x0000000189A5C2C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38AA */, bool useObjectPool = false /* Metadata: 0x00AF38AE */) => default; // 0x0000000181BDF140-0x0000000181BDF470
	// [XID] // 0x0000000189A63C90-0x0000000189A63CB0
	public static new FireHitEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38AF */, bool useObjectPool = false /* Metadata: 0x00AF38B3 */) => default; // 0x0000000181BDFA50-0x0000000181BDFC70
	[BlackList] // 0x0000000189A6B490-0x0000000189A6B4D0
	// [XID] // 0x0000000189A6B490-0x0000000189A6B4D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181BDE850-0x0000000181BDEB20
	// [XID] // 0x0000000189A75A50-0x0000000189A75A70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181BE0D30-0x0000000181BE0FE0
	[BlackList] // 0x0000000189A7D670-0x0000000189A7D6B0
	// [XID] // 0x0000000189A7D670-0x0000000189A7D6B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181BE0100-0x0000000181BE01F0
	// [XID] // 0x0000000189A87F60-0x0000000189A87F80
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181BE1110-0x0000000181BE11B0
	// [XID] // 0x0000000189A8F7D0-0x0000000189A8F7F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181BDF470-0x0000000181BDF5D0
	[BlackList] // 0x0000000189AAD160-0x0000000189AAD1A0
	// [XID] // 0x0000000189AAD160-0x0000000189AAD1A0
	public override void AutoAllocTypeFields() {} // 0x0000000181BDEB20-0x0000000181BDEBC0
	[BlackList] // 0x0000000189AB7A60-0x0000000189AB7AA0
	// [XID] // 0x0000000189AB7A60-0x0000000189AB7AA0
	public override void AutoRecycleTypeFields() {} // 0x0000000181BDEBC0-0x0000000181BDECF0
	[BlackList] // 0x0000000189AC28C0-0x0000000189AC2900
	// [XID] // 0x0000000189AC28C0-0x0000000189AC2900
	public override void ReturnToObjectPool() {} // 0x0000000181BE11B0-0x0000000181BE1250
}

