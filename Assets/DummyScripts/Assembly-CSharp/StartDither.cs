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
public class StartDither : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16587
{
	// Fields
	private SimpleSafeFloat durationRawNum; // 0x68
	private bool _reverse; // 0x6C

	// Properties
	public float duration { /* [XID] */ /* 0x0000000189B5E580-0x0000000189B5E5A0 */ get => default; /* [XID] */ /* 0x0000000189B65B40-0x0000000189B65B60 */ private set {} } // 0x0000000183EC9630-0x0000000183EC9710 0x0000000183EC9D40-0x0000000183EC9E20
	public bool reverse { /* [XID] */ /* 0x0000000189B6D060-0x0000000189B6D080 */ get => default; /* [XID] */ /* 0x0000000189B74770-0x0000000189B74790 */ private set {} } // 0x0000000183EC9480-0x0000000183EC9520 0x0000000183EC9790-0x0000000183EC9840
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189604490-0x00000001896044B0 */ get => default; } // 0x0000000183ECB0D0-0x0000000183ECB170 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018960BDA0-0x000000018960BDC0 */ get => default; } // 0x0000000183ECA700-0x0000000183ECA7A0 

	// Constructors
	public StartDither() {} // 0x0000000183ECB840-0x0000000183ECB8A0

	// Methods
	// [XID] // 0x0000000189B7BDF0-0x0000000189B7BE10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183ECB5F0-0x0000000183ECB700
	// [XID] // 0x0000000189B83720-0x0000000189B83740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183ECB1D0-0x0000000183ECB280
	// [XID] // 0x0000000189B8AAF0-0x0000000189B8AB10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF400A */) => default; // 0x0000000183ECAD40-0x0000000183ECAE20
	// [XID] // 0x0000000189B92120-0x0000000189B92140
	public override int GetHashNum() => default; // 0x0000000183EC9840-0x0000000183EC9910
	// [XID] // 0x0000000189B99660-0x0000000189B99680
	public override void InitEmpty() {} // 0x0000000183ECA7A0-0x0000000183ECA870
	[BlackList] // 0x0000000189BA0BD0-0x0000000189BA0C10
	// [XID] // 0x0000000189BA0BD0-0x0000000189BA0C10
	public override bool FromJson(JSONNode node) => default; // 0x0000000183ECA080-0x0000000183ECA400
	// [XID] // 0x0000000189BAB1C0-0x0000000189BAB1E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183EC8D00-0x0000000183EC9030
	[BlackList] // 0x0000000189BB2790-0x0000000189BB27D0
	// [XID] // 0x0000000189BB2790-0x0000000189BB27D0
	public static new StartDither ParseFromJson(JSONNode node) => default; // 0x0000000183ECAE80-0x0000000183ECB0D0
	// [XID] // 0x0000000189BBCC00-0x0000000189BBCC20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF400B */, bool useObjectPool = false /* Metadata: 0x00AF400F */) => default; // 0x0000000183ECAA40-0x0000000183ECAD40
	// [XID] // 0x0000000189BC48C0-0x0000000189BC48E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4010 */, bool useObjectPool = false /* Metadata: 0x00AF4014 */) => default; // 0x0000000183EC9A60-0x0000000183EC9D40
	// [XID] // 0x0000000189BCC2A0-0x0000000189BCC2C0
	public static new StartDither ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4015 */, bool useObjectPool = false /* Metadata: 0x00AF4019 */) => default; // 0x0000000183ECA400-0x0000000183ECA620
	[BlackList] // 0x0000000189BD3910-0x0000000189BD3950
	// [XID] // 0x0000000189BD3910-0x0000000189BD3950
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183EC9030-0x0000000183EC9300
	// [XID] // 0x0000000189BDE320-0x0000000189BDE340
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183ECB360-0x0000000183ECB5F0
	[BlackList] // 0x00000001895EAE70-0x00000001895EAEB0
	// [XID] // 0x00000001895EAE70-0x00000001895EAEB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183ECA950-0x0000000183ECAA40
	// [XID] // 0x00000001895F5510-0x00000001895F5530
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183ECB700-0x0000000183ECB7A0
	// [XID] // 0x00000001895FCA70-0x00000001895FCA90
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183EC9E20-0x0000000183EC9F80
	[BlackList] // 0x0000000189613340-0x0000000189613380
	// [XID] // 0x0000000189613340-0x0000000189613380
	public override void AutoAllocTypeFields() {} // 0x0000000183EC9300-0x0000000183EC93A0
	[BlackList] // 0x000000018961DAD0-0x000000018961DB10
	// [XID] // 0x000000018961DAD0-0x000000018961DB10
	public override void AutoRecycleTypeFields() {} // 0x0000000183EC93A0-0x0000000183EC9480
	[BlackList] // 0x00000001896280F0-0x0000000189628130
	// [XID] // 0x00000001896280F0-0x0000000189628130
	public override void ReturnToObjectPool() {} // 0x0000000183ECB7A0-0x0000000183ECB840
}

