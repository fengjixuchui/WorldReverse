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
public class AttachModifierToHPPercentMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17059
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DynamicFloat[] _valueSteps; // 0x30
	private string[] _modifierNameSteps; // 0x38

	// Properties
	public DynamicFloat[] valueSteps { /* [XID] */ /* 0x0000000189928090-0x00000001899280B0 */ get => default; /* [XID] */ /* 0x000000018992F6E0-0x000000018992F700 */ private set {} } // 0x000000018292CE20-0x000000018292CEC0 0x000000018292CA50-0x000000018292CB00
	public string[] modifierNameSteps { /* [XID] */ /* 0x0000000189936B50-0x0000000189936B70 */ get => default; /* [XID] */ /* 0x000000018993E710-0x000000018993E730 */ private set {} } // 0x000000018292C510-0x000000018292C5B0 0x000000018292C3E0-0x000000018292C490
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899C2DC0-0x00000001899C2DE0 */ get => default; } // 0x000000018292C630-0x000000018292C6D0 

	// Constructors
	public AttachModifierToHPPercentMixin() {} // 0x000000018292DF60-0x000000018292DFC0

	// Methods
	// [XID] // 0x0000000189945D60-0x0000000189945D80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018292DDB0-0x000000018292DEC0
	// [XID] // 0x000000018994D1F0-0x000000018994D210
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018292D9C0-0x000000018292DAC0
	// [XID] // 0x00000001899549C0-0x00000001899549E0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF61D3 */) => default; // 0x000000018292D5D0-0x000000018292D6B0
	// [XID] // 0x000000018995C1E0-0x000000018995C200
	public override int GetHashNum() => default; // 0x000000018292BF20-0x000000018292BFF0
	// [XID] // 0x0000000189963C20-0x0000000189963C40
	public override void InitEmpty() {} // 0x000000018292CF30-0x000000018292D020
	[BlackList] // 0x000000018996B1B0-0x000000018996B1F0
	// [XID] // 0x000000018996B1B0-0x000000018996B1F0
	public override bool FromJson(JSONNode node) => default; // 0x000000018292C6D0-0x000000018292CA50
	// [XID] // 0x0000000189975BB0-0x0000000189975BD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018292B6B0-0x000000018292B9D0
	[BlackList] // 0x000000018997CBB0-0x000000018997CBF0
	// [XID] // 0x000000018997CBB0-0x000000018997CBF0
	public static new AttachModifierToHPPercentMixin ParseFromJson(JSONNode node) => default; // 0x000000018292D710-0x000000018292D960
	// [XID] // 0x00000001899879D0-0x00000001899879F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61D4 */, bool useObjectPool = false /* Metadata: 0x00AF61D8 */) => default; // 0x000000018292D1F0-0x000000018292D4F0
	// [XID] // 0x000000018998F5A0-0x000000018998F5C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61D9 */, bool useObjectPool = false /* Metadata: 0x00AF61DD */) => default; // 0x000000018292C0D0-0x000000018292C3E0
	// [XID] // 0x0000000189996FC0-0x0000000189996FE0
	public static new AttachModifierToHPPercentMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF61DE */, bool useObjectPool = false /* Metadata: 0x00AF61E2 */) => default; // 0x000000018292CB70-0x000000018292CD90
	[BlackList] // 0x000000018999EB30-0x000000018999EB70
	// [XID] // 0x000000018999EB30-0x000000018999EB70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018292B9D0-0x000000018292BCA0
	// [XID] // 0x00000001899A93A0-0x00000001899A93C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018292DAC0-0x000000018292DDB0
	[BlackList] // 0x00000001899B0E90-0x00000001899B0ED0
	// [XID] // 0x00000001899B0E90-0x00000001899B0ED0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018292D100-0x000000018292D1F0
	// [XID] // 0x00000001899BB2D0-0x00000001899BB2F0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018292D4F0-0x000000018292D5D0
	[BlackList] // 0x00000001899CA200-0x00000001899CA240
	// [XID] // 0x00000001899CA200-0x00000001899CA240
	public override void AutoAllocTypeFields() {} // 0x000000018292BCA0-0x000000018292BD40
	[BlackList] // 0x00000001899D4930-0x00000001899D4970
	// [XID] // 0x00000001899D4930-0x00000001899D4970
	public override void AutoRecycleTypeFields() {} // 0x000000018292BD40-0x000000018292BE00
	[BlackList] // 0x00000001899DECF0-0x00000001899DED30
	// [XID] // 0x00000001899DECF0-0x00000001899DED30
	public override void ReturnToObjectPool() {} // 0x000000018292DEC0-0x000000018292DF60
}

