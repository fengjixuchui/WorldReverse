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
public class HealHP : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16444
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amount; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCasterMaxHPRatio; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByTargetMaxHPRatio; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByTargetCurrentHPRatio; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCasterAttackRatio; // 0x88
	private bool _muteHealEffect; // 0x90
	private SimpleSafeFloat healRatioRawNum; // 0x94
	private bool _ignoreAbilityProperty; // 0x98

	// Properties
	public DynamicFloat amount { /* [XID] */ /* 0x00000001899FD050-0x00000001899FD070 */ get => default; /* [XID] */ /* 0x0000000189A044F0-0x0000000189A04510 */ private set {} } // 0x00000001846D71C0-0x00000001846D7260 0x00000001846D5BA0-0x00000001846D5C50
	public DynamicFloat amountByCasterMaxHPRatio { /* [XID] */ /* 0x0000000189A0BBF0-0x0000000189A0BC10 */ get => default; /* [XID] */ /* 0x0000000189A134E0-0x0000000189A13500 */ private set {} } // 0x00000001846D5B00-0x00000001846D5BA0 0x00000001846D4460-0x00000001846D4510
	public DynamicFloat amountByTargetMaxHPRatio { /* [XID] */ /* 0x0000000189A1A610-0x0000000189A1A630 */ get => default; /* [XID] */ /* 0x0000000189A21F10-0x0000000189A21F30 */ private set {} } // 0x00000001846D7E20-0x00000001846D7EC0 0x00000001846D5100-0x00000001846D51B0
	public DynamicFloat amountByTargetCurrentHPRatio { /* [XID] */ /* 0x0000000189A29340-0x0000000189A29360 */ get => default; /* [XID] */ /* 0x0000000189A308D0-0x0000000189A308F0 */ private set {} } // 0x00000001846D6F20-0x00000001846D6FD0 0x00000001846D5630-0x00000001846D56E0
	public DynamicFloat amountByCasterAttackRatio { /* [XID] */ /* 0x0000000189A382D0-0x0000000189A382F0 */ get => default; /* [XID] */ /* 0x0000000189A3FB00-0x0000000189A3FB20 */ private set {} } // 0x00000001846D86B0-0x00000001846D8760 0x00000001846D5CD0-0x00000001846D5D80
	public bool muteHealEffect { /* [XID] */ /* 0x0000000189A471B0-0x0000000189A471D0 */ get => default; /* [XID] */ /* 0x0000000189A4EAD0-0x0000000189A4EAF0 */ private set {} } // 0x00000001846D5980-0x00000001846D5A30 0x00000001846D66D0-0x00000001846D6780
	public float healRatio { /* [XID] */ /* 0x0000000189A56140-0x0000000189A56160 */ get => default; /* [XID] */ /* 0x0000000189A5DC60-0x0000000189A5DC80 */ private set {} } // 0x00000001846D7760-0x00000001846D7840 0x00000001846D5750-0x00000001846D5830
	public bool ignoreAbilityProperty { /* [XID] */ /* 0x0000000189A653E0-0x0000000189A65400 */ get => default; /* [XID] */ /* 0x0000000189A6CB00-0x0000000189A6CB20 */ private set {} } // 0x00000001846D73B0-0x00000001846D7460 0x00000001846D7EC0-0x00000001846D7F70
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AF90D0-0x0000000189AF90F0 */ get => default; } // 0x00000001846D7BD0-0x00000001846D7C70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B00690-0x0000000189B006B0 */ get => default; } // 0x00000001846D6E80-0x00000001846D6F20 

	// Constructors
	public HealHP() {} // 0x00000001846D8AC0-0x00000001846D8B60

	// Methods
	// [XID] // 0x0000000189A74290-0x0000000189A742B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001846D8760-0x00000001846D8980
	// [XID] // 0x0000000189A7BC20-0x0000000189A7BC40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001846D7CD0-0x00000001846D7E20
	// [XID] // 0x0000000189A835A0-0x0000000189A835C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B9A */) => default; // 0x00000001846D7840-0x00000001846D7920
	// [XID] // 0x0000000189A8AE40-0x0000000189A8AE60
	public override int GetHashNum() => default; // 0x00000001846D58B0-0x00000001846D5980
	// [XID] // 0x0000000189A925D0-0x0000000189A925F0
	public override void InitEmpty() {} // 0x00000001846D6FD0-0x00000001846D7140
	[BlackList] // 0x0000000189A9A080-0x0000000189A9A0C0
	// [XID] // 0x0000000189A9A080-0x0000000189A9A0C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001846D6800-0x00000001846D6B80
	// [XID] // 0x0000000189AA44E0-0x0000000189AA4500
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001846D4590-0x00000001846D4E30
	[BlackList] // 0x0000000189AAB9B0-0x0000000189AAB9F0
	// [XID] // 0x0000000189AAB9B0-0x0000000189AAB9F0
	public static new HealHP ParseFromJson(JSONNode node) => default; // 0x00000001846D7980-0x00000001846D7BD0
	// [XID] // 0x0000000189AB6360-0x0000000189AB6380
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B9B */, bool useObjectPool = false /* Metadata: 0x00AF3B9F */) => default; // 0x00000001846D7460-0x00000001846D7760
	// [XID] // 0x0000000189ABDE10-0x0000000189ABDE30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BA0 */, bool useObjectPool = false /* Metadata: 0x00AF3BA4 */) => default; // 0x00000001846D5D80-0x00000001846D64F0
	// [XID] // 0x0000000189AC5930-0x0000000189AC5950
	public static new HealHP ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BA5 */, bool useObjectPool = false /* Metadata: 0x00AF3BA9 */) => default; // 0x00000001846D6B80-0x00000001846D6DA0
	[BlackList] // 0x0000000189ACCEA0-0x0000000189ACCEE0
	// [XID] // 0x0000000189ACCEA0-0x0000000189ACCEE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001846D4E30-0x00000001846D5100
	// [XID] // 0x0000000189AD7C00-0x0000000189AD7C20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001846D8050-0x00000001846D86B0
	[BlackList] // 0x0000000189ADF690-0x0000000189ADF6D0
	// [XID] // 0x0000000189ADF690-0x0000000189ADF6D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001846D72C0-0x00000001846D73B0
	// [XID] // 0x0000000189AE9BF0-0x0000000189AE9C10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001846D8980-0x00000001846D8A20
	// [XID] // 0x0000000189AF1970-0x0000000189AF1990
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001846D64F0-0x00000001846D6650
	[BlackList] // 0x0000000189B07BD0-0x0000000189B07C10
	// [XID] // 0x0000000189B07BD0-0x0000000189B07C10
	public override void AutoAllocTypeFields() {} // 0x00000001846D51B0-0x00000001846D5250
	[BlackList] // 0x0000000189B12400-0x0000000189B12440
	// [XID] // 0x0000000189B12400-0x0000000189B12440
	public override void AutoRecycleTypeFields() {} // 0x00000001846D5250-0x00000001846D5590
	[BlackList] // 0x0000000189B1CAB0-0x0000000189B1CAF0
	// [XID] // 0x0000000189B1CAB0-0x0000000189B1CAF0
	public override void ReturnToObjectPool() {} // 0x00000001846D8A20-0x00000001846D8AC0
}

