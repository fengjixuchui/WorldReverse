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
public class WeightDetectRegionMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16951
{
	// Fields
	private string _globalValueKey; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onWeightChanged; // 0x38

	// Properties
	public string globalValueKey { /* [XID] */ /* 0x0000000189A38210-0x0000000189A38230 */ get => default; /* [XID] */ /* 0x0000000189A3F980-0x0000000189A3F9A0 */ private set {} } // 0x00000001850846C0-0x0000000185084760 0x0000000185083660-0x0000000185083710
	public ConfigAbilityAction[] onWeightChanged { /* [XID] */ /* 0x0000000189A470B0-0x0000000189A470D0 */ get => default; /* [XID] */ /* 0x0000000189A4E9D0-0x0000000189A4E9F0 */ private set {} } // 0x0000000185083B70-0x0000000185083C10 0x00000001850843D0-0x0000000185084480
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189AD2FC0-0x0000000189AD2FE0 */ get => default; } // 0x0000000185083C90-0x0000000185083D30 

	// Constructors
	public WeightDetectRegionMixin() {} // 0x0000000185085590-0x00000001850855F0

	// Methods
	// [XID] // 0x0000000189A560E0-0x0000000189A56100
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850853E0-0x00000001850854F0
	// [XID] // 0x0000000189A5DB80-0x0000000189A5DBA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185085020-0x0000000185085120
	// [XID] // 0x0000000189A652E0-0x0000000189A65300
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E87 */) => default; // 0x0000000185084C30-0x0000000185084D10
	// [XID] // 0x0000000189A6CA80-0x0000000189A6CAA0
	public override int GetHashNum() => default; // 0x0000000185083590-0x0000000185083660
	// [XID] // 0x0000000189A74190-0x0000000189A741B0
	public override void InitEmpty() {} // 0x00000001850844F0-0x00000001850845E0
	[BlackList] // 0x0000000189A7BB00-0x0000000189A7BB40
	// [XID] // 0x0000000189A7BB00-0x0000000189A7BB40
	public override bool FromJson(JSONNode node) => default; // 0x0000000185083D30-0x00000001850840B0
	// [XID] // 0x0000000189A86410-0x0000000189A86430
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185082D30-0x0000000185083040
	[BlackList] // 0x0000000189A8DDF0-0x0000000189A8DE30
	// [XID] // 0x0000000189A8DDF0-0x0000000189A8DE30
	public static new WeightDetectRegionMixin ParseFromJson(JSONNode node) => default; // 0x0000000185084D70-0x0000000185084FC0
	// [XID] // 0x0000000189A986C0-0x0000000189A986E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E88 */, bool useObjectPool = false /* Metadata: 0x00AF5E8C */) => default; // 0x0000000185084850-0x0000000185084B50
	// [XID] // 0x0000000189A9FAD0-0x0000000189A9FAF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E8D */, bool useObjectPool = false /* Metadata: 0x00AF5E91 */) => default; // 0x00000001850837F0-0x0000000185083AF0
	// [XID] // 0x0000000189AA7260-0x0000000189AA7280
	public static new WeightDetectRegionMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E92 */, bool useObjectPool = false /* Metadata: 0x00AF5E96 */) => default; // 0x0000000185084120-0x0000000185084340
	[BlackList] // 0x0000000189AAE960-0x0000000189AAE9A0
	// [XID] // 0x0000000189AAE960-0x0000000189AAE9A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185083040-0x0000000185083310
	// [XID] // 0x0000000189AB9070-0x0000000189AB9090
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185085120-0x00000001850853E0
	[BlackList] // 0x0000000189AC0BB0-0x0000000189AC0BF0
	// [XID] // 0x0000000189AC0BB0-0x0000000189AC0BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185084760-0x0000000185084850
	// [XID] // 0x0000000189ACB590-0x0000000189ACB5B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000185084B50-0x0000000185084C30
	[BlackList] // 0x0000000189ADAA00-0x0000000189ADAA40
	// [XID] // 0x0000000189ADAA00-0x0000000189ADAA40
	public override void AutoAllocTypeFields() {} // 0x0000000185083310-0x00000001850833B0
	[BlackList] // 0x0000000189AE5720-0x0000000189AE5760
	// [XID] // 0x0000000189AE5720-0x0000000189AE5760
	public override void AutoRecycleTypeFields() {} // 0x00000001850833B0-0x0000000185083470
	[BlackList] // 0x0000000189AF0250-0x0000000189AF0290
	// [XID] // 0x0000000189AF0250-0x0000000189AF0290
	public override void ReturnToObjectPool() {} // 0x00000001850854F0-0x0000000185085590
}

