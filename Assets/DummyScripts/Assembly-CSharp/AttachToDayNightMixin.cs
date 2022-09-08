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
public class AttachToDayNightMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17020
{
	// Fields
	private LevelDayTimeType _time; // 0x30
	private string _modifierName; // 0x38

	// Properties
	public LevelDayTimeType time { /* [XID] */ /* 0x00000001899EC650-0x00000001899EC670 */ get => default; /* [XID] */ /* 0x00000001899F43D0-0x00000001899F43F0 */ private set {} } // 0x000000018350CB50-0x000000018350CBF0 0x000000018350C990-0x000000018350CA40
	public string modifierName { /* [XID] */ /* 0x00000001899FB930-0x00000001899FB950 */ get => default; /* [XID] */ /* 0x0000000189A02D30-0x0000000189A02D50 */ private set {} } // 0x000000018350CBF0-0x000000018350CC90 0x000000018350BCB0-0x000000018350BD60
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A863F0-0x0000000189A86410 */ get => default; } // 0x000000018350B350-0x000000018350B3F0 

	// Constructors
	public AttachToDayNightMixin() {} // 0x000000018350CD30-0x000000018350CD90

	// Methods
	// [XID] // 0x0000000189A0A320-0x0000000189A0A340
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018350CA40-0x000000018350CB50
	// [XID] // 0x0000000189A11C80-0x0000000189A11CA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018350C620-0x000000018350C700
	// [XID] // 0x0000000189A18F50-0x0000000189A18F70
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF609D */) => default; // 0x000000018350C230-0x000000018350C310
	// [XID] // 0x0000000189A20670-0x0000000189A20690
	public override int GetHashNum() => default; // 0x000000018350ADC0-0x000000018350AE90
	// [XID] // 0x0000000189A27AE0-0x0000000189A27B00
	public override void InitEmpty() {} // 0x000000018350BB00-0x000000018350BBD0
	[BlackList] // 0x0000000189A2F170-0x0000000189A2F1B0
	// [XID] // 0x0000000189A2F170-0x0000000189A2F1B0
	public override bool FromJson(JSONNode node) => default; // 0x000000018350B3F0-0x000000018350B770
	// [XID] // 0x0000000189A39990-0x0000000189A399B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018350A580-0x000000018350A880
	[BlackList] // 0x0000000189A411D0-0x0000000189A41210
	// [XID] // 0x0000000189A411D0-0x0000000189A41210
	public static new AttachToDayNightMixin ParseFromJson(JSONNode node) => default; // 0x000000018350C370-0x000000018350C5C0
	// [XID] // 0x0000000189A4B7E0-0x0000000189A4B800
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF609E */, bool useObjectPool = false /* Metadata: 0x00AF60A2 */) => default; // 0x000000018350BE50-0x000000018350C150
	// [XID] // 0x0000000189A52EE0-0x0000000189A52F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60A3 */, bool useObjectPool = false /* Metadata: 0x00AF60A7 */) => default; // 0x000000018350AF70-0x000000018350B250
	// [XID] // 0x0000000189A5A730-0x0000000189A5A750
	public static new AttachToDayNightMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60A8 */, bool useObjectPool = false /* Metadata: 0x00AF60AC */) => default; // 0x000000018350B7E0-0x000000018350BA00
	[BlackList] // 0x0000000189A61E70-0x0000000189A61EB0
	// [XID] // 0x0000000189A61E70-0x0000000189A61EB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018350A880-0x000000018350AB50
	// [XID] // 0x0000000189A6CA20-0x0000000189A6CA40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018350C700-0x000000018350C990
	[BlackList] // 0x0000000189A74150-0x0000000189A74190
	// [XID] // 0x0000000189A74150-0x0000000189A74190
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018350BD60-0x000000018350BE50
	// [XID] // 0x0000000189A7EC00-0x0000000189A7EC20
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018350C150-0x000000018350C230
	[BlackList] // 0x0000000189A8DDB0-0x0000000189A8DDF0
	// [XID] // 0x0000000189A8DDB0-0x0000000189A8DDF0
	public override void AutoAllocTypeFields() {} // 0x000000018350AB50-0x000000018350ABF0
	[BlackList] // 0x0000000189A98620-0x0000000189A98660
	// [XID] // 0x0000000189A98620-0x0000000189A98660
	public override void AutoRecycleTypeFields() {} // 0x000000018350ABF0-0x000000018350ACA0
	[BlackList] // 0x0000000189AA28C0-0x0000000189AA2900
	// [XID] // 0x0000000189AA28C0-0x0000000189AA2900
	public override void ReturnToObjectPool() {} // 0x000000018350CC90-0x000000018350CD30
}

