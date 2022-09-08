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
public class TriggerTypeSupportMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16930
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x30
	private SimpleSafeFloat radiusRawNum; // 0x34

	// Properties
	public float duration { /* [XID] */ /* 0x00000001899DD6A0-0x00000001899DD6C0 */ get => default; /* [XID] */ /* 0x00000001899E53A0-0x00000001899E53C0 */ private set {} } // 0x0000000183AA8FF0-0x0000000183AA90D0 0x0000000183AA95E0-0x0000000183AA96C0
	public float radius { /* [XID] */ /* 0x00000001899EC690-0x00000001899EC6B0 */ get => default; /* [XID] */ /* 0x00000001899F4410-0x00000001899F4430 */ private set {} } // 0x0000000183AAAAB0-0x0000000183AAAB90 0x0000000183AAAF30-0x0000000183AAB010
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A772D0-0x0000000189A772F0 */ get => default; } // 0x0000000183AA97C0-0x0000000183AA9860 

	// Constructors
	public TriggerTypeSupportMixin() {} // 0x0000000183AAB0B0-0x0000000183AAB150

	// Methods
	// [XID] // 0x00000001899FB990-0x00000001899FB9B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AAAE20-0x0000000183AAAF30
	// [XID] // 0x0000000189A02D90-0x0000000189A02DB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AAAA00-0x0000000183AAAAB0
	// [XID] // 0x0000000189A0A3C0-0x0000000189A0A3E0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DDD */) => default; // 0x0000000183AAA610-0x0000000183AAA6F0
	// [XID] // 0x0000000189A11D00-0x0000000189A11D20
	public override int GetHashNum() => default; // 0x0000000183AA9150-0x0000000183AA9220
	// [XID] // 0x0000000189A18FD0-0x0000000189A18FF0
	public override void InitEmpty() {} // 0x0000000183AA9F70-0x0000000183AAA060
	[BlackList] // 0x0000000189A20730-0x0000000189A20770
	// [XID] // 0x0000000189A20730-0x0000000189A20770
	public override bool FromJson(JSONNode node) => default; // 0x0000000183AA9860-0x0000000183AA9BE0
	// [XID] // 0x0000000189A2AAC0-0x0000000189A2AAE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183AA8770-0x0000000183AA8AF0
	[BlackList] // 0x0000000189A320C0-0x0000000189A32100
	// [XID] // 0x0000000189A320C0-0x0000000189A32100
	public static new TriggerTypeSupportMixin ParseFromJson(JSONNode node) => default; // 0x0000000183AAA750-0x0000000183AAA9A0
	// [XID] // 0x0000000189A3C840-0x0000000189A3C860
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DDE */, bool useObjectPool = false /* Metadata: 0x00AF5DE2 */) => default; // 0x0000000183AAA230-0x0000000183AAA530
	// [XID] // 0x0000000189A442D0-0x0000000189A442F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DE3 */, bool useObjectPool = false /* Metadata: 0x00AF5DE7 */) => default; // 0x0000000183AA9300-0x0000000183AA95E0
	// [XID] // 0x0000000189A4B860-0x0000000189A4B880
	public static new TriggerTypeSupportMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DE8 */, bool useObjectPool = false /* Metadata: 0x00AF5DEC */) => default; // 0x0000000183AA9C50-0x0000000183AA9E70
	[BlackList] // 0x0000000189A52F60-0x0000000189A52FA0
	// [XID] // 0x0000000189A52F60-0x0000000189A52FA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AA8AF0-0x0000000183AA8DC0
	// [XID] // 0x0000000189A5DBA0-0x0000000189A5DBC0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AAAB90-0x0000000183AAAE20
	[BlackList] // 0x0000000189A65300-0x0000000189A65340
	// [XID] // 0x0000000189A65300-0x0000000189A65340
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AAA140-0x0000000183AAA230
	// [XID] // 0x0000000189A6FB00-0x0000000189A6FB20
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183AAA530-0x0000000183AAA610
	[BlackList] // 0x0000000189A7EC20-0x0000000189A7EC60
	// [XID] // 0x0000000189A7EC20-0x0000000189A7EC60
	public override void AutoAllocTypeFields() {} // 0x0000000183AA8DC0-0x0000000183AA8E60
	[BlackList] // 0x0000000189A896D0-0x0000000189A89710
	// [XID] // 0x0000000189A896D0-0x0000000189A89710
	public override void AutoRecycleTypeFields() {} // 0x0000000183AA8E60-0x0000000183AA8F50
	[BlackList] // 0x0000000189A93A10-0x0000000189A93A50
	// [XID] // 0x0000000189A93A10-0x0000000189A93A50
	public override void ReturnToObjectPool() {} // 0x0000000183AAB010-0x0000000183AAB0B0
}

