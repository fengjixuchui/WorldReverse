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
public class UpdateReactionDamage : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16681
{
	// Fields
	private AbilityTargetting _levelTarget; // 0x68
	private string _reactionDamageName; // 0x70

	// Properties
	public AbilityTargetting levelTarget { /* [XID] */ /* 0x0000000189897AE0-0x0000000189897B00 */ get => default; /* [XID] */ /* 0x000000018989EF20-0x000000018989EF40 */ private set {} } // 0x0000000183918BB0-0x0000000183918C50 0x0000000183919FB0-0x000000018391A060
	public string reactionDamageName { /* [XID] */ /* 0x00000001898A69E0-0x00000001898A6A00 */ get => default; /* [XID] */ /* 0x00000001898AE130-0x00000001898AE150 */ private set {} } // 0x000000018391A5C0-0x000000018391A660 0x000000018391A280-0x000000018391A330
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018993A190-0x000000018993A1B0 */ get => default; } // 0x0000000183919F10-0x0000000183919FB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189941340-0x0000000189941360 */ get => default; } // 0x0000000183919530-0x00000001839195D0 

	// Constructors
	public UpdateReactionDamage() {} // 0x000000018391A8B0-0x000000018391A920

	// Methods
	// [XID] // 0x00000001898B56D0-0x00000001898B56F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018391A660-0x000000018391A770
	// [XID] // 0x00000001898BD100-0x00000001898BD120
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018391A0C0-0x000000018391A1A0
	// [XID] // 0x00000001898C4880-0x00000001898C48A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42EE */) => default; // 0x0000000183919B80-0x0000000183919C60
	// [XID] // 0x00000001898CBE10-0x00000001898CBE30
	public override int GetHashNum() => default; // 0x00000001839186B0-0x0000000183918780
	// [XID] // 0x00000001898D3690-0x00000001898D36B0
	public override void InitEmpty() {} // 0x00000001839195D0-0x00000001839196A0
	[BlackList] // 0x00000001898DAE60-0x00000001898DAEA0
	// [XID] // 0x00000001898DAE60-0x00000001898DAEA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183918EB0-0x0000000183919230
	// [XID] // 0x00000001898E5D60-0x00000001898E5D80
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183917E00-0x0000000183918100
	[BlackList] // 0x00000001898ED640-0x00000001898ED680
	// [XID] // 0x00000001898ED640-0x00000001898ED680
	public static new UpdateReactionDamage ParseFromJson(JSONNode node) => default; // 0x0000000183919CC0-0x0000000183919F10
	// [XID] // 0x00000001898F8090-0x00000001898F80B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42EF */, bool useObjectPool = false /* Metadata: 0x00AF42F3 */) => default; // 0x0000000183919880-0x0000000183919B80
	// [XID] // 0x00000001898FF6D0-0x00000001898FF6F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42F4 */, bool useObjectPool = false /* Metadata: 0x00AF42F8 */) => default; // 0x00000001839188D0-0x0000000183918BB0
	// [XID] // 0x0000000189906ED0-0x0000000189906EF0
	public static new UpdateReactionDamage ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42F9 */, bool useObjectPool = false /* Metadata: 0x00AF42FD */) => default; // 0x0000000183919230-0x0000000183919450
	[BlackList] // 0x000000018990E8F0-0x000000018990E930
	// [XID] // 0x000000018990E8F0-0x000000018990E930
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183918100-0x00000001839183D0
	// [XID] // 0x0000000189919280-0x00000001899192A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018391A330-0x000000018391A5C0
	[BlackList] // 0x00000001899207F0-0x0000000189920830
	// [XID] // 0x00000001899207F0-0x0000000189920830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183919780-0x0000000183919880
	// [XID] // 0x000000018992B180-0x000000018992B1A0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018391A770-0x000000018391A810
	// [XID] // 0x00000001899327A0-0x00000001899327C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183918C50-0x0000000183918DB0
	[BlackList] // 0x0000000189948E80-0x0000000189948EC0
	// [XID] // 0x0000000189948E80-0x0000000189948EC0
	public override void AutoAllocTypeFields() {} // 0x00000001839183D0-0x0000000183918470
	[BlackList] // 0x00000001899533F0-0x0000000189953430
	// [XID] // 0x00000001899533F0-0x0000000189953430
	public override void AutoRecycleTypeFields() {} // 0x0000000183918470-0x0000000183918520
	[BlackList] // 0x000000018995DCB0-0x000000018995DCF0
	// [XID] // 0x000000018995DCB0-0x000000018995DCF0
	public override void ReturnToObjectPool() {} // 0x000000018391A810-0x000000018391A8B0
}

