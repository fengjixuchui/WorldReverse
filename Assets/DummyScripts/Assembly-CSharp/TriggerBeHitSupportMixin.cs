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
public class TriggerBeHitSupportMixin : TriggerTypeSupportMixin, IAutoAllocRecycle // TypeDefIndex: 16934
{
	// Fields
	private HitLevel _hitLevel; // 0x38

	// Properties
	public HitLevel hitLevel { /* [XID] */ /* 0x0000000189B5FDA0-0x0000000189B5FDC0 */ get => default; /* [XID] */ /* 0x0000000189B67440-0x0000000189B67460 */ private set {} } // 0x0000000181E01AA0-0x0000000181E01B40 0x0000000181E00630-0x0000000181E006E0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001895EF440-0x00000001895EF460 */ get => default; } // 0x0000000181E00BC0-0x0000000181E00C60 

	// Constructors
	public TriggerBeHitSupportMixin() {} // 0x0000000181E02290-0x0000000181E022F0

	// Methods
	// [XID] // 0x0000000189B6E6A0-0x0000000189B6E6C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E02100-0x0000000181E021F0
	// [XID] // 0x0000000189B75ED0-0x0000000189B75EF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181E01E50-0x0000000181E01F00
	// [XID] // 0x0000000189B7D3E0-0x0000000189B7D400
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5DFD */) => default; // 0x0000000181E019C0-0x0000000181E01AA0
	// [XID] // 0x0000000189B85170-0x0000000189B85190
	public override int GetHashNum() => default; // 0x0000000181E006E0-0x0000000181E007B0
	// [XID] // 0x0000000189B8BFC0-0x0000000189B8BFE0
	public override void InitEmpty() {} // 0x0000000181E01370-0x0000000181E01410
	[BlackList] // 0x0000000189B937D0-0x0000000189B93810
	// [XID] // 0x0000000189B937D0-0x0000000189B93810
	public override bool FromJson(JSONNode node) => default; // 0x0000000181E00C60-0x0000000181E00FE0
	// [XID] // 0x0000000189B9D9E0-0x0000000189B9DA00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181DFFED0-0x0000000181E000F0
	[BlackList] // 0x0000000189BA53F0-0x0000000189BA5430
	// [XID] // 0x0000000189BA53F0-0x0000000189BA5430
	public static new TriggerBeHitSupportMixin ParseFromJson(JSONNode node) => default; // 0x0000000181E01BA0-0x0000000181E01DF0
	// [XID] // 0x0000000189BAF600-0x0000000189BAF620
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5DFE */, bool useObjectPool = false /* Metadata: 0x00AF5E02 */) => default; // 0x0000000181E015E0-0x0000000181E018E0
	// [XID] // 0x0000000189BB6CB0-0x0000000189BB6CD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E03 */, bool useObjectPool = false /* Metadata: 0x00AF5E07 */) => default; // 0x0000000181E00890-0x0000000181E00AC0
	// [XID] // 0x0000000189BBE310-0x0000000189BBE330
	public static new TriggerBeHitSupportMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5E08 */, bool useObjectPool = false /* Metadata: 0x00AF5E0C */) => default; // 0x0000000181E01050-0x0000000181E01270
	[BlackList] // 0x0000000189BC5FA0-0x0000000189BC5FE0
	// [XID] // 0x0000000189BC5FA0-0x0000000189BC5FE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E000F0-0x0000000181E003C0
	// [XID] // 0x0000000189BD09B0-0x0000000189BD09D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E01F00-0x0000000181E02100
	[BlackList] // 0x0000000189BD7E90-0x0000000189BD7ED0
	// [XID] // 0x0000000189BD7E90-0x0000000189BD7ED0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181E014F0-0x0000000181E015E0
	// [XID] // 0x00000001895E7AF0-0x00000001895E7B10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000181E018E0-0x0000000181E019C0
	[BlackList] // 0x00000001895F6E00-0x00000001895F6E40
	// [XID] // 0x00000001895F6E00-0x00000001895F6E40
	public override void AutoAllocTypeFields() {} // 0x0000000181E003C0-0x0000000181E00460
	[BlackList] // 0x00000001896013C0-0x0000000189601400
	// [XID] // 0x00000001896013C0-0x0000000189601400
	public override void AutoRecycleTypeFields() {} // 0x0000000181E00460-0x0000000181E00510
	[BlackList] // 0x000000018960BC00-0x000000018960BC40
	// [XID] // 0x000000018960BC00-0x000000018960BC40
	public override void ReturnToObjectPool() {} // 0x0000000181E021F0-0x0000000181E02290
}

