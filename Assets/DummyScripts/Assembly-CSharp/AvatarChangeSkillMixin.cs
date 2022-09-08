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
public class AvatarChangeSkillMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16959
{
	// Fields
	private SimpleSafeUInt32 indexRawNum; // 0x30
	private SwitchSkillPriority _priority; // 0x34
	private SimpleSafeUInt32 aimSkillIDRawNum; // 0x38
	private SimpleSafeUInt32 jumpSkillIDRawNum; // 0x3C
	private SimpleSafeUInt32 flySkillIDRawNum; // 0x40
	private bool _changeOnAdd; // 0x44

	// Properties
	public uint index { /* [XID] */ /* 0x00000001896E1330-0x00000001896E1350 */ get => default; /* [XID] */ /* 0x00000001896E85E0-0x00000001896E8600 */ private set {} } // 0x0000000184AFCB10-0x0000000184AFCBE0 0x0000000184AFCEE0-0x0000000184AFCFC0
	public SwitchSkillPriority priority { /* [XID] */ /* 0x00000001896EFAE0-0x00000001896EFB00 */ get => default; /* [XID] */ /* 0x00000001896F7510-0x00000001896F7530 */ private set {} } // 0x0000000184AFD180-0x0000000184AFD220 0x0000000184AFBCE0-0x0000000184AFBD90
	public uint aimSkillID { /* [XID] */ /* 0x00000001896FEED0-0x00000001896FEEF0 */ get => default; /* [XID] */ /* 0x0000000189706120-0x0000000189706140 */ private set {} } // 0x0000000184AFD770-0x0000000184AFD840 0x0000000184AFD690-0x0000000184AFD770
	public uint jumpSkillID { /* [XID] */ /* 0x000000018970DA50-0x000000018970DA70 */ get => default; /* [XID] */ /* 0x0000000189714E70-0x0000000189714E90 */ private set {} } // 0x0000000184AFC770-0x0000000184AFC840 0x0000000184AFB590-0x0000000184AFB670
	public uint flySkillID { /* [XID] */ /* 0x000000018971C940-0x000000018971C960 */ get => default; /* [XID] */ /* 0x0000000189723D70-0x0000000189723D90 */ private set {} } // 0x0000000184AFC2A0-0x0000000184AFC370 0x0000000184AFC620-0x0000000184AFC700
	public bool changeOnAdd { /* [XID] */ /* 0x000000018972B510-0x000000018972B530 */ get => default; /* [XID] */ /* 0x0000000189732D40-0x0000000189732D60 */ private set {} } // 0x0000000184AFB3A0-0x0000000184AFB440 0x0000000184AFD4D0-0x0000000184AFD580
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001897B72B0-0x00000001897B72D0 */ get => default; } // 0x0000000184AFBE10-0x0000000184AFBEB0 

	// Constructors
	public AvatarChangeSkillMixin() {} // 0x0000000184AFDFC0-0x0000000184AFE060

	// Methods
	// [XID] // 0x000000018973A450-0x000000018973A470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184AFDDA0-0x0000000184AFDF20
	// [XID] // 0x0000000189741E00-0x0000000189741E20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184AFD5E0-0x0000000184AFD690
	// [XID] // 0x00000001897497C0-0x00000001897497E0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5EBF */) => default; // 0x0000000184AFD0A0-0x0000000184AFD180
	// [XID] // 0x0000000189750CC0-0x0000000189750CE0
	public override int GetHashNum() => default; // 0x0000000184AFB4C0-0x0000000184AFB590
	// [XID] // 0x00000001897580D0-0x00000001897580F0
	public override void InitEmpty() {} // 0x0000000184AFC840-0x0000000184AFC940
	[BlackList] // 0x000000018975FBF0-0x000000018975FC30
	// [XID] // 0x000000018975FBF0-0x000000018975FC30
	public override bool FromJson(JSONNode node) => default; // 0x0000000184AFBEB0-0x0000000184AFC230
	// [XID] // 0x000000018976A170-0x000000018976A190
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184AFA740-0x0000000184AFAE70
	[BlackList] // 0x00000001897719B0-0x00000001897719F0
	// [XID] // 0x00000001897719B0-0x00000001897719F0
	public static new AvatarChangeSkillMixin ParseFromJson(JSONNode node) => default; // 0x0000000184AFD280-0x0000000184AFD4D0
	// [XID] // 0x000000018977C000-0x000000018977C020
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EC0 */, bool useObjectPool = false /* Metadata: 0x00AF5EC4 */) => default; // 0x0000000184AFCBE0-0x0000000184AFCEE0
	// [XID] // 0x00000001897838D0-0x00000001897838F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EC5 */, bool useObjectPool = false /* Metadata: 0x00AF5EC9 */) => default; // 0x0000000184AFB750-0x0000000184AFBC60
	// [XID] // 0x000000018978B0E0-0x000000018978B100
	public static new AvatarChangeSkillMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5ECA */, bool useObjectPool = false /* Metadata: 0x00AF5ECE */) => default; // 0x0000000184AFC370-0x0000000184AFC590
	[BlackList] // 0x0000000189792640-0x0000000189792680
	// [XID] // 0x0000000189792640-0x0000000189792680
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AFAE70-0x0000000184AFB140
	// [XID] // 0x000000018979D910-0x000000018979D930
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184AFD840-0x0000000184AFDDA0
	[BlackList] // 0x00000001897A4BB0-0x00000001897A4BF0
	// [XID] // 0x00000001897A4BB0-0x00000001897A4BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184AFCA20-0x0000000184AFCB10
	// [XID] // 0x00000001897AF450-0x00000001897AF470
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184AFCFC0-0x0000000184AFD0A0
	[BlackList] // 0x00000001897BF1B0-0x00000001897BF1F0
	// [XID] // 0x00000001897BF1B0-0x00000001897BF1F0
	public override void AutoAllocTypeFields() {} // 0x0000000184AFB140-0x0000000184AFB1E0
	[BlackList] // 0x00000001897C9740-0x00000001897C9780
	// [XID] // 0x00000001897C9740-0x00000001897C9780
	public override void AutoRecycleTypeFields() {} // 0x0000000184AFB1E0-0x0000000184AFB300
	[BlackList] // 0x00000001897D3D60-0x00000001897D3DA0
	// [XID] // 0x00000001897D3D60-0x00000001897D3DA0
	public override void ReturnToObjectPool() {} // 0x0000000184AFDF20-0x0000000184AFDFC0
}

