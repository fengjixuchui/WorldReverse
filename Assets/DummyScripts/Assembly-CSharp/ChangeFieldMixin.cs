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
public class ChangeFieldMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16955
{
	// Fields
	private ChangeFieldType _type; // 0x30
	private SimpleSafeFloat targetRadiusRawNum; // 0x34
	private SimpleSafeFloat timeRawNum; // 0x38

	// Properties
	public ChangeFieldType type { /* [XID] */ /* 0x0000000189B10DB0-0x0000000189B10DD0 */ get => default; /* [XID] */ /* 0x0000000189B18020-0x0000000189B18040 */ private set {} } // 0x0000000184BD1140-0x0000000184BD11E0 0x0000000184BD0A80-0x0000000184BD0B30
	public float targetRadius { /* [XID] */ /* 0x0000000189B1F700-0x0000000189B1F720 */ get => default; /* [XID] */ /* 0x0000000189B26FC0-0x0000000189B26FE0 */ private set {} } // 0x0000000184BD0890-0x0000000184BD0970 0x0000000184BD1060-0x0000000184BD1140
	public float time { /* [XID] */ /* 0x0000000189B2E190-0x0000000189B2E1B0 */ get => default; /* [XID] */ /* 0x0000000189B35600-0x0000000189B35620 */ private set {} } // 0x0000000184BD11E0-0x0000000184BD12C0 0x0000000184BD0E50-0x0000000184BD0F30
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189BB8380-0x0000000189BB83A0 */ get => default; } // 0x0000000184BCF6C0-0x0000000184BCF760 

	// Constructors
	public ChangeFieldMixin() {} // 0x0000000184BD1360-0x0000000184BD13C0

	// Methods
	// [XID] // 0x0000000189B3CE80-0x0000000189B3CEA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184BD0F30-0x0000000184BD1060
	// [XID] // 0x0000000189B44C10-0x0000000189B44C30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184BD09D0-0x0000000184BD0A80
	// [XID] // 0x0000000189B4C400-0x0000000189B4C420
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5E9F */) => default; // 0x0000000184BD0500-0x0000000184BD05E0
	// [XID] // 0x0000000189B53A40-0x0000000189B53A60
	public override int GetHashNum() => default; // 0x0000000184BCF090-0x0000000184BCF160
	// [XID] // 0x0000000189B5B350-0x0000000189B5B370
	public override void InitEmpty() {} // 0x0000000184BCFE70-0x0000000184BCFF50
	[BlackList] // 0x0000000189B62740-0x0000000189B62780
	// [XID] // 0x0000000189B62740-0x0000000189B62780
	public override bool FromJson(JSONNode node) => default; // 0x0000000184BCF760-0x0000000184BCFAE0
	// [XID] // 0x0000000189B6CFE0-0x0000000189B6D000
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184BCE690-0x0000000184BCEB10
	[BlackList] // 0x0000000189B74710-0x0000000189B74750
	// [XID] // 0x0000000189B74710-0x0000000189B74750
	public static new ChangeFieldMixin ParseFromJson(JSONNode node) => default; // 0x0000000184BD0640-0x0000000184BD0890
	// [XID] // 0x0000000189B7EB00-0x0000000189B7EB20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EA0 */, bool useObjectPool = false /* Metadata: 0x00AF5EA4 */) => default; // 0x0000000184BD0120-0x0000000184BD0420
	// [XID] // 0x0000000189B867A0-0x0000000189B867C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EA5 */, bool useObjectPool = false /* Metadata: 0x00AF5EA9 */) => default; // 0x0000000184BCF240-0x0000000184BCF5C0
	// [XID] // 0x0000000189B8D8D0-0x0000000189B8D8F0
	public static new ChangeFieldMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5EAA */, bool useObjectPool = false /* Metadata: 0x00AF5EAE */) => default; // 0x0000000184BCFB50-0x0000000184BCFD70
	[BlackList] // 0x0000000189B94EB0-0x0000000189B94EF0
	// [XID] // 0x0000000189B94EB0-0x0000000189B94EF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184BCEB10-0x0000000184BCEDE0
	// [XID] // 0x0000000189B9F290-0x0000000189B9F2B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184BD0B30-0x0000000184BD0E50
	[BlackList] // 0x0000000189BA6B00-0x0000000189BA6B40
	// [XID] // 0x0000000189BA6B00-0x0000000189BA6B40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184BD0030-0x0000000184BD0120
	// [XID] // 0x0000000189BB1250-0x0000000189BB1270
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184BD0420-0x0000000184BD0500
	[BlackList] // 0x0000000189BBFBB0-0x0000000189BBFBF0
	// [XID] // 0x0000000189BBFBB0-0x0000000189BBFBF0
	public override void AutoAllocTypeFields() {} // 0x0000000184BCEDE0-0x0000000184BCEE80
	[BlackList] // 0x0000000189BCAB50-0x0000000189BCAB90
	// [XID] // 0x0000000189BCAB50-0x0000000189BCAB90
	public override void AutoRecycleTypeFields() {} // 0x0000000184BCEE80-0x0000000184BCEF70
	[BlackList] // 0x0000000189BD4F90-0x0000000189BD4FD0
	// [XID] // 0x0000000189BD4F90-0x0000000189BD4FD0
	public override void ReturnToObjectPool() {} // 0x0000000184BD12C0-0x0000000184BD1360
}

