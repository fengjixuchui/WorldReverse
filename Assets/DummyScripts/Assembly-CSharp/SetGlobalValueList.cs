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
public class SetGlobalValueList : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16400
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private GlobalValuePair[] _globalValueList; // 0x68

	// Properties
	public GlobalValuePair[] globalValueList { /* [XID] */ /* 0x0000000189ADF6D0-0x0000000189ADF6F0 */ get => default; /* [XID] */ /* 0x0000000189AE6EB0-0x0000000189AE6ED0 */ private set {} } // 0x0000000184863260-0x0000000184863300 0x0000000184862740-0x00000001848627F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B6A3D0-0x0000000189B6A3F0 */ get => default; } // 0x0000000184863D40-0x0000000184863DE0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B71B90-0x0000000189B71BB0 */ get => default; } // 0x0000000184863370-0x0000000184863410 

	// Constructors
	public SetGlobalValueList() {} // 0x00000001848643D0-0x0000000184864430

	// Methods
	// [XID] // 0x0000000189AEEA00-0x0000000189AEEA20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184864240-0x0000000184864330
	// [XID] // 0x0000000189AF5FD0-0x0000000189AF5FF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184863E40-0x0000000184863F20
	// [XID] // 0x0000000189AFD4F0-0x0000000189AFD510
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A4A */) => default; // 0x00000001848639B0-0x0000000184863A90
	// [XID] // 0x0000000189B04CA0-0x0000000189B04CC0
	public override int GetHashNum() => default; // 0x0000000184862520-0x00000001848625F0
	// [XID] // 0x0000000189B0C490-0x0000000189B0C4B0
	public override void InitEmpty() {} // 0x0000000184863410-0x00000001848634E0
	[BlackList] // 0x0000000189B13A30-0x0000000189B13A70
	// [XID] // 0x0000000189B13A30-0x0000000189B13A70
	public override bool FromJson(JSONNode node) => default; // 0x0000000184862CC0-0x0000000184863040
	// [XID] // 0x0000000189B1DE30-0x0000000189B1DE50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184861D40-0x0000000184861F70
	[BlackList] // 0x0000000189B256A0-0x0000000189B256E0
	// [XID] // 0x0000000189B256A0-0x0000000189B256E0
	public static new SetGlobalValueList ParseFromJson(JSONNode node) => default; // 0x0000000184863AF0-0x0000000184863D40
	// [XID] // 0x0000000189B2F870-0x0000000189B2F890
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A4B */, bool useObjectPool = false /* Metadata: 0x00AF3A4F */) => default; // 0x00000001848636B0-0x00000001848639B0
	// [XID] // 0x0000000189B37190-0x0000000189B371B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A50 */, bool useObjectPool = false /* Metadata: 0x00AF3A54 */) => default; // 0x00000001848627F0-0x0000000184862A60
	// [XID] // 0x0000000189B3EAA0-0x0000000189B3EAC0
	public static new SetGlobalValueList ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A55 */, bool useObjectPool = false /* Metadata: 0x00AF3A59 */) => default; // 0x0000000184863040-0x0000000184863260
	[BlackList] // 0x0000000189B464C0-0x0000000189B46500
	// [XID] // 0x0000000189B464C0-0x0000000189B46500
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184861F70-0x0000000184862240
	// [XID] // 0x0000000189B50D20-0x0000000189B50D40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184864000-0x0000000184864240
	[BlackList] // 0x0000000189B584B0-0x0000000189B584F0
	// [XID] // 0x0000000189B584B0-0x0000000189B584F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001848635C0-0x00000001848636B0
	// [XID] // 0x0000000189B62860-0x0000000189B62880
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184862A60-0x0000000184862BC0
	[BlackList] // 0x0000000189B78EC0-0x0000000189B78F00
	// [XID] // 0x0000000189B78EC0-0x0000000189B78F00
	public override void AutoAllocTypeFields() {} // 0x0000000184862240-0x00000001848622E0
	[BlackList] // 0x0000000189B837A0-0x0000000189B837E0
	// [XID] // 0x0000000189B837A0-0x0000000189B837E0
	public override void AutoRecycleTypeFields() {} // 0x00000001848622E0-0x0000000184862390
	[BlackList] // 0x0000000189B8D990-0x0000000189B8D9D0
	// [XID] // 0x0000000189B8D990-0x0000000189B8D9D0
	public override void ReturnToObjectPool() {} // 0x0000000184864330-0x00000001848643D0
}

