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
public class ExtendLifetimeByPickedGadgetMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17006
{
	// Fields
	private SimpleSafeUInt32[] _pickedConfigIDs; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _extendLifeTime; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxExtendLifeTime; // 0x40

	// Properties
	public SimpleSafeUInt32[] pickedConfigIDs { /* [XID] */ /* 0x0000000189948DA0-0x0000000189948DC0 */ get => default; /* [XID] */ /* 0x00000001899505B0-0x00000001899505D0 */ private set {} } // 0x0000000185879720-0x00000001858797C0 0x000000018587B120-0x000000018587B1D0
	public DynamicFloat extendLifeTime { /* [XID] */ /* 0x0000000189957B00-0x0000000189957B20 */ get => default; /* [XID] */ /* 0x000000018995F390-0x000000018995F3B0 */ private set {} } // 0x0000000185879600-0x00000001858796A0 0x0000000185879010-0x00000001858790C0
	public DynamicFloat maxExtendLifeTime { /* [XID] */ /* 0x0000000189966CB0-0x0000000189966CD0 */ get => default; /* [XID] */ /* 0x000000018996DFC0-0x000000018996DFE0 */ private set {} } // 0x000000018587A170-0x000000018587A210 0x00000001858790C0-0x0000000185879170
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899F2980-0x00000001899F29A0 */ get => default; } // 0x0000000185879840-0x00000001858798E0 

	// Constructors
	public ExtendLifetimeByPickedGadgetMixin() {} // 0x000000018587B270-0x000000018587B2D0

	// Methods
	// [XID] // 0x0000000189975BD0-0x0000000189975BF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018587AFC0-0x000000018587B120
	// [XID] // 0x000000018997CBF0-0x000000018997CC10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018587AB30-0x000000018587AC40
	// [XID] // 0x0000000189984990-0x00000001899849B0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF602D */) => default; // 0x000000018587A740-0x000000018587A820
	// [XID] // 0x000000018998C4B0-0x000000018998C4D0
	public override int GetHashNum() => default; // 0x0000000185878EE0-0x0000000185878FB0
	// [XID] // 0x00000001899941B0-0x00000001899941D0
	public override void InitEmpty() {} // 0x0000000185879FF0-0x000000018587A0F0
	[BlackList] // 0x000000018999BA00-0x000000018999BA40
	// [XID] // 0x000000018999BA00-0x000000018999BA40
	public override bool FromJson(JSONNode node) => default; // 0x00000001858798E0-0x0000000185879C60
	// [XID] // 0x00000001899A6570-0x00000001899A6590
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185878480-0x00000001858788A0
	[BlackList] // 0x00000001899ADCC0-0x00000001899ADD00
	// [XID] // 0x00000001899ADCC0-0x00000001899ADD00
	public static new ExtendLifetimeByPickedGadgetMixin ParseFromJson(JSONNode node) => default; // 0x000000018587A880-0x000000018587AAD0
	// [XID] // 0x00000001899B8190-0x00000001899B81B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF602E */, bool useObjectPool = false /* Metadata: 0x00AF6032 */) => default; // 0x000000018587A360-0x000000018587A660
	// [XID] // 0x00000001899BFCB0-0x00000001899BFCD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6033 */, bool useObjectPool = false /* Metadata: 0x00AF6037 */) => default; // 0x00000001858791F0-0x0000000185879600
	// [XID] // 0x00000001899C7470-0x00000001899C7490
	public static new ExtendLifetimeByPickedGadgetMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6038 */, bool useObjectPool = false /* Metadata: 0x00AF603C */) => default; // 0x0000000185879CD0-0x0000000185879EF0
	[BlackList] // 0x00000001899CEAA0-0x00000001899CEAE0
	// [XID] // 0x00000001899CEAA0-0x00000001899CEAE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001858788A0-0x0000000185878B70
	// [XID] // 0x00000001899D8FB0-0x00000001899D8FD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018587AC40-0x000000018587AFC0
	[BlackList] // 0x00000001899E0720-0x00000001899E0760
	// [XID] // 0x00000001899E0720-0x00000001899E0760
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018587A270-0x000000018587A360
	// [XID] // 0x00000001899EAD00-0x00000001899EAD20
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018587A660-0x000000018587A740
	[BlackList] // 0x00000001899F9E90-0x00000001899F9ED0
	// [XID] // 0x00000001899F9E90-0x00000001899F9ED0
	public override void AutoAllocTypeFields() {} // 0x0000000185878B70-0x0000000185878C10
	[BlackList] // 0x0000000189A043B0-0x0000000189A043F0
	// [XID] // 0x0000000189A043B0-0x0000000189A043F0
	public override void AutoRecycleTypeFields() {} // 0x0000000185878C10-0x0000000185878DC0
	[BlackList] // 0x0000000189A0EA30-0x0000000189A0EA70
	// [XID] // 0x0000000189A0EA30-0x0000000189A0EA70
	public override void ReturnToObjectPool() {} // 0x000000018587B1D0-0x000000018587B270
}

