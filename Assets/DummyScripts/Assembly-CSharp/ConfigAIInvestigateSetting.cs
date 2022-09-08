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
public class ConfigAIInvestigateSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17430
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIInvestigateData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIInvestigateData> _specification; // 0x30

	// Properties
	public ConfigAIInvestigateData defaultSetting { /* [XID] */ /* 0x000000018998AD80-0x000000018998ADA0 */ get => default; /* [XID] */ /* 0x0000000189992650-0x0000000189992670 */ private set {} } // 0x000000018125FE70-0x000000018125FF10 0x000000018125DCB0-0x000000018125DD60
	public Dictionary<SimpleSafeInt32, ConfigAIInvestigateData> specification { /* [XID] */ /* 0x000000018999A3F0-0x000000018999A410 */ get => default; /* [XID] */ /* 0x00000001899A1A90-0x00000001899A1AB0 */ private set {} } // 0x000000018125E360-0x000000018125E400 0x000000018125F8D0-0x000000018125F980

	// Constructors
	public ConfigAIInvestigateSetting() {} // 0x00000001812603B0-0x0000000181260430

	// Methods
	// [XID] // 0x00000001899A9320-0x00000001899A9340
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001812601F0-0x0000000181260310
	// [XID] // 0x00000001899B0DF0-0x00000001899B0E10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018125FD70-0x000000018125FE70
	// [XID] // 0x00000001899B80D0-0x00000001899B80F0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6E53 */) => default; // 0x000000018125F980-0x000000018125FA60
	// [XID] // 0x00000001899BFC50-0x00000001899BFC70
	public override int GetHashNum() => default; // 0x000000018125E710-0x000000018125E7E0
	// [XID] // 0x00000001899C73F0-0x00000001899C7410
	public override void InitEmpty() {} // 0x000000018125F310-0x000000018125F400
	[BlackList] // 0x00000001899CE9A0-0x00000001899CE9E0
	// [XID] // 0x00000001899CE9A0-0x00000001899CE9E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018125ED00-0x000000018125F080
	// [XID] // 0x00000001899D8F10-0x00000001899D8F30
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018125DD60-0x000000018125E090
	[BlackList] // 0x00000001899E05C0-0x00000001899E0600
	// [XID] // 0x00000001899E05C0-0x00000001899E0600
	public static new ConfigAIInvestigateSetting ParseFromJson(JSONNode node) => default; // 0x000000018125FAC0-0x000000018125FD10
	// [XID] // 0x00000001899EAC20-0x00000001899EAC40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E54 */, bool useObjectPool = false /* Metadata: 0x00AF6E58 */) => default; // 0x000000018125F5D0-0x000000018125F8D0
	// [XID] // 0x00000001899F28A0-0x00000001899F28C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E59 */, bool useObjectPool = false /* Metadata: 0x00AF6E5D */) => default; // 0x000000018125E8C0-0x000000018125EC00
	// [XID] // 0x00000001899F9DF0-0x00000001899F9E10
	public static new ConfigAIInvestigateSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E5E */, bool useObjectPool = false /* Metadata: 0x00AF6E62 */) => default; // 0x000000018125F080-0x000000018125F2A0
	[BlackList] // 0x0000000189A011B0-0x0000000189A011F0
	// [XID] // 0x0000000189A011B0-0x0000000189A011F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018125E090-0x000000018125E360
	// [XID] // 0x0000000189A0BA50-0x0000000189A0BA70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018125FF10-0x00000001812601F0
	[BlackList] // 0x0000000189A132E0-0x0000000189A13320
	// [XID] // 0x0000000189A132E0-0x0000000189A13320
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018125F4E0-0x000000018125F5D0
	[BlackList] // 0x0000000189A1D5E0-0x0000000189A1D620
	// [XID] // 0x0000000189A1D5E0-0x0000000189A1D620
	public override void AutoAllocTypeFields() {} // 0x000000018125E400-0x000000018125E4A0
	[BlackList] // 0x0000000189A27A40-0x0000000189A27A80
	// [XID] // 0x0000000189A27A40-0x0000000189A27A80
	public override void AutoRecycleTypeFields() {} // 0x000000018125E4A0-0x000000018125E5F0
	[BlackList] // 0x0000000189A31F00-0x0000000189A31F40
	// [XID] // 0x0000000189A31F00-0x0000000189A31F40
	public override void ReturnToObjectPool() {} // 0x0000000181260310-0x00000001812603B0
}

