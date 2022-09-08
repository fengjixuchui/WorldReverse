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
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAIThreatSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17396
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeFloat clearThreatTargetDistanceRawNum; // 0x14
	private SimpleSafeFloat clearThreatEdgeDistanceRawNum; // 0x18
	private bool _clearThreatByLostPath; // 0x1C
	private bool _clearThreatByTargetOutOfZone; // 0x1D
	private SimpleSafeFloat clearThreatTimerByDistanceRawNum; // 0x20
	private SimpleSafeFloat clearThreatTimerByLostPathRawNum; // 0x24
	private SimpleSafeFloat clearThreatTimerByTargetOutOfZoneRawNum; // 0x28
	private SimpleSafeFloat viewThreatGrowRawNum; // 0x2C
	private SimpleSafeFloat hearThreatGrowRawNum; // 0x30
	private SimpleSafeFloat feelThreatGrowRawNum; // 0x34
	private SimpleSafeFloat threatDecreaseSpeedRawNum; // 0x38
	private SimpleSafeFloat threatBroadcastRangeRawNum; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AIPoint[] _viewAttenuation; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AIPoint[] _hearAttenuation; // 0x48
	private TauntLevel _resistTauntLevel; // 0x50
	private SimpleSafeFloat auxScoreChangeTargetCDRawNum; // 0x54
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAITSAbilityGlobalValueSetting _abilityGlobalValueScoreSystem; // 0x58
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAITSTargetDistanceSetting _targetDistanceScoreSystem; // 0x60
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAITSTargetBearingSetting _targetBearingScoreSystem; // 0x68
	public static Action<ConfigAIThreatSetting, bool> postProcessData; // 0x00
	public static Action<ConfigAIThreatSetting> postInitEmpty; // 0x08
	[BlackList] // 0x00000001898E1340-0x00000001898E1390
	[JsonIgnore] // 0x00000001898E1340-0x00000001898E1390
	// [PooledField] // 0x00000001898E1340-0x00000001898E1390
	public List<ConfigAIThreatScoreBaseSetting> threatScoreSystemList; // 0x70

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001898FDDE0-0x00000001898FDE00 */ get => default; /* [XID] */ /* 0x0000000189905600-0x0000000189905620 */ private set {} } // 0x0000000185188B80-0x0000000185188C20 0x000000018518A1E0-0x000000018518A290
	public float clearThreatTargetDistance { /* [XID] */ /* 0x000000018990CF10-0x000000018990CF30 */ get => default; /* [XID] */ /* 0x00000001899146C0-0x00000001899146E0 */ private set {} } // 0x000000018518A4B0-0x000000018518A590 0x000000018518A050-0x000000018518A130
	public float clearThreatEdgeDistance { /* [XID] */ /* 0x00000001897D14C0-0x00000001897D14E0 */ get => default; /* [XID] */ /* 0x0000000189923920-0x0000000189923940 */ private set {} } // 0x00000001851899D0-0x0000000185189AB0 0x0000000185188400-0x00000001851884E0
	public bool clearThreatByLostPath { /* [XID] */ /* 0x000000018992AF60-0x000000018992AF80 */ get => default; /* [XID] */ /* 0x00000001899325E0-0x0000000189932600 */ private set {} } // 0x00000001851874F0-0x0000000185187590 0x00000001851856D0-0x0000000185185780
	public bool clearThreatByTargetOutOfZone { /* [XID] */ /* 0x00000001897B2DC0-0x00000001897B2DE0 */ get => default; /* [XID] */ /* 0x00000001899411C0-0x00000001899411E0 */ private set {} } // 0x000000018518A410-0x000000018518A4B0 0x0000000185187440-0x00000001851874F0
	public float clearThreatTimerByDistance { /* [XID] */ /* 0x0000000189948CC0-0x0000000189948CE0 */ get => default; /* [XID] */ /* 0x0000000189950490-0x00000001899504B0 */ private set {} } // 0x0000000185187590-0x0000000185187670 0x0000000185189080-0x0000000185189160
	public float clearThreatTimerByLostPath { /* [XID] */ /* 0x0000000189957A80-0x0000000189957AA0 */ get => default; /* [XID] */ /* 0x000000018995F2F0-0x000000018995F310 */ private set {} } // 0x0000000185186B00-0x0000000185186BE0 0x0000000185188320-0x0000000185188400
	public float clearThreatTimerByTargetOutOfZone { /* [XID] */ /* 0x00000001899F32A0-0x00000001899F32C0 */ get => default; /* [XID] */ /* 0x000000018996DF40-0x000000018996DF60 */ private set {} } // 0x0000000185188C20-0x0000000185188D00 0x0000000185189230-0x0000000185189310
	public float viewThreatGrow { /* [XID] */ /* 0x0000000189975B10-0x0000000189975B30 */ get => default; /* [XID] */ /* 0x000000018997CAF0-0x000000018997CB10 */ private set {} } // 0x00000001851886A0-0x0000000185188780 0x000000018518B9E0-0x000000018518BAC0
	public float hearThreatGrow { /* [XID] */ /* 0x000000018982B760-0x000000018982B780 */ get => default; /* [XID] */ /* 0x000000018998C3B0-0x000000018998C3D0 */ private set {} } // 0x000000018518A330-0x000000018518A410 0x00000001851884E0-0x00000001851885C0
	public float feelThreatGrow { /* [XID] */ /* 0x00000001899940B0-0x00000001899940D0 */ get => default; /* [XID] */ /* 0x000000018999B900-0x000000018999B920 */ private set {} } // 0x0000000185188D00-0x0000000185188DE0 0x0000000185186F60-0x0000000185187040
	public float threatDecreaseSpeed { /* [XID] */ /* 0x00000001899A30F0-0x00000001899A3110 */ get => default; /* [XID] */ /* 0x00000001899AABE0-0x00000001899AAC00 */ private set {} } // 0x0000000185189AB0-0x0000000185189B90 0x000000018518BAC0-0x000000018518BBA0
	public float threatBroadcastRange { /* [XID] */ /* 0x00000001899B25D0-0x00000001899B25F0 */ get => default; /* [XID] */ /* 0x00000001899B98F0-0x00000001899B9910 */ private set {} } // 0x000000018518BBA0-0x000000018518BC80 0x000000018518A6E0-0x000000018518A7C0
	public AIPoint[] viewAttenuation { /* [XID] */ /* 0x00000001899C1410-0x00000001899C1430 */ get => default; /* [XID] */ /* 0x00000001899C8A40-0x00000001899C8A60 */ private set {} } // 0x000000018518BC80-0x000000018518BD20 0x0000000185188DE0-0x0000000185188E90
	public AIPoint[] hearAttenuation { /* [XID] */ /* 0x00000001899D03B0-0x00000001899D03D0 */ get => default; /* [XID] */ /* 0x00000001899D7890-0x00000001899D78B0 */ private set {} } // 0x000000018518A290-0x000000018518A330 0x0000000185186BE0-0x0000000185186C90
	public TauntLevel resistTauntLevel { /* [XID] */ /* 0x00000001899DEC70-0x00000001899DEC90 */ get => default; /* [XID] */ /* 0x00000001899E6890-0x00000001899E68B0 */ private set {} } // 0x000000018518A590-0x000000018518A630 0x000000018518A7C0-0x000000018518A870
	public float auxScoreChangeTargetCD { /* [XID] */ /* 0x00000001897A3C30-0x00000001897A3C50 */ get => default; /* [XID] */ /* 0x00000001899F5730-0x00000001899F5750 */ private set {} } // 0x00000001851885C0-0x00000001851886A0 0x0000000185189B90-0x0000000185189C70
	public ConfigAITSAbilityGlobalValueSetting abilityGlobalValueScoreSystem { /* [XID] */ /* 0x00000001899FCE90-0x00000001899FCEB0 */ get => default; /* [XID] */ /* 0x0000000189A04310-0x0000000189A04330 */ private set {} } // 0x00000001851895B0-0x0000000185189650 0x000000018518A130-0x000000018518A1E0
	public ConfigAITSTargetDistanceSetting targetDistanceScoreSystem { /* [XID] */ /* 0x0000000189A0BA70-0x0000000189A0BA90 */ get => default; /* [XID] */ /* 0x0000000189A13320-0x0000000189A13340 */ private set {} } // 0x0000000185188E90-0x0000000185188F30 0x0000000185188F30-0x0000000185188FE0
	public ConfigAITSTargetBearingSetting targetBearingScoreSystem { /* [XID] */ /* 0x000000018996E830-0x000000018996E850 */ get => default; /* [XID] */ /* 0x0000000189A21C50-0x0000000189A21C70 */ private set {} } // 0x0000000185188FE0-0x0000000185189080 0x000000018518A630-0x000000018518A6E0

	// Constructors
	public ConfigAIThreatSetting() {} // 0x000000018518BFA0-0x000000018518C110
	static ConfigAIThreatSetting() {} // 0x000000018518BDC0-0x000000018518BFA0

	// Methods
	// [XID] // 0x00000001897C2660-0x00000001897C2680
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018518B520-0x000000018518B840
	// [XID] // 0x0000000189A307B0-0x0000000189A307D0
	public void InitEmpty() {} // 0x0000000185189310-0x00000001851895B0
	[BlackList] // 0x0000000189A38170-0x0000000189A381B0
	// [XID] // 0x0000000189A38170-0x0000000189A381B0
	public bool FromJson(JSONNode node) => default; // 0x0000000185188780-0x0000000185188B80
	// [XID] // 0x0000000189A42810-0x0000000189A42830
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185185780-0x0000000185186B00
	// [XID] // 0x0000000189A49DA0-0x0000000189A49DC0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D23 */, bool useObjectPool = false /* Metadata: 0x00AF6D27 */) => default; // 0x0000000185189650-0x00000001851899D0
	// [XID] // 0x0000000189A51750-0x0000000189A51770
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D28 */, bool useObjectPool = false /* Metadata: 0x00AF6D2C */) => default; // 0x0000000185187670-0x0000000185188320
	[BlackList] // 0x0000000189A58EE0-0x0000000189A58F20
	// [XID] // 0x0000000189A58EE0-0x0000000189A58F20
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185186C90-0x0000000185186F60
	// [XID] // 0x0000000189A63A50-0x0000000189A63A70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018518A870-0x000000018518B520
	[BlackList] // 0x0000000189A6B2F0-0x0000000189A6B330
	// [XID] // 0x0000000189A6B2F0-0x0000000189A6B330
	public virtual void OnPoolAllocated() {} // 0x000000018518B940-0x000000018518B9E0
	[BlackList] // 0x0000000189A75710-0x0000000189A75750
	// [XID] // 0x0000000189A75710-0x0000000189A75750
	public virtual void OnBeforePoolRecycled() {} // 0x000000018518B840-0x000000018518B940
	// [XID] // 0x0000000189A80000-0x0000000189A80020
	private static void OnPostInitEmpty(ConfigAIThreatSetting data) {} // 0x0000000185189160-0x0000000185189230
	// [XID] // 0x0000000189A87D20-0x0000000189A87D40
	private static void OnPostProcessDataCallback(ConfigAIThreatSetting data, bool useObjectPool) {} // 0x0000000185189C70-0x000000018518A050
	[BlackList] // 0x0000000189A8F590-0x0000000189A8F5D0
	// [XID] // 0x0000000189A8F590-0x0000000189A8F5D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185187040-0x00000001851870E0
	[BlackList] // 0x0000000189A99E40-0x0000000189A99E80
	// [XID] // 0x0000000189A99E40-0x0000000189A99E80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851870E0-0x0000000185187440
	[BlackList] // 0x0000000189AA42E0-0x0000000189AA4320
	// [XID] // 0x0000000189AA42E0-0x0000000189AA4320
	public virtual void ReturnToObjectPool() {} // 0x000000018518BD20-0x000000018518BDC0
}

