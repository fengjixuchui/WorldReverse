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
public class SwitchSkillIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16957
{
	// Fields
	private SwitchSkillPriority _priority; // 0x30
	private SimpleSafeInt32 skillIndexRawNum; // 0x34
	private SimpleSafeUInt32 skillIDRawNum; // 0x38
	private SimpleSafeUInt32 fromSkillIDRawNum; // 0x3C
	private SimpleSafeUInt32 toSkillIDRawNum; // 0x40

	// Properties
	public SwitchSkillPriority priority { /* [XID] */ /* 0x00000001895EC590-0x00000001895EC5B0 */ get => default; /* [XID] */ /* 0x00000001895F3AD0-0x00000001895F3AF0 */ private set {} } // 0x0000000183B0D880-0x0000000183B0D920 0x0000000183B0C570-0x0000000183B0C620
	public int skillIndex { /* [XID] */ /* 0x00000001895FB390-0x00000001895FB3B0 */ get => default; /* [XID] */ /* 0x0000000189602B30-0x0000000189602B50 */ private set {} } // 0x0000000183B0D980-0x0000000183B0DA50 0x0000000183B0C490-0x0000000183B0C570
	public uint skillID { /* [XID] */ /* 0x000000018960A470-0x000000018960A490 */ get => default; /* [XID] */ /* 0x0000000189611C40-0x0000000189611C60 */ private set {} } // 0x0000000183B0CF30-0x0000000183B0D000 0x0000000183B0E360-0x0000000183B0E440
	public uint fromSkillID { /* [XID] */ /* 0x0000000189619500-0x0000000189619520 */ get => default; /* [XID] */ /* 0x0000000189620A80-0x0000000189620AA0 */ private set {} } // 0x0000000183B0D2F0-0x0000000183B0D3C0 0x0000000183B0C740-0x0000000183B0C820
	public uint toSkillID { /* [XID] */ /* 0x0000000189627FF0-0x0000000189628010 */ get => default; /* [XID] */ /* 0x000000018962F8C0-0x000000018962F8E0 */ private set {} } // 0x0000000183B0C340-0x0000000183B0C410 0x0000000183B0DDB0-0x0000000183B0DE90
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896B34F0-0x00000001896B3510 */ get => default; } // 0x0000000183B0C6A0-0x0000000183B0C740 

	// Constructors
	public SwitchSkillIDMixin() {} // 0x0000000183B0E640-0x0000000183B0E6B0

	// Methods
	// [XID] // 0x0000000189637460-0x0000000189637480
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B0E440-0x0000000183B0E5A0
	// [XID] // 0x000000018963EA00-0x000000018963EA20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B0DD00-0x0000000183B0DDB0
	// [XID] // 0x0000000189646100-0x0000000189646120
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5EAF */) => default; // 0x0000000183B0D7A0-0x0000000183B0D880
	// [XID] // 0x000000018964D920-0x000000018964D940
	public override int GetHashNum() => default; // 0x0000000183B0BCC0-0x0000000183B0BD90
	// [XID] // 0x00000001896550E0-0x0000000189655100
	public override void InitEmpty() {} // 0x0000000183B0D000-0x0000000183B0D120
	[BlackList] // 0x000000018965C940-0x000000018965C980
	// [XID] // 0x000000018965C940-0x000000018965C980
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B0C820-0x0000000183B0CBA0
	// [XID] // 0x00000001896670F0-0x0000000189667110
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B0B060-0x0000000183B0B6F0
	[BlackList] // 0x000000018966E7A0-0x000000018966E7E0
	// [XID] // 0x000000018966E7A0-0x000000018966E7E0
	public static new SwitchSkillIDMixin ParseFromJson(JSONNode node) => default; // 0x0000000183B0DA50-0x0000000183B0DCA0
	// [XID] // 0x0000000189679670-0x0000000189679690
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EB0 */, bool useObjectPool = false /* Metadata: 0x00AF5EB4 */) => default; // 0x0000000183B0D3C0-0x0000000183B0D6C0
	// [XID] // 0x0000000189680DC0-0x0000000189680DE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EB5 */, bool useObjectPool = false /* Metadata: 0x00AF5EB9 */) => default; // 0x0000000183B0BE70-0x0000000183B0C340
	// [XID] // 0x00000001896887E0-0x0000000189688800
	public static new SwitchSkillIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EBA */, bool useObjectPool = false /* Metadata: 0x00AF5EBE */) => default; // 0x0000000183B0CC10-0x0000000183B0CE30
	[BlackList] // 0x00000001896901A0-0x00000001896901E0
	// [XID] // 0x00000001896901A0-0x00000001896901E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B0B6F0-0x0000000183B0B9C0
	// [XID] // 0x000000018969A670-0x000000018969A690
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B0DE90-0x0000000183B0E360
	[BlackList] // 0x00000001896A1FA0-0x00000001896A1FE0
	// [XID] // 0x00000001896A1FA0-0x00000001896A1FE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B0D200-0x0000000183B0D2F0
	// [XID] // 0x00000001896AC250-0x00000001896AC270
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183B0D6C0-0x0000000183B0D7A0
	[BlackList] // 0x00000001896BAC70-0x00000001896BACB0
	// [XID] // 0x00000001896BAC70-0x00000001896BACB0
	public override void AutoAllocTypeFields() {} // 0x0000000183B0B9C0-0x0000000183B0BA60
	[BlackList] // 0x00000001896C4F90-0x00000001896C4FD0
	// [XID] // 0x00000001896C4F90-0x00000001896C4FD0
	public override void AutoRecycleTypeFields() {} // 0x0000000183B0BA60-0x0000000183B0BBA0
	[BlackList] // 0x00000001896CF7F0-0x00000001896CF830
	// [XID] // 0x00000001896CF7F0-0x00000001896CF830
	public override void ReturnToObjectPool() {} // 0x0000000183B0E5A0-0x0000000183B0E640
}

