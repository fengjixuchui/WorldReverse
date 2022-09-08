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
public class DoActionByEnergyChangeMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17008
{
	// Fields
	private AvatarStageType _type; // 0x30
	private ElementType[] _elementTypes; // 0x38
	private bool _doWhenEnergyMax; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onGainEnergyByBall; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onGainEnergyByOther; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onGainEnergyByAll; // 0x58
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onGainEnergyMax; // 0x60

	// Properties
	public AvatarStageType type { /* [XID] */ /* 0x0000000189A3E1D0-0x0000000189A3E1F0 */ get => default; /* [XID] */ /* 0x0000000189A45920-0x0000000189A45940 */ private set {} } // 0x00000001836B7120-0x00000001836B71C0 0x00000001836B6770-0x00000001836B6820
	public ElementType[] elementTypes { /* [XID] */ /* 0x0000000189A4CFA0-0x0000000189A4CFC0 */ get => default; /* [XID] */ /* 0x0000000189A546D0-0x0000000189A546F0 */ private set {} } // 0x00000001836B4650-0x00000001836B46F0 0x00000001836B4D60-0x00000001836B4E10
	public bool doWhenEnergyMax { /* [XID] */ /* 0x0000000189A5C1C0-0x0000000189A5C1E0 */ get => default; /* [XID] */ /* 0x0000000189A63B30-0x0000000189A63B50 */ private set {} } // 0x00000001836B6330-0x00000001836B63D0 0x00000001836B6820-0x00000001836B68D0
	public ConfigAbilityAction[] onGainEnergyByBall { /* [XID] */ /* 0x0000000189A6B350-0x0000000189A6B370 */ get => default; /* [XID] */ /* 0x0000000189A72B80-0x0000000189A72BA0 */ private set {} } // 0x00000001836B6EE0-0x00000001836B6F80 0x00000001836B63D0-0x00000001836B6480
	public ConfigAbilityAction[] onGainEnergyByOther { /* [XID] */ /* 0x0000000189A7A6D0-0x0000000189A7A6F0 */ get => default; /* [XID] */ /* 0x0000000189A81C30-0x0000000189A81C50 */ private set {} } // 0x00000001836B6630-0x00000001836B66D0 0x00000001836B5A70-0x00000001836B5B20
	public ConfigAbilityAction[] onGainEnergyByAll { /* [XID] */ /* 0x0000000189A89690-0x0000000189A896B0 */ get => default; /* [XID] */ /* 0x0000000189A90E30-0x0000000189A90E50 */ private set {} } // 0x00000001836B5FE0-0x00000001836B6080 0x00000001836B59C0-0x00000001836B5A70
	public ConfigAbilityAction[] onGainEnergyMax { /* [XID] */ /* 0x0000000189A98660-0x0000000189A98680 */ get => default; /* [XID] */ /* 0x0000000189A9FA70-0x0000000189A9FA90 */ private set {} } // 0x00000001836B66D0-0x00000001836B6770 0x00000001836B3EF0-0x00000001836B3FA0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B23FC0-0x0000000189B23FE0 */ get => default; } // 0x00000001836B4F10-0x00000001836B4FB0 

	// Constructors
	public DoActionByEnergyChangeMixin() {} // 0x00000001836B7260-0x00000001836B72D0

	// Methods
	// [XID] // 0x0000000189AA71E0-0x0000000189AA7200
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836B6F80-0x00000001836B7120
	// [XID] // 0x0000000189AAE8E0-0x0000000189AAE900
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001836B64E0-0x00000001836B6630
	// [XID] // 0x0000000189AB6240-0x0000000189AB6260
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF603D */) => default; // 0x00000001836B5F00-0x00000001836B5FE0
	// [XID] // 0x0000000189ABDC70-0x0000000189ABDC90
	public override int GetHashNum() => default; // 0x00000001836B4520-0x00000001836B45F0
	// [XID] // 0x0000000189AC57F0-0x0000000189AC5810
	public override void InitEmpty() {} // 0x00000001836B56C0-0x00000001836B57F0
	[BlackList] // 0x0000000189ACCCA0-0x0000000189ACCCE0
	// [XID] // 0x0000000189ACCCA0-0x0000000189ACCCE0
	public override bool FromJson(JSONNode node) => default; // 0x00000001836B4FB0-0x00000001836B5330
	// [XID] // 0x0000000189AD7AE0-0x0000000189AD7B00
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001836B37D0-0x00000001836B3EF0
	[BlackList] // 0x0000000189ADF5B0-0x0000000189ADF5F0
	// [XID] // 0x0000000189ADF5B0-0x0000000189ADF5F0
	public static new DoActionByEnergyChangeMixin ParseFromJson(JSONNode node) => default; // 0x00000001836B60E0-0x00000001836B6330
	// [XID] // 0x0000000189AE9B50-0x0000000189AE9B70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF603E */, bool useObjectPool = false /* Metadata: 0x00AF6042 */) => default; // 0x00000001836B5B20-0x00000001836B5E20
	// [XID] // 0x0000000189AF18D0-0x0000000189AF18F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6043 */, bool useObjectPool = false /* Metadata: 0x00AF6047 */) => default; // 0x00000001836B4770-0x00000001836B4D60
	// [XID] // 0x0000000189AF9010-0x0000000189AF9030
	public static new DoActionByEnergyChangeMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6048 */, bool useObjectPool = false /* Metadata: 0x00AF604C */) => default; // 0x00000001836B53A0-0x00000001836B55C0
	[BlackList] // 0x0000000189B005B0-0x0000000189B005F0
	// [XID] // 0x0000000189B005B0-0x0000000189B005F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001836B3FA0-0x00000001836B4270
	// [XID] // 0x0000000189B0AC80-0x0000000189B0ACA0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836B68D0-0x00000001836B6EE0
	[BlackList] // 0x0000000189B123A0-0x0000000189B123E0
	// [XID] // 0x0000000189B123A0-0x0000000189B123E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001836B58D0-0x00000001836B59C0
	// [XID] // 0x0000000189B1CA30-0x0000000189B1CA50
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001836B5E20-0x00000001836B5F00
	[BlackList] // 0x0000000189B2B3F0-0x0000000189B2B430
	// [XID] // 0x0000000189B2B3F0-0x0000000189B2B430
	public override void AutoAllocTypeFields() {} // 0x00000001836B4270-0x00000001836B4310
	[BlackList] // 0x0000000189B355A0-0x0000000189B355E0
	// [XID] // 0x0000000189B355A0-0x0000000189B355E0
	public override void AutoRecycleTypeFields() {} // 0x00000001836B4310-0x00000001836B4400
	[BlackList] // 0x0000000189B401C0-0x0000000189B40200
	// [XID] // 0x0000000189B401C0-0x0000000189B40200
	public override void ReturnToObjectPool() {} // 0x00000001836B71C0-0x00000001836B7260
}

