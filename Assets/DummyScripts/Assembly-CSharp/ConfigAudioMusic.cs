/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAudioMusic : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17597
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateGroupName; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _casualStateValue; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _combatPrepStateValue; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _combatStateValue; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _peaceStateValue; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _cityApproachTrigger; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _combatTrigger; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _combatMusicRtpc; // 0x48
	private SimpleSafeFloat outerEnemyConcernRangeRawNum; // 0x50
	private SimpleSafeFloat innerEnemyConcernRangeRawNum; // 0x54
	private SimpleSafeFloat attackFromBehindEnterDistanceRawNum; // 0x58
	private SimpleSafeFloat attackFromBehindExitDistanceRawNum; // 0x5C
	private SimpleSafeFloat intentionInFrontProductThresholdRawNum; // 0x60
	private SimpleSafeFloat IntentionFromBehindProductThresholdRawNum; // 0x64
	private SimpleSafeFloat combatRtpcLowerBoundRawNum; // 0x68
	private SimpleSafeFloat combatRtpcUpperBoundRawNum; // 0x6C
	private SimpleSafeInt32 waitFramesTillStageMatureRawNum; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enemyMainStateGroup; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _defaultEnemyMainStateValue; // 0x80
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private MusicEnemySettings[] _enemySettings; // 0x88
	private Dictionary<uint, MusicEnemySettings> _enemySettingsIndex; // 0x90

	// Properties
	public ConfigWwiseString stateGroupName { /* [XID] */ /* 0x0000000189953BF0-0x0000000189953C10 */ get => default; /* [XID] */ /* 0x00000001896D0BC0-0x00000001896D0BE0 */ private set {} } // 0x000000018418C670-0x000000018418C710 0x000000018418D580-0x000000018418D630
	public ConfigWwiseString casualStateValue { /* [XID] */ /* 0x00000001896D80D0-0x00000001896D80F0 */ get => default; /* [XID] */ /* 0x00000001896DFAA0-0x00000001896DFAC0 */ private set {} } // 0x000000018418D360-0x000000018418D400 0x000000018418A5B0-0x000000018418A660
	public ConfigWwiseString combatPrepStateValue { /* [XID] */ /* 0x00000001896E6E40-0x00000001896E6E60 */ get => default; /* [XID] */ /* 0x00000001896EE2F0-0x00000001896EE310 */ private set {} } // 0x000000018418D2C0-0x000000018418D360 0x0000000184189610-0x00000001841896C0
	public ConfigWwiseString combatStateValue { /* [XID] */ /* 0x00000001896F5C20-0x00000001896F5C40 */ get => default; /* [XID] */ /* 0x00000001896FD470-0x00000001896FD490 */ private set {} } // 0x000000018418D400-0x000000018418D4A0 0x000000018418C970-0x000000018418CA20
	public ConfigWwiseString peaceStateValue { /* [XID] */ /* 0x00000001898A2AE0-0x00000001898A2B00 */ get => default; /* [XID] */ /* 0x000000018970C090-0x000000018970C0B0 */ private set {} } // 0x000000018418C2B0-0x000000018418C350 0x000000018418C350-0x000000018418C400
	public ConfigWwiseString cityApproachTrigger { /* [XID] */ /* 0x0000000189713A20-0x0000000189713A40 */ get => default; /* [XID] */ /* 0x000000018971B340-0x000000018971B360 */ private set {} } // 0x000000018418BE90-0x000000018418BF30 0x000000018418D050-0x000000018418D100
	public ConfigWwiseString combatTrigger { /* [XID] */ /* 0x00000001897225C0-0x00000001897225E0 */ get => default; /* [XID] */ /* 0x0000000189729CA0-0x0000000189729CC0 */ private set {} } // 0x000000018418BDF0-0x000000018418BE90 0x000000018418A740-0x000000018418A7F0
	public ConfigWwiseString combatMusicRtpc { /* [XID] */ /* 0x0000000189731360-0x0000000189731380 */ get => default; /* [XID] */ /* 0x0000000189738B50-0x0000000189738B70 */ private set {} } // 0x0000000184188030-0x00000001841880D0 0x000000018418C400-0x000000018418C4B0
	public float outerEnemyConcernRange { /* [XID] */ /* 0x00000001897409C0-0x00000001897409E0 */ get => default; /* [XID] */ /* 0x0000000189747D60-0x0000000189747D80 */ private set {} } // 0x000000018418EBD0-0x000000018418ECB0 0x000000018418AB00-0x000000018418ABE0
	public float innerEnemyConcernRange { /* [XID] */ /* 0x000000018974F4D0-0x000000018974F4F0 */ get => default; /* [XID] */ /* 0x0000000189756B40-0x0000000189756B60 */ private set {} } // 0x000000018418A4D0-0x000000018418A5B0 0x000000018418D4A0-0x000000018418D580
	public float attackFromBehindEnterDistance { /* [XID] */ /* 0x000000018975DFD0-0x000000018975DFF0 */ get => default; /* [XID] */ /* 0x0000000189765750-0x0000000189765770 */ private set {} } // 0x000000018418D7C0-0x000000018418D8A0 0x000000018418C590-0x000000018418C670
	public float attackFromBehindExitDistance { /* [XID] */ /* 0x000000018976CFE0-0x000000018976D000 */ get => default; /* [XID] */ /* 0x00000001897744B0-0x00000001897744D0 */ private set {} } // 0x000000018418BD10-0x000000018418BDF0 0x000000018418CA20-0x000000018418CB00
	public float intentionInFrontProductThreshold { /* [XID] */ /* 0x000000018977BE40-0x000000018977BE60 */ get => default; /* [XID] */ /* 0x0000000189783750-0x0000000189783770 */ private set {} } // 0x000000018418D6E0-0x000000018418D7C0 0x000000018418A340-0x000000018418A420
	public float IntentionFromBehindProductThreshold { /* [XID] */ /* 0x000000018978AE60-0x000000018978AE80 */ get => default; /* [XID] */ /* 0x0000000189792420-0x0000000189792440 */ private set {} } // 0x000000018418A970-0x000000018418AA50 0x000000018418D1E0-0x000000018418D2C0
	public float combatRtpcLowerBound { /* [XID] */ /* 0x00000001897999F0-0x0000000189799A10 */ get => default; /* [XID] */ /* 0x00000001897A18E0-0x00000001897A1900 */ private set {} } // 0x000000018418D100-0x000000018418D1E0 0x000000018418CB00-0x000000018418CBE0
	public float combatRtpcUpperBound { /* [XID] */ /* 0x00000001897A9140-0x00000001897A9160 */ get => default; /* [XID] */ /* 0x00000001897B09A0-0x00000001897B09C0 */ private set {} } // 0x000000018418C4B0-0x000000018418C590 0x000000018418EAF0-0x000000018418EBD0
	public int waitFramesTillStageMature { /* [XID] */ /* 0x00000001897B8700-0x00000001897B8720 */ get => default; /* [XID] */ /* 0x00000001897C0740-0x00000001897C0760 */ private set {} } // 0x000000018418A7F0-0x000000018418A8C0 0x000000018418A660-0x000000018418A740
	public ConfigWwiseString enemyMainStateGroup { /* [XID] */ /* 0x00000001897C7FD0-0x00000001897C7FF0 */ get => default; /* [XID] */ /* 0x00000001897CF350-0x00000001897CF370 */ private set {} } // 0x0000000184189990-0x0000000184189A30 0x000000018418BC60-0x000000018418BD10
	public ConfigWwiseString defaultEnemyMainStateValue { /* [XID] */ /* 0x00000001897D6C20-0x00000001897D6C40 */ get => default; /* [XID] */ /* 0x00000001897DE2F0-0x00000001897DE310 */ private set {} } // 0x000000018418AA50-0x000000018418AB00 0x000000018418D630-0x000000018418D6E0
	public MusicEnemySettings[] enemySettings { /* [XID] */ /* 0x00000001897E5DB0-0x00000001897E5DD0 */ get => default; /* [XID] */ /* 0x00000001897ED7B0-0x00000001897ED7D0 */ private set {} } // 0x000000018418A8C0-0x000000018418A970 0x000000018418A420-0x000000018418A4D0

	// Constructors
	public ConfigAudioMusic() {} // 0x000000018418ED50-0x000000018418EDB0

	// Methods
	// [XID] // 0x00000001897F5050-0x00000001897F5070
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018418E600-0x000000018418E9B0
	// [XID] // 0x00000001897FCAE0-0x00000001897FCB00
	public void InitEmpty() {} // 0x000000018418C710-0x000000018418C970
	[BlackList] // 0x0000000189803FF0-0x0000000189804030
	// [XID] // 0x0000000189803FF0-0x0000000189804030
	public bool FromJson(JSONNode node) => default; // 0x000000018418BF30-0x000000018418C2B0
	// [XID] // 0x000000018980E530-0x000000018980E550
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001841880D0-0x0000000184189610
	// [XID] // 0x0000000189815C90-0x0000000189815CB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF743D */, bool useObjectPool = false /* Metadata: 0x00AF7441 */) => default; // 0x000000018418CBE0-0x000000018418CEE0
	// [XID] // 0x000000018981D670-0x000000018981D690
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7442 */, bool useObjectPool = false /* Metadata: 0x00AF7446 */) => default; // 0x000000018418ABE0-0x000000018418BC60
	[BlackList] // 0x0000000189824B60-0x0000000189824BA0
	// [XID] // 0x0000000189824B60-0x0000000189824BA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001841896C0-0x0000000184189990
	// [XID] // 0x000000018982F100-0x000000018982F120
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018418D8A0-0x000000018418E600
	// [XID] // 0x0000000189836990-0x00000001898369B0
	public void BuildEnemySettingsIndex() {} // 0x000000018418CEE0-0x000000018418D050
	// [XID] // 0x000000018983DD60-0x000000018983DD80
	public void GetEnemyStates(uint enemyConfigId, ConfigAICombatPhase combatPhase, out ConfigWwiseString mainStateValue, out ConfigWwiseString auxStateGroup, out ConfigWwiseString auxStateValue) {
		mainStateValue = default;
		auxStateGroup = default;
		auxStateValue = default;
	} // 0x0000000184189A30-0x0000000184189C80
	[BlackList] // 0x0000000189845570-0x00000001898455B0
	// [XID] // 0x0000000189845570-0x00000001898455B0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184189C80-0x0000000184189D20
	[BlackList] // 0x000000018984F900-0x000000018984F940
	// [XID] // 0x000000018984F900-0x000000018984F940
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184189D20-0x000000018418A340
	[BlackList] // 0x0000000189859F90-0x0000000189859FD0
	// [XID] // 0x0000000189859F90-0x0000000189859FD0
	public virtual void ReturnToObjectPool() {} // 0x000000018418ECB0-0x000000018418ED50
	[BlackList] // 0x00000001898643F0-0x0000000189864430
	// [XID] // 0x00000001898643F0-0x0000000189864430
	public virtual void OnPoolAllocated() {} // 0x000000018418EA50-0x000000018418EAF0
	[BlackList] // 0x000000018986E850-0x000000018986E890
	// [XID] // 0x000000018986E850-0x000000018986E890
	public virtual void OnBeforePoolRecycled() {} // 0x000000018418E9B0-0x000000018418EA50
}

