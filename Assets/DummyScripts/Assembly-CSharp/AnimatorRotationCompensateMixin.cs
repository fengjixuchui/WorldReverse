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
public class AnimatorRotationCompensateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17065
{
	// Fields
	private string[] _animatorStateIDs; // 0x30
	private SimpleSafeFloat animationRotateRawNum; // 0x38
	private SimpleSafeFloat angleLimitRawNum; // 0x3C

	// Properties
	public string[] animatorStateIDs { /* [XID] */ /* 0x0000000189BB5490-0x0000000189BB54B0 */ get => default; /* [XID] */ /* 0x0000000189BBCBA0-0x0000000189BBCBC0 */ private set {} } // 0x0000000182DF0E90-0x0000000182DF0F30 0x0000000182DEF500-0x0000000182DEF5B0
	public float animationRotate { /* [XID] */ /* 0x0000000189BC4800-0x0000000189BC4820 */ get => default; /* [XID] */ /* 0x0000000189BCC1A0-0x0000000189BCC1C0 */ private set {} } // 0x0000000182DEEFC0-0x0000000182DEF0A0 0x0000000182DF0840-0x0000000182DF0920
	public float angleLimit { /* [XID] */ /* 0x0000000189BD3790-0x0000000189BD37B0 */ get => default; /* [XID] */ /* 0x0000000189BDB140-0x0000000189BDB160 */ private set {} } // 0x0000000182DEEE80-0x0000000182DEEF60 0x0000000182DF0A60-0x0000000182DF0B40
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189663E40-0x0000000189663E60 */ get => default; } // 0x0000000182DEF630-0x0000000182DEF6D0 

	// Constructors
	public AnimatorRotationCompensateMixin() {} // 0x0000000182DF1100-0x0000000182DF11B0

	// Methods
	// [XID] // 0x00000001895E7A70-0x00000001895E7A90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182DF0F30-0x0000000182DF1060
	// [XID] // 0x00000001895EF3C0-0x00000001895EF3E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182DF0980-0x0000000182DF0A60
	// [XID] // 0x00000001895F6DC0-0x00000001895F6DE0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6203 */) => default; // 0x0000000182DF04B0-0x0000000182DF0590
	// [XID] // 0x00000001895FE1C0-0x00000001895FE1E0
	public override int GetHashNum() => default; // 0x0000000182DEEDB0-0x0000000182DEEE80
	// [XID] // 0x00000001896059D0-0x00000001896059F0
	public override void InitEmpty() {} // 0x0000000182DEFDE0-0x0000000182DEFF00
	[BlackList] // 0x000000018960D320-0x000000018960D360
	// [XID] // 0x000000018960D320-0x000000018960D360
	public override bool FromJson(JSONNode node) => default; // 0x0000000182DEF6D0-0x0000000182DEFA50
	// [XID] // 0x00000001896177B0-0x00000001896177D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182DEE3F0-0x0000000182DEE830
	[BlackList] // 0x000000018961F380-0x000000018961F3C0
	// [XID] // 0x000000018961F380-0x000000018961F3C0
	public static new AnimatorRotationCompensateMixin ParseFromJson(JSONNode node) => default; // 0x0000000182DF05F0-0x0000000182DF0840
	// [XID] // 0x0000000189629A10-0x0000000189629A30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6204 */, bool useObjectPool = false /* Metadata: 0x00AF6208 */) => default; // 0x0000000182DF00D0-0x0000000182DF03D0
	// [XID] // 0x0000000189631260-0x0000000189631280
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6209 */, bool useObjectPool = false /* Metadata: 0x00AF620D */) => default; // 0x0000000182DEF120-0x0000000182DEF480
	// [XID] // 0x0000000189638C10-0x0000000189638C30
	public static new AnimatorRotationCompensateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF620E */, bool useObjectPool = false /* Metadata: 0x00AF6212 */) => default; // 0x0000000182DEFAC0-0x0000000182DEFCE0
	[BlackList] // 0x0000000189640050-0x0000000189640090
	// [XID] // 0x0000000189640050-0x0000000189640090
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182DEE830-0x0000000182DEEB00
	// [XID] // 0x000000018964A840-0x000000018964A860
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182DF0B40-0x0000000182DF0E90
	[BlackList] // 0x0000000189652120-0x0000000189652160
	// [XID] // 0x0000000189652120-0x0000000189652160
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182DEFFE0-0x0000000182DF00D0
	// [XID] // 0x000000018965C920-0x000000018965C940
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182DF03D0-0x0000000182DF04B0
	[BlackList] // 0x000000018966B5C0-0x000000018966B600
	// [XID] // 0x000000018966B5C0-0x000000018966B600
	public override void AutoAllocTypeFields() {} // 0x0000000182DEEB00-0x0000000182DEEBA0
	[BlackList] // 0x0000000189676340-0x0000000189676380
	// [XID] // 0x0000000189676340-0x0000000189676380
	public override void AutoRecycleTypeFields() {} // 0x0000000182DEEBA0-0x0000000182DEEC90
	[BlackList] // 0x0000000189680D40-0x0000000189680D80
	// [XID] // 0x0000000189680D40-0x0000000189680D80
	public override void ReturnToObjectPool() {} // 0x0000000182DF1060-0x0000000182DF1100
}

