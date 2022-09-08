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
public class ConfigAIBirdCirclingSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17474
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIBirdCirclingData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIBirdCirclingData> _specification; // 0x30

	// Properties
	public ConfigAIBirdCirclingData defaultSetting { /* [XID] */ /* 0x0000000189B07970-0x0000000189B07990 */ get => default; /* [XID] */ /* 0x0000000189B0F1F0-0x0000000189B0F210 */ private set {} } // 0x000000018198A240-0x000000018198A2E0 0x0000000181988080-0x0000000181988130
	public Dictionary<SimpleSafeInt32, ConfigAIBirdCirclingData> specification { /* [XID] */ /* 0x0000000189B16510-0x0000000189B16530 */ get => default; /* [XID] */ /* 0x0000000189B1DC90-0x0000000189B1DCB0 */ private set {} } // 0x0000000181988730-0x00000001819887D0 0x0000000181989CA0-0x0000000181989D50

	// Constructors
	public ConfigAIBirdCirclingSetting() {} // 0x000000018198A780-0x000000018198A800

	// Methods
	// [XID] // 0x0000000189B254A0-0x0000000189B254C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018198A5C0-0x000000018198A6E0
	// [XID] // 0x0000000189B2CA50-0x0000000189B2CA70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018198A140-0x000000018198A240
	// [XID] // 0x0000000189B33E20-0x0000000189B33E40
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6FD3 */) => default; // 0x0000000181989D50-0x0000000181989E30
	// [XID] // 0x0000000189B3B750-0x0000000189B3B770
	public override int GetHashNum() => default; // 0x0000000181988AE0-0x0000000181988BB0
	// [XID] // 0x0000000189B43150-0x0000000189B43170
	public override void InitEmpty() {} // 0x00000001819896E0-0x00000001819897D0
	[BlackList] // 0x0000000189B4A9B0-0x0000000189B4A9F0
	// [XID] // 0x0000000189B4A9B0-0x0000000189B4A9F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001819890D0-0x0000000181989450
	// [XID] // 0x0000000189B55090-0x0000000189B550B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181988130-0x0000000181988460
	[BlackList] // 0x0000000189B5CA70-0x0000000189B5CAB0
	// [XID] // 0x0000000189B5CA70-0x0000000189B5CAB0
	public static new ConfigAIBirdCirclingSetting ParseFromJson(JSONNode node) => default; // 0x0000000181989E90-0x000000018198A0E0
	// [XID] // 0x0000000189B67320-0x0000000189B67340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FD4 */, bool useObjectPool = false /* Metadata: 0x00AF6FD8 */) => default; // 0x00000001819899A0-0x0000000181989CA0
	// [XID] // 0x0000000189B6E580-0x0000000189B6E5A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FD9 */, bool useObjectPool = false /* Metadata: 0x00AF6FDD */) => default; // 0x0000000181988C90-0x0000000181988FD0
	// [XID] // 0x0000000189B75DD0-0x0000000189B75DF0
	public static new ConfigAIBirdCirclingSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FDE */, bool useObjectPool = false /* Metadata: 0x00AF6FE2 */) => default; // 0x0000000181989450-0x0000000181989670
	[BlackList] // 0x0000000189B7D300-0x0000000189B7D340
	// [XID] // 0x0000000189B7D300-0x0000000189B7D340
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181988460-0x0000000181988730
	// [XID] // 0x0000000189B87D20-0x0000000189B87D40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018198A2E0-0x000000018198A5C0
	[BlackList] // 0x0000000189B8EEF0-0x0000000189B8EF30
	// [XID] // 0x0000000189B8EEF0-0x0000000189B8EF30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001819898B0-0x00000001819899A0
	[BlackList] // 0x0000000189B99460-0x0000000189B994A0
	// [XID] // 0x0000000189B99460-0x0000000189B994A0
	public override void AutoAllocTypeFields() {} // 0x00000001819887D0-0x0000000181988870
	[BlackList] // 0x0000000189BA3B10-0x0000000189BA3B50
	// [XID] // 0x0000000189BA3B10-0x0000000189BA3B50
	public override void AutoRecycleTypeFields() {} // 0x0000000181988870-0x00000001819889C0
	[BlackList] // 0x0000000189BADC00-0x0000000189BADC40
	// [XID] // 0x0000000189BADC00-0x0000000189BADC40
	public override void ReturnToObjectPool() {} // 0x000000018198A6E0-0x000000018198A780
}

