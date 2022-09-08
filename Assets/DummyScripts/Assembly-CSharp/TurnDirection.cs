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
public class TurnDirection : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16377
{
	// Fields
	private TurnMode _turnMode; // 0x68

	// Properties
	public TurnMode turnMode { /* [XID] */ /* 0x0000000189A5A810-0x0000000189A5A830 */ get => default; /* [XID] */ /* 0x0000000189A61FB0-0x0000000189A61FD0 */ private set {} } // 0x0000000183414A80-0x0000000183414B20 0x0000000183413D60-0x0000000183413E10
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AEEA40-0x0000000189AEEA60 */ get => default; } // 0x00000001834145F0-0x0000000183414690 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AF6010-0x0000000189AF6030 */ get => default; } // 0x0000000183413BA0-0x0000000183413C40 

	// Constructors
	public TurnDirection() {} // 0x0000000183414D50-0x0000000183414DB0

	// Methods
	// [XID] // 0x0000000189A69E70-0x0000000189A69E90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183414B20-0x0000000183414C10
	// [XID] // 0x0000000189A710E0-0x0000000189A71100
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001834146F0-0x00000001834147A0
	// [XID] // 0x0000000189A78D00-0x0000000189A78D20
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF398C */) => default; // 0x0000000183414260-0x0000000183414340
	// [XID] // 0x0000000189A801E0-0x0000000189A80200
	public override int GetHashNum() => default; // 0x0000000183412E70-0x0000000183412F40
	// [XID] // 0x0000000189A87F40-0x0000000189A87F60
	public override void InitEmpty() {} // 0x0000000183413C40-0x0000000183413CE0
	[BlackList] // 0x0000000189A8F790-0x0000000189A8F7D0
	// [XID] // 0x0000000189A8F790-0x0000000189A8F7D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183413520-0x00000001834138A0
	// [XID] // 0x0000000189A9A0E0-0x0000000189A9A100
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001834126A0-0x00000001834128C0
	[BlackList] // 0x0000000189AA1020-0x0000000189AA1060
	// [XID] // 0x0000000189AA1020-0x0000000189AA1060
	public static new TurnDirection ParseFromJson(JSONNode node) => default; // 0x00000001834143A0-0x00000001834145F0
	// [XID] // 0x0000000189AAB9F0-0x0000000189AABA10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF398D */, bool useObjectPool = false /* Metadata: 0x00AF3991 */) => default; // 0x0000000183413F60-0x0000000183414260
	// [XID] // 0x0000000189AB33A0-0x0000000189AB33C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3992 */, bool useObjectPool = false /* Metadata: 0x00AF3996 */) => default; // 0x0000000183413090-0x00000001834132C0
	// [XID] // 0x0000000189ABB0F0-0x0000000189ABB110
	public static new TurnDirection ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3997 */, bool useObjectPool = false /* Metadata: 0x00AF399B */) => default; // 0x00000001834138A0-0x0000000183413AC0
	[BlackList] // 0x0000000189AC2880-0x0000000189AC28C0
	// [XID] // 0x0000000189AC2880-0x0000000189AC28C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001834128C0-0x0000000183412B90
	// [XID] // 0x0000000189ACCF00-0x0000000189ACCF20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183414880-0x0000000183414A80
	[BlackList] // 0x0000000189AD4BA0-0x0000000189AD4BE0
	// [XID] // 0x0000000189AD4BA0-0x0000000189AD4BE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183413E70-0x0000000183413F60
	// [XID] // 0x0000000189ADF710-0x0000000189ADF730
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183414C10-0x0000000183414CB0
	// [XID] // 0x0000000189AE6EF0-0x0000000189AE6F10
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001834132C0-0x0000000183413420
	[BlackList] // 0x0000000189AFD530-0x0000000189AFD570
	// [XID] // 0x0000000189AFD530-0x0000000189AFD570
	public override void AutoAllocTypeFields() {} // 0x0000000183412B90-0x0000000183412C30
	[BlackList] // 0x0000000189B07C10-0x0000000189B07C50
	// [XID] // 0x0000000189B07C10-0x0000000189B07C50
	public override void AutoRecycleTypeFields() {} // 0x0000000183412C30-0x0000000183412CE0
	[BlackList] // 0x0000000189B12460-0x0000000189B124A0
	// [XID] // 0x0000000189B12460-0x0000000189B124A0
	public override void ReturnToObjectPool() {} // 0x0000000183414CB0-0x0000000183414D50
}

