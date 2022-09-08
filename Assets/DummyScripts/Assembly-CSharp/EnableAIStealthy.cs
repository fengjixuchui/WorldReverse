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
public class EnableAIStealthy : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16613
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189B20DD0-0x0000000189B20DF0 */ get => default; /* [XID] */ /* 0x0000000189B28490-0x0000000189B284B0 */ private set {} } // 0x0000000184131290-0x0000000184131330 0x0000000184131FD0-0x0000000184132080
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BB2770-0x0000000189BB2790 */ get => default; } // 0x0000000184132080-0x0000000184132120 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189BB9C20-0x0000000189BB9C40 */ get => default; } // 0x0000000184131630-0x00000001841316D0 

	// Constructors
	public EnableAIStealthy() {} // 0x0000000184132740-0x00000001841327A0

	// Methods
	// [XID] // 0x0000000189B2F7F0-0x0000000189B2F810
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184132510-0x0000000184132600
	// [XID] // 0x0000000189B370D0-0x0000000189B370F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184132180-0x0000000184132230
	// [XID] // 0x0000000189B3EA20-0x0000000189B3EA40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF40DA */) => default; // 0x0000000184131C40-0x0000000184131D20
	// [XID] // 0x0000000189B46480-0x0000000189B464A0
	public override int GetHashNum() => default; // 0x0000000184130860-0x0000000184130930
	// [XID] // 0x0000000189B4DA40-0x0000000189B4DA60
	public override void InitEmpty() {} // 0x00000001841316D0-0x0000000184131770
	[BlackList] // 0x0000000189B55290-0x0000000189B552D0
	// [XID] // 0x0000000189B55290-0x0000000189B552D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184130F10-0x0000000184131290
	// [XID] // 0x0000000189B5FE80-0x0000000189B5FEA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841300B0-0x00000001841302B0
	[BlackList] // 0x0000000189B67520-0x0000000189B67560
	// [XID] // 0x0000000189B67520-0x0000000189B67560
	public static new EnableAIStealthy ParseFromJson(JSONNode node) => default; // 0x0000000184131D80-0x0000000184131FD0
	// [XID] // 0x0000000189B71AD0-0x0000000189B71AF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40DB */, bool useObjectPool = false /* Metadata: 0x00AF40DF */) => default; // 0x0000000184131940-0x0000000184131C40
	// [XID] // 0x0000000189B78E60-0x0000000189B78E80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40E0 */, bool useObjectPool = false /* Metadata: 0x00AF40E4 */) => default; // 0x0000000184130A80-0x0000000184130CB0
	// [XID] // 0x0000000189B803F0-0x0000000189B80410
	public static new EnableAIStealthy ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF40E5 */, bool useObjectPool = false /* Metadata: 0x00AF40E9 */) => default; // 0x0000000184131330-0x0000000184131550
	[BlackList] // 0x0000000189B87EC0-0x0000000189B87F00
	// [XID] // 0x0000000189B87EC0-0x0000000189B87F00
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841302B0-0x0000000184130580
	// [XID] // 0x0000000189B920E0-0x0000000189B92100
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184132310-0x0000000184132510
	[BlackList] // 0x0000000189B99600-0x0000000189B99640
	// [XID] // 0x0000000189B99600-0x0000000189B99640
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184131850-0x0000000184131940
	// [XID] // 0x0000000189BA3CF0-0x0000000189BA3D10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184132600-0x00000001841326A0
	// [XID] // 0x0000000189BAB1A0-0x0000000189BAB1C0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184130CB0-0x0000000184130E10
	[BlackList] // 0x0000000189BC1BB0-0x0000000189BC1BF0
	// [XID] // 0x0000000189BC1BB0-0x0000000189BC1BF0
	public override void AutoAllocTypeFields() {} // 0x0000000184130580-0x0000000184130620
	[BlackList] // 0x0000000189BCC260-0x0000000189BCC2A0
	// [XID] // 0x0000000189BCC260-0x0000000189BCC2A0
	public override void AutoRecycleTypeFields() {} // 0x0000000184130620-0x00000001841306D0
	[BlackList] // 0x0000000189BD6680-0x0000000189BD66C0
	// [XID] // 0x0000000189BD6680-0x0000000189BD66C0
	public override void ReturnToObjectPool() {} // 0x00000001841326A0-0x0000000184132740
}

