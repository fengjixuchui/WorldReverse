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
public class ConfigAudioCombat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17565
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _impactEvent; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _arrowImpactHeadEvent; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _bushImpactEvent; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _treeImpactEvent; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _putAwayWeaponEvent; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _strikeTypeSwitchKey; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<StrikeType, ConfigWwiseString> _strikeTypeSwitchMap; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _strikeTypeSwitchDefault; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _elementTypeSwitchKey; // 0x50
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<ElementType, ConfigWwiseString> _elementTypeSwitchMap; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _elementTypeSwitchDefault; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private AudioOneTimeEvent _hitSceneEvent; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _whetherRecurringSwitchKey; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _hitOneshotSwitchValue; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _hitRecurringSwitchValue; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _entityFadeOutEvent; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _patrollerTemperatureRtpc; // 0x90
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _patrollerAwareEvent; // 0x98
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _patrollerAlertEvent; // 0xA0
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _patrollerCalmEvent; // 0xA8
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioImpactOverrideEvent[] _impactOverrideEvents; // 0xB0
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioImpactOverrideEvent[] _arrowImpactOverrideEvents; // 0xB8
	private SimpleSafeUInt32[] _hittingSceneIgnoreList; // 0xC0
	private Dictionary<uint, AudioOneTimeEvent> _arrowImpactOverrideMap; // 0xC8
	private Dictionary<uint, AudioOneTimeEvent> _normalImpactOverrideMap; // 0xD0
	private SimpleSafeUInt32[] _sortedHittingSceneIgnoreList; // 0xD8

	// Properties
	public AudioOneTimeEvent impactEvent { /* [XID] */ /* 0x00000001898D4D70-0x00000001898D4D90 */ get => default; /* [XID] */ /* 0x00000001898DC7D0-0x00000001898DC7F0 */ private set {} } // 0x00000001851E7260-0x00000001851E7300 0x00000001851ED240-0x00000001851ED2F0
	public AudioOneTimeEvent arrowImpactHeadEvent { /* [XID] */ /* 0x00000001898E4200-0x00000001898E4220 */ get => default; /* [XID] */ /* 0x00000001898EBCB0-0x00000001898EBCD0 */ private set {} } // 0x00000001851EB740-0x00000001851EB7E0 0x00000001851ECBA0-0x00000001851ECC50
	public AudioOneTimeEvent bushImpactEvent { /* [XID] */ /* 0x00000001898F3520-0x00000001898F3540 */ get => default; /* [XID] */ /* 0x00000001898FAB00-0x00000001898FAB20 */ private set {} } // 0x00000001851ECC50-0x00000001851ECCF0 0x00000001851EEDB0-0x00000001851EEE60
	public AudioOneTimeEvent treeImpactEvent { /* [XID] */ /* 0x00000001899026C0-0x00000001899026E0 */ get => default; /* [XID] */ /* 0x0000000189909CA0-0x0000000189909CC0 */ private set {} } // 0x00000001851EB6A0-0x00000001851EB740 0x00000001851EC050-0x00000001851EC100
	public ConfigWwiseString putAwayWeaponEvent { /* [XID] */ /* 0x00000001899114E0-0x0000000189911500 */ get => default; /* [XID] */ /* 0x00000001899190A0-0x00000001899190C0 */ private set {} } // 0x00000001851E9C70-0x00000001851E9D10 0x00000001851E9B10-0x00000001851E9BC0
	public ConfigWwiseString strikeTypeSwitchKey { /* [XID] */ /* 0x0000000189920630-0x0000000189920650 */ get => default; /* [XID] */ /* 0x0000000189928010-0x0000000189928030 */ private set {} } // 0x00000001851EC640-0x00000001851EC6E0 0x00000001851EB290-0x00000001851EB340
	public Dictionary<StrikeType, ConfigWwiseString> strikeTypeSwitchMap { /* [XID] */ /* 0x000000018992F620-0x000000018992F640 */ get => default; /* [XID] */ /* 0x0000000189936A70-0x0000000189936A90 */ private set {} } // 0x00000001851E9A70-0x00000001851E9B10 0x00000001851ED190-0x00000001851ED240
	public ConfigWwiseString strikeTypeSwitchDefault { /* [XID] */ /* 0x000000018993E590-0x000000018993E5B0 */ get => default; /* [XID] */ /* 0x0000000189945C40-0x0000000189945C60 */ private set {} } // 0x00000001851EEF10-0x00000001851EEFB0 0x00000001851ECCF0-0x00000001851ECDA0
	public ConfigWwiseString elementTypeSwitchKey { /* [XID] */ /* 0x000000018994D110-0x000000018994D130 */ get => default; /* [XID] */ /* 0x0000000189954840-0x0000000189954860 */ private set {} } // 0x00000001851EEFB0-0x00000001851EF050 0x00000001851EB540-0x00000001851EB5F0
	public Dictionary<ElementType, ConfigWwiseString> elementTypeSwitchMap { /* [XID] */ /* 0x000000018995C120-0x000000018995C140 */ get => default; /* [XID] */ /* 0x0000000189963B00-0x0000000189963B20 */ private set {} } // 0x00000001851EBDC0-0x00000001851EBE60 0x00000001851EEE60-0x00000001851EEF10
	public ConfigWwiseString elementTypeSwitchDefault { /* [XID] */ /* 0x000000018996B090-0x000000018996B0B0 */ get => default; /* [XID] */ /* 0x0000000189972B30-0x0000000189972B50 */ private set {} } // 0x00000001851EBFB0-0x00000001851EC050 0x00000001851EB8B0-0x00000001851EB960
	public AudioOneTimeEvent hitSceneEvent { /* [XID] */ /* 0x000000018997A3F0-0x000000018997A410 */ get => default; /* [XID] */ /* 0x0000000189981BE0-0x0000000189981C00 */ private set {} } // 0x00000001851E71C0-0x00000001851E7260 0x00000001851EC100-0x00000001851EC1B0
	public ConfigWwiseString whetherRecurringSwitchKey { /* [XID] */ /* 0x00000001899895A0-0x00000001899895C0 */ get => default; /* [XID] */ /* 0x0000000189990DB0-0x0000000189990DD0 */ private set {} } // 0x00000001851EE580-0x00000001851EE620 0x00000001851ED3A0-0x00000001851ED450
	public ConfigWwiseString hitOneshotSwitchValue { /* [XID] */ /* 0x0000000189998870-0x0000000189998890 */ get => default; /* [XID] */ /* 0x00000001899A0170-0x00000001899A0190 */ private set {} } // 0x00000001851EBE60-0x00000001851EBF00 0x00000001851ECAF0-0x00000001851ECBA0
	public ConfigWwiseString hitRecurringSwitchValue { /* [XID] */ /* 0x00000001899A7CA0-0x00000001899A7CC0 */ get => default; /* [XID] */ /* 0x00000001899AF4B0-0x00000001899AF4D0 */ private set {} } // 0x00000001851E99C0-0x00000001851E9A70 0x00000001851EED00-0x00000001851EEDB0
	public ConfigWwiseString entityFadeOutEvent { /* [XID] */ /* 0x00000001899B6930-0x00000001899B6950 */ get => default; /* [XID] */ /* 0x00000001899BE470-0x00000001899BE490 */ private set {} } // 0x00000001851E8970-0x00000001851E8A20 0x00000001851E9D10-0x00000001851E9DC0
	public ConfigWwiseString patrollerTemperatureRtpc { /* [XID] */ /* 0x00000001899C5C10-0x00000001899C5C30 */ get => default; /* [XID] */ /* 0x00000001899CD350-0x00000001899CD370 */ private set {} } // 0x00000001851EC260-0x00000001851EC310 0x00000001851ECF50-0x00000001851ED000
	public ConfigWwiseString patrollerAwareEvent { /* [XID] */ /* 0x00000001899D4810-0x00000001899D4830 */ get => default; /* [XID] */ /* 0x00000001899DBE90-0x00000001899DBEB0 */ private set {} } // 0x00000001851EB490-0x00000001851EB540 0x00000001851E9BC0-0x00000001851E9C70
	public ConfigWwiseString patrollerAlertEvent { /* [XID] */ /* 0x00000001899E3870-0x00000001899E3890 */ get => default; /* [XID] */ /* 0x00000001899EAC00-0x00000001899EAC20 */ private set {} } // 0x00000001851ED000-0x00000001851ED0B0 0x00000001851E9DC0-0x00000001851E9E70
	public ConfigWwiseString patrollerCalmEvent { /* [XID] */ /* 0x00000001899F2840-0x00000001899F2860 */ get => default; /* [XID] */ /* 0x00000001899F9D70-0x00000001899F9D90 */ private set {} } // 0x00000001851E9910-0x00000001851E99C0 0x00000001851EC1B0-0x00000001851EC260
	public AudioImpactOverrideEvent[] impactOverrideEvents { /* [XID] */ /* 0x0000000189A01130-0x0000000189A01150 */ get => default; /* [XID] */ /* 0x0000000189A08B10-0x0000000189A08B30 */ private set {} } // 0x00000001851EC310-0x00000001851EC3C0 0x00000001851ED2F0-0x00000001851ED3A0
	public AudioImpactOverrideEvent[] arrowImpactOverrideEvents { /* [XID] */ /* 0x0000000189A100B0-0x0000000189A100D0 */ get => default; /* [XID] */ /* 0x0000000189A175B0-0x0000000189A175D0 */ private set {} } // 0x00000001851ED450-0x00000001851ED500 0x00000001851E96D0-0x00000001851E9780
	public SimpleSafeUInt32[] hittingSceneIgnoreList { /* [XID] */ /* 0x0000000189A1ED30-0x0000000189A1ED50 */ get => default; /* [XID] */ /* 0x0000000189A263A0-0x0000000189A263C0 */ private set {} } // 0x00000001851EBF00-0x00000001851EBFB0 0x00000001851EB5F0-0x00000001851EB6A0

	// Constructors
	public ConfigAudioCombat() {} // 0x00000001851EF0F0-0x00000001851EF150

	// Methods
	// [XID] // 0x0000000189A2D630-0x0000000189A2D650
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851EE700-0x00000001851EEBC0
	// [XID] // 0x0000000189A35110-0x0000000189A35130
	public void InitEmpty() {} // 0x00000001851EC3C0-0x00000001851EC640
	[BlackList] // 0x0000000189A3C5D0-0x0000000189A3C610
	// [XID] // 0x0000000189A3C5D0-0x0000000189A3C610
	public bool FromJson(JSONNode node) => default; // 0x00000001851EB960-0x00000001851EBCE0
	// [XID] // 0x0000000189A46F30-0x0000000189A46F50
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851E7300-0x00000001851E8970
	// [XID] // 0x0000000189A4E850-0x0000000189A4E870
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF731B */, bool useObjectPool = false /* Metadata: 0x00AF731F */) => default; // 0x00000001851EC7F0-0x00000001851ECAF0
	// [XID] // 0x0000000189A55F60-0x0000000189A55F80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7320 */, bool useObjectPool = false /* Metadata: 0x00AF7324 */) => default; // 0x00000001851E9E70-0x00000001851EB290
	[BlackList] // 0x0000000189A5DA00-0x0000000189A5DA40
	// [XID] // 0x0000000189A5DA00-0x0000000189A5DA40
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001851E8A20-0x00000001851E8CF0
	// [XID] // 0x0000000189A68570-0x0000000189A68590
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851ED500-0x00000001851EE580
	// [XID] // 0x0000000189A6F8E0-0x0000000189A6F900
	public void SortHittingSceneIgnoreList() {} // 0x00000001851EB340-0x00000001851EB490
	// [XID] // 0x0000000189A770B0-0x0000000189A770D0
	public void BuildOverrideImpactEventMaps() {} // 0x00000001851EE620-0x00000001851EE700
	// [XID] // 0x0000000189A7EAE0-0x0000000189A7EB00
	public uint GetCombatStrikeTypeSwitchValue(StrikeType strike) => default; // 0x00000001851ED0B0-0x00000001851ED190
	// [XID] // 0x0000000189A862F0-0x0000000189A86310
	public uint GetCombatElementTypeSwitchValue(ElementType element) => default; // 0x00000001851EBCE0-0x00000001851EBDC0
	// [XID] // 0x0000000189A8DCD0-0x0000000189A8DCF0
	public AudioOneTimeEvent GetOverrideImpactEvent(uint id, bool hitHead) => default; // 0x00000001851EC6E0-0x00000001851EC7F0
	// [XID] // 0x0000000189A95290-0x0000000189A952B0
	public bool IsIdInHittingSceneIngoreList(uint id) => default; // 0x00000001851EB7E0-0x00000001851EB8B0
	// [XID] // 0x0000000189A9CA90-0x0000000189A9CAB0
	private void BuildOverrideImpactEventMap(ref Dictionary<uint, AudioOneTimeEvent> map, AudioImpactOverrideEvent[] events) {} // 0x00000001851E9780-0x00000001851E9910
	private ConfigWwiseString GetWwiseStringByEnum<TEnum>(Dictionary<TEnum, ConfigWwiseString> dictionary, TEnum key) => default;
	// [XID] // 0x0000000189AA4280-0x0000000189AA42A0
	private int BinarySearch(uint needle, SimpleSafeUInt32[] hay) => default; // 0x00000001851ECDA0-0x00000001851ECF50
	[BlackList] // 0x0000000189AAB730-0x0000000189AAB770
	// [XID] // 0x0000000189AAB730-0x0000000189AAB770
	public virtual void AutoAllocTypeFields() {} // 0x00000001851E8CF0-0x00000001851E8D90
	[BlackList] // 0x0000000189AB60E0-0x0000000189AB6120
	// [XID] // 0x0000000189AB60E0-0x0000000189AB6120
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851E8D90-0x00000001851E96D0
	[BlackList] // 0x0000000189AC0B10-0x0000000189AC0B50
	// [XID] // 0x0000000189AC0B10-0x0000000189AC0B50
	public virtual void ReturnToObjectPool() {} // 0x00000001851EF050-0x00000001851EF0F0
	[BlackList] // 0x0000000189ACB490-0x0000000189ACB4D0
	// [XID] // 0x0000000189ACB490-0x0000000189ACB4D0
	public virtual void OnPoolAllocated() {} // 0x00000001851EEC60-0x00000001851EED00
	[BlackList] // 0x0000000189AD6380-0x0000000189AD63C0
	// [XID] // 0x0000000189AD6380-0x0000000189AD63C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851EEBC0-0x00000001851EEC60
}

