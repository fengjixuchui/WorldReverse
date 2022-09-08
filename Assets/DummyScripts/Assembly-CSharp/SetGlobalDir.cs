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
public class SetGlobalDir : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16426
{
	// Fields
	private string _key; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private bool _setTarget; // 0x78

	// Properties
	public string key { /* [XID] */ /* 0x00000001899593B0-0x00000001899593D0 */ get => default; /* [XID] */ /* 0x0000000189960C80-0x0000000189960CA0 */ private set {} } // 0x0000000181315A40-0x0000000181315AE0 0x0000000181317450-0x0000000181317500
	public ConfigBornType born { /* [XID] */ /* 0x0000000189968420-0x0000000189968440 */ get => default; /* [XID] */ /* 0x000000018996F8C0-0x000000018996F8E0 */ private set {} } // 0x0000000181315B50-0x0000000181315BF0 0x0000000181317C60-0x0000000181317D10
	public bool setTarget { /* [XID] */ /* 0x0000000189977640-0x0000000189977660 */ get => default; /* [XID] */ /* 0x000000018997E940-0x000000018997E960 */ private set {} } // 0x0000000181317020-0x00000001813170C0 0x0000000181316210-0x00000001813162C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A0A4E0-0x0000000189A0A500 */ get => default; } // 0x0000000181317500-0x00000001813175A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A11E00-0x0000000189A11E20 */ get => default; } // 0x00000001813169C0-0x0000000181316A60 

	// Constructors
	public SetGlobalDir() {} // 0x0000000181317E50-0x0000000181317EC0

	// Methods
	// [XID] // 0x00000001899862D0-0x00000001899862F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181317B20-0x0000000181317C60
	// [XID] // 0x000000018998DEA0-0x000000018998DEC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181317600-0x0000000181317700
	// [XID] // 0x00000001899959B0-0x00000001899959D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B1E */) => default; // 0x00000001813170C0-0x00000001813171A0
	// [XID] // 0x000000018999D2D0-0x000000018999D2F0
	public override int GetHashNum() => default; // 0x0000000181315970-0x0000000181315A40
	// [XID] // 0x00000001899A4C50-0x00000001899A4C70
	public override void InitEmpty() {} // 0x0000000181316A60-0x0000000181316B50
	[BlackList] // 0x00000001899AC7D0-0x00000001899AC810
	// [XID] // 0x00000001899AC7D0-0x00000001899AC810
	public override bool FromJson(JSONNode node) => default; // 0x0000000181316340-0x00000001813166C0
	// [XID] // 0x00000001899B6B50-0x00000001899B6B70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181314F80-0x0000000181315330
	[BlackList] // 0x00000001899BE630-0x00000001899BE670
	// [XID] // 0x00000001899BE630-0x00000001899BE670
	public static new SetGlobalDir ParseFromJson(JSONNode node) => default; // 0x0000000181317200-0x0000000181317450
	// [XID] // 0x00000001899C8BA0-0x00000001899C8BC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B1F */, bool useObjectPool = false /* Metadata: 0x00AF3B23 */) => default; // 0x0000000181316D20-0x0000000181317020
	// [XID] // 0x00000001899D0530-0x00000001899D0550
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B24 */, bool useObjectPool = false /* Metadata: 0x00AF3B28 */) => default; // 0x0000000181315CD0-0x0000000181316030
	// [XID] // 0x00000001899D79B0-0x00000001899D79D0
	public static new SetGlobalDir ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B29 */, bool useObjectPool = false /* Metadata: 0x00AF3B2D */) => default; // 0x00000001813166C0-0x00000001813168E0
	[BlackList] // 0x00000001899DEE90-0x00000001899DEED0
	// [XID] // 0x00000001899DEE90-0x00000001899DEED0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181315330-0x0000000181315600
	// [XID] // 0x00000001899E97E0-0x00000001899E9800
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001813177E0-0x0000000181317B20
	[BlackList] // 0x00000001899F0F30-0x00000001899F0F70
	// [XID] // 0x00000001899F0F30-0x00000001899F0F70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181316C30-0x0000000181316D20
	// [XID] // 0x00000001899FBB50-0x00000001899FBB70
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181317D10-0x0000000181317DB0
	// [XID] // 0x0000000189A02F10-0x0000000189A02F30
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181316030-0x0000000181316190
	[BlackList] // 0x0000000189A190B0-0x0000000189A190F0
	// [XID] // 0x0000000189A190B0-0x0000000189A190F0
	public override void AutoAllocTypeFields() {} // 0x0000000181315600-0x00000001813156A0
	[BlackList] // 0x0000000189A23720-0x0000000189A23760
	// [XID] // 0x0000000189A23720-0x0000000189A23760
	public override void AutoRecycleTypeFields() {} // 0x00000001813156A0-0x00000001813157E0
	[BlackList] // 0x0000000189A2D8B0-0x0000000189A2D8F0
	// [XID] // 0x0000000189A2D8B0-0x0000000189A2D8F0
	public override void ReturnToObjectPool() {} // 0x0000000181317DB0-0x0000000181317E50
}

