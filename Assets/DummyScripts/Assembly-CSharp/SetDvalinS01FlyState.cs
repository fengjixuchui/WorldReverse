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
public class SetDvalinS01FlyState : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16647
{
	// Fields
	private SimpleSafeInt32 toStateRawNum; // 0x68

	// Properties
	public int toState { /* [XID] */ /* 0x000000018972FF40-0x000000018972FF60 */ get => default; /* [XID] */ /* 0x00000001897377E0-0x0000000189737800 */ private set {} } // 0x000000018241DCE0-0x000000018241DDB0 0x000000018241EB80-0x000000018241EC60
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897C3690-0x00000001897C36B0 */ get => default; } // 0x000000018241EFF0-0x000000018241F090 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897CAEB0-0x00000001897CAED0 */ get => default; } // 0x000000018241E530-0x000000018241E5D0 

	// Constructors
	public SetDvalinS01FlyState() {} // 0x000000018241F6E0-0x000000018241F770

	// Methods
	// [XID] // 0x000000018973F320-0x000000018973F340
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018241F4B0-0x000000018241F5A0
	// [XID] // 0x0000000189746640-0x0000000189746660
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018241F0F0-0x000000018241F1A0
	// [XID] // 0x000000018974E110-0x000000018974E130
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF41EA */) => default; // 0x000000018241EC60-0x000000018241ED40
	// [XID] // 0x00000001897557F0-0x0000000189755810
	public override int GetHashNum() => default; // 0x000000018241D730-0x000000018241D800
	// [XID] // 0x000000018975CAF0-0x000000018975CB10
	public override void InitEmpty() {} // 0x000000018241E5D0-0x000000018241E6A0
	[BlackList] // 0x00000001897642A0-0x00000001897642E0
	// [XID] // 0x00000001897642A0-0x00000001897642E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018241DEB0-0x000000018241E230
	// [XID] // 0x000000018976E840-0x000000018976E860
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018241CF20-0x000000018241D160
	[BlackList] // 0x0000000189776280-0x00000001897762C0
	// [XID] // 0x0000000189776280-0x00000001897762C0
	public static new SetDvalinS01FlyState ParseFromJson(JSONNode node) => default; // 0x000000018241EDA0-0x000000018241EFF0
	// [XID] // 0x0000000189780960-0x0000000189780980
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41EB */, bool useObjectPool = false /* Metadata: 0x00AF41EF */) => default; // 0x000000018241E880-0x000000018241EB80
	// [XID] // 0x0000000189788020-0x0000000189788040
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41F0 */, bool useObjectPool = false /* Metadata: 0x00AF41F4 */) => default; // 0x000000018241D950-0x000000018241DB80
	// [XID] // 0x000000018978F5E0-0x000000018978F600
	public static new SetDvalinS01FlyState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41F5 */, bool useObjectPool = false /* Metadata: 0x00AF41F9 */) => default; // 0x000000018241E230-0x000000018241E450
	[BlackList] // 0x0000000189796DD0-0x0000000189796E10
	// [XID] // 0x0000000189796DD0-0x0000000189796E10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018241D160-0x000000018241D430
	// [XID] // 0x00000001897A1AC0-0x00000001897A1AE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018241F280-0x000000018241F4B0
	[BlackList] // 0x00000001897A9380-0x00000001897A93C0
	// [XID] // 0x00000001897A9380-0x00000001897A93C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018241E780-0x000000018241E880
	// [XID] // 0x00000001897B4230-0x00000001897B4250
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018241F5A0-0x000000018241F640
	// [XID] // 0x00000001897BBED0-0x00000001897BBEF0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018241DB80-0x000000018241DCE0
	[BlackList] // 0x00000001897D2570-0x00000001897D25B0
	// [XID] // 0x00000001897D2570-0x00000001897D25B0
	public override void AutoAllocTypeFields() {} // 0x000000018241D430-0x000000018241D4D0
	[BlackList] // 0x00000001897DCC70-0x00000001897DCCB0
	// [XID] // 0x00000001897DCC70-0x00000001897DCCB0
	public override void AutoRecycleTypeFields() {} // 0x000000018241D4D0-0x000000018241D5A0
	[BlackList] // 0x00000001897E74B0-0x00000001897E74F0
	// [XID] // 0x00000001897E74B0-0x00000001897E74F0
	public override void ReturnToObjectPool() {} // 0x000000018241F640-0x000000018241F6E0
}

