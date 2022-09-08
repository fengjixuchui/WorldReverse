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
public class DoActionByKillingMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17080
{
	// Fields
	private string[] _attackTags; // 0x30
	private SimpleSafeFloat detectWindowRawNum; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _onKill; // 0x40

	// Properties
	public string[] attackTags { /* [XID] */ /* 0x0000000189BCAB30-0x0000000189BCAB50 */ get => default; /* [XID] */ /* 0x0000000189BD21C0-0x0000000189BD21E0 */ private set {} } // 0x00000001837E8B50-0x00000001837E8BF0 0x00000001837E8720-0x00000001837E87D0
	public float detectWindow { /* [XID] */ /* 0x0000000189BD97E0-0x0000000189BD9800 */ get => default; /* [XID] */ /* 0x00000001895E6290-0x00000001895E62B0 */ private set {} } // 0x00000001837E9080-0x00000001837E9160 0x00000001837EA220-0x00000001837EA300
	public ConfigAbilityAction[] onKill { /* [XID] */ /* 0x00000001895EDBB0-0x00000001895EDBD0 */ get => default; /* [XID] */ /* 0x00000001895F5470-0x00000001895F5490 */ private set {} } // 0x00000001837EAB60-0x00000001837EAC00 0x00000001837E8670-0x00000001837E8720
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189679610-0x0000000189679630 */ get => default; } // 0x00000001837E9260-0x00000001837E9300 

	// Constructors
	public DoActionByKillingMixin() {} // 0x00000001837EACA0-0x00000001837EAD00

	// Methods
	// [XID] // 0x00000001895FC9F0-0x00000001895FCA10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837EAA30-0x00000001837EAB60
	// [XID] // 0x0000000189604410-0x0000000189604430
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837EA5B0-0x00000001837EA6B0
	// [XID] // 0x000000018960BBC0-0x000000018960BBE0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6273 */) => default; // 0x00000001837EA0E0-0x00000001837EA1C0
	// [XID] // 0x00000001896131E0-0x0000000189613200
	public override int GetHashNum() => default; // 0x00000001837E8A80-0x00000001837E8B50
	// [XID] // 0x000000018961AA60-0x000000018961AA80
	public override void InitEmpty() {} // 0x00000001837E9A10-0x00000001837E9B30
	[BlackList] // 0x0000000189622060-0x00000001896220A0
	// [XID] // 0x0000000189622060-0x00000001896220A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001837E9300-0x00000001837E9680
	// [XID] // 0x000000018962C670-0x000000018962C690
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837E7F60-0x00000001837E83A0
	[BlackList] // 0x0000000189634330-0x0000000189634370
	// [XID] // 0x0000000189634330-0x0000000189634370
	public static new DoActionByKillingMixin ParseFromJson(JSONNode node) => default; // 0x00000001837EA300-0x00000001837EA550
	// [XID] // 0x000000018963E9A0-0x000000018963E9C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6274 */, bool useObjectPool = false /* Metadata: 0x00AF6278 */) => default; // 0x00000001837E9D00-0x00000001837EA000
	// [XID] // 0x00000001896460A0-0x00000001896460C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6279 */, bool useObjectPool = false /* Metadata: 0x00AF627D */) => default; // 0x00000001837E8CD0-0x00000001837E9080
	// [XID] // 0x000000018964D900-0x000000018964D920
	public static new DoActionByKillingMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF627E */, bool useObjectPool = false /* Metadata: 0x00AF6282 */) => default; // 0x00000001837E96F0-0x00000001837E9910
	[BlackList] // 0x0000000189655060-0x00000001896550A0
	// [XID] // 0x0000000189655060-0x00000001896550A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837E83A0-0x00000001837E8670
	// [XID] // 0x000000018965F6E0-0x000000018965F700
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837EA6B0-0x00000001837EAA30
	[BlackList] // 0x0000000189667090-0x00000001896670D0
	// [XID] // 0x0000000189667090-0x00000001896670D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837E9C10-0x00000001837E9D00
	// [XID] // 0x0000000189671E20-0x0000000189671E40
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001837EA000-0x00000001837EA0E0
	[BlackList] // 0x0000000189680D00-0x0000000189680D40
	// [XID] // 0x0000000189680D00-0x0000000189680D40
	public override void AutoAllocTypeFields() {} // 0x00000001837E87D0-0x00000001837E8870
	[BlackList] // 0x000000018968B870-0x000000018968B8B0
	// [XID] // 0x000000018968B870-0x000000018968B8B0
	public override void AutoRecycleTypeFields() {} // 0x00000001837E8870-0x00000001837E8960
	[BlackList] // 0x0000000189696430-0x0000000189696470
	// [XID] // 0x0000000189696430-0x0000000189696470
	public override void ReturnToObjectPool() {} // 0x00000001837EAC00-0x00000001837EACA0
}

