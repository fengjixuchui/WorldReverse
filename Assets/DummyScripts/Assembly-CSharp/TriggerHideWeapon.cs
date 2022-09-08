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
public class TriggerHideWeapon : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16531
{
	// Fields
	private bool _visible; // 0x68
	private string[] _partNames; // 0x70

	// Properties
	public bool visible { /* [XID] */ /* 0x00000001896551C0-0x00000001896551E0 */ get => default; /* [XID] */ /* 0x000000018965CA60-0x000000018965CA80 */ private set {} } // 0x000000018467BD50-0x000000018467BDF0 0x000000018467AA80-0x000000018467AB30
	public string[] partNames { /* [XID] */ /* 0x0000000189663EE0-0x0000000189663F00 */ get => default; /* [XID] */ /* 0x000000018966B600-0x000000018966B620 */ private set {} } // 0x000000018467B800-0x000000018467B8A0 0x000000018467B320-0x000000018467B3D0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896F5EA0-0x00000001896F5EC0 */ get => default; } // 0x000000018467B620-0x000000018467B6C0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896FD650-0x00000001896FD670 */ get => default; } // 0x000000018467ABA0-0x000000018467AC40 

	// Constructors
	public TriggerHideWeapon() {} // 0x000000018467BF30-0x000000018467BF90

	// Methods
	// [XID] // 0x0000000189673320-0x0000000189673340
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018467BC40-0x000000018467BD50
	// [XID] // 0x000000018967AB60-0x000000018967AB80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018467B720-0x000000018467B800
	// [XID] // 0x00000001896824B0-0x00000001896824D0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E56 */) => default; // 0x000000018467B1E0-0x000000018467B2C0
	// [XID] // 0x0000000189689E70-0x0000000189689E90
	public override int GetHashNum() => default; // 0x0000000184679D10-0x0000000184679DE0
	// [XID] // 0x0000000189691C50-0x0000000189691C70
	public override void InitEmpty() {} // 0x000000018467AC40-0x000000018467AD10
	[BlackList] // 0x0000000189699160-0x00000001896991A0
	// [XID] // 0x0000000189699160-0x00000001896991A0
	public override bool FromJson(JSONNode node) => default; // 0x000000018467A470-0x000000018467A7F0
	// [XID] // 0x00000001896A3600-0x00000001896A3620
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184679470-0x0000000184679760
	[BlackList] // 0x00000001896AAAB0-0x00000001896AAAF0
	// [XID] // 0x00000001896AAAB0-0x00000001896AAAF0
	public static new TriggerHideWeapon ParseFromJson(JSONNode node) => default; // 0x000000018467B3D0-0x000000018467B620
	// [XID] // 0x00000001896B5150-0x00000001896B5170
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E57 */, bool useObjectPool = false /* Metadata: 0x00AF3E5B */) => default; // 0x000000018467AEE0-0x000000018467B1E0
	// [XID] // 0x00000001896BC340-0x00000001896BC360
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E5C */, bool useObjectPool = false /* Metadata: 0x00AF3E60 */) => default; // 0x0000000184679F30-0x000000018467A210
	// [XID] // 0x00000001896C3820-0x00000001896C3840
	public static new TriggerHideWeapon ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E61 */, bool useObjectPool = false /* Metadata: 0x00AF3E65 */) => default; // 0x000000018467A7F0-0x000000018467AA10
	[BlackList] // 0x00000001896CACF0-0x00000001896CAD30
	// [XID] // 0x00000001896CACF0-0x00000001896CAD30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184679760-0x0000000184679A30
	// [XID] // 0x00000001896D5480-0x00000001896D54A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018467B980-0x000000018467BC40
	[BlackList] // 0x00000001896DC9C0-0x00000001896DCA00
	// [XID] // 0x00000001896DC9C0-0x00000001896DCA00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018467ADF0-0x000000018467AEE0
	// [XID] // 0x00000001896E6FE0-0x00000001896E7000
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018467BDF0-0x000000018467BE90
	// [XID] // 0x00000001896EE550-0x00000001896EE570
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018467A210-0x000000018467A370
	[BlackList] // 0x0000000189704A90-0x0000000189704AD0
	// [XID] // 0x0000000189704A90-0x0000000189704AD0
	public override void AutoAllocTypeFields() {} // 0x0000000184679A30-0x0000000184679AD0
	[BlackList] // 0x000000018970F480-0x000000018970F4C0
	// [XID] // 0x000000018970F480-0x000000018970F4C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184679AD0-0x0000000184679B80
	[BlackList] // 0x0000000189719C30-0x0000000189719C70
	// [XID] // 0x0000000189719C30-0x0000000189719C70
	public override void ReturnToObjectPool() {} // 0x000000018467BE90-0x000000018467BF30
}

