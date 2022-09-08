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
public class TryTriggerPlatformStartMove : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16503
{
	// Fields
	private SimpleSafeFloat detectHeightRawNum; // 0x68
	private SimpleSafeFloat detectWidthRawNum; // 0x6C
	private bool _enableRotationOffset; // 0x70
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _failActions; // 0x78
	private bool _forceReset; // 0x80
	private bool _forceTrigger; // 0x81

	// Properties
	public float detectHeight { /* [XID] */ /* 0x00000001896F2B70-0x00000001896F2B90 */ get => default; /* [XID] */ /* 0x00000001896FA4B0-0x00000001896FA4D0 */ private set {} } // 0x00000001840CFD90-0x00000001840CFE70 0x00000001840D0C80-0x00000001840D0D60
	public float detectWidth { /* [XID] */ /* 0x0000000189701BA0-0x0000000189701BC0 */ get => default; /* [XID] */ /* 0x00000001897094E0-0x0000000189709500 */ private set {} } // 0x00000001840D17D0-0x00000001840D18B0 0x00000001840CF6E0-0x00000001840CF7C0
	public bool enableRotationOffset { /* [XID] */ /* 0x0000000189710D10-0x0000000189710D30 */ get => default; /* [XID] */ /* 0x0000000189718050-0x0000000189718070 */ private set {} } // 0x00000001840D0F40-0x00000001840D0FE0 0x00000001840D01B0-0x00000001840D0260
	public ConfigAbilityAction[] failActions { /* [XID] */ /* 0x000000018971FA50-0x000000018971FA70 */ get => default; /* [XID] */ /* 0x00000001897270E0-0x0000000189727100 */ private set {} } // 0x00000001840CF8C0-0x00000001840CF960 0x00000001840D18B0-0x00000001840D1960
	public bool forceReset { /* [XID] */ /* 0x000000018972E6B0-0x000000018972E6D0 */ get => default; /* [XID] */ /* 0x0000000189735E00-0x0000000189735E20 */ private set {} } // 0x00000001840CF960-0x00000001840CFA10 0x00000001840CFE70-0x00000001840CFF20
	public bool forceTrigger { /* [XID] */ /* 0x000000018973D990-0x000000018973D9B0 */ get => default; /* [XID] */ /* 0x0000000189744E10-0x0000000189744E30 */ private set {} } // 0x00000001840D15A0-0x00000001840D1650 0x00000001840CEFB0-0x00000001840CF060
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897C97A0-0x00000001897C97C0 */ get => default; } // 0x00000001840D0D60-0x00000001840D0E00 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897D0DB0-0x00000001897D0DD0 */ get => default; } // 0x00000001840D0260-0x00000001840D0300 

	// Constructors
	public TryTriggerPlatformStartMove() {} // 0x00000001840D1A00-0x00000001840D1A70

	// Methods
	// [XID] // 0x000000018974CA00-0x000000018974CA20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840D1650-0x00000001840D17D0
	// [XID] // 0x0000000189753CC0-0x0000000189753CE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001840D0E60-0x00000001840D0F40
	// [XID] // 0x000000018975B1E0-0x000000018975B200
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D7A */) => default; // 0x00000001840D08F0-0x00000001840D09D0
	// [XID] // 0x0000000189762C10-0x0000000189762C30
	public override int GetHashNum() => default; // 0x00000001840CED90-0x00000001840CEE60
	// [XID] // 0x000000018976A250-0x000000018976A270
	public override void InitEmpty() {} // 0x00000001840D0300-0x00000001840D0420
	[BlackList] // 0x0000000189771A90-0x0000000189771AD0
	// [XID] // 0x0000000189771A90-0x0000000189771AD0
	public override bool FromJson(JSONNode node) => default; // 0x00000001840CFA10-0x00000001840CFD90
	// [XID] // 0x000000018977C0C0-0x000000018977C0E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001840CE0E0-0x00000001840CE780
	[BlackList] // 0x00000001897839F0-0x0000000189783A30
	// [XID] // 0x00000001897839F0-0x0000000189783A30
	public static new TryTriggerPlatformStartMove ParseFromJson(JSONNode node) => default; // 0x00000001840D0A30-0x00000001840D0C80
	// [XID] // 0x000000018978DEB0-0x000000018978DED0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D7B */, bool useObjectPool = false /* Metadata: 0x00AF3D7F */) => default; // 0x00000001840D05F0-0x00000001840D08F0
	// [XID] // 0x0000000189795600-0x0000000189795620
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D80 */, bool useObjectPool = false /* Metadata: 0x00AF3D84 */) => default; // 0x00000001840CF060-0x00000001840CF580
	// [XID] // 0x000000018979DA70-0x000000018979DA90
	public static new TryTriggerPlatformStartMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D85 */, bool useObjectPool = false /* Metadata: 0x00AF3D89 */) => default; // 0x00000001840CFF20-0x00000001840D0140
	[BlackList] // 0x00000001897A4D30-0x00000001897A4D70
	// [XID] // 0x00000001897A4D30-0x00000001897A4D70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001840CE780-0x00000001840CEA50
	// [XID] // 0x00000001897AF4F0-0x00000001897AF510
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840D10C0-0x00000001840D15A0
	[BlackList] // 0x00000001897B73B0-0x00000001897B73F0
	// [XID] // 0x00000001897B73B0-0x00000001897B73F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001840D0500-0x00000001840D05F0
	// [XID] // 0x00000001897C1E90-0x00000001897C1EB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001840CF580-0x00000001840CF6E0
	[BlackList] // 0x00000001897D8C70-0x00000001897D8CB0
	// [XID] // 0x00000001897D8C70-0x00000001897D8CB0
	public override void AutoAllocTypeFields() {} // 0x00000001840CEA50-0x00000001840CEAF0
	[BlackList] // 0x00000001897E2EE0-0x00000001897E2F20
	// [XID] // 0x00000001897E2EE0-0x00000001897E2F20
	public override void AutoRecycleTypeFields() {} // 0x00000001840CEAF0-0x00000001840CEC00
	[BlackList] // 0x00000001897ED9F0-0x00000001897EDA30
	// [XID] // 0x00000001897ED9F0-0x00000001897EDA30
	public override void ReturnToObjectPool() {} // 0x00000001840D1960-0x00000001840D1A00
}

