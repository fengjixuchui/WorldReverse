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
public class ConfigAIFindBackSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17453
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFindBackData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIFindBackData> _specification; // 0x30

	// Properties
	public ConfigAIFindBackData defaultSetting { /* [XID] */ /* 0x0000000189B19590-0x0000000189B195B0 */ get => default; /* [XID] */ /* 0x0000000189B20BD0-0x0000000189B20BF0 */ private set {} } // 0x0000000181DF7DA0-0x0000000181DF7E40 0x0000000181DF5BE0-0x0000000181DF5C90
	public Dictionary<SimpleSafeInt32, ConfigAIFindBackData> specification { /* [XID] */ /* 0x0000000189B28370-0x0000000189B28390 */ get => default; /* [XID] */ /* 0x0000000189B2F6D0-0x0000000189B2F6F0 */ private set {} } // 0x0000000181DF6290-0x0000000181DF6330 0x0000000181DF7800-0x0000000181DF78B0

	// Constructors
	public ConfigAIFindBackSetting() {} // 0x0000000181DF82E0-0x0000000181DF8360

	// Methods
	// [XID] // 0x0000000189B36F70-0x0000000189B36F90
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181DF8120-0x0000000181DF8240
	// [XID] // 0x0000000189B3E840-0x0000000189B3E860
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181DF7CA0-0x0000000181DF7DA0
	// [XID] // 0x0000000189B46300-0x0000000189B46320
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F1D */) => default; // 0x0000000181DF78B0-0x0000000181DF7990
	// [XID] // 0x0000000189B4D840-0x0000000189B4D860
	public override int GetHashNum() => default; // 0x0000000181DF6640-0x0000000181DF6710
	// [XID] // 0x0000000189B550B0-0x0000000189B550D0
	public override void InitEmpty() {} // 0x0000000181DF7240-0x0000000181DF7330
	[BlackList] // 0x0000000189B5CAB0-0x0000000189B5CAF0
	// [XID] // 0x0000000189B5CAB0-0x0000000189B5CAF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181DF6C30-0x0000000181DF6FB0
	// [XID] // 0x0000000189B67340-0x0000000189B67360
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181DF5C90-0x0000000181DF5FC0
	[BlackList] // 0x0000000189B6E5A0-0x0000000189B6E5E0
	// [XID] // 0x0000000189B6E5A0-0x0000000189B6E5E0
	public static new ConfigAIFindBackSetting ParseFromJson(JSONNode node) => default; // 0x0000000181DF79F0-0x0000000181DF7C40
	// [XID] // 0x0000000189B78D80-0x0000000189B78DA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F1E */, bool useObjectPool = false /* Metadata: 0x00AF6F22 */) => default; // 0x0000000181DF7500-0x0000000181DF7800
	// [XID] // 0x0000000189B80290-0x0000000189B802B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F23 */, bool useObjectPool = false /* Metadata: 0x00AF6F27 */) => default; // 0x0000000181DF67F0-0x0000000181DF6B30
	// [XID] // 0x0000000189B87D60-0x0000000189B87D80
	public static new ConfigAIFindBackSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F28 */, bool useObjectPool = false /* Metadata: 0x00AF6F2C */) => default; // 0x0000000181DF6FB0-0x0000000181DF71D0
	[BlackList] // 0x0000000189B8EF50-0x0000000189B8EF90
	// [XID] // 0x0000000189B8EF50-0x0000000189B8EF90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181DF5FC0-0x0000000181DF6290
	// [XID] // 0x0000000189B994A0-0x0000000189B994C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181DF7E40-0x0000000181DF8120
	[BlackList] // 0x0000000189BA0930-0x0000000189BA0970
	// [XID] // 0x0000000189BA0930-0x0000000189BA0970
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181DF7410-0x0000000181DF7500
	[BlackList] // 0x0000000189BAAFA0-0x0000000189BAAFE0
	// [XID] // 0x0000000189BAAFA0-0x0000000189BAAFE0
	public override void AutoAllocTypeFields() {} // 0x0000000181DF6330-0x0000000181DF63D0
	[BlackList] // 0x0000000189BB53B0-0x0000000189BB53F0
	// [XID] // 0x0000000189BB53B0-0x0000000189BB53F0
	public override void AutoRecycleTypeFields() {} // 0x0000000181DF63D0-0x0000000181DF6520
	[BlackList] // 0x0000000189BBF990-0x0000000189BBF9D0
	// [XID] // 0x0000000189BBF990-0x0000000189BBF9D0
	public override void ReturnToObjectPool() {} // 0x0000000181DF8240-0x0000000181DF82E0
}

