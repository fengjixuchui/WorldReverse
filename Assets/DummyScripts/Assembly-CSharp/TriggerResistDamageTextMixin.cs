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
public class TriggerResistDamageTextMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17041
{
	// Fields
	private ElementType[] _elementTypes; // 0x30

	// Properties
	public ElementType[] elementTypes { /* [XID] */ /* 0x00000001896670D0-0x00000001896670F0 */ get => default; /* [XID] */ /* 0x000000018966E780-0x000000018966E7A0 */ private set {} } // 0x0000000183522890-0x0000000183522930 0x0000000183522C20-0x0000000183522CD0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896F1060-0x00000001896F1080 */ get => default; } // 0x0000000183522DD0-0x0000000183522E70 

	// Constructors
	public TriggerResistDamageTextMixin() {} // 0x00000001835244A0-0x0000000183524500

	// Methods
	// [XID] // 0x0000000189676380-0x00000001896763A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183524310-0x0000000183524400
	// [XID] // 0x000000018967DBA0-0x000000018967DBC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183523FF0-0x00000001835240D0
	// [XID] // 0x0000000189685300-0x0000000189685320
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6143 */) => default; // 0x0000000183523C00-0x0000000183523CE0
	// [XID] // 0x000000018968CDE0-0x000000018968CE00
	public override int GetHashNum() => default; // 0x0000000183522760-0x0000000183522830
	// [XID] // 0x0000000189694940-0x0000000189694960
	public override void InitEmpty() {} // 0x0000000183523580-0x0000000183523650
	[BlackList] // 0x000000018969C040-0x000000018969C080
	// [XID] // 0x000000018969C040-0x000000018969C080
	public override bool FromJson(JSONNode node) => default; // 0x0000000183522E70-0x00000001835231F0
	// [XID] // 0x00000001896A6310-0x00000001896A6330
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183521FF0-0x0000000183522220
	[BlackList] // 0x00000001896AD850-0x00000001896AD890
	// [XID] // 0x00000001896AD850-0x00000001896AD890
	public static new TriggerResistDamageTextMixin ParseFromJson(JSONNode node) => default; // 0x0000000183523D40-0x0000000183523F90
	// [XID] // 0x00000001896B7E50-0x00000001896B7E70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6144 */, bool useObjectPool = false /* Metadata: 0x00AF6148 */) => default; // 0x0000000183523820-0x0000000183523B20
	// [XID] // 0x00000001896BEE90-0x00000001896BEEB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6149 */, bool useObjectPool = false /* Metadata: 0x00AF614D */) => default; // 0x00000001835229B0-0x0000000183522C20
	// [XID] // 0x00000001896C6830-0x00000001896C6850
	public static new TriggerResistDamageTextMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF614E */, bool useObjectPool = false /* Metadata: 0x00AF6152 */) => default; // 0x0000000183523260-0x0000000183523480
	[BlackList] // 0x00000001896CDD90-0x00000001896CDDD0
	// [XID] // 0x00000001896CDD90-0x00000001896CDDD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183522220-0x00000001835224F0
	// [XID] // 0x00000001896D8230-0x00000001896D8250
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835240D0-0x0000000183524310
	[BlackList] // 0x00000001896DFB60-0x00000001896DFBA0
	// [XID] // 0x00000001896DFB60-0x00000001896DFBA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183523730-0x0000000183523820
	// [XID] // 0x00000001896E9FC0-0x00000001896E9FE0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183523B20-0x0000000183523C00
	[BlackList] // 0x00000001896F8920-0x00000001896F8960
	// [XID] // 0x00000001896F8920-0x00000001896F8960
	public override void AutoAllocTypeFields() {} // 0x00000001835224F0-0x0000000183522590
	[BlackList] // 0x00000001897032D0-0x0000000189703310
	// [XID] // 0x00000001897032D0-0x0000000189703310
	public override void AutoRecycleTypeFields() {} // 0x0000000183522590-0x0000000183522640
	[BlackList] // 0x000000018970D970-0x000000018970D9B0
	// [XID] // 0x000000018970D970-0x000000018970D9B0
	public override void ReturnToObjectPool() {} // 0x0000000183524400-0x00000001835244A0
}

