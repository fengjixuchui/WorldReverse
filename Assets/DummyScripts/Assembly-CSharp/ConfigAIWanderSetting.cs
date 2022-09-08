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
public class ConfigAIWanderSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17421
{
	// Fields
	private SimpleSafeInt32[] _threatLevelLimit; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIWanderData _defaultSetting; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIWanderData> _specification; // 0x38
	public static Action<ConfigAIWanderSetting, bool> postProcessData; // 0x00
	public static Action<ConfigAIWanderSetting> postInitEmpty; // 0x08
	private static HashSet<ThreatLevel> defaultThreatLimitSet; // 0x10
	[BlackList] // 0x0000000189AB7930-0x0000000189AB7980
	[JsonIgnore] // 0x0000000189AB7930-0x0000000189AB7980
	// [PooledField] // 0x0000000189AB7930-0x0000000189AB7980
	public HashSet<ThreatLevel> threatLevelLimitSet; // 0x40

	// Properties
	public SimpleSafeInt32[] threatLevelLimit { /* [XID] */ /* 0x0000000189AD4940-0x0000000189AD4960 */ get => default; /* [XID] */ /* 0x0000000189ADC260-0x0000000189ADC280 */ private set {} } // 0x00000001813606E0-0x0000000181360780 0x00000001813608D0-0x0000000181360980
	public ConfigAIWanderData defaultSetting { /* [XID] */ /* 0x0000000189AE3C70-0x0000000189AE3C90 */ get => default; /* [XID] */ /* 0x0000000189AEB570-0x0000000189AEB590 */ private set {} } // 0x0000000181362560-0x0000000181362600 0x000000018135FC10-0x000000018135FCC0
	public Dictionary<SimpleSafeInt32, ConfigAIWanderData> specification { /* [XID] */ /* 0x0000000189AF2E90-0x0000000189AF2EB0 */ get => default; /* [XID] */ /* 0x0000000189AFA780-0x0000000189AFA7A0 */ private set {} } // 0x00000001813603A0-0x0000000181360440 0x0000000181361DE0-0x0000000181361E90

	// Constructors
	public ConfigAIWanderSetting() {} // 0x0000000181362FE0-0x0000000181363060
	static ConfigAIWanderSetting() {} // 0x0000000181362D70-0x0000000181362FE0

	// Methods
	// [XID] // 0x0000000189B01D10-0x0000000189B01D30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181362990-0x0000000181362AD0
	// [XID] // 0x0000000189B09290-0x0000000189B092B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181362450-0x0000000181362560
	// [XID] // 0x0000000189B10CF0-0x0000000189B10D10
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E05 */) => default; // 0x0000000181361E90-0x0000000181361F70
	// [XID] // 0x0000000189B17EC0-0x0000000189B17EE0
	public override int GetHashNum() => default; // 0x0000000181360800-0x00000001813608D0
	// [XID] // 0x0000000189B1F6A0-0x0000000189B1F6C0
	public override void InitEmpty() {} // 0x0000000181361710-0x0000000181361890
	[BlackList] // 0x0000000189B26F20-0x0000000189B26F60
	// [XID] // 0x0000000189B26F20-0x0000000189B26F60
	public override bool FromJson(JSONNode node) => default; // 0x0000000181360F40-0x0000000181361340
	// [XID] // 0x0000000189B310B0-0x0000000189B310D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018135FCC0-0x00000001813600D0
	[BlackList] // 0x0000000189B386F0-0x0000000189B38730
	// [XID] // 0x0000000189B386F0-0x0000000189B38730
	public static new ConfigAIWanderSetting ParseFromJson(JSONNode node) => default; // 0x00000001813621A0-0x00000001813623F0
	// [XID] // 0x0000000189B43170-0x0000000189B43190
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E06 */, bool useObjectPool = false /* Metadata: 0x00AF6E0A */) => default; // 0x0000000181361A60-0x0000000181361DE0
	// [XID] // 0x0000000189B4A9F0-0x0000000189B4AA10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E0B */, bool useObjectPool = false /* Metadata: 0x00AF6E0F */) => default; // 0x0000000181360A60-0x0000000181360E40
	// [XID] // 0x0000000189B52080-0x0000000189B520A0
	public static new ConfigAIWanderSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E10 */, bool useObjectPool = false /* Metadata: 0x00AF6E14 */) => default; // 0x0000000181361340-0x0000000181361560
	[BlackList] // 0x0000000189B599E0-0x0000000189B59A20
	// [XID] // 0x0000000189B599E0-0x0000000189B59A20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001813600D0-0x00000001813603A0
	// [XID] // 0x0000000189B64130-0x0000000189B64150
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181362600-0x0000000181362990
	[BlackList] // 0x0000000189B6B850-0x0000000189B6B890
	// [XID] // 0x0000000189B6B850-0x0000000189B6B890
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181361970-0x0000000181361A60
	// [XID] // 0x0000000189B75DF0-0x0000000189B75E10
	public override void OnPoolAllocated() {} // 0x0000000181362BD0-0x0000000181362C70
	// [XID] // 0x0000000189B7D340-0x0000000189B7D360
	public override void OnBeforePoolRecycled() {} // 0x0000000181362AD0-0x0000000181362BD0
	// [XID] // 0x0000000189B850F0-0x0000000189B85110
	private static void OnPostInitEmpty(ConfigAIWanderSetting data) {} // 0x0000000181361630-0x0000000181361710
	// [XID] // 0x0000000189B8BF20-0x0000000189B8BF40
	private static void OnPostProcessDataCallback(ConfigAIWanderSetting data, bool useObjectPool) {} // 0x0000000181361FD0-0x00000001813621A0
	[BlackList] // 0x0000000189B936F0-0x0000000189B93730
	// [XID] // 0x0000000189B936F0-0x0000000189B93730
	public override void AutoAllocTypeFields() {} // 0x0000000181360440-0x00000001813604E0
	[BlackList] // 0x0000000189B9D980-0x0000000189B9D9C0
	// [XID] // 0x0000000189B9D980-0x0000000189B9D9C0
	public override void AutoRecycleTypeFields() {} // 0x00000001813604E0-0x0000000181360640
	[BlackList] // 0x0000000189BA8070-0x0000000189BA80B0
	// [XID] // 0x0000000189BA8070-0x0000000189BA80B0
	public override void ReturnToObjectPool() {} // 0x0000000181362CD0-0x0000000181362D70
}

