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
public class CostStaminaMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16965
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _costStaminaDelta; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _costStaminaRatio; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onStaminaEmpty; // 0x40

	// Properties
	public DynamicFloat costStaminaDelta { /* [XID] */ /* 0x00000001899B2770-0x00000001899B2790 */ get => default; /* [XID] */ /* 0x00000001899B99F0-0x00000001899B9A10 */ private set {} } // 0x000000018451B220-0x000000018451B2C0 0x000000018451CEC0-0x000000018451CF70
	public DynamicFloat costStaminaRatio { /* [XID] */ /* 0x00000001899C1530-0x00000001899C1550 */ get => default; /* [XID] */ /* 0x00000001899C8AA0-0x00000001899C8AC0 */ private set {} } // 0x000000018451CF70-0x000000018451D010 0x000000018451C3E0-0x000000018451C490
	public ConfigAbilityAction[] onStaminaEmpty { /* [XID] */ /* 0x00000001899D0470-0x00000001899D0490 */ get => default; /* [XID] */ /* 0x00000001899D7910-0x00000001899D7930 */ private set {} } // 0x000000018451ABB0-0x000000018451AC50 0x000000018451C140-0x000000018451C1F0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A5A750-0x0000000189A5A770 */ get => default; } // 0x000000018451BA00-0x000000018451BAA0 

	// Constructors
	public CostStaminaMixin() {} // 0x000000018451D580-0x000000018451D5E0

	// Methods
	// [XID] // 0x00000001899DED70-0x00000001899DED90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018451D390-0x000000018451D4E0
	// [XID] // 0x00000001899E6990-0x00000001899E69B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018451CDB0-0x000000018451CEC0
	// [XID] // 0x00000001899EDFC0-0x00000001899EDFE0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5EEF */) => default; // 0x000000018451C9C0-0x000000018451CAA0
	// [XID] // 0x00000001899F57B0-0x00000001899F57D0
	public override int GetHashNum() => default; // 0x000000018451B340-0x000000018451B410
	// [XID] // 0x00000001899FCF70-0x00000001899FCF90
	public override void InitEmpty() {} // 0x000000018451C260-0x000000018451C360
	[BlackList] // 0x0000000189A043F0-0x0000000189A04430
	// [XID] // 0x0000000189A043F0-0x0000000189A04430
	public override bool FromJson(JSONNode node) => default; // 0x000000018451BAA0-0x000000018451BE20
	// [XID] // 0x0000000189A0EA70-0x0000000189A0EA90
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018451A790-0x000000018451ABB0
	[BlackList] // 0x0000000189A16160-0x0000000189A161A0
	// [XID] // 0x0000000189A16160-0x0000000189A161A0
	public static new CostStaminaMixin ParseFromJson(JSONNode node) => default; // 0x000000018451CB00-0x000000018451CD50
	// [XID] // 0x0000000189A206F0-0x0000000189A20710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EF0 */, bool useObjectPool = false /* Metadata: 0x00AF5EF4 */) => default; // 0x000000018451C5E0-0x000000018451C8E0
	// [XID] // 0x0000000189A27B40-0x0000000189A27B60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EF5 */, bool useObjectPool = false /* Metadata: 0x00AF5EF9 */) => default; // 0x000000018451B4F0-0x000000018451B900
	// [XID] // 0x0000000189A2F1B0-0x0000000189A2F1D0
	public static new CostStaminaMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EFA */, bool useObjectPool = false /* Metadata: 0x00AF5EFE */) => default; // 0x000000018451BE90-0x000000018451C0B0
	[BlackList] // 0x0000000189A36B50-0x0000000189A36B90
	// [XID] // 0x0000000189A36B50-0x0000000189A36B90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018451AC50-0x000000018451AF20
	// [XID] // 0x0000000189A41210-0x0000000189A41230
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018451D010-0x000000018451D390
	[BlackList] // 0x0000000189A48890-0x0000000189A488D0
	// [XID] // 0x0000000189A48890-0x0000000189A488D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018451C4F0-0x000000018451C5E0
	// [XID] // 0x0000000189A52F40-0x0000000189A52F60
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018451C8E0-0x000000018451C9C0
	[BlackList] // 0x0000000189A61EB0-0x0000000189A61EF0
	// [XID] // 0x0000000189A61EB0-0x0000000189A61EF0
	public override void AutoAllocTypeFields() {} // 0x000000018451AF20-0x000000018451AFC0
	[BlackList] // 0x0000000189A6CA40-0x0000000189A6CA80
	// [XID] // 0x0000000189A6CA40-0x0000000189A6CA80
	public override void AutoRecycleTypeFields() {} // 0x000000018451AFC0-0x000000018451B180
	[BlackList] // 0x0000000189A77290-0x0000000189A772D0
	// [XID] // 0x0000000189A77290-0x0000000189A772D0
	public override void ReturnToObjectPool() {} // 0x000000018451D4E0-0x000000018451D580
}

