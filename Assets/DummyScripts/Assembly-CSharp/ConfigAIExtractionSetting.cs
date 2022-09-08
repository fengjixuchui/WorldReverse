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
public class ConfigAIExtractionSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17483
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIExtractionData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIExtractionData> _specification; // 0x30

	// Properties
	public ConfigAIExtractionData defaultSetting { /* [XID] */ /* 0x00000001899A01D0-0x00000001899A01F0 */ get => default; /* [XID] */ /* 0x00000001899A7D20-0x00000001899A7D40 */ private set {} } // 0x0000000182F86F00-0x0000000182F86FA0 0x0000000182F84D40-0x0000000182F84DF0
	public Dictionary<SimpleSafeInt32, ConfigAIExtractionData> specification { /* [XID] */ /* 0x00000001899AF4F0-0x00000001899AF510 */ get => default; /* [XID] */ /* 0x00000001899B6990-0x00000001899B69B0 */ private set {} } // 0x0000000182F853F0-0x0000000182F85490 0x0000000182F86960-0x0000000182F86A10

	// Constructors
	public ConfigAIExtractionSetting() {} // 0x0000000182F87440-0x0000000182F874C0

	// Methods
	// [XID] // 0x00000001899BE490-0x00000001899BE4B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F87280-0x0000000182F873A0
	// [XID] // 0x00000001899C5C30-0x00000001899C5C50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182F86E00-0x0000000182F86F00
	// [XID] // 0x00000001899CD3B0-0x00000001899CD3D0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF7021 */) => default; // 0x0000000182F86A10-0x0000000182F86AF0
	// [XID] // 0x00000001899D4830-0x00000001899D4850
	public override int GetHashNum() => default; // 0x0000000182F857A0-0x0000000182F85870
	// [XID] // 0x00000001899DBED0-0x00000001899DBEF0
	public override void InitEmpty() {} // 0x0000000182F863A0-0x0000000182F86490
	[BlackList] // 0x00000001899E38D0-0x00000001899E3910
	// [XID] // 0x00000001899E38D0-0x00000001899E3910
	public override bool FromJson(JSONNode node) => default; // 0x0000000182F85D90-0x0000000182F86110
	// [XID] // 0x00000001899EDEC0-0x00000001899EDEE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182F84DF0-0x0000000182F85120
	[BlackList] // 0x00000001899F56F0-0x00000001899F5730
	// [XID] // 0x00000001899F56F0-0x00000001899F5730
	public static new ConfigAIExtractionSetting ParseFromJson(JSONNode node) => default; // 0x0000000182F86B50-0x0000000182F86DA0
	// [XID] // 0x00000001899FFBC0-0x00000001899FFBE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7022 */, bool useObjectPool = false /* Metadata: 0x00AF7026 */) => default; // 0x0000000182F86660-0x0000000182F86960
	// [XID] // 0x0000000189A07450-0x0000000189A07470
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7027 */, bool useObjectPool = false /* Metadata: 0x00AF702B */) => default; // 0x0000000182F85950-0x0000000182F85C90
	// [XID] // 0x0000000189A0E910-0x0000000189A0E930
	public static new ConfigAIExtractionSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF702C */, bool useObjectPool = false /* Metadata: 0x00AF7030 */) => default; // 0x0000000182F86110-0x0000000182F86330
	[BlackList] // 0x0000000189A16040-0x0000000189A16080
	// [XID] // 0x0000000189A16040-0x0000000189A16080
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F85120-0x0000000182F853F0
	// [XID] // 0x0000000189A20550-0x0000000189A20570
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F86FA0-0x0000000182F87280
	[BlackList] // 0x0000000189A27A00-0x0000000189A27A40
	// [XID] // 0x0000000189A27A00-0x0000000189A27A40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182F86570-0x0000000182F86660
	[BlackList] // 0x0000000189A31EA0-0x0000000189A31EE0
	// [XID] // 0x0000000189A31EA0-0x0000000189A31EE0
	public override void AutoAllocTypeFields() {} // 0x0000000182F85490-0x0000000182F85530
	[BlackList] // 0x0000000189A3C680-0x0000000189A3C6C0
	// [XID] // 0x0000000189A3C680-0x0000000189A3C6C0
	public override void AutoRecycleTypeFields() {} // 0x0000000182F85530-0x0000000182F85680
	[BlackList] // 0x0000000189A46F90-0x0000000189A46FD0
	// [XID] // 0x0000000189A46F90-0x0000000189A46FD0
	public override void ReturnToObjectPool() {} // 0x0000000182F873A0-0x0000000182F87440
}

