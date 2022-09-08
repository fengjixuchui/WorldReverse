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
public class ConfigAISpacialProbeSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17468
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAISpacialProbeData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAISpacialProbeData> _specification; // 0x30

	// Properties
	public ConfigAISpacialProbeData defaultSetting { /* [XID] */ /* 0x0000000189830A40-0x0000000189830A60 */ get => default; /* [XID] */ /* 0x0000000189837FC0-0x0000000189837FE0 */ private set {} } // 0x0000000182EDAC80-0x0000000182EDAD20 0x0000000182ED8AC0-0x0000000182ED8B70
	public Dictionary<SimpleSafeInt32, ConfigAISpacialProbeData> specification { /* [XID] */ /* 0x000000018983F770-0x000000018983F790 */ get => default; /* [XID] */ /* 0x0000000189846DF0-0x0000000189846E10 */ private set {} } // 0x0000000182ED9170-0x0000000182ED9210 0x0000000182EDA6E0-0x0000000182EDA790

	// Constructors
	public ConfigAISpacialProbeSetting() {} // 0x0000000182EDB1C0-0x0000000182EDB240

	// Methods
	// [XID] // 0x000000018984E380-0x000000018984E3A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EDB000-0x0000000182EDB120
	// [XID] // 0x0000000189855590-0x00000001898555B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182EDAB80-0x0000000182EDAC80
	// [XID] // 0x000000018985CAD0-0x000000018985CAF0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6F9F */) => default; // 0x0000000182EDA790-0x0000000182EDA870
	// [XID] // 0x0000000189864450-0x0000000189864470
	public override int GetHashNum() => default; // 0x0000000182ED9520-0x0000000182ED95F0
	// [XID] // 0x000000018986B940-0x000000018986B960
	public override void InitEmpty() {} // 0x0000000182EDA120-0x0000000182EDA210
	[BlackList] // 0x0000000189872C30-0x0000000189872C70
	// [XID] // 0x0000000189872C30-0x0000000189872C70
	public override bool FromJson(JSONNode node) => default; // 0x0000000182ED9B10-0x0000000182ED9E90
	// [XID] // 0x000000018987D8E0-0x000000018987D900
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182ED8B70-0x0000000182ED8EA0
	[BlackList] // 0x00000001898847F0-0x0000000189884830
	// [XID] // 0x00000001898847F0-0x0000000189884830
	public static new ConfigAISpacialProbeSetting ParseFromJson(JSONNode node) => default; // 0x0000000182EDA8D0-0x0000000182EDAB20
	// [XID] // 0x000000018988EC20-0x000000018988EC40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FA0 */, bool useObjectPool = false /* Metadata: 0x00AF6FA4 */) => default; // 0x0000000182EDA3E0-0x0000000182EDA6E0
	// [XID] // 0x0000000189896140-0x0000000189896160
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FA5 */, bool useObjectPool = false /* Metadata: 0x00AF6FA9 */) => default; // 0x0000000182ED96D0-0x0000000182ED9A10
	// [XID] // 0x000000018989D740-0x000000018989D760
	public static new ConfigAISpacialProbeSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6FAA */, bool useObjectPool = false /* Metadata: 0x00AF6FAE */) => default; // 0x0000000182ED9E90-0x0000000182EDA0B0
	[BlackList] // 0x00000001898A5140-0x00000001898A5180
	// [XID] // 0x00000001898A5140-0x00000001898A5180
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ED8EA0-0x0000000182ED9170
	// [XID] // 0x00000001898AF7F0-0x00000001898AF810
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182EDAD20-0x0000000182EDB000
	[BlackList] // 0x00000001898B6D90-0x00000001898B6DD0
	// [XID] // 0x00000001898B6D90-0x00000001898B6DD0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182EDA2F0-0x0000000182EDA3E0
	[BlackList] // 0x00000001898C15C0-0x00000001898C1600
	// [XID] // 0x00000001898C15C0-0x00000001898C1600
	public override void AutoAllocTypeFields() {} // 0x0000000182ED9210-0x0000000182ED92B0
	[BlackList] // 0x00000001898CBCD0-0x00000001898CBD10
	// [XID] // 0x00000001898CBCD0-0x00000001898CBD10
	public override void AutoRecycleTypeFields() {} // 0x0000000182ED92B0-0x0000000182ED9400
	[BlackList] // 0x00000001898D66E0-0x00000001898D6720
	// [XID] // 0x00000001898D66E0-0x00000001898D6720
	public override void ReturnToObjectPool() {} // 0x0000000182EDB120-0x0000000182EDB1C0
}

