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
public class FireEffectToTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16347
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x68
	private bool _reverse; // 0x70
	private bool _fromSelf; // 0x71
	private SimpleSafeFloat scaleRawNum; // 0x74

	// Properties
	public DynamicString effectPattern { /* [XID] */ /* 0x00000001898E9040-0x00000001898E9060 */ get => default; /* [XID] */ /* 0x00000001898F0820-0x00000001898F0840 */ private set {} } // 0x00000001844F7590-0x00000001844F7630 0x00000001844F8880-0x00000001844F8930
	public bool reverse { /* [XID] */ /* 0x00000001898F8190-0x00000001898F81B0 */ get => default; /* [XID] */ /* 0x00000001898FF770-0x00000001898FF790 */ private set {} } // 0x00000001844F5E40-0x00000001844F5EE0 0x00000001844F6070-0x00000001844F6120
	public bool fromSelf { /* [XID] */ /* 0x0000000189906F90-0x0000000189906FB0 */ get => default; /* [XID] */ /* 0x000000018990E9B0-0x000000018990E9D0 */ private set {} } // 0x00000001844F72C0-0x00000001844F7360 0x00000001844F71A0-0x00000001844F7250
	public float scale { /* [XID] */ /* 0x0000000189915FE0-0x0000000189916000 */ get => default; /* [XID] */ /* 0x000000018991DAD0-0x000000018991DAF0 */ private set {} } // 0x00000001844F7050-0x00000001844F7130 0x00000001844F8700-0x00000001844F87E0
	public override EntityTokenActionType entityTokenType { /* [XID] */ /* 0x00000001899A1CB0-0x00000001899A1CD0 */ get => default; } // 0x00000001844F6D90-0x00000001844F6E30 
	public override bool useActionToken { /* [XID] */ /* 0x00000001899A9540-0x00000001899A9560 */ get => default; } // 0x00000001844F8140-0x00000001844F81E0 
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899B8230-0x00000001899B8250 */ get => default; } // 0x00000001844F7E80-0x00000001844F7F20 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899BFD10-0x00000001899BFD30 */ get => default; } // 0x00000001844F7360-0x00000001844F7400 

	// Constructors
	public FireEffectToTarget() {} // 0x00000001844F89D0-0x00000001844F8A70

	// Methods
	// [XID] // 0x0000000189925200-0x0000000189925220
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001844F85A0-0x00000001844F8700
	// [XID] // 0x000000018992C840-0x000000018992C860
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001844F7F80-0x00000001844F8060
	// [XID] // 0x0000000189933EC0-0x0000000189933EE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3894 */) => default; // 0x00000001844F7A80-0x00000001844F7B60
	// [XID] // 0x000000018993BA10-0x000000018993BA30
	public override int GetHashNum() => default; // 0x00000001844F6120-0x00000001844F61F0
	// [XID] // 0x0000000189942B50-0x0000000189942B70
	public override void InitEmpty() {} // 0x00000001844F7400-0x00000001844F7510
	[BlackList] // 0x000000018994A340-0x000000018994A380
	// [XID] // 0x000000018994A340-0x000000018994A380
	public override bool FromJson(JSONNode node) => default; // 0x00000001844F6A10-0x00000001844F6D90
	// [XID] // 0x0000000189954AA0-0x0000000189954AC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001844F54A0-0x00000001844F5960
	[BlackList] // 0x000000018995C260-0x000000018995C2A0
	// [XID] // 0x000000018995C260-0x000000018995C2A0
	public static new FireEffectToTarget ParseFromJson(JSONNode node) => default; // 0x00000001844F7C30-0x00000001844F7E80
	// [XID] // 0x0000000189966DB0-0x0000000189966DD0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3895 */, bool useObjectPool = false /* Metadata: 0x00AF3899 */) => default; // 0x00000001844F7780-0x00000001844F7A80
	// [XID] // 0x000000018996E0E0-0x000000018996E100
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF389A */, bool useObjectPool = false /* Metadata: 0x00AF389E */) => default; // 0x00000001844F6340-0x00000001844F6740
	// [XID] // 0x0000000189975CB0-0x0000000189975CD0
	public static new FireEffectToTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF389F */, bool useObjectPool = false /* Metadata: 0x00AF38A3 */) => default; // 0x00000001844F6E30-0x00000001844F7050
	[BlackList] // 0x000000018997CD90-0x000000018997CDD0
	// [XID] // 0x000000018997CD90-0x000000018997CDD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001844F5960-0x00000001844F5C30
	// [XID] // 0x0000000189987B50-0x0000000189987B70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001844F81E0-0x00000001844F85A0
	[BlackList] // 0x000000018998F6A0-0x000000018998F6E0
	// [XID] // 0x000000018998F6A0-0x000000018998F6E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001844F7690-0x00000001844F7780
	// [XID] // 0x000000018999A610-0x000000018999A630
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001844F87E0-0x00000001844F8880
	// [XID] // 0x00000001899B1050-0x00000001899B1070
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001844F6740-0x00000001844F68A0
	[BlackList] // 0x00000001899C7510-0x00000001899C7550
	// [XID] // 0x00000001899C7510-0x00000001899C7550
	public override void AutoAllocTypeFields() {} // 0x00000001844F5C30-0x00000001844F5CD0
	[BlackList] // 0x00000001899D1B40-0x00000001899D1B80
	// [XID] // 0x00000001899D1B40-0x00000001899D1B80
	public override void AutoRecycleTypeFields() {} // 0x00000001844F5CD0-0x00000001844F5E40
	[BlackList] // 0x00000001899DC0D0-0x00000001899DC110
	// [XID] // 0x00000001899DC0D0-0x00000001899DC110
	public override void ReturnToObjectPool() {} // 0x00000001844F8930-0x00000001844F89D0
}

