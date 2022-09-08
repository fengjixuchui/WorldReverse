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
public class ConfigAIFleeSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17462
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIFleeData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIFleeData> _specification; // 0x30

	// Properties
	public ConfigAIFleeData defaultSetting { /* [XID] */ /* 0x0000000189AA0DE0-0x0000000189AA0E00 */ get => default; /* [XID] */ /* 0x0000000189AA8480-0x0000000189AA84A0 */ private set {} } // 0x0000000181A20150-0x0000000181A201F0 0x0000000181A1DF90-0x0000000181A1E040
	public Dictionary<SimpleSafeInt32, ConfigAIFleeData> specification { /* [XID] */ /* 0x0000000189AB0180-0x0000000189AB01A0 */ get => default; /* [XID] */ /* 0x0000000189AB78F0-0x0000000189AB7910 */ private set {} } // 0x0000000181A1E640-0x0000000181A1E6E0 0x0000000181A1FBB0-0x0000000181A1FC60

	// Constructors
	public ConfigAIFleeSetting() {} // 0x0000000181A20690-0x0000000181A20710

	// Methods
	// [XID] // 0x0000000189ABF350-0x0000000189ABF370
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181A204D0-0x0000000181A205F0
	// [XID] // 0x0000000189AC6DE0-0x0000000189AC6E00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181A20050-0x0000000181A20150
	// [XID] // 0x0000000189ACE550-0x0000000189ACE570
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F6B */) => default; // 0x0000000181A1FC60-0x0000000181A1FD40
	// [XID] // 0x0000000189AD6420-0x0000000189AD6440
	public override int GetHashNum() => default; // 0x0000000181A1E9F0-0x0000000181A1EAC0
	// [XID] // 0x0000000189ADDC80-0x0000000189ADDCA0
	public override void InitEmpty() {} // 0x0000000181A1F5F0-0x0000000181A1F6E0
	[BlackList] // 0x0000000189AE5620-0x0000000189AE5660
	// [XID] // 0x0000000189AE5620-0x0000000189AE5660
	public override bool FromJson(JSONNode node) => default; // 0x0000000181A1EFE0-0x0000000181A1F360
	// [XID] // 0x0000000189AF0130-0x0000000189AF0150
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181A1E040-0x0000000181A1E370
	[BlackList] // 0x0000000189AF75E0-0x0000000189AF7620
	// [XID] // 0x0000000189AF75E0-0x0000000189AF7620
	public static new ConfigAIFleeSetting ParseFromJson(JSONNode node) => default; // 0x0000000181A1FDA0-0x0000000181A1FFF0
	// [XID] // 0x0000000189B01CF0-0x0000000189B01D10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F6C */, bool useObjectPool = false /* Metadata: 0x00AF6F70 */) => default; // 0x0000000181A1F8B0-0x0000000181A1FBB0
	// [XID] // 0x0000000189B09270-0x0000000189B09290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F71 */, bool useObjectPool = false /* Metadata: 0x00AF6F75 */) => default; // 0x0000000181A1EBA0-0x0000000181A1EEE0
	// [XID] // 0x0000000189B10CD0-0x0000000189B10CF0
	public static new ConfigAIFleeSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6F76 */, bool useObjectPool = false /* Metadata: 0x00AF6F7A */) => default; // 0x0000000181A1F360-0x0000000181A1F580
	[BlackList] // 0x0000000189B17E80-0x0000000189B17EC0
	// [XID] // 0x0000000189B17E80-0x0000000189B17EC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181A1E370-0x0000000181A1E640
	// [XID] // 0x0000000189B22570-0x0000000189B22590
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181A201F0-0x0000000181A204D0
	[BlackList] // 0x0000000189B29A80-0x0000000189B29AC0
	// [XID] // 0x0000000189B29A80-0x0000000189B29AC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181A1F7C0-0x0000000181A1F8B0
	[BlackList] // 0x0000000189B33E40-0x0000000189B33E80
	// [XID] // 0x0000000189B33E40-0x0000000189B33E80
	public override void AutoAllocTypeFields() {} // 0x0000000181A1E6E0-0x0000000181A1E780
	[BlackList] // 0x0000000189B3E800-0x0000000189B3E840
	// [XID] // 0x0000000189B3E800-0x0000000189B3E840
	public override void AutoRecycleTypeFields() {} // 0x0000000181A1E780-0x0000000181A1E8D0
	[BlackList] // 0x0000000189B494A0-0x0000000189B494E0
	// [XID] // 0x0000000189B494A0-0x0000000189B494E0
	public override void ReturnToObjectPool() {} // 0x0000000181A205F0-0x0000000181A20690
}

