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
public class ReviveElemEnergyMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16992
{
	// Fields
	private AvatarStageType _type; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _period; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _baseEnergy; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _ratio; // 0x48

	// Properties
	public AvatarStageType type { /* [XID] */ /* 0x0000000189A90E50-0x0000000189A90E70 */ get => default; /* [XID] */ /* 0x0000000189A98680-0x0000000189A986A0 */ private set {} } // 0x000000018273A770-0x000000018273A810 0x000000018273A150-0x000000018273A200
	public DynamicFloat period { /* [XID] */ /* 0x0000000189A9FA90-0x0000000189A9FAB0 */ get => default; /* [XID] */ /* 0x0000000189AA7200-0x0000000189AA7220 */ private set {} } // 0x00000001827390A0-0x0000000182739140 0x0000000182738F80-0x0000000182739030
	public DynamicFloat baseEnergy { /* [XID] */ /* 0x0000000189AAE900-0x0000000189AAE920 */ get => default; /* [XID] */ /* 0x0000000189AB6260-0x0000000189AB6280 */ private set {} } // 0x00000001827397D0-0x0000000182739870 0x0000000182737F10-0x0000000182737FC0
	public DynamicFloat ratio { /* [XID] */ /* 0x0000000189ABDC90-0x0000000189ABDCB0 */ get => default; /* [XID] */ /* 0x0000000189AC5810-0x0000000189AC5830 */ private set {} } // 0x0000000182738460-0x0000000182738500 0x00000001827393F0-0x00000001827394A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B49580-0x0000000189B495A0 */ get => default; } // 0x0000000182738B60-0x0000000182738C00 

	// Constructors
	public ReviveElemEnergyMixin() {} // 0x000000018273A8B0-0x000000018273A950

	// Methods
	// [XID] // 0x0000000189ACCCE0-0x0000000189ACCD00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018273A5F0-0x000000018273A770
	// [XID] // 0x0000000189AD4A00-0x0000000189AD4A20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018273A040-0x000000018273A150
	// [XID] // 0x0000000189ADC360-0x0000000189ADC380
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5FC5 */) => default; // 0x0000000182739C50-0x0000000182739D30
	// [XID] // 0x0000000189AE3D50-0x0000000189AE3D70
	public override int GetHashNum() => default; // 0x0000000182738390-0x0000000182738460
	// [XID] // 0x0000000189AEB590-0x0000000189AEB5B0
	public override void InitEmpty() {} // 0x0000000182739510-0x0000000182739600
	[BlackList] // 0x0000000189AF2ED0-0x0000000189AF2F10
	// [XID] // 0x0000000189AF2ED0-0x0000000189AF2F10
	public override bool FromJson(JSONNode node) => default; // 0x0000000182738C00-0x0000000182738F80
	// [XID] // 0x0000000189AFD330-0x0000000189AFD350
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182737770-0x0000000182737C40
	[BlackList] // 0x0000000189B04B40-0x0000000189B04B80
	// [XID] // 0x0000000189B04B40-0x0000000189B04B80
	public static new ReviveElemEnergyMixin ParseFromJson(JSONNode node) => default; // 0x0000000182739D90-0x0000000182739FE0
	// [XID] // 0x0000000189B0F310-0x0000000189B0F330
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FC6 */, bool useObjectPool = false /* Metadata: 0x00AF5FCA */) => default; // 0x0000000182739870-0x0000000182739B70
	// [XID] // 0x0000000189B16630-0x0000000189B16650
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FCB */, bool useObjectPool = false /* Metadata: 0x00AF5FCF */) => default; // 0x00000001827385E0-0x0000000182738A60
	// [XID] // 0x0000000189B1DCF0-0x0000000189B1DD10
	public static new ReviveElemEnergyMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5FD0 */, bool useObjectPool = false /* Metadata: 0x00AF5FD4 */) => default; // 0x0000000182739140-0x0000000182739360
	[BlackList] // 0x0000000189B254E0-0x0000000189B25520
	// [XID] // 0x0000000189B254E0-0x0000000189B25520
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182737C40-0x0000000182737F10
	// [XID] // 0x0000000189B2F730-0x0000000189B2F750
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018273A200-0x000000018273A5F0
	[BlackList] // 0x0000000189B36FD0-0x0000000189B37010
	// [XID] // 0x0000000189B36FD0-0x0000000189B37010
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827396E0-0x00000001827397D0
	// [XID] // 0x0000000189B41BF0-0x0000000189B41C10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182739B70-0x0000000182739C50
	[BlackList] // 0x0000000189B50BC0-0x0000000189B50C00
	// [XID] // 0x0000000189B50BC0-0x0000000189B50C00
	public override void AutoAllocTypeFields() {} // 0x0000000182737FC0-0x0000000182738060
	[BlackList] // 0x0000000189B5B2D0-0x0000000189B5B310
	// [XID] // 0x0000000189B5B2D0-0x0000000189B5B310
	public override void AutoRecycleTypeFields() {} // 0x0000000182738060-0x0000000182738270
	[BlackList] // 0x0000000189B65A80-0x0000000189B65AC0
	// [XID] // 0x0000000189B65A80-0x0000000189B65AC0
	public override void ReturnToObjectPool() {} // 0x000000018273A810-0x000000018273A8B0
}

