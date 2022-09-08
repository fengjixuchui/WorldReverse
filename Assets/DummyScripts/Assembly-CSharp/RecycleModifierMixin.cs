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
public class RecycleModifierMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17016
{
	// Fields
	private string _modifierName; // 0x30
	private SimpleSafeFloat cdRawNum; // 0x38
	private SimpleSafeFloat initialCDRawNum; // 0x3C

	// Properties
	public string modifierName { /* [XID] */ /* 0x000000018985B730-0x000000018985B750 */ get => default; /* [XID] */ /* 0x0000000189862D10-0x0000000189862D30 */ private set {} } // 0x0000000183671C80-0x0000000183671D20 0x0000000183670B40-0x0000000183670BF0
	public float cd { /* [XID] */ /* 0x000000018986A120-0x000000018986A140 */ get => default; /* [XID] */ /* 0x0000000189871490-0x00000001898714B0 */ private set {} } // 0x0000000183671750-0x0000000183671830 0x0000000183670860-0x0000000183670940
	public float initialCD { /* [XID] */ /* 0x0000000189878E30-0x0000000189878E50 */ get => default; /* [XID] */ /* 0x0000000189880460-0x0000000189880480 */ private set {} } // 0x00000001836712E0-0x00000001836713C0 0x00000001836710C0-0x00000001836711A0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189903FB0-0x0000000189903FD0 */ get => default; } // 0x00000001836700B0-0x0000000183670150 

	// Constructors
	public RecycleModifierMixin() {} // 0x0000000183671DC0-0x0000000183671E70

	// Methods
	// [XID] // 0x00000001898879A0-0x00000001898879C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183671B50-0x0000000183671C80
	// [XID] // 0x000000018988ECA0-0x000000018988ECC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183671670-0x0000000183671750
	// [XID] // 0x00000001898961E0-0x0000000189896200
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF607D */) => default; // 0x00000001836711A0-0x0000000183671280
	// [XID] // 0x000000018989D880-0x000000018989D8A0
	public override int GetHashNum() => default; // 0x000000018366FAB0-0x000000018366FB80
	// [XID] // 0x00000001898A5200-0x00000001898A5220
	public override void InitEmpty() {} // 0x0000000183670940-0x0000000183670A60
	[BlackList] // 0x00000001898AC740-0x00000001898AC780
	// [XID] // 0x00000001898AC740-0x00000001898AC780
	public override bool FromJson(JSONNode node) => default; // 0x0000000183670150-0x00000001836704D0
	// [XID] // 0x00000001898B6E90-0x00000001898B6EB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018366F0F0-0x000000018366F530
	[BlackList] // 0x00000001898BE5A0-0x00000001898BE5E0
	// [XID] // 0x00000001898BE5A0-0x00000001898BE5E0
	public static new RecycleModifierMixin ParseFromJson(JSONNode node) => default; // 0x00000001836713C0-0x0000000183671610
	// [XID] // 0x00000001898C8F80-0x00000001898C8FA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF607E */, bool useObjectPool = false /* Metadata: 0x00AF6082 */) => default; // 0x0000000183670CE0-0x0000000183670FE0
	// [XID] // 0x00000001898D0760-0x00000001898D0780
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6083 */, bool useObjectPool = false /* Metadata: 0x00AF6087 */) => default; // 0x000000018366FC60-0x000000018366FFB0
	// [XID] // 0x00000001898D7E60-0x00000001898D7E80
	public static new RecycleModifierMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6088 */, bool useObjectPool = false /* Metadata: 0x00AF608C */) => default; // 0x0000000183670540-0x0000000183670760
	[BlackList] // 0x00000001898DFC40-0x00000001898DFC80
	// [XID] // 0x00000001898DFC40-0x00000001898DFC80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018366F530-0x000000018366F800
	// [XID] // 0x00000001898EA7D0-0x00000001898EA7F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183671830-0x0000000183671B50
	[BlackList] // 0x00000001898F1E30-0x00000001898F1E70
	// [XID] // 0x00000001898F1E30-0x00000001898F1E70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183670BF0-0x0000000183670CE0
	// [XID] // 0x00000001898FC4F0-0x00000001898FC510
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183670FE0-0x00000001836710C0
	[BlackList] // 0x000000018990B550-0x000000018990B590
	// [XID] // 0x000000018990B550-0x000000018990B590
	public override void AutoAllocTypeFields() {} // 0x000000018366F800-0x000000018366F8A0
	[BlackList] // 0x0000000189915E80-0x0000000189915EC0
	// [XID] // 0x0000000189915E80-0x0000000189915EC0
	public override void AutoRecycleTypeFields() {} // 0x000000018366F8A0-0x000000018366F990
	[BlackList] // 0x0000000189920730-0x0000000189920770
	// [XID] // 0x0000000189920730-0x0000000189920770
	public override void ReturnToObjectPool() {} // 0x0000000183671D20-0x0000000183671DC0
}

