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
public class EnablePushColliderName : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16563
{
	// Fields
	private string[] _pushColliderNames; // 0x68
	private bool _setEnable; // 0x70

	// Properties
	public string[] pushColliderNames { /* [XID] */ /* 0x00000001897287D0-0x00000001897287F0 */ get => default; /* [XID] */ /* 0x000000018972FF80-0x000000018972FFA0 */ private set {} } // 0x00000001837F42A0-0x00000001837F4340 0x00000001837F4CB0-0x00000001837F4D60
	public bool setEnable { /* [XID] */ /* 0x0000000189737820-0x0000000189737840 */ get => default; /* [XID] */ /* 0x000000018973F360-0x000000018973F380 */ private set {} } // 0x00000001837F49C0-0x00000001837F4A60 0x00000001837F57A0-0x00000001837F5850
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897CAED0-0x00000001897CAEF0 */ get => default; } // 0x00000001837F54E0-0x00000001837F5580 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897D25B0-0x00000001897D25D0 */ get => default; } // 0x00000001837F4A60-0x00000001837F4B00 

	// Constructors
	public EnablePushColliderName() {} // 0x00000001837F5D60-0x00000001837F5DC0

	// Methods
	// [XID] // 0x00000001897466A0-0x00000001897466C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837F5B10-0x00000001837F5C20
	// [XID] // 0x000000018974E130-0x000000018974E150
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837F55E0-0x00000001837F56C0
	// [XID] // 0x0000000189755810-0x0000000189755830
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3F4E */) => default; // 0x00000001837F5150-0x00000001837F5230
	// [XID] // 0x000000018975CB10-0x000000018975CB30
	public override int GetHashNum() => default; // 0x00000001837F3B40-0x00000001837F3C10
	// [XID] // 0x00000001897642E0-0x0000000189764300
	public override void InitEmpty() {} // 0x00000001837F4B00-0x00000001837F4BD0
	[BlackList] // 0x000000018976BBC0-0x000000018976BC00
	// [XID] // 0x000000018976BBC0-0x000000018976BC00
	public override bool FromJson(JSONNode node) => default; // 0x00000001837F4340-0x00000001837F46C0
	// [XID] // 0x00000001897762C0-0x00000001897762E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001837F32A0-0x00000001837F3590
	[BlackList] // 0x000000018977D9C0-0x000000018977DA00
	// [XID] // 0x000000018977D9C0-0x000000018977DA00
	public static new EnablePushColliderName ParseFromJson(JSONNode node) => default; // 0x00000001837F5290-0x00000001837F54E0
	// [XID] // 0x0000000189788040-0x0000000189788060
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F4F */, bool useObjectPool = false /* Metadata: 0x00AF3F53 */) => default; // 0x00000001837F4E50-0x00000001837F5150
	// [XID] // 0x000000018978F600-0x000000018978F620
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F54 */, bool useObjectPool = false /* Metadata: 0x00AF3F58 */) => default; // 0x00000001837F3D60-0x00000001837F4040
	// [XID] // 0x0000000189796E10-0x0000000189796E30
	public static new EnablePushColliderName ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3F59 */, bool useObjectPool = false /* Metadata: 0x00AF3F5D */) => default; // 0x00000001837F46C0-0x00000001837F48E0
	[BlackList] // 0x000000018979EEB0-0x000000018979EEF0
	// [XID] // 0x000000018979EEB0-0x000000018979EEF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001837F3590-0x00000001837F3860
	// [XID] // 0x00000001897A93C0-0x00000001897A93E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837F5850-0x00000001837F5B10
	[BlackList] // 0x00000001897B0B20-0x00000001897B0B60
	// [XID] // 0x00000001897B0B20-0x00000001897B0B60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837F4D60-0x00000001837F4E50
	// [XID] // 0x00000001897BBEF0-0x00000001897BBF10
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001837F5C20-0x00000001837F5CC0
	// [XID] // 0x00000001897C36B0-0x00000001897C36D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001837F4040-0x00000001837F41A0
	[BlackList] // 0x00000001897DA270-0x00000001897DA2B0
	// [XID] // 0x00000001897DA270-0x00000001897DA2B0
	public override void AutoAllocTypeFields() {} // 0x00000001837F3860-0x00000001837F3900
	[BlackList] // 0x00000001897E4610-0x00000001897E4650
	// [XID] // 0x00000001897E4610-0x00000001897E4650
	public override void AutoRecycleTypeFields() {} // 0x00000001837F3900-0x00000001837F39B0
	[BlackList] // 0x00000001897EF130-0x00000001897EF170
	// [XID] // 0x00000001897EF130-0x00000001897EF170
	public override void ReturnToObjectPool() {} // 0x00000001837F5CC0-0x00000001837F5D60
}

