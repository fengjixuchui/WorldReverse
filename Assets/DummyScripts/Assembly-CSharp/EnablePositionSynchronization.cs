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
public class EnablePositionSynchronization : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16815
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001896F7550-0x00000001896F7570 */ get => default; /* [XID] */ /* 0x00000001896FEF10-0x00000001896FEF30 */ private set {} } // 0x000000018170EA00-0x000000018170EAA0 0x000000018170F6E0-0x000000018170F790
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189782240-0x0000000189782260 */ get => default; } // 0x000000018170F790-0x000000018170F830 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897895E0-0x0000000189789600 */ get => default; } // 0x000000018170ED30-0x000000018170EDD0 

	// Constructors
	public EnablePositionSynchronization() {} // 0x000000018170FDB0-0x000000018170FE20

	// Methods
	// [XID] // 0x0000000189706160-0x0000000189706180
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018170FC20-0x000000018170FD10
	// [XID] // 0x000000018970DA90-0x000000018970DAB0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018170F890-0x000000018170F940
	// [XID] // 0x0000000189714EB0-0x0000000189714ED0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF4726 */) => default; // 0x000000018170F350-0x000000018170F430
	// [XID] // 0x000000018971C980-0x000000018971C9A0
	public override int GetHashNum() => default; // 0x000000018170DFD0-0x000000018170E0A0
	// [XID] // 0x0000000189723DB0-0x0000000189723DD0
	public override void InitEmpty() {} // 0x000000018170EDD0-0x000000018170EE70
	[BlackList] // 0x000000018972B5D0-0x000000018972B610
	// [XID] // 0x000000018972B5D0-0x000000018972B610
	public override bool FromJson(JSONNode node) => default; // 0x000000018170E680-0x000000018170EA00
	// [XID] // 0x0000000189735D60-0x0000000189735D80
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018170D820-0x000000018170DA20
	[BlackList] // 0x000000018973D8F0-0x000000018973D930
	// [XID] // 0x000000018973D8F0-0x000000018973D930
	public static new EnablePositionSynchronization ParseFromJson(JSONNode node) => default; // 0x000000018170F490-0x000000018170F6E0
	// [XID] // 0x0000000189747FA0-0x0000000189747FC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4727 */, bool useObjectPool = false /* Metadata: 0x00AF472B */) => default; // 0x000000018170F050-0x000000018170F350
	// [XID] // 0x000000018974F6F0-0x000000018974F710
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF472C */, bool useObjectPool = false /* Metadata: 0x00AF4730 */) => default; // 0x000000018170E1F0-0x000000018170E420
	// [XID] // 0x0000000189756D60-0x0000000189756D80
	public static new EnablePositionSynchronization ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4731 */, bool useObjectPool = false /* Metadata: 0x00AF4735 */) => default; // 0x000000018170EAA0-0x000000018170ECC0
	[BlackList] // 0x000000018975E230-0x000000018975E270
	// [XID] // 0x000000018975E230-0x000000018975E270
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018170DA20-0x000000018170DCF0
	// [XID] // 0x0000000189768900-0x0000000189768920
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018170FA20-0x000000018170FC20
	[BlackList] // 0x000000018976FF90-0x000000018976FFD0
	// [XID] // 0x000000018976FF90-0x000000018976FFD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018170EF50-0x000000018170F050
	// [XID] // 0x000000018977A660-0x000000018977A680
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018170E420-0x000000018170E580
	[BlackList] // 0x0000000189790CD0-0x0000000189790D10
	// [XID] // 0x0000000189790CD0-0x0000000189790D10
	public override void AutoAllocTypeFields() {} // 0x000000018170DCF0-0x000000018170DD90
	[BlackList] // 0x000000018979BE10-0x000000018979BE50
	// [XID] // 0x000000018979BE10-0x000000018979BE50
	public override void AutoRecycleTypeFields() {} // 0x000000018170DD90-0x000000018170DE40
	[BlackList] // 0x00000001897A64C0-0x00000001897A6500
	// [XID] // 0x00000001897A64C0-0x00000001897A6500
	public override void ReturnToObjectPool() {} // 0x000000018170FD10-0x000000018170FDB0
}

