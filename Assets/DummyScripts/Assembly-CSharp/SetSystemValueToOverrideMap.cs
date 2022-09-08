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
public class SetSystemValueToOverrideMap : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16412
{
	// Fields
	private string _key; // 0x68
	private SystemValuerType _type; // 0x70

	// Properties
	public string key { /* [XID] */ /* 0x0000000189953490-0x00000001899534B0 */ get => default; /* [XID] */ /* 0x000000018995AC30-0x000000018995AC50 */ private set {} } // 0x0000000185B378E0-0x0000000185B37980 0x0000000185B39060-0x0000000185B39110
	public SystemValuerType type { /* [XID] */ /* 0x0000000189962790-0x00000001899627B0 */ get => default; /* [XID] */ /* 0x0000000189969B60-0x0000000189969B80 */ private set {} } // 0x0000000185B39890-0x0000000185B39930 0x0000000185B39360-0x0000000185B39410
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899F5890-0x00000001899F58B0 */ get => default; } // 0x0000000185B39110-0x0000000185B391B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899FD070-0x00000001899FD090 */ get => default; } // 0x0000000185B38690-0x0000000185B38730 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189A04510-0x0000000189A04530 */ get => default; } // 0x0000000185B37840-0x0000000185B378E0 

	// Constructors
	public SetSystemValueToOverrideMap() {} // 0x0000000185B39A70-0x0000000185B39AD0

	// Methods
	// [XID] // 0x0000000189971900-0x0000000189971920
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185B39780-0x0000000185B39890
	// [XID] // 0x00000001899791D0-0x00000001899791F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185B39280-0x0000000185B39360
	// [XID] // 0x0000000189980280-0x00000001899802A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3AAE */) => default; // 0x0000000185B38CD0-0x0000000185B38DB0
	// [XID] // 0x0000000189987B30-0x0000000189987B50
	public override int GetHashNum() => default; // 0x0000000185B37770-0x0000000185B37840
	// [XID] // 0x000000018998F680-0x000000018998F6A0
	public override void InitEmpty() {} // 0x0000000185B38730-0x0000000185B38800
	[BlackList] // 0x00000001899970A0-0x00000001899970E0
	// [XID] // 0x00000001899970A0-0x00000001899970E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000185B38010-0x0000000185B38390
	// [XID] // 0x00000001899A1C70-0x00000001899A1C90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185B36EB0-0x0000000185B371C0
	[BlackList] // 0x00000001899A94E0-0x00000001899A9520
	// [XID] // 0x00000001899A94E0-0x00000001899A9520
	public static new SetSystemValueToOverrideMap ParseFromJson(JSONNode node) => default; // 0x0000000185B38E10-0x0000000185B39060
	// [XID] // 0x00000001899B3F60-0x00000001899B3F80
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AAF */, bool useObjectPool = false /* Metadata: 0x00AF3AB3 */) => default; // 0x0000000185B389D0-0x0000000185B38CD0
	// [XID] // 0x00000001899BB430-0x00000001899BB450
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AB4 */, bool useObjectPool = false /* Metadata: 0x00AF3AB8 */) => default; // 0x0000000185B37AD0-0x0000000185B37DB0
	// [XID] // 0x00000001899C2F20-0x00000001899C2F40
	public static new SetSystemValueToOverrideMap ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AB9 */, bool useObjectPool = false /* Metadata: 0x00AF3ABD */) => default; // 0x0000000185B38390-0x0000000185B385B0
	[BlackList] // 0x00000001899CA2C0-0x00000001899CA300
	// [XID] // 0x00000001899CA2C0-0x00000001899CA300
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185B371C0-0x0000000185B37490
	// [XID] // 0x00000001899D4A70-0x00000001899D4A90
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185B394F0-0x0000000185B39780
	[BlackList] // 0x00000001899DC070-0x00000001899DC0B0
	// [XID] // 0x00000001899DC070-0x00000001899DC0B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185B388E0-0x0000000185B389D0
	// [XID] // 0x00000001899E6A70-0x00000001899E6A90
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000185B39930-0x0000000185B399D0
	// [XID] // 0x00000001899EE040-0x00000001899EE060
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000185B37DB0-0x0000000185B37F10
	[BlackList] // 0x0000000189A0BC10-0x0000000189A0BC50
	// [XID] // 0x0000000189A0BC10-0x0000000189A0BC50
	public override void AutoAllocTypeFields() {} // 0x0000000185B37490-0x0000000185B37530
	[BlackList] // 0x0000000189A16240-0x0000000189A16280
	// [XID] // 0x0000000189A16240-0x0000000189A16280
	public override void AutoRecycleTypeFields() {} // 0x0000000185B37530-0x0000000185B375E0
	[BlackList] // 0x0000000189A20810-0x0000000189A20850
	// [XID] // 0x0000000189A20810-0x0000000189A20850
	public override void ReturnToObjectPool() {} // 0x0000000185B399D0-0x0000000185B39A70
}

