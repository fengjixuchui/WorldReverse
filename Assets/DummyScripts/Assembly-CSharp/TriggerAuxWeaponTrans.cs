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
public class TriggerAuxWeaponTrans : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16519
{
	// Fields
	private bool _setEnable; // 0x68
	private string _equipPart; // 0x70

	// Properties
	public bool setEnable { /* [XID] */ /* 0x00000001897955E0-0x0000000189795600 */ get => default; /* [XID] */ /* 0x000000018979DA50-0x000000018979DA70 */ private set {} } // 0x00000001845B2770-0x00000001845B2810 0x00000001845B34A0-0x00000001845B3550
	public string equipPart { /* [XID] */ /* 0x00000001897A4D10-0x00000001897A4D30 */ get => default; /* [XID] */ /* 0x00000001897AC2C0-0x00000001897AC2E0 */ private set {} } // 0x00000001845B2440-0x00000001845B24E0 0x00000001845B1AD0-0x00000001845B1B80
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189830BE0-0x0000000189830C00 */ get => default; } // 0x00000001845B31E0-0x00000001845B3280 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898382A0-0x00000001898382C0 */ get => default; } // 0x00000001845B2810-0x00000001845B28B0 

	// Constructors
	public TriggerAuxWeaponTrans() {} // 0x00000001845B3990-0x00000001845B39F0

	// Methods
	// [XID] // 0x00000001897B4290-0x00000001897B42B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845B37E0-0x00000001845B38F0
	// [XID] // 0x00000001897BBF10-0x00000001897BBF30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845B32E0-0x00000001845B33C0
	// [XID] // 0x00000001897C36D0-0x00000001897C36F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3DF6 */) => default; // 0x00000001845B2E50-0x00000001845B2F30
	// [XID] // 0x00000001897CAEF0-0x00000001897CAF10
	public override int GetHashNum() => default; // 0x00000001845B18B0-0x00000001845B1980
	// [XID] // 0x00000001897D25D0-0x00000001897D25F0
	public override void InitEmpty() {} // 0x00000001845B28B0-0x00000001845B2980
	[BlackList] // 0x00000001897DA2B0-0x00000001897DA2F0
	// [XID] // 0x00000001897DA2B0-0x00000001897DA2F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001845B20C0-0x00000001845B2440
	// [XID] // 0x00000001897E4650-0x00000001897E4670
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001845B1010-0x00000001845B1300
	[BlackList] // 0x00000001897EC180-0x00000001897EC1C0
	// [XID] // 0x00000001897EC180-0x00000001897EC1C0
	public static new TriggerAuxWeaponTrans ParseFromJson(JSONNode node) => default; // 0x00000001845B2F90-0x00000001845B31E0
	// [XID] // 0x00000001897F67C0-0x00000001897F67E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DF7 */, bool useObjectPool = false /* Metadata: 0x00AF3DFB */) => default; // 0x00000001845B2B50-0x00000001845B2E50
	// [XID] // 0x00000001897FDE60-0x00000001897FDE80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3DFC */, bool useObjectPool = false /* Metadata: 0x00AF3E00 */) => default; // 0x00000001845B1B80-0x00000001845B1E60
	// [XID] // 0x0000000189805670-0x0000000189805690
	public static new TriggerAuxWeaponTrans ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E01 */, bool useObjectPool = false /* Metadata: 0x00AF3E05 */) => default; // 0x00000001845B24E0-0x00000001845B2700
	[BlackList] // 0x000000018980CC10-0x000000018980CC50
	// [XID] // 0x000000018980CC10-0x000000018980CC50
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845B1300-0x00000001845B15D0
	// [XID] // 0x0000000189817720-0x0000000189817740
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845B3550-0x00000001845B37E0
	[BlackList] // 0x000000018981F040-0x000000018981F080
	// [XID] // 0x000000018981F040-0x000000018981F080
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845B2A60-0x00000001845B2B50
	// [XID] // 0x00000001898295F0-0x0000000189829610
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001845B1E60-0x00000001845B1FC0
	[BlackList] // 0x000000018983F910-0x000000018983F950
	// [XID] // 0x000000018983F910-0x000000018983F950
	public override void AutoAllocTypeFields() {} // 0x00000001845B15D0-0x00000001845B1670
	[BlackList] // 0x0000000189849D90-0x0000000189849DD0
	// [XID] // 0x0000000189849D90-0x0000000189849DD0
	public override void AutoRecycleTypeFields() {} // 0x00000001845B1670-0x00000001845B1720
	[BlackList] // 0x0000000189853E00-0x0000000189853E40
	// [XID] // 0x0000000189853E00-0x0000000189853E40
	public override void ReturnToObjectPool() {} // 0x00000001845B38F0-0x00000001845B3990
}

