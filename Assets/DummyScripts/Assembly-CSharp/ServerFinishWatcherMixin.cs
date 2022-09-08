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
public class ServerFinishWatcherMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17133
{
	// Fields
	private SimpleSafeUInt32 watcherIdRawNum; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x38

	// Properties
	public uint watcherId { /* [XID] */ /* 0x00000001896C7EB0-0x00000001896C7ED0 */ get => default; /* [XID] */ /* 0x00000001896CF7D0-0x00000001896CF7F0 */ private set {} } // 0x0000000183AEBE30-0x0000000183AEBF00 0x0000000183AEB4B0-0x0000000183AEB590
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x00000001896D6B00-0x00000001896D6B20 */ get => default; /* [XID] */ /* 0x00000001896DE180-0x00000001896DE1A0 */ private set {} } // 0x0000000183AECED0-0x0000000183AECF70 0x0000000183AECA30-0x0000000183AECAE0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189761570-0x0000000189761590 */ get => default; } // 0x0000000183AEBA10-0x0000000183AEBAB0 

	// Constructors
	public ServerFinishWatcherMixin() {} // 0x0000000183AED410-0x0000000183AED470

	// Methods
	// [XID] // 0x00000001896E5610-0x00000001896E5630
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AED260-0x0000000183AED370
	// [XID] // 0x00000001896ECD00-0x00000001896ECD20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183AECDF0-0x0000000183AECED0
	// [XID] // 0x00000001896F4500-0x00000001896F4520
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6441 */) => default; // 0x0000000183AEC950-0x0000000183AECA30
	// [XID] // 0x00000001896FBD30-0x00000001896FBD50
	public override int GetHashNum() => default; // 0x0000000183AEB380-0x0000000183AEB450
	// [XID] // 0x0000000189703270-0x0000000189703290
	public override void InitEmpty() {} // 0x0000000183AEC290-0x0000000183AEC3A0
	[BlackList] // 0x000000018970A9A0-0x000000018970A9E0
	// [XID] // 0x000000018970A9A0-0x000000018970A9E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183AEBAB0-0x0000000183AEBE30
	// [XID] // 0x0000000189714DF0-0x0000000189714E10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183AEAAB0-0x0000000183AEAE00
	[BlackList] // 0x000000018971C8E0-0x000000018971C920
	// [XID] // 0x000000018971C8E0-0x000000018971C920
	public static new ServerFinishWatcherMixin ParseFromJson(JSONNode node) => default; // 0x0000000183AECB40-0x0000000183AECD90
	// [XID] // 0x0000000189726F40-0x0000000189726F60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6442 */, bool useObjectPool = false /* Metadata: 0x00AF6446 */) => default; // 0x0000000183AEC570-0x0000000183AEC870
	// [XID] // 0x000000018972E4D0-0x000000018972E4F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6447 */, bool useObjectPool = false /* Metadata: 0x00AF644B */) => default; // 0x0000000183AEB610-0x0000000183AEB910
	// [XID] // 0x0000000189735C40-0x0000000189735C60
	public static new ServerFinishWatcherMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF644C */, bool useObjectPool = false /* Metadata: 0x00AF6450 */) => default; // 0x0000000183AEBF70-0x0000000183AEC190
	[BlackList] // 0x000000018973D850-0x000000018973D890
	// [XID] // 0x000000018973D850-0x000000018973D890
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AEAE00-0x0000000183AEB0D0
	// [XID] // 0x0000000189747EC0-0x0000000189747EE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AECF70-0x0000000183AED260
	[BlackList] // 0x000000018974F5F0-0x000000018974F630
	// [XID] // 0x000000018974F5F0-0x000000018974F630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183AEC480-0x0000000183AEC570
	// [XID] // 0x0000000189759920-0x0000000189759940
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183AEC870-0x0000000183AEC950
	[BlackList] // 0x0000000189768820-0x0000000189768860
	// [XID] // 0x0000000189768820-0x0000000189768860
	public override void AutoAllocTypeFields() {} // 0x0000000183AEB0D0-0x0000000183AEB170
	[BlackList] // 0x0000000189772F40-0x0000000189772F80
	// [XID] // 0x0000000189772F40-0x0000000189772F80
	public override void AutoRecycleTypeFields() {} // 0x0000000183AEB170-0x0000000183AEB260
	[BlackList] // 0x000000018977D880-0x000000018977D8C0
	// [XID] // 0x000000018977D880-0x000000018977D8C0
	public override void ReturnToObjectPool() {} // 0x0000000183AED370-0x0000000183AED410
}

