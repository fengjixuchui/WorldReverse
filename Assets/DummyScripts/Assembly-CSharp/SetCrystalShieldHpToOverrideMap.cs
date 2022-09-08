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
public class SetCrystalShieldHpToOverrideMap : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16408
{
	// Fields
	private string _overrideMapKey; // 0x68

	// Properties
	public string overrideMapKey { /* [XID] */ /* 0x00000001898C1FC0-0x00000001898C1FE0 */ get => default; /* [XID] */ /* 0x000000018987BFA0-0x000000018987BFC0 */ private set {} } // 0x00000001833AE7E0-0x00000001833AE880 0x00000001833AE880-0x00000001833AE930
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189906F50-0x0000000189906F70 */ get => default; } // 0x00000001833AE2B0-0x00000001833AE350 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018990E970-0x000000018990E990 */ get => default; } // 0x00000001833AD8E0-0x00000001833AD980 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189915FA0-0x0000000189915FC0 */ get => default; } // 0x00000001833ACBA0-0x00000001833ACC40 

	// Constructors
	public SetCrystalShieldHpToOverrideMap() {} // 0x00000001833AEB60-0x00000001833AEBC0

	// Methods
	// [XID] // 0x00000001898830D0-0x00000001898830F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833AE930-0x00000001833AEA20
	// [XID] // 0x000000018988A8B0-0x000000018988A8D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001833AE420-0x00000001833AE500
	// [XID] // 0x0000000189891CE0-0x0000000189891D00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A8A */) => default; // 0x00000001833ADF20-0x00000001833AE000
	// [XID] // 0x00000001898995B0-0x00000001898995D0
	public override int GetHashNum() => default; // 0x00000001833ACAD0-0x00000001833ACBA0
	// [XID] // 0x00000001898A0770-0x00000001898A0790
	public override void InitEmpty() {} // 0x00000001833AD980-0x00000001833ADA50
	[BlackList] // 0x00000001898A7EF0-0x00000001898A7F30
	// [XID] // 0x00000001898A7EF0-0x00000001898A7F30
	public override bool FromJson(JSONNode node) => default; // 0x00000001833AD260-0x00000001833AD5E0
	// [XID] // 0x00000001898B2670-0x00000001898B2690
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001833AC2F0-0x00000001833AC520
	[BlackList] // 0x00000001898BA440-0x00000001898BA480
	// [XID] // 0x00000001898BA440-0x00000001898BA480
	public static new SetCrystalShieldHpToOverrideMap ParseFromJson(JSONNode node) => default; // 0x00000001833AE060-0x00000001833AE2B0
	// [XID] // 0x00000001898C4920-0x00000001898C4940
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A8B */, bool useObjectPool = false /* Metadata: 0x00AF3A8F */) => default; // 0x00000001833ADC20-0x00000001833ADF20
	// [XID] // 0x00000001898CBE70-0x00000001898CBE90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A90 */, bool useObjectPool = false /* Metadata: 0x00AF3A94 */) => default; // 0x00000001833ACD90-0x00000001833AD000
	// [XID] // 0x00000001898D36B0-0x00000001898D36D0
	public static new SetCrystalShieldHpToOverrideMap ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A95 */, bool useObjectPool = false /* Metadata: 0x00AF3A99 */) => default; // 0x00000001833AD5E0-0x00000001833AD800
	[BlackList] // 0x00000001898DAEA0-0x00000001898DAEE0
	// [XID] // 0x00000001898DAEA0-0x00000001898DAEE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001833AC520-0x00000001833AC7F0
	// [XID] // 0x00000001898E5E20-0x00000001898E5E40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833AE5E0-0x00000001833AE7E0
	[BlackList] // 0x00000001898ED6E0-0x00000001898ED720
	// [XID] // 0x00000001898ED6E0-0x00000001898ED720
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001833ADB30-0x00000001833ADC20
	// [XID] // 0x00000001898F8150-0x00000001898F8170
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001833AEA20-0x00000001833AEAC0
	// [XID] // 0x00000001898FF730-0x00000001898FF750
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001833AD000-0x00000001833AD160
	[BlackList] // 0x000000018991DA50-0x000000018991DA90
	// [XID] // 0x000000018991DA50-0x000000018991DA90
	public override void AutoAllocTypeFields() {} // 0x00000001833AC7F0-0x00000001833AC890
	[BlackList] // 0x0000000189928210-0x0000000189928250
	// [XID] // 0x0000000189928210-0x0000000189928250
	public override void AutoRecycleTypeFields() {} // 0x00000001833AC890-0x00000001833AC940
	[BlackList] // 0x0000000189932820-0x0000000189932860
	// [XID] // 0x0000000189932820-0x0000000189932860
	public override void ReturnToObjectPool() {} // 0x00000001833AEAC0-0x00000001833AEB60
}

