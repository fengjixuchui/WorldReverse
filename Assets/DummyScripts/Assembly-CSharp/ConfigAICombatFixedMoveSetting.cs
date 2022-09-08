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
public class ConfigAICombatFixedMoveSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17456
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICombatFixedMoveData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAICombatFixedMoveData> _specification; // 0x30

	// Properties
	public ConfigAICombatFixedMoveData defaultSetting { /* [XID] */ /* 0x00000001896CC4B0-0x00000001896CC4D0 */ get => default; /* [XID] */ /* 0x00000001896D36A0-0x00000001896D36C0 */ private set {} } // 0x0000000184512B10-0x0000000184512BB0 0x0000000184510950-0x0000000184510A00
	public Dictionary<SimpleSafeInt32, ConfigAICombatFixedMoveData> specification { /* [XID] */ /* 0x00000001896DB1A0-0x00000001896DB1C0 */ get => default; /* [XID] */ /* 0x00000001896E2900-0x00000001896E2920 */ private set {} } // 0x0000000184511000-0x00000001845110A0 0x0000000184512570-0x0000000184512620

	// Constructors
	public ConfigAICombatFixedMoveSetting() {} // 0x0000000184513050-0x00000001845130D0

	// Methods
	// [XID] // 0x00000001896E9F00-0x00000001896E9F20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184512E90-0x0000000184512FB0
	// [XID] // 0x00000001896F0FE0-0x00000001896F1000
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184512A10-0x0000000184512B10
	// [XID] // 0x00000001896F8840-0x00000001896F8860
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F37 */) => default; // 0x0000000184512620-0x0000000184512700
	// [XID] // 0x0000000189700160-0x0000000189700180
	public override int GetHashNum() => default; // 0x00000001845113B0-0x0000000184511480
	// [XID] // 0x00000001897078B0-0x00000001897078D0
	public override void InitEmpty() {} // 0x0000000184511FB0-0x00000001845120A0
	[BlackList] // 0x000000018970F2A0-0x000000018970F2E0
	// [XID] // 0x000000018970F2A0-0x000000018970F2E0
	public override bool FromJson(JSONNode node) => default; // 0x00000001845119A0-0x0000000184511D20
	// [XID] // 0x00000001897199F0-0x0000000189719A10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184510A00-0x0000000184510D30
	[BlackList] // 0x0000000189720F30-0x0000000189720F70
	// [XID] // 0x0000000189720F30-0x0000000189720F70
	public static new ConfigAICombatFixedMoveSetting ParseFromJson(JSONNode node) => default; // 0x0000000184512760-0x00000001845129B0
	// [XID] // 0x000000018972B3D0-0x000000018972B3F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F38 */, bool useObjectPool = false /* Metadata: 0x00AF6F3C */) => default; // 0x0000000184512270-0x0000000184512570
	// [XID] // 0x0000000189732BE0-0x0000000189732C00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F3D */, bool useObjectPool = false /* Metadata: 0x00AF6F41 */) => default; // 0x0000000184511560-0x00000001845118A0
	// [XID] // 0x000000018973A2F0-0x000000018973A310
	public static new ConfigAICombatFixedMoveSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F42 */, bool useObjectPool = false /* Metadata: 0x00AF6F46 */) => default; // 0x0000000184511D20-0x0000000184511F40
	[BlackList] // 0x0000000189741D80-0x0000000189741DC0
	// [XID] // 0x0000000189741D80-0x0000000189741DC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184510D30-0x0000000184511000
	// [XID] // 0x000000018974C860-0x000000018974C880
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184512BB0-0x0000000184512E90
	[BlackList] // 0x0000000189753B40-0x0000000189753B80
	// [XID] // 0x0000000189753B40-0x0000000189753B80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184512180-0x0000000184512270
	[BlackList] // 0x000000018975E030-0x000000018975E070
	// [XID] // 0x000000018975E030-0x000000018975E070
	public override void AutoAllocTypeFields() {} // 0x00000001845110A0-0x0000000184511140
	[BlackList] // 0x0000000189768760-0x00000001897687A0
	// [XID] // 0x0000000189768760-0x00000001897687A0
	public override void AutoRecycleTypeFields() {} // 0x0000000184511140-0x0000000184511290
	[BlackList] // 0x0000000189772E60-0x0000000189772EA0
	// [XID] // 0x0000000189772E60-0x0000000189772EA0
	public override void ReturnToObjectPool() {} // 0x0000000184512FB0-0x0000000184513050
}

