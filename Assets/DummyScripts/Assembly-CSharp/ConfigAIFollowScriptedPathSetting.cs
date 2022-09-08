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
public class ConfigAIFollowScriptedPathSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17424
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFollowScriptedPathData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIFollowScriptedPathData> _specification; // 0x30

	// Properties
	public ConfigAIFollowScriptedPathData defaultSetting { /* [XID] */ /* 0x0000000189688740-0x0000000189688760 */ get => default; /* [XID] */ /* 0x00000001896900E0-0x0000000189690100 */ private set {} } // 0x0000000183530E10-0x0000000183530EB0 0x000000018352EC50-0x000000018352ED00
	public Dictionary<SimpleSafeInt32, ConfigAIFollowScriptedPathData> specification { /* [XID] */ /* 0x0000000189697A60-0x0000000189697A80 */ get => default; /* [XID] */ /* 0x000000018969EE50-0x000000018969EE70 */ private set {} } // 0x000000018352F300-0x000000018352F3A0 0x0000000183530870-0x0000000183530920

	// Constructors
	public ConfigAIFollowScriptedPathSetting() {} // 0x0000000183531350-0x00000001835313D0

	// Methods
	// [XID] // 0x00000001896A6210-0x00000001896A6230
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183531190-0x00000001835312B0
	// [XID] // 0x00000001896AD6B0-0x00000001896AD6D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183530D10-0x0000000183530E10
	// [XID] // 0x00000001896B4E10-0x00000001896B4E30
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E1F */) => default; // 0x0000000183530920-0x0000000183530A00
	// [XID] // 0x00000001896BC140-0x00000001896BC160
	public override int GetHashNum() => default; // 0x000000018352F6B0-0x000000018352F780
	// [XID] // 0x00000001896C35C0-0x00000001896C35E0
	public override void InitEmpty() {} // 0x00000001835302B0-0x00000001835303A0
	[BlackList] // 0x00000001896CAB50-0x00000001896CAB90
	// [XID] // 0x00000001896CAB50-0x00000001896CAB90
	public override bool FromJson(JSONNode node) => default; // 0x000000018352FCA0-0x0000000183530020
	// [XID] // 0x00000001896D52C0-0x00000001896D52E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018352ED00-0x000000018352F030
	[BlackList] // 0x00000001896DC7E0-0x00000001896DC820
	// [XID] // 0x00000001896DC7E0-0x00000001896DC820
	public static new ConfigAIFollowScriptedPathSetting ParseFromJson(JSONNode node) => default; // 0x0000000183530A60-0x0000000183530CB0
	// [XID] // 0x00000001896E6E80-0x00000001896E6EA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E20 */, bool useObjectPool = false /* Metadata: 0x00AF6E24 */) => default; // 0x0000000183530570-0x0000000183530870
	// [XID] // 0x00000001896EE390-0x00000001896EE3B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E25 */, bool useObjectPool = false /* Metadata: 0x00AF6E29 */) => default; // 0x000000018352F860-0x000000018352FBA0
	// [XID] // 0x00000001896F5CA0-0x00000001896F5CC0
	public static new ConfigAIFollowScriptedPathSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E2A */, bool useObjectPool = false /* Metadata: 0x00AF6E2E */) => default; // 0x0000000183530020-0x0000000183530240
	[BlackList] // 0x00000001896FD4B0-0x00000001896FD4F0
	// [XID] // 0x00000001896FD4B0-0x00000001896FD4F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018352F030-0x000000018352F300
	// [XID] // 0x00000001897078D0-0x00000001897078F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183530EB0-0x0000000183531190
	[BlackList] // 0x000000018970F2E0-0x000000018970F320
	// [XID] // 0x000000018970F2E0-0x000000018970F320
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183530480-0x0000000183530570
	[BlackList] // 0x0000000189719A10-0x0000000189719A50
	// [XID] // 0x0000000189719A10-0x0000000189719A50
	public override void AutoAllocTypeFields() {} // 0x000000018352F3A0-0x000000018352F440
	[BlackList] // 0x0000000189723C90-0x0000000189723CD0
	// [XID] // 0x0000000189723C90-0x0000000189723CD0
	public override void AutoRecycleTypeFields() {} // 0x000000018352F440-0x000000018352F590
	[BlackList] // 0x000000018972E430-0x000000018972E470
	// [XID] // 0x000000018972E430-0x000000018972E470
	public override void ReturnToObjectPool() {} // 0x00000001835312B0-0x0000000183531350
}

