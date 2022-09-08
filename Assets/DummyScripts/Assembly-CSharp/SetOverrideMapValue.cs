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
public class SetOverrideMapValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16406
{
	// Fields
	private SimpleSafeFloat valueRawNum; // 0x68
	private string _overrideMapKey; // 0x70

	// Properties
	public float value { /* [XID] */ /* 0x0000000189795620-0x0000000189795640 */ get => default; /* [XID] */ /* 0x000000018979DA90-0x000000018979DAB0 */ private set {} } // 0x0000000182D53510-0x0000000182D535F0 0x0000000182D533B0-0x0000000182D53490
	public string overrideMapKey { /* [XID] */ /* 0x00000001897A4D70-0x00000001897A4D90 */ get => default; /* [XID] */ /* 0x00000001897AC2E0-0x00000001897AC300 */ private set {} } // 0x0000000182D54C40-0x0000000182D54CE0 0x0000000182D54CE0-0x0000000182D54D90
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189838300-0x0000000189838320 */ get => default; } // 0x0000000182D54680-0x0000000182D54720 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018983F970-0x000000018983F990 */ get => default; } // 0x0000000182D53C70-0x0000000182D53D10 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189846FB0-0x0000000189846FD0 */ get => default; } // 0x0000000182D52CE0-0x0000000182D52D80 

	// Constructors
	public SetOverrideMapValue() {} // 0x0000000182D54FE0-0x0000000182D55040

	// Methods
	// [XID] // 0x00000001897B42B0-0x00000001897B42D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D54D90-0x0000000182D54EA0
	// [XID] // 0x00000001897BBF30-0x00000001897BBF50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D547F0-0x0000000182D548D0
	// [XID] // 0x00000001897C36F0-0x00000001897C3710
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A7A */) => default; // 0x0000000182D542F0-0x0000000182D543D0
	// [XID] // 0x00000001897CAF10-0x00000001897CAF30
	public override int GetHashNum() => default; // 0x0000000182D52C10-0x0000000182D52CE0
	// [XID] // 0x00000001897D25F0-0x00000001897D2610
	public override void InitEmpty() {} // 0x0000000182D53D10-0x0000000182D53E20
	[BlackList] // 0x00000001897DA310-0x00000001897DA350
	// [XID] // 0x00000001897DA310-0x00000001897DA350
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D535F0-0x0000000182D53970
	// [XID] // 0x00000001897E4670-0x00000001897E4690
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D522E0-0x0000000182D52630
	[BlackList] // 0x00000001897EC1C0-0x00000001897EC200
	// [XID] // 0x00000001897EC1C0-0x00000001897EC200
	public static new SetOverrideMapValue ParseFromJson(JSONNode node) => default; // 0x0000000182D54430-0x0000000182D54680
	// [XID] // 0x00000001897F67E0-0x00000001897F6800
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A7B */, bool useObjectPool = false /* Metadata: 0x00AF3A7F */) => default; // 0x0000000182D53FF0-0x0000000182D542F0
	// [XID] // 0x00000001897FDE80-0x00000001897FDEA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A80 */, bool useObjectPool = false /* Metadata: 0x00AF3A84 */) => default; // 0x0000000182D52ED0-0x0000000182D531D0
	// [XID] // 0x0000000189805690-0x00000001898056B0
	public static new SetOverrideMapValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A85 */, bool useObjectPool = false /* Metadata: 0x00AF3A89 */) => default; // 0x0000000182D53970-0x0000000182D53B90
	[BlackList] // 0x000000018980CC70-0x000000018980CCB0
	// [XID] // 0x000000018980CC70-0x000000018980CCB0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D52630-0x0000000182D52900
	// [XID] // 0x0000000189817760-0x0000000189817780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D549B0-0x0000000182D54C40
	[BlackList] // 0x000000018981F0A0-0x000000018981F0E0
	// [XID] // 0x000000018981F0A0-0x000000018981F0E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D53F00-0x0000000182D53FF0
	// [XID] // 0x0000000189829630-0x0000000189829650
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182D54EA0-0x0000000182D54F40
	// [XID] // 0x0000000189830C40-0x0000000189830C60
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182D531D0-0x0000000182D53330
	[BlackList] // 0x000000018984E5A0-0x000000018984E5E0
	// [XID] // 0x000000018984E5A0-0x000000018984E5E0
	public override void AutoAllocTypeFields() {} // 0x0000000182D52900-0x0000000182D529A0
	[BlackList] // 0x0000000189858960-0x00000001898589A0
	// [XID] // 0x0000000189858960-0x00000001898589A0
	public override void AutoRecycleTypeFields() {} // 0x0000000182D529A0-0x0000000182D52A80
	[BlackList] // 0x0000000189862E90-0x0000000189862ED0
	// [XID] // 0x0000000189862E90-0x0000000189862ED0
	public override void ReturnToObjectPool() {} // 0x0000000182D54F40-0x0000000182D54FE0
}

