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
public class DoTileAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16745
{
	// Fields
	private string _actionID; // 0x68

	// Properties
	public string actionID { /* [XID] */ /* 0x0000000189B3CEC0-0x0000000189B3CEE0 */ get => default; /* [XID] */ /* 0x0000000189B44C70-0x0000000189B44C90 */ private set {} } // 0x000000018477F380-0x000000018477F420 0x000000018477ED20-0x000000018477EDD0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189BCF330-0x0000000189BCF350 */ get => default; } // 0x000000018477F7B0-0x000000018477F850 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189BD6640-0x0000000189BD6660 */ get => default; } // 0x000000018477EC80-0x000000018477ED20 

	// Constructors
	public DoTileAction() {} // 0x000000018477FEA0-0x000000018477FF00

	// Methods
	// [XID] // 0x0000000189B4C420-0x0000000189B4C440
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018477FC70-0x000000018477FD60
	// [XID] // 0x0000000189B53A60-0x0000000189B53A80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018477F8B0-0x000000018477F990
	// [XID] // 0x0000000189B5B370-0x0000000189B5B390
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44EE */) => default; // 0x000000018477F420-0x000000018477F500
	// [XID] // 0x0000000189B627E0-0x0000000189B62800
	public override int GetHashNum() => default; // 0x000000018477DF10-0x000000018477DFE0
	// [XID] // 0x0000000189B6A350-0x0000000189B6A370
	public override void InitEmpty() {} // 0x000000018477EDD0-0x000000018477EEA0
	[BlackList] // 0x0000000189B71A70-0x0000000189B71AB0
	// [XID] // 0x0000000189B71A70-0x0000000189B71AB0
	public override bool FromJson(JSONNode node) => default; // 0x000000018477E600-0x000000018477E980
	// [XID] // 0x0000000189B7BDB0-0x0000000189B7BDD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018477D730-0x000000018477D960
	[BlackList] // 0x0000000189B836A0-0x0000000189B836E0
	// [XID] // 0x0000000189B836A0-0x0000000189B836E0
	public static new DoTileAction ParseFromJson(JSONNode node) => default; // 0x000000018477F560-0x000000018477F7B0
	// [XID] // 0x0000000189B8D910-0x0000000189B8D930
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44EF */, bool useObjectPool = false /* Metadata: 0x00AF44F3 */) => default; // 0x000000018477F080-0x000000018477F380
	// [XID] // 0x0000000189B94F30-0x0000000189B94F50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44F4 */, bool useObjectPool = false /* Metadata: 0x00AF44F8 */) => default; // 0x000000018477E130-0x000000018477E3A0
	// [XID] // 0x0000000189B9C680-0x0000000189B9C6A0
	public static new DoTileAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44F9 */, bool useObjectPool = false /* Metadata: 0x00AF44FD */) => default; // 0x000000018477E980-0x000000018477EBA0
	[BlackList] // 0x0000000189BA3CB0-0x0000000189BA3CF0
	// [XID] // 0x0000000189BA3CB0-0x0000000189BA3CF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018477D960-0x000000018477DC30
	// [XID] // 0x0000000189BADD20-0x0000000189BADD40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018477FA70-0x000000018477FC70
	[BlackList] // 0x0000000189BB54D0-0x0000000189BB5510
	// [XID] // 0x0000000189BB54D0-0x0000000189BB5510
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018477EF80-0x000000018477F080
	// [XID] // 0x0000000189BBFC10-0x0000000189BBFC30
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018477FD60-0x000000018477FE00
	// [XID] // 0x0000000189BC7720-0x0000000189BC7740
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018477E3A0-0x000000018477E500
	[BlackList] // 0x0000000189BDE280-0x0000000189BDE2C0
	// [XID] // 0x0000000189BDE280-0x0000000189BDE2C0
	public override void AutoAllocTypeFields() {} // 0x000000018477DC30-0x000000018477DCD0
	[BlackList] // 0x00000001895EDC30-0x00000001895EDC70
	// [XID] // 0x00000001895EDC30-0x00000001895EDC70
	public override void AutoRecycleTypeFields() {} // 0x000000018477DCD0-0x000000018477DD80
	[BlackList] // 0x00000001895F8530-0x00000001895F8570
	// [XID] // 0x00000001895F8530-0x00000001895F8570
	public override void ReturnToObjectPool() {} // 0x000000018477FE00-0x000000018477FEA0
}

