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
public class AvatarExitFocus : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16359
{
	// Fields
	private bool _keepRotation; // 0x68

	// Properties
	public bool keepRotation { /* [XID] */ /* 0x0000000189BA5CD0-0x0000000189BA5CF0 */ get => default; /* [XID] */ /* 0x00000001899C8BC0-0x00000001899C8BE0 */ private set {} } // 0x0000000184A78430-0x0000000184A784D0 0x0000000184A789C0-0x0000000184A78A70
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A53040-0x0000000189A53060 */ get => default; } // 0x0000000184A79B10-0x0000000184A79BB0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A5A830-0x0000000189A5A850 */ get => default; } // 0x0000000184A79170-0x0000000184A79210 

	// Constructors
	public AvatarExitFocus() {} // 0x0000000184A7A1D0-0x0000000184A7A240

	// Methods
	// [XID] // 0x00000001899D0550-0x00000001899D0570
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A79FA0-0x0000000184A7A090
	// [XID] // 0x00000001899D7A10-0x00000001899D7A30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A79C10-0x0000000184A79CC0
	// [XID] // 0x00000001899DEED0-0x00000001899DEEF0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF38F8 */) => default; // 0x0000000184A79780-0x0000000184A79860
	// [XID] // 0x00000001899E6A90-0x00000001899E6AB0
	public override int GetHashNum() => default; // 0x0000000184A782F0-0x0000000184A783C0
	// [XID] // 0x00000001899EE060-0x00000001899EE080
	public override void InitEmpty() {} // 0x0000000184A79210-0x0000000184A792B0
	[BlackList] // 0x00000001899F58D0-0x00000001899F5910
	// [XID] // 0x00000001899F58D0-0x00000001899F5910
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A78AF0-0x0000000184A78E70
	// [XID] // 0x00000001899FFE00-0x00000001899FFE20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A77B40-0x0000000184A77D40
	[BlackList] // 0x0000000189A076B0-0x0000000189A076F0
	// [XID] // 0x0000000189A076B0-0x0000000189A076F0
	public static new AvatarExitFocus ParseFromJson(JSONNode node) => default; // 0x0000000184A798C0-0x0000000184A79B10
	// [XID] // 0x0000000189A11E20-0x0000000189A11E40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38F9 */, bool useObjectPool = false /* Metadata: 0x00AF38FD */) => default; // 0x0000000184A79480-0x0000000184A79780
	// [XID] // 0x0000000189A190F0-0x0000000189A19110
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF38FE */, bool useObjectPool = false /* Metadata: 0x00AF3902 */) => default; // 0x0000000184A785B0-0x0000000184A787E0
	// [XID] // 0x0000000189A20850-0x0000000189A20870
	public static new AvatarExitFocus ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3903 */, bool useObjectPool = false /* Metadata: 0x00AF3907 */) => default; // 0x0000000184A78E70-0x0000000184A79090
	[BlackList] // 0x0000000189A27C40-0x0000000189A27C80
	// [XID] // 0x0000000189A27C40-0x0000000189A27C80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A77D40-0x0000000184A78010
	// [XID] // 0x0000000189A32100-0x0000000189A32120
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A79DA0-0x0000000184A79FA0
	[BlackList] // 0x0000000189A39A70-0x0000000189A39AB0
	// [XID] // 0x0000000189A39A70-0x0000000189A39AB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A79390-0x0000000184A79480
	// [XID] // 0x0000000189A443D0-0x0000000189A443F0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A7A090-0x0000000184A7A130
	// [XID] // 0x0000000189A4B9C0-0x0000000189A4B9E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A787E0-0x0000000184A78940
	[BlackList] // 0x0000000189A61FD0-0x0000000189A62010
	// [XID] // 0x0000000189A61FD0-0x0000000189A62010
	public override void AutoAllocTypeFields() {} // 0x0000000184A78010-0x0000000184A780B0
	[BlackList] // 0x0000000189A6CB40-0x0000000189A6CB80
	// [XID] // 0x0000000189A6CB40-0x0000000189A6CB80
	public override void AutoRecycleTypeFields() {} // 0x0000000184A780B0-0x0000000184A78160
	[BlackList] // 0x0000000189A77370-0x0000000189A773B0
	// [XID] // 0x0000000189A77370-0x0000000189A773B0
	public override void ReturnToObjectPool() {} // 0x0000000184A7A130-0x0000000184A7A1D0
}

