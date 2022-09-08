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
public class AvatarSteerByCameraMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16906
{
	// Fields
	private string[] _stateIDs; // 0x30
	private SimpleSafeFloat angularSpeedRawNum; // 0x38

	// Properties
	public string[] stateIDs { /* [XID] */ /* 0x0000000189608DB0-0x0000000189608DD0 */ get => default; /* [XID] */ /* 0x00000001896104F0-0x0000000189610510 */ private set {} } // 0x0000000182FBECE0-0x0000000182FBED80 0x0000000182FBED80-0x0000000182FBEE30
	public float angularSpeed { /* [XID] */ /* 0x00000001896177F0-0x0000000189617810 */ get => default; /* [XID] */ /* 0x000000018961F400-0x000000018961F420 */ private set {} } // 0x0000000182FBDBC0-0x0000000182FBDCA0 0x0000000182FBE6F0-0x0000000182FBE7D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896A3500-0x00000001896A3520 */ get => default; } // 0x0000000182FBD410-0x0000000182FBD4B0 

	// Constructors
	public AvatarSteerByCameraMixin() {} // 0x0000000182FBEED0-0x0000000182FBEF70

	// Methods
	// [XID] // 0x0000000189626820-0x0000000189626840
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182FBEBD0-0x0000000182FBECE0
	// [XID] // 0x000000018962E050-0x000000018962E070
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182FBE830-0x0000000182FBE910
	// [XID] // 0x0000000189635D30-0x0000000189635D50
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5D29 */) => default; // 0x0000000182FBE360-0x0000000182FBE440
	// [XID] // 0x000000018963D470-0x000000018963D490
	public override int GetHashNum() => default; // 0x0000000182FBCE80-0x0000000182FBCF50
	// [XID] // 0x00000001896449F0-0x0000000189644A10
	public override void InitEmpty() {} // 0x0000000182FBDCA0-0x0000000182FBDDB0
	[BlackList] // 0x000000018964C250-0x000000018964C290
	// [XID] // 0x000000018964C250-0x000000018964C290
	public override bool FromJson(JSONNode node) => default; // 0x0000000182FBD4B0-0x0000000182FBD830
	// [XID] // 0x0000000189656850-0x0000000189656870
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182FBC5D0-0x0000000182FBC910
	[BlackList] // 0x000000018965DF30-0x000000018965DF70
	// [XID] // 0x000000018965DF30-0x000000018965DF70
	public static new AvatarSteerByCameraMixin ParseFromJson(JSONNode node) => default; // 0x0000000182FBE4A0-0x0000000182FBE6F0
	// [XID] // 0x0000000189668980-0x00000001896689A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D2A */, bool useObjectPool = false /* Metadata: 0x00AF5D2E */) => default; // 0x0000000182FBDF80-0x0000000182FBE280
	// [XID] // 0x00000001896704D0-0x00000001896704F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D2F */, bool useObjectPool = false /* Metadata: 0x00AF5D33 */) => default; // 0x0000000182FBD030-0x0000000182FBD310
	// [XID] // 0x0000000189677D10-0x0000000189677D30
	public static new AvatarSteerByCameraMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5D34 */, bool useObjectPool = false /* Metadata: 0x00AF5D38 */) => default; // 0x0000000182FBD8A0-0x0000000182FBDAC0
	[BlackList] // 0x000000018967F280-0x000000018967F2C0
	// [XID] // 0x000000018967F280-0x000000018967F2C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182FBC910-0x0000000182FBCBE0
	// [XID] // 0x0000000189689DD0-0x0000000189689DF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182FBE910-0x0000000182FBEBD0
	[BlackList] // 0x0000000189691B70-0x0000000189691BB0
	// [XID] // 0x0000000189691B70-0x0000000189691BB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182FBDE90-0x0000000182FBDF80
	// [XID] // 0x000000018969C0E0-0x000000018969C100
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182FBE280-0x0000000182FBE360
	[BlackList] // 0x00000001896AA970-0x00000001896AA9B0
	// [XID] // 0x00000001896AA970-0x00000001896AA9B0
	public override void AutoAllocTypeFields() {} // 0x0000000182FBCBE0-0x0000000182FBCC80
	[BlackList] // 0x00000001896B4FD0-0x00000001896B5010
	// [XID] // 0x00000001896B4FD0-0x00000001896B5010
	public override void AutoRecycleTypeFields() {} // 0x0000000182FBCC80-0x0000000182FBCD60
	[BlackList] // 0x00000001896BEEB0-0x00000001896BEEF0
	// [XID] // 0x00000001896BEEB0-0x00000001896BEEF0
	public override void ReturnToObjectPool() {} // 0x0000000182FBEE30-0x0000000182FBEED0
}

