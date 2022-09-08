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
public class HideUIBillBoard : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16573
{
	// Fields
	private bool _hide; // 0x68

	// Properties
	public bool hide { /* [XID] */ /* 0x0000000189B065C0-0x0000000189B065E0 */ get => default; /* [XID] */ /* 0x0000000189B0DBF0-0x0000000189B0DC10 */ private set {} } // 0x0000000182D10920-0x0000000182D109C0 0x0000000182D0FCB0-0x0000000182D0FD60
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B97EE0-0x0000000189B97F00 */ get => default; } // 0x0000000182D10770-0x0000000182D10810 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B9F2F0-0x0000000189B9F310 */ get => default; } // 0x0000000182D0FDD0-0x0000000182D0FE70 

	// Constructors
	public HideUIBillBoard() {} // 0x0000000182D10ED0-0x0000000182D10F40

	// Methods
	// [XID] // 0x0000000189B15050-0x0000000189B15070
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D10CA0-0x0000000182D10D90
	// [XID] // 0x0000000189B1CA70-0x0000000189B1CA90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D10870-0x0000000182D10920
	// [XID] // 0x0000000189B24040-0x0000000189B24060
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F9A */) => default; // 0x0000000182D103E0-0x0000000182D104C0
	// [XID] // 0x0000000189B2B4D0-0x0000000189B2B4F0
	public override int GetHashNum() => default; // 0x0000000182D0EFF0-0x0000000182D0F0C0
	// [XID] // 0x0000000189B32A00-0x0000000189B32A20
	public override void InitEmpty() {} // 0x0000000182D0FE70-0x0000000182D0FF10
	[BlackList] // 0x0000000189B3A2F0-0x0000000189B3A330
	// [XID] // 0x0000000189B3A2F0-0x0000000189B3A330
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D0F6A0-0x0000000182D0FA20
	// [XID] // 0x0000000189B44C90-0x0000000189B44CB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D0E840-0x0000000182D0EA40
	[BlackList] // 0x0000000189B4C4E0-0x0000000189B4C520
	// [XID] // 0x0000000189B4C4E0-0x0000000189B4C520
	public static new HideUIBillBoard ParseFromJson(JSONNode node) => default; // 0x0000000182D10520-0x0000000182D10770
	// [XID] // 0x0000000189B56CF0-0x0000000189B56D10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F9B */, bool useObjectPool = false /* Metadata: 0x00AF3F9F */) => default; // 0x0000000182D100E0-0x0000000182D103E0
	// [XID] // 0x0000000189B5E5A0-0x0000000189B5E5C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FA0 */, bool useObjectPool = false /* Metadata: 0x00AF3FA4 */) => default; // 0x0000000182D0F210-0x0000000182D0F440
	// [XID] // 0x0000000189B65B60-0x0000000189B65B80
	public static new HideUIBillBoard ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FA5 */, bool useObjectPool = false /* Metadata: 0x00AF3FA9 */) => default; // 0x0000000182D0FA20-0x0000000182D0FC40
	[BlackList] // 0x0000000189B6D080-0x0000000189B6D0C0
	// [XID] // 0x0000000189B6D080-0x0000000189B6D0C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D0EA40-0x0000000182D0ED10
	// [XID] // 0x0000000189B775F0-0x0000000189B77610
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D10AA0-0x0000000182D10CA0
	[BlackList] // 0x0000000189B7EB80-0x0000000189B7EBC0
	// [XID] // 0x0000000189B7EB80-0x0000000189B7EBC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D0FFF0-0x0000000182D100E0
	// [XID] // 0x0000000189B89530-0x0000000189B89550
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182D10D90-0x0000000182D10E30
	// [XID] // 0x0000000189B90AD0-0x0000000189B90AF0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182D0F440-0x0000000182D0F5A0
	[BlackList] // 0x0000000189BA6B40-0x0000000189BA6B80
	// [XID] // 0x0000000189BA6B40-0x0000000189BA6B80
	public override void AutoAllocTypeFields() {} // 0x0000000182D0ED10-0x0000000182D0EDB0
	[BlackList] // 0x0000000189BB12F0-0x0000000189BB1330
	// [XID] // 0x0000000189BB12F0-0x0000000189BB1330
	public override void AutoRecycleTypeFields() {} // 0x0000000182D0EDB0-0x0000000182D0EE60
	[BlackList] // 0x0000000189BBB4D0-0x0000000189BBB510
	// [XID] // 0x0000000189BBB4D0-0x0000000189BBB510
	public override void ReturnToObjectPool() {} // 0x0000000182D10E30-0x0000000182D10ED0
}

