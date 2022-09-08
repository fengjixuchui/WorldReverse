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
public class FireSubEmitterEffect : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16343
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicString _effectPattern; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private SimpleSafeFloat scaleRawNum; // 0x78

	// Properties
	public DynamicString effectPattern { /* [XID] */ /* 0x0000000189723E70-0x0000000189723E90 */ get => default; /* [XID] */ /* 0x000000018972B6D0-0x000000018972B6F0 */ private set {} } // 0x000000018205A130-0x000000018205A1D0 0x000000018205B2E0-0x000000018205B390
	public ConfigBornType born { /* [XID] */ /* 0x0000000189732E80-0x0000000189732EA0 */ get => default; /* [XID] */ /* 0x000000018973A530-0x000000018973A550 */ private set {} } // 0x0000000182059080-0x0000000182059120 0x000000018205B150-0x000000018205B200
	public float scale { /* [XID] */ /* 0x0000000189741E80-0x0000000189741EA0 */ get => default; /* [XID] */ /* 0x0000000189749880-0x00000001897498A0 */ private set {} } // 0x0000000182059D90-0x0000000182059E70 0x000000018205B200-0x000000018205B2E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897CE040-0x00000001897CE060 */ get => default; } // 0x000000018205A9B0-0x000000018205AA50 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001897D55D0-0x00000001897D55F0 */ get => default; } // 0x0000000182059EE0-0x0000000182059F80 

	// Constructors
	public FireSubEmitterEffect() {} // 0x000000018205B430-0x000000018205B4D0

	// Methods
	// [XID] // 0x0000000189750DE0-0x0000000189750E00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018205AFF0-0x000000018205B150
	// [XID] // 0x0000000189758290-0x00000001897582B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018205AAB0-0x000000018205ABB0
	// [XID] // 0x000000018975FD70-0x000000018975FD90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3874 */) => default; // 0x000000018205A620-0x000000018205A700
	// [XID] // 0x0000000189767400-0x0000000189767420
	public override int GetHashNum() => default; // 0x0000000182058F40-0x0000000182059010
	// [XID] // 0x000000018976E980-0x000000018976E9A0
	public override void InitEmpty() {} // 0x0000000182059F80-0x000000018205A0B0
	[BlackList] // 0x0000000189776300-0x0000000189776340
	// [XID] // 0x0000000189776300-0x0000000189776340
	public override bool FromJson(JSONNode node) => default; // 0x00000001820597F0-0x0000000182059B70
	// [XID] // 0x0000000189780A20-0x0000000189780A40
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182058440-0x0000000182058860
	[BlackList] // 0x0000000189788080-0x00000001897880C0
	// [XID] // 0x0000000189788080-0x00000001897880C0
	public static new FireSubEmitterEffect ParseFromJson(JSONNode node) => default; // 0x000000018205A760-0x000000018205A9B0
	// [XID] // 0x0000000189792780-0x00000001897927A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3875 */, bool useObjectPool = false /* Metadata: 0x00AF3879 */) => default; // 0x000000018205A320-0x000000018205A620
	// [XID] // 0x0000000189799CD0-0x0000000189799CF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF387A */, bool useObjectPool = false /* Metadata: 0x00AF387E */) => default; // 0x0000000182059200-0x0000000182059590
	// [XID] // 0x00000001897A1B60-0x00000001897A1B80
	public static new FireSubEmitterEffect ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF387F */, bool useObjectPool = false /* Metadata: 0x00AF3883 */) => default; // 0x0000000182059B70-0x0000000182059D90
	[BlackList] // 0x00000001897A93E0-0x00000001897A9420
	// [XID] // 0x00000001897A93E0-0x00000001897A9420
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182058860-0x0000000182058B30
	// [XID] // 0x00000001897B42F0-0x00000001897B4310
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018205AC90-0x000000018205AFF0
	[BlackList] // 0x00000001897BBF70-0x00000001897BBFB0
	// [XID] // 0x00000001897BBF70-0x00000001897BBFB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018205A230-0x000000018205A320
	// [XID] // 0x00000001897C68C0-0x00000001897C68E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182059590-0x00000001820596F0
	[BlackList] // 0x00000001897DCD50-0x00000001897DCD90
	// [XID] // 0x00000001897DCD50-0x00000001897DCD90
	public override void AutoAllocTypeFields() {} // 0x0000000182058B30-0x0000000182058BD0
	[BlackList] // 0x00000001897E7590-0x00000001897E75D0
	// [XID] // 0x00000001897E7590-0x00000001897E75D0
	public override void AutoRecycleTypeFields() {} // 0x0000000182058BD0-0x0000000182058DB0
	[BlackList] // 0x00000001897F2530-0x00000001897F2570
	// [XID] // 0x00000001897F2530-0x00000001897F2570
	public override void ReturnToObjectPool() {} // 0x000000018205B390-0x000000018205B430
}

