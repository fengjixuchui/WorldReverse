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
public class ChangeTag : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16751
{
	// Fields
	private bool _isAdd; // 0x68
	private string _tag; // 0x70

	// Properties
	public bool isAdd { /* [XID] */ /* 0x00000001897A9320-0x00000001897A9340 */ get => default; /* [XID] */ /* 0x00000001897B0B00-0x00000001897B0B20 */ private set {} } // 0x0000000182A77100-0x0000000182A771A0 0x0000000182A76460-0x0000000182A76510
	public string tag { /* [XID] */ /* 0x00000001897B8860-0x00000001897B8880 */ get => default; /* [XID] */ /* 0x00000001897C08E0-0x00000001897C0900 */ private set {} } // 0x0000000182A77E40-0x0000000182A77EE0 0x0000000182A763B0-0x0000000182A76460
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189844100-0x0000000189844120 */ get => default; } // 0x0000000182A77BF0-0x0000000182A77C90 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018984B550-0x000000018984B570 */ get => default; } // 0x0000000182A77210-0x0000000182A772B0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189852660-0x0000000189852680 */ get => default; } // 0x0000000182A76310-0x0000000182A763B0 

	// Constructors
	public ChangeTag() {} // 0x0000000182A78400-0x0000000182A78470

	// Methods
	// [XID] // 0x00000001897C8230-0x00000001897C8250
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A78250-0x0000000182A78360
	// [XID] // 0x00000001897CF5D0-0x00000001897CF5F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A77D60-0x0000000182A77E40
	// [XID] // 0x00000001897D6E60-0x00000001897D6E80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF451E */) => default; // 0x0000000182A77860-0x0000000182A77940
	// [XID] // 0x00000001897DE4F0-0x00000001897DE510
	public override int GetHashNum() => default; // 0x0000000182A76240-0x0000000182A76310
	// [XID] // 0x00000001897E5FB0-0x00000001897E5FD0
	public override void InitEmpty() {} // 0x0000000182A772B0-0x0000000182A77380
	[BlackList] // 0x00000001897ED930-0x00000001897ED970
	// [XID] // 0x00000001897ED930-0x00000001897ED970
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A76B60-0x0000000182A76EE0
	// [XID] // 0x00000001897F82A0-0x00000001897F82C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A759A0-0x0000000182A75C90
	[BlackList] // 0x00000001897FF9B0-0x00000001897FF9F0
	// [XID] // 0x00000001897FF9B0-0x00000001897FF9F0
	public static new ChangeTag ParseFromJson(JSONNode node) => default; // 0x0000000182A779A0-0x0000000182A77BF0
	// [XID] // 0x0000000189809FD0-0x0000000189809FF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF451F */, bool useObjectPool = false /* Metadata: 0x00AF4523 */) => default; // 0x0000000182A77560-0x0000000182A77860
	// [XID] // 0x0000000189811660-0x0000000189811680
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4524 */, bool useObjectPool = false /* Metadata: 0x00AF4528 */) => default; // 0x0000000182A76660-0x0000000182A76940
	// [XID] // 0x00000001898191D0-0x00000001898191F0
	public static new ChangeTag ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4529 */, bool useObjectPool = false /* Metadata: 0x00AF452D */) => default; // 0x0000000182A76EE0-0x0000000182A77100
	[BlackList] // 0x0000000189820970-0x00000001898209B0
	// [XID] // 0x0000000189820970-0x00000001898209B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A75C90-0x0000000182A75F60
	// [XID] // 0x000000018982ADF0-0x000000018982AE10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A77FC0-0x0000000182A78250
	[BlackList] // 0x00000001898322D0-0x0000000189832310
	// [XID] // 0x00000001898322D0-0x0000000189832310
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A77460-0x0000000182A77560
	// [XID] // 0x000000018983C9F0-0x000000018983CA10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182A76940-0x0000000182A76A60
	[BlackList] // 0x000000018985A090-0x000000018985A0D0
	// [XID] // 0x000000018985A090-0x000000018985A0D0
	public override void AutoAllocTypeFields() {} // 0x0000000182A75F60-0x0000000182A76000
	[BlackList] // 0x00000001898644D0-0x0000000189864510
	// [XID] // 0x00000001898644D0-0x0000000189864510
	public override void AutoRecycleTypeFields() {} // 0x0000000182A76000-0x0000000182A760B0
	[BlackList] // 0x000000018986E950-0x000000018986E990
	// [XID] // 0x000000018986E950-0x000000018986E990
	public override void ReturnToObjectPool() {} // 0x0000000182A78360-0x0000000182A78400
}

