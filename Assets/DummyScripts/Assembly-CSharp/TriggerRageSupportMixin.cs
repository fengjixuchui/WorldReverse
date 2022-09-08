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
public class TriggerRageSupportMixin : TriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 16936
{
	// Fields
	private SimpleSafeFloat dampRatioRawNum; // 0x38
	private SimpleSafeFloat addRatioRawNum; // 0x3C
	private SimpleSafeFloat maxValueRawNum; // 0x40
	private SimpleSafeFloat minValueRawNum; // 0x44

	// Properties
	public float dampRatio { /* [XID] */ /* 0x000000018961DA30-0x000000018961DA50 */ get => default; /* [XID] */ /* 0x0000000189624F10-0x0000000189624F30 */ private set {} } // 0x00000001847B3C60-0x00000001847B3D40 0x00000001847B5800-0x00000001847B58E0
	public float addRatio { /* [XID] */ /* 0x000000018962C710-0x000000018962C730 */ get => default; /* [XID] */ /* 0x00000001896343D0-0x00000001896343F0 */ private set {} } // 0x00000001847B4C00-0x00000001847B4CE0 0x00000001847B3B00-0x00000001847B3BE0
	public float maxValue { /* [XID] */ /* 0x000000018963BB00-0x000000018963BB20 */ get => default; /* [XID] */ /* 0x00000001896431C0-0x00000001896431E0 */ private set {} } // 0x00000001847B4B20-0x00000001847B4C00 0x00000001847B39C0-0x00000001847B3AA0
	public float minValue { /* [XID] */ /* 0x000000018964A8A0-0x000000018964A8C0 */ get => default; /* [XID] */ /* 0x0000000189652160-0x0000000189652180 */ private set {} } // 0x00000001847B54D0-0x00000001847B55B0 0x00000001847B4330-0x00000001847B4410
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896D5380-0x00000001896D53A0 */ get => default; } // 0x00000001847B4290-0x00000001847B4330 

	// Constructors
	public TriggerRageSupportMixin() {} // 0x00000001847B5F80-0x00000001847B5FE0

	// Methods
	// [XID] // 0x00000001896597D0-0x00000001896597F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001847B5D90-0x00000001847B5EE0
	// [XID] // 0x0000000189660F90-0x0000000189660FB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847B5940-0x00000001847B59F0
	// [XID] // 0x0000000189668960-0x0000000189668980
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E0D */) => default; // 0x00000001847B5390-0x00000001847B5470
	// [XID] // 0x00000001896704B0-0x00000001896704D0
	public override int GetHashNum() => default; // 0x00000001847B38F0-0x00000001847B39C0
	// [XID] // 0x0000000189677CF0-0x0000000189677D10
	public override void InitEmpty() {} // 0x00000001847B4CE0-0x00000001847B4DE0
	[BlackList] // 0x000000018967F240-0x000000018967F280
	// [XID] // 0x000000018967F240-0x000000018967F280
	public override bool FromJson(JSONNode node) => default; // 0x00000001847B4410-0x00000001847B4790
	// [XID] // 0x0000000189689DB0-0x0000000189689DD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001847B2D70-0x00000001847B3350
	[BlackList] // 0x0000000189691B30-0x0000000189691B70
	// [XID] // 0x0000000189691B30-0x0000000189691B70
	public static new TriggerRageSupportMixin ParseFromJson(JSONNode node) => default; // 0x00000001847B55B0-0x00000001847B5800
	// [XID] // 0x000000018969C0C0-0x000000018969C0E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E0E */, bool useObjectPool = false /* Metadata: 0x00AF5E12 */) => default; // 0x00000001847B4FB0-0x00000001847B52B0
	// [XID] // 0x00000001896A34E0-0x00000001896A3500
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E13 */, bool useObjectPool = false /* Metadata: 0x00AF5E17 */) => default; // 0x00000001847B3D40-0x00000001847B4190
	// [XID] // 0x00000001896AA950-0x00000001896AA970
	public static new TriggerRageSupportMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E18 */, bool useObjectPool = false /* Metadata: 0x00AF5E1C */) => default; // 0x00000001847B4800-0x00000001847B4A20
	[BlackList] // 0x00000001896B1930-0x00000001896B1970
	// [XID] // 0x00000001896B1930-0x00000001896B1970
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001847B3350-0x00000001847B3620
	// [XID] // 0x00000001896BC2C0-0x00000001896BC2E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001847B59F0-0x00000001847B5D90
	[BlackList] // 0x00000001896C3720-0x00000001896C3760
	// [XID] // 0x00000001896C3720-0x00000001896C3760
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001847B4EC0-0x00000001847B4FB0
	// [XID] // 0x00000001896CDE10-0x00000001896CDE30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001847B52B0-0x00000001847B5390
	[BlackList] // 0x00000001896DC900-0x00000001896DC940
	// [XID] // 0x00000001896DC900-0x00000001896DC940
	public override void AutoAllocTypeFields() {} // 0x00000001847B3620-0x00000001847B36C0
	[BlackList] // 0x00000001896E6F00-0x00000001896E6F40
	// [XID] // 0x00000001896E6F00-0x00000001896E6F40
	public override void AutoRecycleTypeFields() {} // 0x00000001847B36C0-0x00000001847B37D0
	[BlackList] // 0x00000001896F1080-0x00000001896F10C0
	// [XID] // 0x00000001896F1080-0x00000001896F10C0
	public override void ReturnToObjectPool() {} // 0x00000001847B5EE0-0x00000001847B5F80
}

