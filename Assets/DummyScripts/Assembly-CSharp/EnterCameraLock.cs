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
public class EnterCameraLock : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16661
{
	// Fields
	private string _transName; // 0x68
	private string _cfgPath; // 0x70

	// Properties
	public string transName { /* [XID] */ /* 0x00000001896C68B0-0x00000001896C68D0 */ get => default; /* [XID] */ /* 0x00000001896CDED0-0x00000001896CDEF0 */ private set {} } // 0x0000000184A48680-0x0000000184A48720 0x0000000184A46BE0-0x0000000184A46C90
	public string cfgPath { /* [XID] */ /* 0x00000001896D5460-0x00000001896D5480 */ get => default; /* [XID] */ /* 0x00000001896DC9A0-0x00000001896DC9C0 */ private set {} } // 0x0000000184A48720-0x0000000184A487C0 0x0000000184A48040-0x0000000184A480F0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189767320-0x0000000189767340 */ get => default; } // 0x0000000184A483A0-0x0000000184A48440 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018976E820-0x000000018976E840 */ get => default; } // 0x0000000184A478F0-0x0000000184A47990 

	// Constructors
	public EnterCameraLock() {} // 0x0000000184A48CA0-0x0000000184A48D00

	// Methods
	// [XID] // 0x00000001896E4330-0x00000001896E4350
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A48A50-0x0000000184A48B60
	// [XID] // 0x00000001896EB720-0x00000001896EB740
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A484A0-0x0000000184A485A0
	// [XID] // 0x00000001896F2AF0-0x00000001896F2B10
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF425A */) => default; // 0x0000000184A47F60-0x0000000184A48040
	// [XID] // 0x00000001896FA410-0x00000001896FA430
	public override int GetHashNum() => default; // 0x0000000184A46A40-0x0000000184A46B10
	// [XID] // 0x0000000189701B20-0x0000000189701B40
	public override void InitEmpty() {} // 0x0000000184A47990-0x0000000184A47A80
	[BlackList] // 0x0000000189709420-0x0000000189709460
	// [XID] // 0x0000000189709420-0x0000000189709460
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A47270-0x0000000184A475F0
	// [XID] // 0x0000000189713BE0-0x0000000189713C00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A46180-0x0000000184A46490
	[BlackList] // 0x000000018971B440-0x000000018971B480
	// [XID] // 0x000000018971B440-0x000000018971B480
	public static new EnterCameraLock ParseFromJson(JSONNode node) => default; // 0x0000000184A48150-0x0000000184A483A0
	// [XID] // 0x0000000189725780-0x00000001897257A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF425B */, bool useObjectPool = false /* Metadata: 0x00AF425F */) => default; // 0x0000000184A47C60-0x0000000184A47F60
	// [XID] // 0x000000018972CCC0-0x000000018972CCE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4260 */, bool useObjectPool = false /* Metadata: 0x00AF4264 */) => default; // 0x0000000184A46D10-0x0000000184A47010
	// [XID] // 0x00000001897344B0-0x00000001897344D0
	public static new EnterCameraLock ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4265 */, bool useObjectPool = false /* Metadata: 0x00AF4269 */) => default; // 0x0000000184A475F0-0x0000000184A47810
	[BlackList] // 0x000000018973BE20-0x000000018973BE60
	// [XID] // 0x000000018973BE20-0x000000018973BE60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A46490-0x0000000184A46760
	// [XID] // 0x0000000189746620-0x0000000189746640
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A487C0-0x0000000184A48A50
	[BlackList] // 0x000000018974E0D0-0x000000018974E110
	// [XID] // 0x000000018974E0D0-0x000000018974E110
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A47B60-0x0000000184A47C60
	// [XID] // 0x0000000189758190-0x00000001897581B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184A48B60-0x0000000184A48C00
	// [XID] // 0x000000018975FCB0-0x000000018975FCD0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184A47010-0x0000000184A47170
	[BlackList] // 0x0000000189776240-0x0000000189776280
	// [XID] // 0x0000000189776240-0x0000000189776280
	public override void AutoAllocTypeFields() {} // 0x0000000184A46760-0x0000000184A46800
	[BlackList] // 0x0000000189780920-0x0000000189780960
	// [XID] // 0x0000000189780920-0x0000000189780960
	public override void AutoRecycleTypeFields() {} // 0x0000000184A46800-0x0000000184A468B0
	[BlackList] // 0x000000018978B1A0-0x000000018978B1E0
	// [XID] // 0x000000018978B1A0-0x000000018978B1E0
	public override void ReturnToObjectPool() {} // 0x0000000184A48C00-0x0000000184A48CA0
}

