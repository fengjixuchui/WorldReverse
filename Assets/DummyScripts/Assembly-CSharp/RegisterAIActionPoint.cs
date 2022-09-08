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
public class RegisterAIActionPoint : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16717
{
	// Fields
	private ActionPointType _pointType; // 0x68

	// Properties
	public ActionPointType pointType { /* [XID] */ /* 0x0000000189B6D040-0x0000000189B6D060 */ get => default; /* [XID] */ /* 0x0000000189B74750-0x0000000189B74770 */ private set {} } // 0x0000000183526230-0x00000001835262D0 0x0000000183525CA0-0x0000000183525D50
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189604450-0x0000000189604470 */ get => default; } // 0x0000000183526580-0x0000000183526620 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018960BCA0-0x000000018960BCC0 */ get => default; } // 0x0000000183525A80-0x0000000183525B20 

	// Constructors
	public RegisterAIActionPoint() {} // 0x0000000183526C40-0x0000000183526D50

	// Methods
	// [XID] // 0x0000000189B7BDD0-0x0000000189B7BDF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183526A10-0x0000000183526B00
	// [XID] // 0x0000000189B836E0-0x0000000189B83700
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183526680-0x0000000183526730
	// [XID] // 0x0000000189B8AAB0-0x0000000189B8AAD0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF440E */) => default; // 0x0000000183526150-0x0000000183526230
	// [XID] // 0x0000000189B920A0-0x0000000189B920C0
	public override int GetHashNum() => default; // 0x0000000183524D50-0x0000000183524E20
	// [XID] // 0x0000000189B995A0-0x0000000189B995C0
	public override void InitEmpty() {} // 0x0000000183525B20-0x0000000183525BC0
	[BlackList] // 0x0000000189BA0AF0-0x0000000189BA0B30
	// [XID] // 0x0000000189BA0AF0-0x0000000189BA0B30
	public override bool FromJson(JSONNode node) => default; // 0x0000000183525400-0x0000000183525780
	// [XID] // 0x0000000189BAB160-0x0000000189BAB180
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183524580-0x00000001835247A0
	[BlackList] // 0x0000000189BB2710-0x0000000189BB2750
	// [XID] // 0x0000000189BB2710-0x0000000189BB2750
	public static new RegisterAIActionPoint ParseFromJson(JSONNode node) => default; // 0x0000000183526330-0x0000000183526580
	// [XID] // 0x0000000189BBCBE0-0x0000000189BBCC00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF440F */, bool useObjectPool = false /* Metadata: 0x00AF4413 */) => default; // 0x0000000183525E50-0x0000000183526150
	// [XID] // 0x0000000189BC4860-0x0000000189BC4880
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4414 */, bool useObjectPool = false /* Metadata: 0x00AF4418 */) => default; // 0x0000000183524F70-0x00000001835251A0
	// [XID] // 0x0000000189BCC200-0x0000000189BCC220
	public static new RegisterAIActionPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4419 */, bool useObjectPool = false /* Metadata: 0x00AF441D */) => default; // 0x0000000183525780-0x00000001835259A0
	[BlackList] // 0x0000000189BD3830-0x0000000189BD3870
	// [XID] // 0x0000000189BD3830-0x0000000189BD3870
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001835247A0-0x0000000183524A70
	// [XID] // 0x0000000189BDE2C0-0x0000000189BDE2E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183526810-0x0000000183526A10
	[BlackList] // 0x00000001895EADF0-0x00000001895EAE30
	// [XID] // 0x00000001895EADF0-0x00000001895EAE30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183525D50-0x0000000183525E50
	// [XID] // 0x00000001895F54D0-0x00000001895F54F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183526B00-0x0000000183526BA0
	// [XID] // 0x00000001895FCA30-0x00000001895FCA50
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001835251A0-0x0000000183525300
	[BlackList] // 0x0000000189613280-0x00000001896132C0
	// [XID] // 0x0000000189613280-0x00000001896132C0
	public override void AutoAllocTypeFields() {} // 0x0000000183524A70-0x0000000183524B10
	[BlackList] // 0x000000018961DA50-0x000000018961DA90
	// [XID] // 0x000000018961DA50-0x000000018961DA90
	public override void AutoRecycleTypeFields() {} // 0x0000000183524B10-0x0000000183524BC0
	[BlackList] // 0x0000000189628090-0x00000001896280D0
	// [XID] // 0x0000000189628090-0x00000001896280D0
	public override void ReturnToObjectPool() {} // 0x0000000183526BA0-0x0000000183526C40
}

