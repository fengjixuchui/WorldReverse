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
public class FireEffectForStorm : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16345
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x68
	private SimpleSafeFloat heightRawNum; // 0x70

	// Properties
	public ConfigBornType born { /* [XID] */ /* 0x000000018980B600-0x000000018980B620 */ get => default; /* [XID] */ /* 0x0000000189812CE0-0x0000000189812D00 */ private set {} } // 0x00000001827A5830-0x00000001827A58D0 0x00000001827A77D0-0x00000001827A7880
	public float height { /* [XID] */ /* 0x000000018981A900-0x000000018981A920 */ get => default; /* [XID] */ /* 0x00000001898220D0-0x00000001898220F0 */ private set {} } // 0x00000001827A75C0-0x00000001827A76A0 0x00000001827A6F60-0x00000001827A7040
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001898AAD40-0x00000001898AAD60 */ get => default; } // 0x00000001827A7040-0x00000001827A70E0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898B26B0-0x00000001898B26D0 */ get => default; } // 0x00000001827A6550-0x00000001827A65F0 

	// Constructors
	public FireEffectForStorm() {} // 0x00000001827A79C0-0x00000001827A7AC0

	// Methods
	// [XID] // 0x0000000189829650-0x0000000189829670
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827A76A0-0x00000001827A77D0
	// [XID] // 0x0000000189830C60-0x0000000189830C80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001827A7140-0x00000001827A7220
	// [XID] // 0x0000000189838340-0x0000000189838360
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3884 */) => default; // 0x00000001827A6BD0-0x00000001827A6CB0
	// [XID] // 0x000000018983F9D0-0x000000018983F9F0
	public override int GetHashNum() => default; // 0x00000001827A56F0-0x00000001827A57C0
	// [XID] // 0x0000000189846FD0-0x0000000189846FF0
	public override void InitEmpty() {} // 0x00000001827A65F0-0x00000001827A6700
	[BlackList] // 0x000000018984E5E0-0x000000018984E620
	// [XID] // 0x000000018984E5E0-0x000000018984E620
	public override bool FromJson(JSONNode node) => default; // 0x00000001827A5ED0-0x00000001827A6250
	// [XID] // 0x00000001898589E0-0x0000000189858A00
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827A4D70-0x00000001827A5090
	[BlackList] // 0x000000018985FAF0-0x000000018985FB30
	// [XID] // 0x000000018985FAF0-0x000000018985FB30
	public static new FireEffectForStorm ParseFromJson(JSONNode node) => default; // 0x00000001827A6D10-0x00000001827A6F60
	// [XID] // 0x000000018986A2E0-0x000000018986A300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3885 */, bool useObjectPool = false /* Metadata: 0x00AF3889 */) => default; // 0x00000001827A68D0-0x00000001827A6BD0
	// [XID] // 0x0000000189871710-0x0000000189871730
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF388A */, bool useObjectPool = false /* Metadata: 0x00AF388E */) => default; // 0x00000001827A59B0-0x00000001827A5C70
	// [XID] // 0x0000000189878F30-0x0000000189878F50
	public static new FireEffectForStorm ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF388F */, bool useObjectPool = false /* Metadata: 0x00AF3893 */) => default; // 0x00000001827A6250-0x00000001827A6470
	[BlackList] // 0x00000001898805A0-0x00000001898805E0
	// [XID] // 0x00000001898805A0-0x00000001898805E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827A5090-0x00000001827A5360
	// [XID] // 0x000000018988A8F0-0x000000018988A910
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827A7300-0x00000001827A75C0
	[BlackList] // 0x0000000189891D40-0x0000000189891D80
	// [XID] // 0x0000000189891D40-0x0000000189891D80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827A67E0-0x00000001827A68D0
	// [XID] // 0x000000018989C3C0-0x000000018989C3E0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001827A7880-0x00000001827A7920
	// [XID] // 0x00000001898A3A20-0x00000001898A3A40
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001827A5C70-0x00000001827A5DD0
	[BlackList] // 0x00000001898BA4A0-0x00000001898BA4E0
	// [XID] // 0x00000001898BA4A0-0x00000001898BA4E0
	public override void AutoAllocTypeFields() {} // 0x00000001827A5360-0x00000001827A5400
	[BlackList] // 0x00000001898C4980-0x00000001898C49C0
	// [XID] // 0x00000001898C4980-0x00000001898C49C0
	public override void AutoRecycleTypeFields() {} // 0x00000001827A5400-0x00000001827A5560
	[BlackList] // 0x00000001898CF050-0x00000001898CF090
	// [XID] // 0x00000001898CF050-0x00000001898CF090
	public override void ReturnToObjectPool() {} // 0x00000001827A7920-0x00000001827A79C0
}

