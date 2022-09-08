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
public class AddGlobalPos : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16422
{
	// Fields
	private string _key; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private bool _setTarget; // 0x78

	// Properties
	public string key { /* [XID] */ /* 0x0000000189793BC0-0x0000000189793BE0 */ get => default; /* [XID] */ /* 0x000000018979BF30-0x000000018979BF50 */ private set {} } // 0x00000001830DCD10-0x00000001830DCDB0 0x00000001830DE720-0x00000001830DE7D0
	public ConfigBornType born { /* [XID] */ /* 0x00000001897A33A0-0x00000001897A33C0 */ get => default; /* [XID] */ /* 0x00000001897AA960-0x00000001897AA980 */ private set {} } // 0x00000001830DCE20-0x00000001830DCEC0 0x00000001830DEF30-0x00000001830DEFE0
	public bool setTarget { /* [XID] */ /* 0x00000001897B24F0-0x00000001897B2510 */ get => default; /* [XID] */ /* 0x00000001897B9E10-0x00000001897B9E30 */ private set {} } // 0x00000001830DE2F0-0x00000001830DE390 0x00000001830DD4E0-0x00000001830DD590
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898457F0-0x0000000189845810 */ get => default; } // 0x00000001830DE7D0-0x00000001830DE870 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018984CD60-0x000000018984CD80 */ get => default; } // 0x00000001830DDC90-0x00000001830DDD30 

	// Constructors
	public AddGlobalPos() {} // 0x00000001830DF120-0x00000001830DF190

	// Methods
	// [XID] // 0x00000001897C1EF0-0x00000001897C1F10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830DEDF0-0x00000001830DEF30
	// [XID] // 0x00000001897C97C0-0x00000001897C97E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001830DE8D0-0x00000001830DE9D0
	// [XID] // 0x00000001897D0DD0-0x00000001897D0DF0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3AFE */) => default; // 0x00000001830DE390-0x00000001830DE470
	// [XID] // 0x00000001897D8CB0-0x00000001897D8CD0
	public override int GetHashNum() => default; // 0x00000001830DCC40-0x00000001830DCD10
	// [XID] // 0x00000001897DFE70-0x00000001897DFE90
	public override void InitEmpty() {} // 0x00000001830DDD30-0x00000001830DDE20
	[BlackList] // 0x00000001897E7550-0x00000001897E7590
	// [XID] // 0x00000001897E7550-0x00000001897E7590
	public override bool FromJson(JSONNode node) => default; // 0x00000001830DD610-0x00000001830DD990
	// [XID] // 0x00000001897F24F0-0x00000001897F2510
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001830DC250-0x00000001830DC600
	[BlackList] // 0x00000001897F9C20-0x00000001897F9C60
	// [XID] // 0x00000001897F9C20-0x00000001897F9C60
	public static new AddGlobalPos ParseFromJson(JSONNode node) => default; // 0x00000001830DE4D0-0x00000001830DE720
	// [XID] // 0x00000001898041B0-0x00000001898041D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AFF */, bool useObjectPool = false /* Metadata: 0x00AF3B03 */) => default; // 0x00000001830DDFF0-0x00000001830DE2F0
	// [XID] // 0x000000018980B5E0-0x000000018980B600
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B04 */, bool useObjectPool = false /* Metadata: 0x00AF3B08 */) => default; // 0x00000001830DCFA0-0x00000001830DD300
	// [XID] // 0x0000000189812CA0-0x0000000189812CC0
	public static new AddGlobalPos ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B09 */, bool useObjectPool = false /* Metadata: 0x00AF3B0D */) => default; // 0x00000001830DD990-0x00000001830DDBB0
	[BlackList] // 0x000000018981A880-0x000000018981A8C0
	// [XID] // 0x000000018981A880-0x000000018981A8C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001830DC600-0x00000001830DC8D0
	// [XID] // 0x0000000189824CE0-0x0000000189824D00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001830DEAB0-0x00000001830DEDF0
	[BlackList] // 0x000000018982C6B0-0x000000018982C6F0
	// [XID] // 0x000000018982C6B0-0x000000018982C6F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001830DDF00-0x00000001830DDFF0
	// [XID] // 0x0000000189836B50-0x0000000189836B70
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001830DEFE0-0x00000001830DF080
	// [XID] // 0x000000018983DF80-0x000000018983DFA0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001830DD300-0x00000001830DD460
	[BlackList] // 0x0000000189853E60-0x0000000189853EA0
	// [XID] // 0x0000000189853E60-0x0000000189853EA0
	public override void AutoAllocTypeFields() {} // 0x00000001830DC8D0-0x00000001830DC970
	[BlackList] // 0x000000018985DFD0-0x000000018985E010
	// [XID] // 0x000000018985DFD0-0x000000018985E010
	public override void AutoRecycleTypeFields() {} // 0x00000001830DC970-0x00000001830DCAB0
	[BlackList] // 0x0000000189868A30-0x0000000189868A70
	// [XID] // 0x0000000189868A30-0x0000000189868A70
	public override void ReturnToObjectPool() {} // 0x00000001830DF080-0x00000001830DF120
}

