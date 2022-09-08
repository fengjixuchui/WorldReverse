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
public class SetGlobalValueByTargetDistance : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16414
{
	// Fields
	private string _key; // 0x68
	private bool _isXZ; // 0x70

	// Properties
	public string key { /* [XID] */ /* 0x00000001898D1080-0x00000001898D10A0 */ get => default; /* [XID] */ /* 0x0000000189A39A10-0x0000000189A39A30 */ private set {} } // 0x0000000182726D40-0x0000000182726DE0 0x0000000182728560-0x0000000182728610
	public bool isXZ { /* [XID] */ /* 0x0000000189A41330-0x0000000189A41350 */ get => default; /* [XID] */ /* 0x0000000189A48970-0x0000000189A48990 */ private set {} } // 0x0000000182727D40-0x0000000182727DE0 0x00000001827288D0-0x0000000182728980
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AD4B80-0x0000000189AD4BA0 */ get => default; } // 0x0000000182728610-0x00000001827286B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189ADC540-0x0000000189ADC560 */ get => default; } // 0x0000000182727AF0-0x0000000182727B90 

	// Constructors
	public SetGlobalValueByTargetDistance() {} // 0x0000000182728E60-0x0000000182728ED0

	// Methods
	// [XID] // 0x0000000189A500E0-0x0000000189A50100
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182728C10-0x0000000182728D20
	// [XID] // 0x0000000189A576B0-0x0000000189A576D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182728710-0x00000001827287F0
	// [XID] // 0x0000000189A5F1F0-0x0000000189A5F210
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3ABE */) => default; // 0x00000001827281D0-0x00000001827282B0
	// [XID] // 0x0000000189A66A80-0x0000000189A66AA0
	public override int GetHashNum() => default; // 0x0000000182726C70-0x0000000182726D40
	// [XID] // 0x0000000189A6E3C0-0x0000000189A6E3E0
	public override void InitEmpty() {} // 0x0000000182727B90-0x0000000182727C60
	[BlackList] // 0x0000000189A759D0-0x0000000189A75A10
	// [XID] // 0x0000000189A759D0-0x0000000189A75A10
	public override bool FromJson(JSONNode node) => default; // 0x0000000182727470-0x00000001827277F0
	// [XID] // 0x0000000189A80180-0x0000000189A801A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827263D0-0x00000001827266C0
	[BlackList] // 0x0000000189A87F00-0x0000000189A87F40
	// [XID] // 0x0000000189A87F00-0x0000000189A87F40
	public static new SetGlobalValueByTargetDistance ParseFromJson(JSONNode node) => default; // 0x0000000182728310-0x0000000182728560
	// [XID] // 0x0000000189A925F0-0x0000000189A92610
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3ABF */, bool useObjectPool = false /* Metadata: 0x00AF3AC3 */) => default; // 0x0000000182727ED0-0x00000001827281D0
	// [XID] // 0x0000000189A9A0C0-0x0000000189A9A0E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AC4 */, bool useObjectPool = false /* Metadata: 0x00AF3AC8 */) => default; // 0x0000000182726F30-0x0000000182727210
	// [XID] // 0x0000000189AA1000-0x0000000189AA1020
	public static new SetGlobalValueByTargetDistance ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3AC9 */, bool useObjectPool = false /* Metadata: 0x00AF3ACD */) => default; // 0x00000001827277F0-0x0000000182727A10
	[BlackList] // 0x0000000189AA8740-0x0000000189AA8780
	// [XID] // 0x0000000189AA8740-0x0000000189AA8780
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827266C0-0x0000000182726990
	// [XID] // 0x0000000189AB3380-0x0000000189AB33A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182728980-0x0000000182728C10
	[BlackList] // 0x0000000189ABB070-0x0000000189ABB0B0
	// [XID] // 0x0000000189ABB070-0x0000000189ABB0B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182727DE0-0x0000000182727ED0
	// [XID] // 0x0000000189AC5950-0x0000000189AC5970
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182728D20-0x0000000182728DC0
	// [XID] // 0x0000000189ACCEE0-0x0000000189ACCF00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182727210-0x0000000182727370
	[BlackList] // 0x0000000189AE3E70-0x0000000189AE3EB0
	// [XID] // 0x0000000189AE3E70-0x0000000189AE3EB0
	public override void AutoAllocTypeFields() {} // 0x0000000182726990-0x0000000182726A30
	[BlackList] // 0x0000000189AEE9C0-0x0000000189AEEA00
	// [XID] // 0x0000000189AEE9C0-0x0000000189AEEA00
	public override void AutoRecycleTypeFields() {} // 0x0000000182726A30-0x0000000182726AE0
	[BlackList] // 0x0000000189AF9130-0x0000000189AF9170
	// [XID] // 0x0000000189AF9130-0x0000000189AF9170
	public override void ReturnToObjectPool() {} // 0x0000000182728DC0-0x0000000182728E60
}

