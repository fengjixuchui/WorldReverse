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
public class SetAIHitFeeling : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16731
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189B37070-0x0000000189B37090 */ get => default; /* [XID] */ /* 0x0000000189B3E9C0-0x0000000189B3E9E0 */ private set {} } // 0x000000018283FA20-0x000000018283FAC0 0x0000000182840700-0x00000001828407B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BC1B30-0x0000000189BC1B50 */ get => default; } // 0x00000001828407B0-0x0000000182840850 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189BC9140-0x0000000189BC9160 */ get => default; } // 0x000000018283FD50-0x000000018283FDF0 

	// Constructors
	public SetAIHitFeeling() {} // 0x0000000182840DD0-0x0000000182840E30

	// Methods
	// [XID] // 0x0000000189B46400-0x0000000189B46420
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182840C40-0x0000000182840D30
	// [XID] // 0x0000000189B4D9A0-0x0000000189B4D9C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828408B0-0x0000000182840960
	// [XID] // 0x0000000189B55210-0x0000000189B55230
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF447E */) => default; // 0x0000000182840370-0x0000000182840450
	// [XID] // 0x0000000189B5CBD0-0x0000000189B5CBF0
	public override int GetHashNum() => default; // 0x000000018283EFF0-0x000000018283F0C0
	// [XID] // 0x0000000189B64230-0x0000000189B64250
	public override void InitEmpty() {} // 0x000000018283FDF0-0x000000018283FE90
	[BlackList] // 0x0000000189B6B8D0-0x0000000189B6B910
	// [XID] // 0x0000000189B6B8D0-0x0000000189B6B910
	public override bool FromJson(JSONNode node) => default; // 0x000000018283F6A0-0x000000018283FA20
	// [XID] // 0x0000000189B75F90-0x0000000189B75FB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018283E840-0x000000018283EA40
	[BlackList] // 0x0000000189B7D4A0-0x0000000189B7D4E0
	// [XID] // 0x0000000189B7D4A0-0x0000000189B7D4E0
	public static new SetAIHitFeeling ParseFromJson(JSONNode node) => default; // 0x00000001828404B0-0x0000000182840700
	// [XID] // 0x0000000189B87E40-0x0000000189B87E60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF447F */, bool useObjectPool = false /* Metadata: 0x00AF4483 */) => default; // 0x0000000182840070-0x0000000182840370
	// [XID] // 0x0000000189B8F050-0x0000000189B8F070
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4484 */, bool useObjectPool = false /* Metadata: 0x00AF4488 */) => default; // 0x000000018283F210-0x000000018283F440
	// [XID] // 0x0000000189B96560-0x0000000189B96580
	public static new SetAIHitFeeling ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4489 */, bool useObjectPool = false /* Metadata: 0x00AF448D */) => default; // 0x000000018283FAC0-0x000000018283FCE0
	[BlackList] // 0x0000000189B9DA00-0x0000000189B9DA40
	// [XID] // 0x0000000189B9DA00-0x0000000189B9DA40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018283EA40-0x000000018283ED10
	// [XID] // 0x0000000189BA81B0-0x0000000189BA81D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182840A40-0x0000000182840C40
	[BlackList] // 0x0000000189BAF640-0x0000000189BAF680
	// [XID] // 0x0000000189BAF640-0x0000000189BAF680
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018283FF70-0x0000000182840070
	// [XID] // 0x0000000189BB9B60-0x0000000189BB9B80
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018283F440-0x000000018283F5A0
	[BlackList] // 0x0000000189BD0A10-0x0000000189BD0A50
	// [XID] // 0x0000000189BD0A10-0x0000000189BD0A50
	public override void AutoAllocTypeFields() {} // 0x000000018283ED10-0x000000018283EDB0
	[BlackList] // 0x0000000189BDB240-0x0000000189BDB280
	// [XID] // 0x0000000189BDB240-0x0000000189BDB280
	public override void AutoRecycleTypeFields() {} // 0x000000018283EDB0-0x000000018283EE60
	[BlackList] // 0x00000001895EADB0-0x00000001895EADF0
	// [XID] // 0x00000001895EADB0-0x00000001895EADF0
	public override void ReturnToObjectPool() {} // 0x0000000182840D30-0x0000000182840DD0
}

