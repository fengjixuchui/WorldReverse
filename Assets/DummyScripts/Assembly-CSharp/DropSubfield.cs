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
public class DropSubfield : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16599
{
	// Fields
	private string _subfieldName; // 0x68

	// Properties
	public string subfieldName { /* [XID] */ /* 0x0000000189B83700-0x0000000189B83720 */ get => default; /* [XID] */ /* 0x0000000189B8AAD0-0x0000000189B8AAF0 */ private set {} } // 0x00000001845CA070-0x00000001845CA110 0x00000001845CB960-0x00000001845CBA10
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018961AB80-0x000000018961ABA0 */ get => default; } // 0x00000001845CB780-0x00000001845CB820 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189622180-0x00000001896221A0 */ get => default; } // 0x00000001845CADB0-0x00000001845CAE50 

	// Constructors
	public DropSubfield() {} // 0x00000001845CBF20-0x00000001845CBF80

	// Methods
	// [XID] // 0x0000000189B92100-0x0000000189B92120
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845CBCF0-0x00000001845CBDE0
	// [XID] // 0x0000000189B99640-0x0000000189B99660
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845CB880-0x00000001845CB960
	// [XID] // 0x0000000189BA0BB0-0x0000000189BA0BD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF406A */) => default; // 0x00000001845CB3F0-0x00000001845CB4D0
	// [XID] // 0x0000000189BA8210-0x0000000189BA8230
	public override int GetHashNum() => default; // 0x00000001845C9FA0-0x00000001845CA070
	// [XID] // 0x0000000189BAF720-0x0000000189BAF740
	public override void InitEmpty() {} // 0x00000001845CAE50-0x00000001845CAF20
	[BlackList] // 0x0000000189BB6D30-0x0000000189BB6D70
	// [XID] // 0x0000000189BB6D30-0x0000000189BB6D70
	public override bool FromJson(JSONNode node) => default; // 0x00000001845CA730-0x00000001845CAAB0
	// [XID] // 0x0000000189BC1BF0-0x0000000189BC1C10
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001845C97C0-0x00000001845C99F0
	[BlackList] // 0x0000000189BC91A0-0x0000000189BC91E0
	// [XID] // 0x0000000189BC91A0-0x0000000189BC91E0
	public static new DropSubfield ParseFromJson(JSONNode node) => default; // 0x00000001845CB530-0x00000001845CB780
	// [XID] // 0x0000000189BD38F0-0x0000000189BD3910
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF406B */, bool useObjectPool = false /* Metadata: 0x00AF406F */) => default; // 0x00000001845CB0F0-0x00000001845CB3F0
	// [XID] // 0x0000000189BDB2C0-0x0000000189BDB2E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4070 */, bool useObjectPool = false /* Metadata: 0x00AF4074 */) => default; // 0x00000001845CA260-0x00000001845CA4D0
	// [XID] // 0x00000001895E7BB0-0x00000001895E7BD0
	public static new DropSubfield ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4075 */, bool useObjectPool = false /* Metadata: 0x00AF4079 */) => default; // 0x00000001845CAAB0-0x00000001845CACD0
	[BlackList] // 0x00000001895EF520-0x00000001895EF560
	// [XID] // 0x00000001895EF520-0x00000001895EF560
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845C99F0-0x00000001845C9CC0
	// [XID] // 0x00000001895F9CC0-0x00000001895F9CE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845CBAF0-0x00000001845CBCF0
	[BlackList] // 0x0000000189601520-0x0000000189601560
	// [XID] // 0x0000000189601520-0x0000000189601560
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845CB000-0x00000001845CB0F0
	// [XID] // 0x000000018960BD80-0x000000018960BDA0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001845CBDE0-0x00000001845CBE80
	// [XID] // 0x0000000189613320-0x0000000189613340
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001845CA4D0-0x00000001845CA630
	[BlackList] // 0x0000000189629AB0-0x0000000189629AF0
	// [XID] // 0x0000000189629AB0-0x0000000189629AF0
	public override void AutoAllocTypeFields() {} // 0x00000001845C9CC0-0x00000001845C9D60
	[BlackList] // 0x00000001896344D0-0x0000000189634510
	// [XID] // 0x00000001896344D0-0x0000000189634510
	public override void AutoRecycleTypeFields() {} // 0x00000001845C9D60-0x00000001845C9E10
	[BlackList] // 0x000000018963EAC0-0x000000018963EB00
	// [XID] // 0x000000018963EAC0-0x000000018963EB00
	public override void ReturnToObjectPool() {} // 0x00000001845CBE80-0x00000001845CBF20
}

