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
public class SetSkillCanUseInStateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17161
{
	// Fields
	private SimpleSafeUInt32[] _skillList; // 0x30
	private string[] _stateList; // 0x38

	// Properties
	public SimpleSafeUInt32[] skillList { /* [XID] */ /* 0x0000000189B6B8B0-0x0000000189B6B8D0 */ get => default; /* [XID] */ /* 0x0000000189B72FB0-0x0000000189B72FD0 */ private set {} } // 0x0000000183665920-0x00000001836659C0 0x0000000183664980-0x0000000183664A30
	public string[] stateList { /* [XID] */ /* 0x0000000189B7A5F0-0x0000000189B7A610 */ get => default; /* [XID] */ /* 0x0000000189B81D70-0x0000000189B81D90 */ private set {} } // 0x00000001836643B0-0x0000000183664450 0x0000000183665D70-0x0000000183665E20
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018960A430-0x000000018960A450 */ get => default; } // 0x00000001836648E0-0x0000000183664980 

	// Constructors
	public SetSkillCanUseInStateMixin() {} // 0x00000001836662C0-0x0000000183666320

	// Methods
	// [XID] // 0x0000000189B89450-0x0000000189B89470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183666110-0x0000000183666220
	// [XID] // 0x0000000189B90A50-0x0000000189B90A70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183665C70-0x0000000183665D70
	// [XID] // 0x0000000189B97E60-0x0000000189B97E80
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6511 */) => default; // 0x00000001836657E0-0x00000001836658C0
	// [XID] // 0x0000000189B9F270-0x0000000189B9F290
	public override int GetHashNum() => default; // 0x0000000183664280-0x0000000183664350
	// [XID] // 0x0000000189BA6AA0-0x0000000189BA6AC0
	public override void InitEmpty() {} // 0x0000000183665140-0x0000000183665230
	[BlackList] // 0x0000000189BADCE0-0x0000000189BADD20
	// [XID] // 0x0000000189BADCE0-0x0000000189BADD20
	public override bool FromJson(JSONNode node) => default; // 0x0000000183664A30-0x0000000183664DB0
	// [XID] // 0x0000000189BB8340-0x0000000189BB8360
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183663A20-0x0000000183663D40
	[BlackList] // 0x0000000189BBFB50-0x0000000189BBFB90
	// [XID] // 0x0000000189BBFB50-0x0000000189BBFB90
	public static new SetSkillCanUseInStateMixin ParseFromJson(JSONNode node) => default; // 0x00000001836659C0-0x0000000183665C10
	// [XID] // 0x0000000189BCAB10-0x0000000189BCAB30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6512 */, bool useObjectPool = false /* Metadata: 0x00AF6516 */) => default; // 0x0000000183665400-0x0000000183665700
	// [XID] // 0x0000000189BD21A0-0x0000000189BD21C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6517 */, bool useObjectPool = false /* Metadata: 0x00AF651B */) => default; // 0x00000001836644D0-0x00000001836647E0
	// [XID] // 0x0000000189BD97C0-0x0000000189BD97E0
	public static new SetSkillCanUseInStateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF651C */, bool useObjectPool = false /* Metadata: 0x00AF6520 */) => default; // 0x0000000183664E20-0x0000000183665040
	[BlackList] // 0x00000001895E6210-0x00000001895E6250
	// [XID] // 0x00000001895E6210-0x00000001895E6250
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183663D40-0x0000000183664010
	// [XID] // 0x00000001895F0AC0-0x00000001895F0AE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183665E20-0x0000000183666110
	[BlackList] // 0x00000001895F8490-0x00000001895F84D0
	// [XID] // 0x00000001895F8490-0x00000001895F84D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183665310-0x0000000183665400
	// [XID] // 0x0000000189602AF0-0x0000000189602B10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183665700-0x00000001836657E0
	[BlackList] // 0x0000000189611BE0-0x0000000189611C20
	// [XID] // 0x0000000189611BE0-0x0000000189611C20
	public override void AutoAllocTypeFields() {} // 0x0000000183664010-0x00000001836640B0
	[BlackList] // 0x000000018961C3E0-0x000000018961C420
	// [XID] // 0x000000018961C3E0-0x000000018961C420
	public override void AutoRecycleTypeFields() {} // 0x00000001836640B0-0x0000000183664160
	[BlackList] // 0x0000000189626780-0x00000001896267C0
	// [XID] // 0x0000000189626780-0x00000001896267C0
	public override void ReturnToObjectPool() {} // 0x0000000183666220-0x00000001836662C0
}

