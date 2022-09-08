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
public class ByHasTag : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17366
{
	// Fields
	private string _tag; // 0x18

	// Properties
	public string tag { /* [XID] */ /* 0x00000001896F5CC0-0x00000001896F5CE0 */ get => default; /* [XID] */ /* 0x00000001896FD530-0x00000001896FD550 */ private set {} } // 0x0000000182AD1390-0x0000000182AD1430 0x0000000182ACFCE0-0x0000000182ACFD90

	// Constructors
	public ByHasTag() {} // 0x0000000182AD1870-0x0000000182AD18D0

	// Methods
	// [XID] // 0x0000000189704990-0x00000001897049B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AD16E0-0x0000000182AD17D0
	// [XID] // 0x000000018970C130-0x000000018970C150
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182AD12B0-0x0000000182AD1390
	// [XID] // 0x0000000189713B20-0x0000000189713B40
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BCF */) => default; // 0x0000000182AD0EC0-0x0000000182AD0FA0
	// [XID] // 0x000000018971B3C0-0x000000018971B3E0
	public override int GetHashNum() => default; // 0x0000000182ACFC10-0x0000000182ACFCE0
	// [XID] // 0x0000000189722620-0x0000000189722640
	public override void InitEmpty() {} // 0x0000000182AD0920-0x0000000182AD09F0
	[BlackList] // 0x0000000189729D00-0x0000000189729D40
	// [XID] // 0x0000000189729D00-0x0000000189729D40
	public override bool FromJson(JSONNode node) => default; // 0x0000000182AD0310-0x0000000182AD0690
	// [XID] // 0x00000001897343F0-0x0000000189734410
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182ACF4A0-0x0000000182ACF6D0
	[BlackList] // 0x000000018973BCC0-0x000000018973BD00
	// [XID] // 0x000000018973BCC0-0x000000018973BD00
	public static new ByHasTag ParseFromJson(JSONNode node) => default; // 0x0000000182AD1000-0x0000000182AD1250
	// [XID] // 0x00000001897464E0-0x0000000189746500
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BD0 */, bool useObjectPool = false /* Metadata: 0x00AF6BD4 */) => default; // 0x0000000182AD0BC0-0x0000000182AD0EC0
	// [XID] // 0x000000018974DF70-0x000000018974DF90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BD5 */, bool useObjectPool = false /* Metadata: 0x00AF6BD9 */) => default; // 0x0000000182ACFE70-0x0000000182AD00E0
	// [XID] // 0x0000000189755710-0x0000000189755730
	public static new ByHasTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BDA */, bool useObjectPool = false /* Metadata: 0x00AF6BDE */) => default; // 0x0000000182AD0690-0x0000000182AD08B0
	[BlackList] // 0x000000018975C990-0x000000018975C9D0
	// [XID] // 0x000000018975C990-0x000000018975C9D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ACF6D0-0x0000000182ACF9A0
	// [XID] // 0x0000000189767260-0x0000000189767280
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AD14E0-0x0000000182AD16E0
	[BlackList] // 0x000000018976E6E0-0x000000018976E720
	// [XID] // 0x000000018976E6E0-0x000000018976E720
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182AD0AD0-0x0000000182AD0BC0
	// [XID] // 0x00000001897790A0-0x00000001897790C0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182AD00E0-0x0000000182AD0210
	[BlackList] // 0x00000001897807C0-0x0000000189780800
	// [XID] // 0x00000001897807C0-0x0000000189780800
	public override void AutoAllocTypeFields() {} // 0x0000000182ACF9A0-0x0000000182ACFA40
	[BlackList] // 0x000000018978AF80-0x000000018978AFC0
	// [XID] // 0x000000018978AF80-0x000000018978AFC0
	public override void AutoRecycleTypeFields() {} // 0x0000000182ACFA40-0x0000000182ACFAF0
	[BlackList] // 0x0000000189795420-0x0000000189795460
	// [XID] // 0x0000000189795420-0x0000000189795460
	public override void ReturnToObjectPool() {} // 0x0000000182AD17D0-0x0000000182AD1870
}

