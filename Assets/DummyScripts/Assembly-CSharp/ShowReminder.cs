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
public class ShowReminder : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16679
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x68

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897D0D90-0x00000001897D0DB0 */ get => default; /* [XID] */ /* 0x00000001897D8C50-0x00000001897D8C70 */ private set {} } // 0x0000000181FBD1F0-0x0000000181FBD2C0 0x0000000181FBC370-0x0000000181FBC450
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189862DD0-0x0000000189862DF0 */ get => default; } // 0x0000000181FBCC40-0x0000000181FBCCE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018986A1E0-0x000000018986A200 */ get => default; } // 0x0000000181FBC180-0x0000000181FBC220 

	// Constructors
	public ShowReminder() {} // 0x0000000181FBD400-0x0000000181FBD460

	// Methods
	// [XID] // 0x00000001897DFE50-0x00000001897DFE70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FBD100-0x0000000181FBD1F0
	// [XID] // 0x00000001897E7490-0x00000001897E74B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FBCD40-0x0000000181FBCDF0
	// [XID] // 0x00000001897EF110-0x00000001897EF130
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42DE */) => default; // 0x0000000181FBC8B0-0x0000000181FBC990
	// [XID] // 0x00000001897F67A0-0x00000001897F67C0
	public override int GetHashNum() => default; // 0x0000000181FBB410-0x0000000181FBB4E0
	// [XID] // 0x00000001897FDE20-0x00000001897FDE40
	public override void InitEmpty() {} // 0x0000000181FBC220-0x0000000181FBC2F0
	[BlackList] // 0x0000000189805610-0x0000000189805650
	// [XID] // 0x0000000189805610-0x0000000189805650
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FBBB00-0x0000000181FBBE80
	// [XID] // 0x0000000189810070-0x0000000189810090
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FBABD0-0x0000000181FBAE30
	[BlackList] // 0x0000000189817620-0x0000000189817660
	// [XID] // 0x0000000189817620-0x0000000189817660
	public static new ShowReminder ParseFromJson(JSONNode node) => default; // 0x0000000181FBC9F0-0x0000000181FBCC40
	// [XID] // 0x0000000189821FF0-0x0000000189822010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42DF */, bool useObjectPool = false /* Metadata: 0x00AF42E3 */) => default; // 0x0000000181FBC5B0-0x0000000181FBC8B0
	// [XID] // 0x0000000189829530-0x0000000189829550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42E4 */, bool useObjectPool = false /* Metadata: 0x00AF42E8 */) => default; // 0x0000000181FBB630-0x0000000181FBB8A0
	// [XID] // 0x0000000189830B80-0x0000000189830BA0
	public static new ShowReminder ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42E9 */, bool useObjectPool = false /* Metadata: 0x00AF42ED */) => default; // 0x0000000181FBBE80-0x0000000181FBC0A0
	[BlackList] // 0x00000001898381E0-0x0000000189838220
	// [XID] // 0x00000001898381E0-0x0000000189838220
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FBAE30-0x0000000181FBB100
	// [XID] // 0x0000000189842980-0x00000001898429A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FBCED0-0x0000000181FBD100
	[BlackList] // 0x0000000189849C50-0x0000000189849C90
	// [XID] // 0x0000000189849C50-0x0000000189849C90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FBC4B0-0x0000000181FBC5B0
	// [XID] // 0x0000000189853D00-0x0000000189853D20
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181FBD2C0-0x0000000181FBD360
	// [XID] // 0x000000018985B850-0x000000018985B870
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181FBB8A0-0x0000000181FBBA00
	[BlackList] // 0x00000001898715D0-0x0000000189871610
	// [XID] // 0x00000001898715D0-0x0000000189871610
	public override void AutoAllocTypeFields() {} // 0x0000000181FBB100-0x0000000181FBB1A0
	[BlackList] // 0x000000018987BEA0-0x000000018987BEE0
	// [XID] // 0x000000018987BEA0-0x000000018987BEE0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FBB1A0-0x0000000181FBB280
	[BlackList] // 0x0000000189886380-0x00000001898863C0
	// [XID] // 0x0000000189886380-0x00000001898863C0
	public override void ReturnToObjectPool() {} // 0x0000000181FBD360-0x0000000181FBD400
}

