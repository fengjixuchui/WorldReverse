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
public class Summon : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16589
{
	// Fields
	private SimpleSafeUInt32 monsterIDRawNum; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBornType _born; // 0x70
	private SimpleSafeUInt32 bornSlotIndexRawNum; // 0x78
	private AbilityTargetting _faceToTarget; // 0x7C
	private SimpleSafeUInt32 summonTagRawNum; // 0x80
	private bool _aliveByOwner; // 0x84
	private bool _isElite; // 0x85
	private SimpleSafeUInt32[] _affixList; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicInt _levelDelta; // 0x90
	private bool _hasDrop; // 0x98
	private bool _hasExp; // 0x99
	private bool _sightGroupWithOwner; // 0x9A

	// Properties
	public uint monsterID { /* [XID] */ /* 0x00000001896493A0-0x00000001896493C0 */ get => default; /* [XID] */ /* 0x0000000189650990-0x00000001896509B0 */ private set {} } // 0x00000001833D7DF0-0x00000001833D7EC0 0x00000001833D8D40-0x00000001833D8E20
	public ConfigBornType born { /* [XID] */ /* 0x0000000189658230-0x0000000189658250 */ get => default; /* [XID] */ /* 0x000000018965F7A0-0x000000018965F7C0 */ private set {} } // 0x00000001833D7150-0x00000001833D71F0 0x00000001833DAC30-0x00000001833DACE0
	public uint bornSlotIndex { /* [XID] */ /* 0x0000000189667230-0x0000000189667250 */ get => default; /* [XID] */ /* 0x000000018966E9E0-0x000000018966EA00 */ private set {} } // 0x00000001833D7080-0x00000001833D7150 0x00000001833D8760-0x00000001833D8840
	public AbilityTargetting faceToTarget { /* [XID] */ /* 0x0000000189676440-0x0000000189676460 */ get => default; /* [XID] */ /* 0x000000018967DC20-0x000000018967DC40 */ private set {} } // 0x00000001833DA8A0-0x00000001833DA940 0x00000001833D8B10-0x00000001833D8BC0
	public uint summonTag { /* [XID] */ /* 0x00000001896853A0-0x00000001896853C0 */ get => default; /* [XID] */ /* 0x000000018968CEA0-0x000000018968CEC0 */ private set {} } // 0x00000001833D96F0-0x00000001833D97C0 0x00000001833D7300-0x00000001833D73E0
	public bool aliveByOwner { /* [XID] */ /* 0x00000001896949A0-0x00000001896949C0 */ get => default; /* [XID] */ /* 0x000000018969C160-0x000000018969C180 */ private set {} } // 0x00000001833D8330-0x00000001833D83E0 0x00000001833D97C0-0x00000001833D9870
	public bool isElite { /* [XID] */ /* 0x00000001896A35C0-0x00000001896A35E0 */ get => default; /* [XID] */ /* 0x00000001896AAA70-0x00000001896AAA90 */ private set {} } // 0x00000001833D8A60-0x00000001833D8B10 0x00000001833D95E0-0x00000001833D9690
	public SimpleSafeUInt32[] affixList { /* [XID] */ /* 0x00000001896B19D0-0x00000001896B19F0 */ get => default; /* [XID] */ /* 0x00000001896B93D0-0x00000001896B93F0 */ private set {} } // 0x00000001833D7250-0x00000001833D7300 0x00000001833DA940-0x00000001833DA9F0
	public DynamicInt levelDelta { /* [XID] */ /* 0x00000001896C07E0-0x00000001896C0800 */ get => default; /* [XID] */ /* 0x00000001896C7F30-0x00000001896C7F50 */ private set {} } // 0x00000001833D6E10-0x00000001833D6EC0 0x00000001833D8020-0x00000001833D80D0
	public bool hasDrop { /* [XID] */ /* 0x00000001896CF870-0x00000001896CF890 */ get => default; /* [XID] */ /* 0x00000001896D6B80-0x00000001896D6BA0 */ private set {} } // 0x00000001833D8200-0x00000001833D82B0 0x00000001833D9530-0x00000001833D95E0
	public bool hasExp { /* [XID] */ /* 0x00000001896DE240-0x00000001896DE260 */ get => default; /* [XID] */ /* 0x00000001896E5730-0x00000001896E5750 */ private set {} } // 0x00000001833D6550-0x00000001833D6600 0x00000001833D73E0-0x00000001833D7490
	public bool sightGroupWithOwner { /* [XID] */ /* 0x00000001896ECE00-0x00000001896ECE20 */ get => default; /* [XID] */ /* 0x00000001896F4600-0x00000001896F4620 */ private set {} } // 0x00000001833D8150-0x00000001833D8200 0x00000001833D6FD0-0x00000001833D7080
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897868A0-0x00000001897868C0 */ get => default; } // 0x00000001833D9AC0-0x00000001833D9B60 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018978DE90-0x000000018978DEB0 */ get => default; } // 0x00000001833D8CA0-0x00000001833D8D40 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x0000000189795560-0x0000000189795580 */ get => default; } // 0x00000001833D6EC0-0x00000001833D6F60 

	// Constructors
	public Summon() {} // 0x00000001833DAE20-0x00000001833DAE90

	// Methods
	// [XID] // 0x00000001896FBE70-0x00000001896FBE90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833DA9F0-0x00000001833DAC30
	// [XID] // 0x0000000189703330-0x0000000189703350
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001833D9C30-0x00000001833D9D40
	// [XID] // 0x000000018970AA40-0x000000018970AA60
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF401A */) => default; // 0x00000001833D9450-0x00000001833D9530
	// [XID] // 0x00000001897124B0-0x00000001897124D0
	public override int GetHashNum() => default; // 0x00000001833D6D40-0x00000001833D6E10
	// [XID] // 0x0000000189719BF0-0x0000000189719C10
	public override void InitEmpty() {} // 0x00000001833D8E20-0x00000001833D8F80
	[BlackList] // 0x00000001897211B0-0x00000001897211F0
	// [XID] // 0x00000001897211B0-0x00000001897211F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001833D83E0-0x00000001833D8760
	// [XID] // 0x000000018972B630-0x000000018972B650
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001833D59A0-0x00000001833D6550
	[BlackList] // 0x0000000189732DA0-0x0000000189732DE0
	// [XID] // 0x0000000189732DA0-0x0000000189732DE0
	public static new Summon ParseFromJson(JSONNode node) => default; // 0x00000001833D9870-0x00000001833D9AC0
	// [XID] // 0x000000018973D970-0x000000018973D990
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF401B */, bool useObjectPool = false /* Metadata: 0x00AF401F */) => default; // 0x00000001833D9150-0x00000001833D9450
	// [XID] // 0x0000000189744DF0-0x0000000189744E10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4020 */, bool useObjectPool = false /* Metadata: 0x00AF4024 */) => default; // 0x00000001833D7510-0x00000001833D7DF0
	// [XID] // 0x000000018974C9E0-0x000000018974CA00
	public static new Summon ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4025 */, bool useObjectPool = false /* Metadata: 0x00AF4029 */) => default; // 0x00000001833D8840-0x00000001833D8A60
	[BlackList] // 0x0000000189753C80-0x0000000189753CC0
	// [XID] // 0x0000000189753C80-0x0000000189753CC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001833D6600-0x00000001833D68D0
	// [XID] // 0x000000018975E330-0x000000018975E350
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833D9FA0-0x00000001833DA8A0
	[BlackList] // 0x0000000189765990-0x00000001897659D0
	// [XID] // 0x0000000189765990-0x00000001897659D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001833D9060-0x00000001833D9150
	// [XID] // 0x0000000189770050-0x0000000189770070
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001833DACE0-0x00000001833DAD80
	// [XID] // 0x00000001897777B0-0x00000001897777D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001833D7EC0-0x00000001833D8020
	// [XID] // 0x000000018977EEA0-0x000000018977EEC0
	public override void CallAuthority(MPActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt, ref RecordInvokeEntryContext context) {} // 0x00000001833D9E20-0x00000001833D9FA0
	[BlackList] // 0x000000018979D9F0-0x000000018979DA30
	// [XID] // 0x000000018979D9F0-0x000000018979DA30
	public override void AutoAllocTypeFields() {} // 0x00000001833D68D0-0x00000001833D6970
	[BlackList] // 0x00000001897A7A80-0x00000001897A7AC0
	// [XID] // 0x00000001897A7A80-0x00000001897A7AC0
	public override void AutoRecycleTypeFields() {} // 0x00000001833D6970-0x00000001833D6BB0
	[BlackList] // 0x00000001897B2450-0x00000001897B2490
	// [XID] // 0x00000001897B2450-0x00000001897B2490
	public override void ReturnToObjectPool() {} // 0x00000001833DAD80-0x00000001833DAE20
}

