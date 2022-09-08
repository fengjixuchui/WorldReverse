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
public class ConfigLevelMonsterUnit : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18495
{
	// Fields
	private SimpleSafeUInt32 groupIdRawNum; // 0x10
	private SimpleSafeUInt32 mapInstIdRawNum; // 0x14
	private bool _spawnedByEvtPattern; // 0x18
	private SimpleSafeInt32 routeIdRawNum; // 0x1C
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigLevelMonsterAIPatrol _aiPatrolSetting; // 0x20
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeUInt32 aiGroupIDRawNum; // 0x28
	private bool _overrideDefendAreaRange; // 0x2C
	private SimpleSafeFloat defendAreaRangeRawNum; // 0x30
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeUInt32 defendAreaIDRawNum; // 0x34
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeUInt32 wanderAreaIDRawNum; // 0x38
	private string _aiNeuronSetting; // 0x40
	private string _aiSensingTemplate; // 0x48
	private bool _forceCombatOnSpawn; // 0x50
	private bool _disableWander; // 0x51
	private bool _standOnDistantMesh; // 0x52
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeUInt32 landingPointIDRawNum; // 0x54
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeUInt32 extractionPointIDRawNum; // 0x58
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private bool _billboard_HasUIBar; // 0x5C
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeFloat billboard_ShowUIBarDisRawNum; // 0x60
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private SimpleSafeFloat billboard_HideUIBarDisRawNum; // 0x64
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private bool _billboard_UIBarNeedEnterCombat; // 0x68
	[Browsable] // 0x000000018961C030-0x000000018961C040
	private HpBarStyle _billboard_HpBarStyle; // 0x6C

	// Properties
	public uint groupId { /* [XID] */ /* 0x0000000189641520-0x0000000189641540 */ get => default; /* [XID] */ /* 0x0000000189648EE0-0x0000000189648F00 */ private set {} } // 0x0000000183511D90-0x0000000183511E60 0x0000000183511E60-0x0000000183511F40
	public uint mapInstId { /* [XID] */ /* 0x0000000189650510-0x0000000189650530 */ get => default; /* [XID] */ /* 0x0000000189657E50-0x0000000189657E70 */ private set {} } // 0x0000000183510EB0-0x0000000183510F80 0x0000000183510530-0x0000000183510610
	public bool spawnedByEvtPattern { /* [XID] */ /* 0x000000018965F480-0x000000018965F4A0 */ get => default; /* [XID] */ /* 0x0000000189666D90-0x0000000189666DB0 */ private set {} } // 0x000000018350EF10-0x000000018350EFB0 0x0000000183511610-0x00000001835116C0
	public int routeId { /* [XID] */ /* 0x0000000189874C90-0x0000000189874CB0 */ get => default; /* [XID] */ /* 0x00000001896761A0-0x00000001896761C0 */ private set {} } // 0x00000001835106B0-0x0000000183510780 0x00000001835116C0-0x00000001835117A0
	public ConfigLevelMonsterAIPatrol aiPatrolSetting { /* [XID] */ /* 0x000000018967DA20-0x000000018967DA40 */ get => default; /* [XID] */ /* 0x0000000189685080-0x00000001896850A0 */ private set {} } // 0x000000018350F4E0-0x000000018350F580 0x0000000183510D30-0x0000000183510DE0
	public uint aiGroupID { /* [XID] */ /* 0x000000018968CB60-0x000000018968CB80 */ get => default; /* [XID] */ /* 0x0000000189694660-0x0000000189694680 */ private set {} } // 0x0000000183511F40-0x0000000183512010 0x000000018350F400-0x000000018350F4E0
	public bool overrideDefendAreaRange { /* [XID] */ /* 0x000000018969BCA0-0x000000018969BCC0 */ get => default; /* [XID] */ /* 0x00000001896A3260-0x00000001896A3280 */ private set {} } // 0x000000018350F360-0x000000018350F400 0x0000000183511560-0x0000000183511610
	public float defendAreaRange { /* [XID] */ /* 0x0000000189899E90-0x0000000189899EB0 */ get => default; /* [XID] */ /* 0x00000001896B1750-0x00000001896B1770 */ private set {} } // 0x000000018350F050-0x000000018350F130 0x000000018350D2A0-0x000000018350D380
	public uint defendAreaID { /* [XID] */ /* 0x00000001896B90F0-0x00000001896B9110 */ get => default; /* [XID] */ /* 0x00000001896C0500-0x00000001896C0520 */ private set {} } // 0x0000000183511C20-0x0000000183511CF0 0x00000001835111C0-0x00000001835112A0
	public uint wanderAreaID { /* [XID] */ /* 0x00000001896C7C50-0x00000001896C7C70 */ get => default; /* [XID] */ /* 0x00000001896CF610-0x00000001896CF630 */ private set {} } // 0x000000018350F130-0x000000018350F200 0x00000001835117A0-0x0000000183511880
	public string aiNeuronSetting { /* [XID] */ /* 0x00000001896D67E0-0x00000001896D6800 */ get => default; /* [XID] */ /* 0x00000001896DDEC0-0x00000001896DDEE0 */ private set {} } // 0x0000000183510910-0x00000001835109B0 0x000000018350D380-0x000000018350D430
	public string aiSensingTemplate { /* [XID] */ /* 0x0000000189AEBEF0-0x0000000189AEBF10 */ get => default; /* [XID] */ /* 0x00000001896ECAC0-0x00000001896ECAE0 */ private set {} } // 0x0000000183510490-0x0000000183510530 0x00000001835132B0-0x0000000183513360
	public bool forceCombatOnSpawn { /* [XID] */ /* 0x00000001896F42C0-0x00000001896F42E0 */ get => default; /* [XID] */ /* 0x00000001896FBAD0-0x00000001896FBAF0 */ private set {} } // 0x0000000183510610-0x00000001835106B0 0x000000018350F200-0x000000018350F2B0
	public bool disableWander { /* [XID] */ /* 0x00000001897C9DC0-0x00000001897C9DE0 */ get => default; /* [XID] */ /* 0x000000018970A6E0-0x000000018970A700 */ private set {} } // 0x0000000183511B80-0x0000000183511C20 0x0000000183511030-0x00000001835110E0
	public bool standOnDistantMesh { /* [XID] */ /* 0x0000000189712190-0x00000001897121B0 */ get => default; /* [XID] */ /* 0x0000000189719810-0x0000000189719830 */ private set {} } // 0x000000018350E810-0x000000018350E8B0 0x0000000183510780-0x0000000183510830
	public uint landingPointID { /* [XID] */ /* 0x0000000189720D90-0x0000000189720DB0 */ get => default; /* [XID] */ /* 0x0000000189728450-0x0000000189728470 */ private set {} } // 0x0000000183510DE0-0x0000000183510EB0 0x0000000183513440-0x0000000183513520
	public uint extractionPointID { /* [XID] */ /* 0x0000000189B5A540-0x0000000189B5A560 */ get => default; /* [XID] */ /* 0x00000001897375E0-0x0000000189737600 */ private set {} } // 0x000000018350F710-0x000000018350F7E0 0x0000000183513360-0x0000000183513440
	public bool billboard_HasUIBar { /* [XID] */ /* 0x000000018973F060-0x000000018973F080 */ get => default; /* [XID] */ /* 0x0000000189746300-0x0000000189746320 */ private set {} } // 0x000000018350EFB0-0x000000018350F050 0x000000018350F660-0x000000018350F710
	public float billboard_ShowUIBarDis { /* [XID] */ /* 0x000000018974DDD0-0x000000018974DDF0 */ get => default; /* [XID] */ /* 0x00000001897554D0-0x00000001897554F0 */ private set {} } // 0x00000001835110E0-0x00000001835111C0 0x000000018350F580-0x000000018350F660
	public float billboard_HideUIBarDis { /* [XID] */ /* 0x000000018975C630-0x000000018975C650 */ get => default; /* [XID] */ /* 0x0000000189763F20-0x0000000189763F40 */ private set {} } // 0x0000000183510830-0x0000000183510910 0x00000001835112A0-0x0000000183511380
	public bool billboard_UIBarNeedEnterCombat { /* [XID] */ /* 0x000000018976B820-0x000000018976B840 */ get => default; /* [XID] */ /* 0x0000000189772D00-0x0000000189772D20 */ private set {} } // 0x000000018350EB80-0x000000018350EC20 0x0000000183510F80-0x0000000183511030
	public HpBarStyle billboard_HpBarStyle { /* [XID] */ /* 0x000000018977A3C0-0x000000018977A3E0 */ get => default; /* [XID] */ /* 0x0000000189782020-0x0000000189782040 */ private set {} } // 0x0000000183511CF0-0x0000000183511D90 0x000000018350F2B0-0x000000018350F360

	// Constructors
	public ConfigLevelMonsterUnit() {} // 0x00000001835135C0-0x0000000183513740

	// Methods
	// [XID] // 0x00000001897893C0-0x00000001897893E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183512E50-0x0000000183513170
	// [XID] // 0x0000000189790A90-0x0000000189790AB0
	public void InitEmpty() {} // 0x0000000183511380-0x0000000183511560
	[BlackList] // 0x0000000189798400-0x0000000189798440
	// [XID] // 0x0000000189798400-0x0000000189798440
	public bool FromJson(JSONNode node) => default; // 0x00000001835109B0-0x0000000183510D30
	// [XID] // 0x00000001897A2FE0-0x00000001897A3000
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018350D430-0x000000018350E810
	// [XID] // 0x00000001897AA5E0-0x00000001897AA600
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F63 */, bool useObjectPool = false /* Metadata: 0x00AF9F67 */) => default; // 0x0000000183511880-0x0000000183511B80
	// [XID] // 0x00000001897B20B0-0x00000001897B20D0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F68 */, bool useObjectPool = false /* Metadata: 0x00AF9F6C */) => default; // 0x000000018350F7E0-0x0000000183510490
	[BlackList] // 0x00000001897B9A50-0x00000001897B9A90
	// [XID] // 0x00000001897B9A50-0x00000001897B9A90
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018350E8B0-0x000000018350EB80
	// [XID] // 0x00000001897C4900-0x00000001897C4920
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183512010-0x0000000183512E50
	[BlackList] // 0x00000001897CC090-0x00000001897CC0D0
	// [XID] // 0x00000001897CC090-0x00000001897CC0D0
	public virtual void AutoAllocTypeFields() {} // 0x000000018350EC20-0x000000018350ECC0
	[BlackList] // 0x00000001897D6A00-0x00000001897D6A40
	// [XID] // 0x00000001897D6A00-0x00000001897D6A40
	public virtual void AutoRecycleTypeFields() {} // 0x000000018350ECC0-0x000000018350EF10
	[BlackList] // 0x00000001897E1300-0x00000001897E1340
	// [XID] // 0x00000001897E1300-0x00000001897E1340
	public virtual void ReturnToObjectPool() {} // 0x0000000183513520-0x00000001835135C0
	[BlackList] // 0x00000001897EBEC0-0x00000001897EBF00
	// [XID] // 0x00000001897EBEC0-0x00000001897EBF00
	public virtual void OnPoolAllocated() {} // 0x0000000183513210-0x00000001835132B0
	[BlackList] // 0x00000001897F64A0-0x00000001897F64E0
	// [XID] // 0x00000001897F64A0-0x00000001897F64E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183513170-0x0000000183513210
}

