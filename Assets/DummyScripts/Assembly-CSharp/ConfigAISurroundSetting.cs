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
public class ConfigAISurroundSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17450
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISurroundData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAISurroundData> _specification; // 0x30

	// Properties
	public ConfigAISurroundData defaultSetting { /* [XID] */ /* 0x0000000189979070-0x0000000189979090 */ get => default; /* [XID] */ /* 0x0000000189980160-0x0000000189980180 */ private set {} } // 0x0000000182567800-0x00000001825678A0 0x0000000182565640-0x00000001825656F0
	public Dictionary<SimpleSafeInt32, ConfigAISurroundData> specification { /* [XID] */ /* 0x0000000189987910-0x0000000189987930 */ get => default; /* [XID] */ /* 0x000000018998F520-0x000000018998F540 */ private set {} } // 0x0000000182565CF0-0x0000000182565D90 0x0000000182567260-0x0000000182567310

	// Constructors
	public ConfigAISurroundSetting() {} // 0x0000000182567D40-0x0000000182567DC0

	// Methods
	// [XID] // 0x0000000189996F20-0x0000000189996F40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182567B80-0x0000000182567CA0
	// [XID] // 0x000000018999EAB0-0x000000018999EAD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182567700-0x0000000182567800
	// [XID] // 0x00000001899A6490-0x00000001899A64B0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F03 */) => default; // 0x0000000182567310-0x00000001825673F0
	// [XID] // 0x00000001899ADB80-0x00000001899ADBA0
	public override int GetHashNum() => default; // 0x00000001825660A0-0x0000000182566170
	// [XID] // 0x00000001899B53C0-0x00000001899B53E0
	public override void InitEmpty() {} // 0x0000000182566CA0-0x0000000182566D90
	[BlackList] // 0x00000001899BCA50-0x00000001899BCA90
	// [XID] // 0x00000001899BCA50-0x00000001899BCA90
	public override bool FromJson(JSONNode node) => default; // 0x0000000182566690-0x0000000182566A10
	// [XID] // 0x00000001899C73D0-0x00000001899C73F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825656F0-0x0000000182565A20
	[BlackList] // 0x00000001899CE960-0x00000001899CE9A0
	// [XID] // 0x00000001899CE960-0x00000001899CE9A0
	public static new ConfigAISurroundSetting ParseFromJson(JSONNode node) => default; // 0x0000000182567450-0x00000001825676A0
	// [XID] // 0x00000001899D8EF0-0x00000001899D8F10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F04 */, bool useObjectPool = false /* Metadata: 0x00AF6F08 */) => default; // 0x0000000182566F60-0x0000000182567260
	// [XID] // 0x00000001899E05A0-0x00000001899E05C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F09 */, bool useObjectPool = false /* Metadata: 0x00AF6F0D */) => default; // 0x0000000182566250-0x0000000182566590
	// [XID] // 0x00000001899E8160-0x00000001899E8180
	public static new ConfigAISurroundSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F0E */, bool useObjectPool = false /* Metadata: 0x00AF6F12 */) => default; // 0x0000000182566A10-0x0000000182566C30
	[BlackList] // 0x00000001899EF610-0x00000001899EF650
	// [XID] // 0x00000001899EF610-0x00000001899EF650
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182565A20-0x0000000182565CF0
	// [XID] // 0x00000001899F9D90-0x00000001899F9DB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825678A0-0x0000000182567B80
	[BlackList] // 0x0000000189A01170-0x0000000189A011B0
	// [XID] // 0x0000000189A01170-0x0000000189A011B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182566E70-0x0000000182566F60
	[BlackList] // 0x0000000189A0BA10-0x0000000189A0BA50
	// [XID] // 0x0000000189A0BA10-0x0000000189A0BA50
	public override void AutoAllocTypeFields() {} // 0x0000000182565D90-0x0000000182565E30
	[BlackList] // 0x0000000189A16080-0x0000000189A160C0
	// [XID] // 0x0000000189A16080-0x0000000189A160C0
	public override void AutoRecycleTypeFields() {} // 0x0000000182565E30-0x0000000182565F80
	[BlackList] // 0x0000000189A20570-0x0000000189A205B0
	// [XID] // 0x0000000189A20570-0x0000000189A205B0
	public override void ReturnToObjectPool() {} // 0x0000000182567CA0-0x0000000182567D40
}

