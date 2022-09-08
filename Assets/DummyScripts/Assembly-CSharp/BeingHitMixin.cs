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
public class BeingHitMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16971
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _toAttacker; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _toAttackerOwner; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _toAttackerOriginOwner; // 0x40

	// Properties
	public ConfigAbilityAction[] toAttacker { /* [XID] */ /* 0x00000001896C36E0-0x00000001896C3700 */ get => default; /* [XID] */ /* 0x00000001896CAC50-0x00000001896CAC70 */ private set {} } // 0x00000001820665C0-0x0000000182066660 0x0000000182066E90-0x0000000182066F40
	public ConfigAbilityAction[] toAttackerOwner { /* [XID] */ /* 0x00000001896D2300-0x00000001896D2320 */ get => default; /* [XID] */ /* 0x00000001896D9C90-0x00000001896D9CB0 */ private set {} } // 0x0000000182066010-0x00000001820660B0 0x0000000182065E90-0x0000000182065F40
	public ConfigAbilityAction[] toAttackerOriginOwner { /* [XID] */ /* 0x00000001896E1310-0x00000001896E1330 */ get => default; /* [XID] */ /* 0x00000001896E85C0-0x00000001896E85E0 */ private set {} } // 0x0000000182067AF0-0x0000000182067B90 0x0000000182065490-0x0000000182065540
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018976BAE0-0x000000018976BB00 */ get => default; } // 0x00000001820666E0-0x0000000182066780 

	// Constructors
	public BeingHitMixin() {} // 0x0000000182068100-0x0000000182068160

	// Methods
	// [XID] // 0x00000001896EFAC0-0x00000001896EFAE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182067F30-0x0000000182068060
	// [XID] // 0x00000001896F74F0-0x00000001896F7510
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820679E0-0x0000000182067AF0
	// [XID] // 0x00000001896FEEB0-0x00000001896FEED0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F1F */) => default; // 0x00000001820675F0-0x00000001820676D0
	// [XID] // 0x0000000189706100-0x0000000189706120
	public override int GetHashNum() => default; // 0x0000000182065F40-0x0000000182066010
	// [XID] // 0x000000018970DA30-0x000000018970DA50
	public override void InitEmpty() {} // 0x0000000182066F40-0x0000000182067040
	[BlackList] // 0x0000000189714E30-0x0000000189714E70
	// [XID] // 0x0000000189714E30-0x0000000189714E70
	public override bool FromJson(JSONNode node) => default; // 0x0000000182066780-0x0000000182066B00
	// [XID] // 0x000000018971F9B0-0x000000018971F9D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182065540-0x0000000182065930
	[BlackList] // 0x0000000189726FE0-0x0000000189727020
	// [XID] // 0x0000000189726FE0-0x0000000189727020
	public static new BeingHitMixin ParseFromJson(JSONNode node) => default; // 0x0000000182067730-0x0000000182067980
	// [XID] // 0x00000001897314C0-0x00000001897314E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F20 */, bool useObjectPool = false /* Metadata: 0x00AF5F24 */) => default; // 0x0000000182067210-0x0000000182067510
	// [XID] // 0x0000000189738D10-0x0000000189738D30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F25 */, bool useObjectPool = false /* Metadata: 0x00AF5F29 */) => default; // 0x0000000182066190-0x0000000182066540
	// [XID] // 0x0000000189740B00-0x0000000189740B20
	public static new BeingHitMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F2A */, bool useObjectPool = false /* Metadata: 0x00AF5F2E */) => default; // 0x0000000182066B70-0x0000000182066D90
	[BlackList] // 0x0000000189747F00-0x0000000189747F40
	// [XID] // 0x0000000189747F00-0x0000000189747F40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182065930-0x0000000182065C00
	// [XID] // 0x0000000189752430-0x0000000189752450
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182067B90-0x0000000182067F30
	[BlackList] // 0x0000000189759960-0x00000001897599A0
	// [XID] // 0x0000000189759960-0x00000001897599A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182067120-0x0000000182067210
	// [XID] // 0x0000000189764220-0x0000000189764240
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182067510-0x00000001820675F0
	[BlackList] // 0x0000000189772FE0-0x0000000189773020
	// [XID] // 0x0000000189772FE0-0x0000000189773020
	public override void AutoAllocTypeFields() {} // 0x0000000182065C00-0x0000000182065CA0
	[BlackList] // 0x000000018977D900-0x000000018977D940
	// [XID] // 0x000000018977D900-0x000000018977D940
	public override void AutoRecycleTypeFields() {} // 0x0000000182065CA0-0x0000000182065D70
	[BlackList] // 0x0000000189787FA0-0x0000000189787FE0
	// [XID] // 0x0000000189787FA0-0x0000000189787FE0
	public override void ReturnToObjectPool() {} // 0x0000000182068060-0x0000000182068100
}

