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
public class TriggerSetRenderersEnable : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16529
{
	// Fields
	private string[] _renderNames; // 0x68
	private bool _setEnable; // 0x70

	// Properties
	public string[] renderNames { /* [XID] */ /* 0x0000000189B78E80-0x0000000189B78EA0 */ get => default; /* [XID] */ /* 0x0000000189B80410-0x0000000189B80430 */ private set {} } // 0x0000000181FE3A00-0x0000000181FE3AA0 0x0000000181FE2FE0-0x0000000181FE3090
	public bool setEnable { /* [XID] */ /* 0x0000000189B87F00-0x0000000189B87F20 */ get => default; /* [XID] */ /* 0x0000000189B8F0F0-0x0000000189B8F110 */ private set {} } // 0x0000000181FE47B0-0x0000000181FE4850 0x0000000181FE54E0-0x0000000181FE5590
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018961F4C0-0x000000018961F4E0 */ get => default; } // 0x0000000181FE5220-0x0000000181FE52C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896268E0-0x0000000189626900 */ get => default; } // 0x0000000181FE4850-0x0000000181FE48F0 

	// Constructors
	public TriggerSetRenderersEnable() {} // 0x0000000181FE5AA0-0x0000000181FE5B00

	// Methods
	// [XID] // 0x0000000189B965E0-0x0000000189B96600
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FE5850-0x0000000181FE5960
	// [XID] // 0x0000000189B9DA60-0x0000000189B9DA80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FE5320-0x0000000181FE5400
	// [XID] // 0x0000000189BA5490-0x0000000189BA54B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E46 */) => default; // 0x0000000181FE4E90-0x0000000181FE4F70
	// [XID] // 0x0000000189BAC630-0x0000000189BAC650
	public override int GetHashNum() => default; // 0x0000000181FE3930-0x0000000181FE3A00
	// [XID] // 0x0000000189BB3F30-0x0000000189BB3F50
	public override void InitEmpty() {} // 0x0000000181FE48F0-0x0000000181FE49C0
	[BlackList] // 0x0000000189BBB530-0x0000000189BBB570
	// [XID] // 0x0000000189BBB530-0x0000000189BBB570
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FE4130-0x0000000181FE44B0
	// [XID] // 0x0000000189BC6060-0x0000000189BC6080
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FE3090-0x0000000181FE3380
	[BlackList] // 0x0000000189BCDBA0-0x0000000189BCDBE0
	// [XID] // 0x0000000189BCDBA0-0x0000000189BCDBE0
	public static new TriggerSetRenderersEnable ParseFromJson(JSONNode node) => default; // 0x0000000181FE4FD0-0x0000000181FE5220
	// [XID] // 0x0000000189BD7F50-0x0000000189BD7F70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E47 */, bool useObjectPool = false /* Metadata: 0x00AF3E4B */) => default; // 0x0000000181FE4B90-0x0000000181FE4E90
	// [XID] // 0x0000000189BDFAE0-0x0000000189BDFB00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E4C */, bool useObjectPool = false /* Metadata: 0x00AF3E50 */) => default; // 0x0000000181FE3BF0-0x0000000181FE3ED0
	// [XID] // 0x00000001895EC6D0-0x00000001895EC6F0
	public static new TriggerSetRenderersEnable ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E51 */, bool useObjectPool = false /* Metadata: 0x00AF3E55 */) => default; // 0x0000000181FE44B0-0x0000000181FE46D0
	[BlackList] // 0x00000001895F3B70-0x00000001895F3BB0
	// [XID] // 0x00000001895F3B70-0x00000001895F3BB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FE3380-0x0000000181FE3650
	// [XID] // 0x00000001895FE2E0-0x00000001895FE300
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FE5590-0x0000000181FE5850
	[BlackList] // 0x0000000189605B70-0x0000000189605BB0
	// [XID] // 0x0000000189605B70-0x0000000189605BB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FE4AA0-0x0000000181FE4B90
	// [XID] // 0x0000000189610590-0x00000001896105B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181FE5960-0x0000000181FE5A00
	// [XID] // 0x0000000189617890-0x00000001896178B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181FE3ED0-0x0000000181FE4030
	[BlackList] // 0x000000018962E0F0-0x000000018962E130
	// [XID] // 0x000000018962E0F0-0x000000018962E130
	public override void AutoAllocTypeFields() {} // 0x0000000181FE3650-0x0000000181FE36F0
	[BlackList] // 0x0000000189638C90-0x0000000189638CD0
	// [XID] // 0x0000000189638C90-0x0000000189638CD0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FE36F0-0x0000000181FE37A0
	[BlackList] // 0x00000001896432C0-0x0000000189643300
	// [XID] // 0x00000001896432C0-0x0000000189643300
	public override void ReturnToObjectPool() {} // 0x0000000181FE5A00-0x0000000181FE5AA0
}

