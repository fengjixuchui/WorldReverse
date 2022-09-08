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
public class UseItem : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16735
{
	// Fields
	private SimpleSafeUInt32 itemIdRawNum; // 0x68
	private SimpleSafeUInt32 itemNumRawNum; // 0x6C

	// Properties
	public uint itemId { /* [XID] */ /* 0x00000001896C4FD0-0x00000001896C4FF0 */ get => default; /* [XID] */ /* 0x00000001896CC590-0x00000001896CC5B0 */ private set {} } // 0x00000001841DE3E0-0x00000001841DE4B0 0x00000001841DE9D0-0x00000001841DEAB0
	public uint itemNum { /* [XID] */ /* 0x00000001896D3800-0x00000001896D3820 */ get => default; /* [XID] */ /* 0x00000001896DB320-0x00000001896DB340 */ private set {} } // 0x00000001841DF8F0-0x00000001841DF9C0 0x00000001841DF410-0x00000001841DF4F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189765970-0x0000000189765990 */ get => default; } // 0x00000001841DFD50-0x00000001841DFDF0 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018976D220-0x000000018976D240 */ get => default; } // 0x00000001841DF1B0-0x00000001841DF250 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189774670-0x0000000189774690 */ get => default; } // 0x00000001841DE270-0x00000001841DE310 

	// Constructors
	public UseItem() {} // 0x00000001841E0590-0x00000001841E05F0

	// Methods
	// [XID] // 0x00000001896E2A80-0x00000001896E2AA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841E0340-0x00000001841E0450
	// [XID] // 0x00000001896EA020-0x00000001896EA040
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001841DFEC0-0x00000001841DFF70
	// [XID] // 0x00000001896F10C0-0x00000001896F10E0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF449E */) => default; // 0x00000001841DF9C0-0x00000001841DFAA0
	// [XID] // 0x00000001896F8960-0x00000001896F8980
	public override int GetHashNum() => default; // 0x00000001841DE1A0-0x00000001841DE270
	// [XID] // 0x0000000189700220-0x0000000189700240
	public override void InitEmpty() {} // 0x00000001841DF250-0x00000001841DF330
	[BlackList] // 0x0000000189707A50-0x0000000189707A90
	// [XID] // 0x0000000189707A50-0x0000000189707A90
	public override bool FromJson(JSONNode node) => default; // 0x00000001841DEB30-0x00000001841DEEB0
	// [XID] // 0x0000000189712490-0x00000001897124B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841DD830-0x00000001841DDBB0
	[BlackList] // 0x0000000189719BB0-0x0000000189719BF0
	// [XID] // 0x0000000189719BB0-0x0000000189719BF0
	public static new UseItem ParseFromJson(JSONNode node) => default; // 0x00000001841DFB00-0x00000001841DFD50
	// [XID] // 0x0000000189723DD0-0x0000000189723DF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF449F */, bool useObjectPool = false /* Metadata: 0x00AF44A3 */) => default; // 0x00000001841DF5F0-0x00000001841DF8F0
	// [XID] // 0x000000018972B610-0x000000018972B630
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44A4 */, bool useObjectPool = false /* Metadata: 0x00AF44A8 */) => default; // 0x00000001841DE530-0x00000001841DE830
	// [XID] // 0x0000000189732D80-0x0000000189732DA0
	public static new UseItem ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44A9 */, bool useObjectPool = false /* Metadata: 0x00AF44AD */) => default; // 0x00000001841DEEB0-0x00000001841DF0D0
	[BlackList] // 0x000000018973A4D0-0x000000018973A510
	// [XID] // 0x000000018973A4D0-0x000000018973A510
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841DDBB0-0x00000001841DDE80
	// [XID] // 0x0000000189744D70-0x0000000189744D90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841E0050-0x00000001841E0340
	[BlackList] // 0x000000018974C960-0x000000018974C9A0
	// [XID] // 0x000000018974C960-0x000000018974C9A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841DF4F0-0x00000001841DF5F0
	// [XID] // 0x0000000189756D80-0x0000000189756DA0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001841E0450-0x00000001841E04F0
	// [XID] // 0x000000018975E290-0x000000018975E2B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001841DE830-0x00000001841DE950
	[BlackList] // 0x000000018977C080-0x000000018977C0C0
	// [XID] // 0x000000018977C080-0x000000018977C0C0
	public override void AutoAllocTypeFields() {} // 0x00000001841DDE80-0x00000001841DDF20
	[BlackList] // 0x0000000189786860-0x00000001897868A0
	// [XID] // 0x0000000189786860-0x00000001897868A0
	public override void AutoRecycleTypeFields() {} // 0x00000001841DDF20-0x00000001841DE010
	[BlackList] // 0x0000000189790D10-0x0000000189790D50
	// [XID] // 0x0000000189790D10-0x0000000189790D50
	public override void ReturnToObjectPool() {} // 0x00000001841E04F0-0x00000001841E0590
}

