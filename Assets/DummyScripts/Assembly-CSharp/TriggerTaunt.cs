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
public class TriggerTaunt : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16533
{
	// Fields
	private TauntLevel _tauntLevel; // 0x68
	private SimpleSafeFloat careValueRawNum; // 0x6C

	// Properties
	public TauntLevel tauntLevel { /* [XID] */ /* 0x000000018972B650-0x000000018972B670 */ get => default; /* [XID] */ /* 0x0000000189732DE0-0x0000000189732E00 */ private set {} } // 0x0000000180E5F250-0x0000000180E5F2F0 0x0000000180E607C0-0x0000000180E60870
	public float careValue { /* [XID] */ /* 0x000000018973A510-0x000000018973A530 */ get => default; /* [XID] */ /* 0x0000000189741E40-0x0000000189741E60 */ private set {} } // 0x0000000180E60C70-0x0000000180E60D50 0x0000000180E601B0-0x0000000180E60290
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897CDFE0-0x00000001897CE000 */ get => default; } // 0x0000000180E60AC0-0x0000000180E60B60 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897D5550-0x00000001897D5570 */ get => default; } // 0x0000000180E5FF50-0x0000000180E5FFF0 

	// Constructors
	public TriggerTaunt() {} // 0x0000000180E61310-0x0000000180E613B0

	// Methods
	// [XID] // 0x0000000189749820-0x0000000189749840
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180E610C0-0x0000000180E611D0
	// [XID] // 0x0000000189750D80-0x0000000189750DA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000180E60BC0-0x0000000180E60C70
	// [XID] // 0x0000000189758230-0x0000000189758250
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E66 */) => default; // 0x0000000180E60680-0x0000000180E60760
	// [XID] // 0x000000018975FCD0-0x000000018975FCF0
	public override int GetHashNum() => default; // 0x0000000180E5F110-0x0000000180E5F1E0
	// [XID] // 0x0000000189767340-0x0000000189767360
	public override void InitEmpty() {} // 0x0000000180E5FFF0-0x0000000180E600D0
	[BlackList] // 0x000000018976E860-0x000000018976E8A0
	// [XID] // 0x000000018976E860-0x000000018976E8A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000180E5F8D0-0x0000000180E5FC50
	// [XID] // 0x00000001897791C0-0x00000001897791E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000180E5E7F0-0x0000000180E5EB30
	[BlackList] // 0x00000001897809C0-0x0000000189780A00
	// [XID] // 0x00000001897809C0-0x0000000189780A00
	public static new TriggerTaunt ParseFromJson(JSONNode node) => default; // 0x0000000180E60870-0x0000000180E60AC0
	// [XID] // 0x000000018978B260-0x000000018978B280
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E67 */, bool useObjectPool = false /* Metadata: 0x00AF3E6B */) => default; // 0x0000000180E60380-0x0000000180E60680
	// [XID] // 0x0000000189792740-0x0000000189792760
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E6C */, bool useObjectPool = false /* Metadata: 0x00AF3E70 */) => default; // 0x0000000180E5F3D0-0x0000000180E5F670
	// [XID] // 0x0000000189799C50-0x0000000189799C70
	public static new TriggerTaunt ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E71 */, bool useObjectPool = false /* Metadata: 0x00AF3E75 */) => default; // 0x0000000180E5FC50-0x0000000180E5FE70
	[BlackList] // 0x00000001897A1AE0-0x00000001897A1B20
	// [XID] // 0x00000001897A1AE0-0x00000001897A1B20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000180E5EB30-0x0000000180E5EE00
	// [XID] // 0x00000001897AC2A0-0x00000001897AC2C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180E60E30-0x0000000180E610C0
	[BlackList] // 0x00000001897B4250-0x00000001897B4290
	// [XID] // 0x00000001897B4250-0x00000001897B4290
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000180E60290-0x0000000180E60380
	// [XID] // 0x00000001897BF290-0x00000001897BF2B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000180E611D0-0x0000000180E61270
	// [XID] // 0x00000001897C6880-0x00000001897C68A0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000180E5F670-0x0000000180E5F7D0
	[BlackList] // 0x00000001897DCCF0-0x00000001897DCD30
	// [XID] // 0x00000001897DCCF0-0x00000001897DCD30
	public override void AutoAllocTypeFields() {} // 0x0000000180E5EE00-0x0000000180E5EEA0
	[BlackList] // 0x00000001897E7510-0x00000001897E7550
	// [XID] // 0x00000001897E7510-0x00000001897E7550
	public override void AutoRecycleTypeFields() {} // 0x0000000180E5EEA0-0x0000000180E5EF80
	[BlackList] // 0x00000001897F2490-0x00000001897F24D0
	// [XID] // 0x00000001897F2490-0x00000001897F24D0
	public override void ReturnToObjectPool() {} // 0x0000000180E61270-0x0000000180E61310
}

