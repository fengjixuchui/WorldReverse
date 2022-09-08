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
public class SetPartControlTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16597
{
	// Fields
	private string[] _partRootNames; // 0x68
	private ControlPartTargetType _targetType; // 0x70

	// Properties
	public string[] partRootNames { /* [XID] */ /* 0x0000000189AAB950-0x0000000189AAB970 */ get => default; /* [XID] */ /* 0x0000000189AB32E0-0x0000000189AB3300 */ private set {} } // 0x0000000182806060-0x0000000182806100 0x0000000182806E30-0x0000000182806EE0
	public ControlPartTargetType targetType { /* [XID] */ /* 0x0000000189ABB010-0x0000000189ABB030 */ get => default; /* [XID] */ /* 0x0000000189AC2820-0x0000000189AC2840 */ private set {} } // 0x00000001828061E0-0x0000000182806280 0x00000001828049F0-0x0000000182804AA0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B4DA60-0x0000000189B4DA80 */ get => default; } // 0x0000000182806C50-0x0000000182806CF0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B552D0-0x0000000189B552F0 */ get => default; } // 0x0000000182806280-0x0000000182806320 

	// Constructors
	public SetPartControlTarget() {} // 0x00000001828074D0-0x0000000182807540

	// Methods
	// [XID] // 0x0000000189AC9DE0-0x0000000189AC9E00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182807280-0x0000000182807390
	// [XID] // 0x0000000189AD1710-0x0000000189AD1730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182806D50-0x0000000182806E30
	// [XID] // 0x0000000189AD9490-0x0000000189AD94B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF405A */) => default; // 0x00000001828068C0-0x00000001828069A0
	// [XID] // 0x0000000189AE0FC0-0x0000000189AE0FE0
	public override int GetHashNum() => default; // 0x0000000182805360-0x0000000182805430
	// [XID] // 0x0000000189AE8390-0x0000000189AE83B0
	public override void InitEmpty() {} // 0x0000000182806320-0x00000001828063F0
	[BlackList] // 0x0000000189AF0330-0x0000000189AF0370
	// [XID] // 0x0000000189AF0330-0x0000000189AF0370
	public override bool FromJson(JSONNode node) => default; // 0x0000000182805AC0-0x0000000182805E40
	// [XID] // 0x0000000189AFA940-0x0000000189AFA960
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182804AA0-0x0000000182804DB0
	[BlackList] // 0x0000000189B01E90-0x0000000189B01ED0
	// [XID] // 0x0000000189B01E90-0x0000000189B01ED0
	public static new SetPartControlTarget ParseFromJson(JSONNode node) => default; // 0x0000000182806A00-0x0000000182806C50
	// [XID] // 0x0000000189B0C430-0x0000000189B0C450
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF405B */, bool useObjectPool = false /* Metadata: 0x00AF405F */) => default; // 0x00000001828065C0-0x00000001828068C0
	// [XID] // 0x0000000189B139D0-0x0000000189B139F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4060 */, bool useObjectPool = false /* Metadata: 0x00AF4064 */) => default; // 0x0000000182805580-0x0000000182805860
	// [XID] // 0x0000000189B1B060-0x0000000189B1B080
	public static new SetPartControlTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4065 */, bool useObjectPool = false /* Metadata: 0x00AF4069 */) => default; // 0x0000000182805E40-0x0000000182806060
	[BlackList] // 0x0000000189B22750-0x0000000189B22790
	// [XID] // 0x0000000189B22750-0x0000000189B22790
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182804DB0-0x0000000182805080
	// [XID] // 0x0000000189B2CB90-0x0000000189B2CBB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182806FC0-0x0000000182807280
	[BlackList] // 0x0000000189B34040-0x0000000189B34080
	// [XID] // 0x0000000189B34040-0x0000000189B34080
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828064D0-0x00000001828065C0
	// [XID] // 0x0000000189B3EA40-0x0000000189B3EA60
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182807390-0x0000000182807430
	// [XID] // 0x0000000189B464A0-0x0000000189B464C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182805860-0x00000001828059C0
	[BlackList] // 0x0000000189B5CC30-0x0000000189B5CC70
	// [XID] // 0x0000000189B5CC30-0x0000000189B5CC70
	public override void AutoAllocTypeFields() {} // 0x0000000182805080-0x0000000182805120
	[BlackList] // 0x0000000189B67560-0x0000000189B675A0
	// [XID] // 0x0000000189B67560-0x0000000189B675A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182805120-0x00000001828051D0
	[BlackList] // 0x0000000189B71AF0-0x0000000189B71B30
	// [XID] // 0x0000000189B71AF0-0x0000000189B71B30
	public override void ReturnToObjectPool() {} // 0x0000000182807430-0x00000001828074D0
}

