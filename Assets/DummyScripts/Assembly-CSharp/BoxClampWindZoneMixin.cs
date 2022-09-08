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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class BoxClampWindZoneMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17028
{
	// Fields
	private MoleMole.Config.Vector _size; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x40
	private SimpleSafeFloat attracForceStrengthRawNum; // 0x48
	private SimpleSafeFloat maxStrengthRangeRawNum; // 0x4C

	// Properties
	public MoleMole.Config.Vector size { /* [XID] */ /* 0x0000000189668940-0x0000000189668960 */ get => default; /* [XID] */ /* 0x0000000189670490-0x00000001896704B0 */ private set {} } // 0x00000001826205F0-0x00000001826206D0 0x000000018261F840-0x000000018261F910
	public ConfigBornType born { /* [XID] */ /* 0x0000000189677CB0-0x0000000189677CD0 */ get => default; /* [XID] */ /* 0x000000018967F200-0x000000018967F220 */ private set {} } // 0x000000018261E360-0x000000018261E400 0x0000000182620860-0x0000000182620910
	public float attracForceStrength { /* [XID] */ /* 0x0000000189686B50-0x0000000189686B70 */ get => default; /* [XID] */ /* 0x000000018968EA30-0x000000018968EA50 */ private set {} } // 0x000000018261EB90-0x000000018261EC70 0x000000018261E990-0x000000018261EA70
	public float maxStrengthRange { /* [XID] */ /* 0x0000000189696470-0x0000000189696490 */ get => default; /* [XID] */ /* 0x000000018969D9F0-0x000000018969DA10 */ private set {} } // 0x000000018261F460-0x000000018261F540 0x000000018261EC70-0x000000018261ED50
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018971F950-0x000000018971F970 */ get => default; } // 0x000000018261EAF0-0x000000018261EB90 

	// Constructors
	public BoxClampWindZoneMixin() {} // 0x00000001826209B0-0x0000000182620A10

	// Methods
	// [XID] // 0x00000001896A4A60-0x00000001896A4A80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001826206D0-0x0000000182620860
	// [XID] // 0x00000001896AC230-0x00000001896AC250
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001826200E0-0x00000001826201C0
	// [XID] // 0x00000001896B34D0-0x00000001896B34F0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF60D9 */) => default; // 0x000000018261FCF0-0x000000018261FDD0
	// [XID] // 0x00000001896BAC50-0x00000001896BAC70
	public override int GetHashNum() => default; // 0x000000018261E290-0x000000018261E360
	// [XID] // 0x00000001896C1DA0-0x00000001896C1DC0
	public override void InitEmpty() {} // 0x000000018261F540-0x000000018261F670
	[BlackList] // 0x00000001896C9390-0x00000001896C93D0
	// [XID] // 0x00000001896C9390-0x00000001896C93D0
	public override bool FromJson(JSONNode node) => default; // 0x000000018261ED50-0x000000018261F0D0
	// [XID] // 0x00000001896D37A0-0x00000001896D37C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018261D730-0x000000018261DC70
	[BlackList] // 0x00000001896DB2A0-0x00000001896DB2E0
	// [XID] // 0x00000001896DB2A0-0x00000001896DB2E0
	public static new BoxClampWindZoneMixin ParseFromJson(JSONNode node) => default; // 0x000000018261FE30-0x0000000182620080
	// [XID] // 0x00000001896E5650-0x00000001896E5670
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60DA */, bool useObjectPool = false /* Metadata: 0x00AF60DE */) => default; // 0x000000018261F910-0x000000018261FC10
	// [XID] // 0x00000001896ECD80-0x00000001896ECDA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60DF */, bool useObjectPool = false /* Metadata: 0x00AF60E3 */) => default; // 0x000000018261E4E0-0x000000018261E910
	// [XID] // 0x00000001896F4540-0x00000001896F4560
	public static new BoxClampWindZoneMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF60E4 */, bool useObjectPool = false /* Metadata: 0x00AF60E8 */) => default; // 0x000000018261F140-0x000000018261F360
	[BlackList] // 0x00000001896FBD70-0x00000001896FBDB0
	// [XID] // 0x00000001896FBD70-0x00000001896FBDB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018261DC70-0x000000018261DF40
	// [XID] // 0x00000001897060C0-0x00000001897060E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001826201C0-0x00000001826205F0
	[BlackList] // 0x000000018970D9B0-0x000000018970D9F0
	// [XID] // 0x000000018970D9B0-0x000000018970D9F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018261F750-0x000000018261F840
	// [XID] // 0x0000000189717F90-0x0000000189717FB0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018261FC10-0x000000018261FCF0
	[BlackList] // 0x0000000189726FA0-0x0000000189726FE0
	// [XID] // 0x0000000189726FA0-0x0000000189726FE0
	public override void AutoAllocTypeFields() {} // 0x000000018261DF40-0x000000018261DFE0
	[BlackList] // 0x0000000189731440-0x0000000189731480
	// [XID] // 0x0000000189731440-0x0000000189731480
	public override void AutoRecycleTypeFields() {} // 0x000000018261DFE0-0x000000018261E170
	[BlackList] // 0x000000018973BDA0-0x000000018973BDE0
	// [XID] // 0x000000018973BDA0-0x000000018973BDE0
	public override void ReturnToObjectPool() {} // 0x0000000182620910-0x00000001826209B0
}

