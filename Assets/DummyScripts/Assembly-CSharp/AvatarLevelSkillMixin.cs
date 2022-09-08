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
public class AvatarLevelSkillMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16961
{
	// Fields
	private SimpleSafeUInt32 skillIDRawNum; // 0x30
	private SimpleSafeInt32 skillIndexRawNum; // 0x34

	// Properties
	public uint skillID { /* [XID] */ /* 0x00000001897E5F30-0x00000001897E5F50 */ get => default; /* [XID] */ /* 0x00000001897ED8F0-0x00000001897ED910 */ private set {} } // 0x0000000182A3BBC0-0x0000000182A3BC90 0x0000000182A3CBA0-0x0000000182A3CC80
	public int skillIndex { /* [XID] */ /* 0x00000001897F50F0-0x00000001897F5110 */ get => default; /* [XID] */ /* 0x00000001897FCBC0-0x00000001897FCBE0 */ private set {} } // 0x0000000182A3C480-0x0000000182A3C550 0x0000000182A3B2B0-0x0000000182A3B390
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018987ED60-0x000000018987ED80 */ get => default; } // 0x0000000182A3B410-0x0000000182A3B4B0 

	// Constructors
	public AvatarLevelSkillMixin() {} // 0x0000000182A3CE30-0x0000000182A3CE90

	// Methods
	// [XID] // 0x0000000189804150-0x0000000189804170
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A3CC80-0x0000000182A3CD90
	// [XID] // 0x000000018980B520-0x000000018980B540
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A3C800-0x0000000182A3C8B0
	// [XID] // 0x0000000189812C00-0x0000000189812C20
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5ECF */) => default; // 0x0000000182A3C340-0x0000000182A3C420
	// [XID] // 0x000000018981A7C0-0x000000018981A7E0
	public override int GetHashNum() => default; // 0x0000000182A3AD80-0x0000000182A3AE50
	// [XID] // 0x0000000189821F50-0x0000000189821F70
	public override void InitEmpty() {} // 0x0000000182A3BC90-0x0000000182A3BD90
	[BlackList] // 0x0000000189829470-0x00000001898294B0
	// [XID] // 0x0000000189829470-0x00000001898294B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A3B4B0-0x0000000182A3B830
	// [XID] // 0x0000000189833B80-0x0000000189833BA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A3A460-0x0000000182A3A7E0
	[BlackList] // 0x000000018983B040-0x000000018983B080
	// [XID] // 0x000000018983B040-0x000000018983B080
	public static new AvatarLevelSkillMixin ParseFromJson(JSONNode node) => default; // 0x0000000182A3C550-0x0000000182A3C7A0
	// [XID] // 0x0000000189845710-0x0000000189845730
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5ED0 */, bool useObjectPool = false /* Metadata: 0x00AF5ED4 */) => default; // 0x0000000182A3BF60-0x0000000182A3C260
	// [XID] // 0x000000018984CC60-0x000000018984CC80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5ED5 */, bool useObjectPool = false /* Metadata: 0x00AF5ED9 */) => default; // 0x0000000182A3AF30-0x0000000182A3B230
	// [XID] // 0x0000000189853C60-0x0000000189853C80
	public static new AvatarLevelSkillMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EDA */, bool useObjectPool = false /* Metadata: 0x00AF5EDE */) => default; // 0x0000000182A3B8A0-0x0000000182A3BAC0
	[BlackList] // 0x000000018985B770-0x000000018985B7B0
	// [XID] // 0x000000018985B770-0x000000018985B7B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A3A7E0-0x0000000182A3AAB0
	// [XID] // 0x0000000189865950-0x0000000189865970
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A3C8B0-0x0000000182A3CBA0
	[BlackList] // 0x000000018986CE10-0x000000018986CE50
	// [XID] // 0x000000018986CE10-0x000000018986CE50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A3BE70-0x0000000182A3BF60
	// [XID] // 0x00000001898774F0-0x0000000189877510
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182A3C260-0x0000000182A3C340
	[BlackList] // 0x00000001898862A0-0x00000001898862E0
	// [XID] // 0x00000001898862A0-0x00000001898862E0
	public override void AutoAllocTypeFields() {} // 0x0000000182A3AAB0-0x0000000182A3AB50
	[BlackList] // 0x0000000189890500-0x0000000189890540
	// [XID] // 0x0000000189890500-0x0000000189890540
	public override void AutoRecycleTypeFields() {} // 0x0000000182A3AB50-0x0000000182A3AC60
	[BlackList] // 0x000000018989ACD0-0x000000018989AD10
	// [XID] // 0x000000018989ACD0-0x000000018989AD10
	public override void ReturnToObjectPool() {} // 0x0000000182A3CD90-0x0000000182A3CE30
}

