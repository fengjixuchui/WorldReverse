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
public class ActCameraShake : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16472
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCameraShake _cameraShake; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70

	// Properties
	public ConfigCameraShake cameraShake { /* [XID] */ /* 0x0000000189A10210-0x0000000189A10230 */ get => default; /* [XID] */ /* 0x0000000189A17830-0x0000000189A17850 */ private set {} } // 0x0000000184D00B10-0x0000000184D00BB0 0x0000000184CFEFB0-0x0000000184CFF060
	public ConfigBornType born { /* [XID] */ /* 0x0000000189A1EED0-0x0000000189A1EEF0 */ get => default; /* [XID] */ /* 0x0000000189A26540-0x0000000189A26560 */ private set {} } // 0x0000000184CFF1A0-0x0000000184CFF240 0x0000000184D01080-0x0000000184D01130
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189AB1E20-0x0000000189AB1E40 */ get => default; } // 0x0000000184D00910-0x0000000184D009B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189AB90B0-0x0000000189AB90D0 */ get => default; } // 0x0000000184CFFF20-0x0000000184CFFFC0 

	// Constructors
	public ActCameraShake() {} // 0x0000000184D01270-0x0000000184D012D0

	// Methods
	// [XID] // 0x0000000189A2D850-0x0000000189A2D870
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D00F70-0x0000000184D01080
	// [XID] // 0x0000000189A35450-0x0000000189A35470
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D00A10-0x0000000184D00B10
	// [XID] // 0x0000000189A3C920-0x0000000189A3C940
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3C80 */) => default; // 0x0000000184D00580-0x0000000184D00660
	// [XID] // 0x0000000189A44390-0x0000000189A443B0
	public override int GetHashNum() => default; // 0x0000000184CFF060-0x0000000184CFF130
	// [XID] // 0x0000000189A4B980-0x0000000189A4B9A0
	public override void InitEmpty() {} // 0x0000000184CFFFC0-0x0000000184D000B0
	[BlackList] // 0x0000000189A53000-0x0000000189A53040
	// [XID] // 0x0000000189A53000-0x0000000189A53040
	public override bool FromJson(JSONNode node) => default; // 0x0000000184CFF8A0-0x0000000184CFFC20
	// [XID] // 0x0000000189A5DC40-0x0000000189A5DC60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184CFE5E0-0x0000000184CFE900
	[BlackList] // 0x0000000189A653A0-0x0000000189A653E0
	// [XID] // 0x0000000189A653A0-0x0000000189A653E0
	public static new ActCameraShake ParseFromJson(JSONNode node) => default; // 0x0000000184D006C0-0x0000000184D00910
	// [XID] // 0x0000000189A6FBA0-0x0000000189A6FBC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C81 */, bool useObjectPool = false /* Metadata: 0x00AF3C85 */) => default; // 0x0000000184D00280-0x0000000184D00580
	// [XID] // 0x0000000189A77350-0x0000000189A77370
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C86 */, bool useObjectPool = false /* Metadata: 0x00AF3C8A */) => default; // 0x0000000184CFF320-0x0000000184CFF640
	// [XID] // 0x0000000189A7EC80-0x0000000189A7ECA0
	public static new ActCameraShake ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3C8B */, bool useObjectPool = false /* Metadata: 0x00AF3C8F */) => default; // 0x0000000184CFFC20-0x0000000184CFFE40
	[BlackList] // 0x0000000189A86490-0x0000000189A864D0
	// [XID] // 0x0000000189A86490-0x0000000189A864D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184CFE900-0x0000000184CFEBD0
	// [XID] // 0x0000000189A90ED0-0x0000000189A90EF0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D00C90-0x0000000184D00F70
	[BlackList] // 0x0000000189A98720-0x0000000189A98760
	// [XID] // 0x0000000189A98720-0x0000000189A98760
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D00190-0x0000000184D00280
	// [XID] // 0x0000000189AA2960-0x0000000189AA2980
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184D01130-0x0000000184D011D0
	// [XID] // 0x0000000189AAA000-0x0000000189AAA020
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184CFF640-0x0000000184CFF7A0
	[BlackList] // 0x0000000189AC0C30-0x0000000189AC0C70
	// [XID] // 0x0000000189AC0C30-0x0000000189AC0C70
	public override void AutoAllocTypeFields() {} // 0x0000000184CFEBD0-0x0000000184CFEC70
	[BlackList] // 0x0000000189ACB690-0x0000000189ACB6D0
	// [XID] // 0x0000000189ACB690-0x0000000189ACB6D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184CFEC70-0x0000000184CFEE20
	[BlackList] // 0x0000000189AD6580-0x0000000189AD65C0
	// [XID] // 0x0000000189AD6580-0x0000000189AD65C0
	public override void ReturnToObjectPool() {} // 0x0000000184D011D0-0x0000000184D01270
}

