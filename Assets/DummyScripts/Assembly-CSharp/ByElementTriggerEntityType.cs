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
public class ByElementTriggerEntityType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17326
{
	// Fields
	private EntityType[] _entityTypes; // 0x18
	private bool _forcebyOriginOwner; // 0x20

	// Properties
	public EntityType[] entityTypes { /* [XID] */ /* 0x0000000189ACB4D0-0x0000000189ACB4F0 */ get => default; /* [XID] */ /* 0x0000000189AD2F20-0x0000000189AD2F40 */ private set {} } // 0x00000001839743F0-0x0000000183974490 0x00000001839750C0-0x0000000183975170
	public bool forcebyOriginOwner { /* [XID] */ /* 0x0000000189ADA9A0-0x0000000189ADA9C0 */ get => default; /* [XID] */ /* 0x0000000189AE21C0-0x0000000189AE21E0 */ private set {} } // 0x0000000183975020-0x00000001839750C0 0x0000000183974500-0x00000001839745B0

	// Constructors
	public ByElementTriggerEntityType() {} // 0x0000000183975690-0x0000000183975700

	// Methods
	// [XID] // 0x0000000189AE9A90-0x0000000189AE9AB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001839754E0-0x00000001839755F0
	// [XID] // 0x0000000189AF17B0-0x0000000189AF17D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183974F40-0x0000000183975020
	// [XID] // 0x0000000189AF8EF0-0x0000000189AF8F10
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6A8F */) => default; // 0x0000000183974B50-0x0000000183974C30
	// [XID] // 0x0000000189B00450-0x0000000189B00470
	public override int GetHashNum() => default; // 0x0000000183973790-0x0000000183973860
	// [XID] // 0x0000000189B079B0-0x0000000189B079D0
	public override void InitEmpty() {} // 0x00000001839745B0-0x0000000183974680
	[BlackList] // 0x0000000189B0F250-0x0000000189B0F290
	// [XID] // 0x0000000189B0F250-0x0000000189B0F290
	public override bool FromJson(JSONNode node) => default; // 0x0000000183973E50-0x00000001839741D0
	// [XID] // 0x0000000189B19610-0x0000000189B19630
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183972F60-0x0000000183973250
	[BlackList] // 0x0000000189B20C90-0x0000000189B20CD0
	// [XID] // 0x0000000189B20C90-0x0000000189B20CD0
	public static new ByElementTriggerEntityType ParseFromJson(JSONNode node) => default; // 0x0000000183974C90-0x0000000183974EE0
	// [XID] // 0x0000000189B2B330-0x0000000189B2B350
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A90 */, bool useObjectPool = false /* Metadata: 0x00AF6A94 */) => default; // 0x0000000183974850-0x0000000183974B50
	// [XID] // 0x0000000189B328C0-0x0000000189B328E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A95 */, bool useObjectPool = false /* Metadata: 0x00AF6A99 */) => default; // 0x0000000183973940-0x0000000183973C20
	// [XID] // 0x0000000189B3A1F0-0x0000000189B3A210
	public static new ByElementTriggerEntityType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6A9A */, bool useObjectPool = false /* Metadata: 0x00AF6A9E */) => default; // 0x00000001839741D0-0x00000001839743F0
	[BlackList] // 0x0000000189B41B30-0x0000000189B41B70
	// [XID] // 0x0000000189B41B30-0x0000000189B41B70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183973250-0x0000000183973520
	// [XID] // 0x0000000189B4C380-0x0000000189B4C3A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183975220-0x00000001839754E0
	[BlackList] // 0x0000000189B53960-0x0000000189B539A0
	// [XID] // 0x0000000189B53960-0x0000000189B539A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183974760-0x0000000183974850
	// [XID] // 0x0000000189B5E4E0-0x0000000189B5E500
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000183973C20-0x0000000183973D50
	[BlackList] // 0x0000000189B659A0-0x0000000189B659E0
	// [XID] // 0x0000000189B659A0-0x0000000189B659E0
	public override void AutoAllocTypeFields() {} // 0x0000000183973520-0x00000001839735C0
	[BlackList] // 0x0000000189B70080-0x0000000189B700C0
	// [XID] // 0x0000000189B70080-0x0000000189B700C0
	public override void AutoRecycleTypeFields() {} // 0x00000001839735C0-0x0000000183973670
	[BlackList] // 0x0000000189B7A590-0x0000000189B7A5D0
	// [XID] // 0x0000000189B7A590-0x0000000189B7A5D0
	public override void ReturnToObjectPool() {} // 0x00000001839755F0-0x0000000183975690
}

