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
public class SetEmissionScaler : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16659
{
	// Fields
	private BodyMaterialType _materialType; // 0x68
	private bool _useDefaultColor; // 0x6C
	private SimpleSafeFloat valueRawNum; // 0x70
	private SimpleSafeFloat durationRawNum; // 0x74

	// Properties
	public BodyMaterialType materialType { /* [XID] */ /* 0x0000000189BCC240-0x0000000189BCC260 */ get => default; /* [XID] */ /* 0x0000000189BD38B0-0x0000000189BD38D0 */ private set {} } // 0x0000000181F066A0-0x0000000181F06740 0x0000000181F06F20-0x0000000181F06FD0
	public bool useDefaultColor { /* [XID] */ /* 0x0000000189BDB280-0x0000000189BDB2A0 */ get => default; /* [XID] */ /* 0x00000001895E7B70-0x00000001895E7B90 */ private set {} } // 0x0000000181F067E0-0x0000000181F06880 0x0000000181F048A0-0x0000000181F04950
	public float value { /* [XID] */ /* 0x00000001895EF4E0-0x00000001895EF500 */ get => default; /* [XID] */ /* 0x00000001895F6F00-0x00000001895F6F20 */ private set {} } // 0x0000000181F05F40-0x0000000181F06020 0x0000000181F05DE0-0x0000000181F05EC0
	public float duration { /* [XID] */ /* 0x00000001895FE2C0-0x00000001895FE2E0 */ get => default; /* [XID] */ /* 0x0000000189605B10-0x0000000189605B30 */ private set {} } // 0x0000000181F053D0-0x0000000181F054B0 0x0000000181F05B20-0x0000000181F05C00
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189691BF0-0x0000000189691C10 */ get => default; } // 0x0000000181F07280-0x0000000181F07320 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189699140-0x0000000189699160 */ get => default; } // 0x0000000181F06740-0x0000000181F067E0 

	// Constructors
	public SetEmissionScaler() {} // 0x0000000181F07B40-0x0000000181F07BE0

	// Methods
	// [XID] // 0x000000018960D4A0-0x000000018960D4C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F078B0-0x0000000181F07A00
	// [XID] // 0x0000000189614B20-0x0000000189614B40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181F07380-0x0000000181F07430
	// [XID] // 0x000000018961C460-0x000000018961C480
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF424A */) => default; // 0x0000000181F06E40-0x0000000181F06F20
	// [XID] // 0x0000000189623800-0x0000000189623820
	public override int GetHashNum() => default; // 0x0000000181F05530-0x0000000181F05600
	// [XID] // 0x000000018962B120-0x000000018962B140
	public override void InitEmpty() {} // 0x0000000181F06880-0x0000000181F06960
	[BlackList] // 0x00000001896328E0-0x0000000189632920
	// [XID] // 0x00000001896328E0-0x0000000189632920
	public override bool FromJson(JSONNode node) => default; // 0x0000000181F06020-0x0000000181F063A0
	// [XID] // 0x000000018963D4B0-0x000000018963D4D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181F04950-0x0000000181F04E60
	[BlackList] // 0x0000000189644A50-0x0000000189644A90
	// [XID] // 0x0000000189644A50-0x0000000189644A90
	public static new SetEmissionScaler ParseFromJson(JSONNode node) => default; // 0x0000000181F07030-0x0000000181F07280
	// [XID] // 0x000000018964F020-0x000000018964F040
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF424B */, bool useObjectPool = false /* Metadata: 0x00AF424F */) => default; // 0x0000000181F06B40-0x0000000181F06E40
	// [XID] // 0x00000001896568B0-0x00000001896568D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4250 */, bool useObjectPool = false /* Metadata: 0x00AF4254 */) => default; // 0x0000000181F05750-0x0000000181F05B20
	// [XID] // 0x000000018965DFB0-0x000000018965DFD0
	public static new SetEmissionScaler ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4255 */, bool useObjectPool = false /* Metadata: 0x00AF4259 */) => default; // 0x0000000181F063A0-0x0000000181F065C0
	[BlackList] // 0x0000000189665710-0x0000000189665750
	// [XID] // 0x0000000189665710-0x0000000189665750
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F04E60-0x0000000181F05130
	// [XID] // 0x0000000189670590-0x00000001896705B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F07510-0x0000000181F078B0
	[BlackList] // 0x0000000189677D90-0x0000000189677DD0
	// [XID] // 0x0000000189677D90-0x0000000189677DD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181F06A40-0x0000000181F06B40
	// [XID] // 0x0000000189682490-0x00000001896824B0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000181F07A00-0x0000000181F07AA0
	// [XID] // 0x0000000189689E30-0x0000000189689E50
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000181F05C00-0x0000000181F05D60
	[BlackList] // 0x00000001896A0670-0x00000001896A06B0
	// [XID] // 0x00000001896A0670-0x00000001896A06B0
	public override void AutoAllocTypeFields() {} // 0x0000000181F05130-0x0000000181F051D0
	[BlackList] // 0x00000001896AAA30-0x00000001896AAA70
	// [XID] // 0x00000001896AAA30-0x00000001896AAA70
	public override void AutoRecycleTypeFields() {} // 0x0000000181F051D0-0x0000000181F052C0
	[BlackList] // 0x00000001896B5110-0x00000001896B5150
	// [XID] // 0x00000001896B5110-0x00000001896B5150
	public override void ReturnToObjectPool() {} // 0x0000000181F07AA0-0x0000000181F07B40
}

