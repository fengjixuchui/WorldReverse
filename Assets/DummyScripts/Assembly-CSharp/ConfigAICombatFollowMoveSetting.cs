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
public class ConfigAICombatFollowMoveSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17440
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAICombatFollowMoveData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAICombatFollowMoveData> _specification; // 0x30

	// Properties
	public ConfigAICombatFollowMoveData defaultSetting { /* [XID] */ /* 0x000000018995C160-0x000000018995C180 */ get => default; /* [XID] */ /* 0x0000000189963B40-0x0000000189963B60 */ private set {} } // 0x00000001825455C0-0x0000000182545660 0x0000000182543400-0x00000001825434B0
	public Dictionary<SimpleSafeInt32, ConfigAICombatFollowMoveData> specification { /* [XID] */ /* 0x000000018996B0D0-0x000000018996B0F0 */ get => default; /* [XID] */ /* 0x0000000189972B70-0x0000000189972B90 */ private set {} } // 0x0000000182543AB0-0x0000000182543B50 0x0000000182545020-0x00000001825450D0

	// Constructors
	public ConfigAICombatFollowMoveSetting() {} // 0x0000000182545B00-0x0000000182545B80

	// Methods
	// [XID] // 0x000000018997A450-0x000000018997A470
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182545940-0x0000000182545A60
	// [XID] // 0x0000000189981C80-0x0000000189981CA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825454C0-0x00000001825455C0
	// [XID] // 0x00000001899895C0-0x00000001899895E0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6EAB */) => default; // 0x00000001825450D0-0x00000001825451B0
	// [XID] // 0x0000000189990E10-0x0000000189990E30
	public override int GetHashNum() => default; // 0x0000000182543E60-0x0000000182543F30
	// [XID] // 0x0000000189998890-0x00000001899988B0
	public override void InitEmpty() {} // 0x0000000182544A60-0x0000000182544B50
	[BlackList] // 0x00000001899A01F0-0x00000001899A0230
	// [XID] // 0x00000001899A01F0-0x00000001899A0230
	public override bool FromJson(JSONNode node) => default; // 0x0000000182544450-0x00000001825447D0
	// [XID] // 0x00000001899AABC0-0x00000001899AABE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825434B0-0x00000001825437E0
	[BlackList] // 0x00000001899B2590-0x00000001899B25D0
	// [XID] // 0x00000001899B2590-0x00000001899B25D0
	public static new ConfigAICombatFollowMoveSetting ParseFromJson(JSONNode node) => default; // 0x0000000182545210-0x0000000182545460
	// [XID] // 0x00000001899BCA90-0x00000001899BCAB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EAC */, bool useObjectPool = false /* Metadata: 0x00AF6EB0 */) => default; // 0x0000000182544D20-0x0000000182545020
	// [XID] // 0x00000001899C4480-0x00000001899C44A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EB1 */, bool useObjectPool = false /* Metadata: 0x00AF6EB5 */) => default; // 0x0000000182544010-0x0000000182544350
	// [XID] // 0x00000001899CBD00-0x00000001899CBD20
	public static new ConfigAICombatFollowMoveSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6EB6 */, bool useObjectPool = false /* Metadata: 0x00AF6EBA */) => default; // 0x00000001825447D0-0x00000001825449F0
	[BlackList] // 0x00000001899D3210-0x00000001899D3250
	// [XID] // 0x00000001899D3210-0x00000001899D3250
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825437E0-0x0000000182543AB0
	// [XID] // 0x00000001899DD600-0x00000001899DD620
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182545660-0x0000000182545940
	[BlackList] // 0x00000001899E52E0-0x00000001899E5320
	// [XID] // 0x00000001899E52E0-0x00000001899E5320
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182544C30-0x0000000182544D20
	[BlackList] // 0x00000001899EF650-0x00000001899EF690
	// [XID] // 0x00000001899EF650-0x00000001899EF690
	public override void AutoAllocTypeFields() {} // 0x0000000182543B50-0x0000000182543BF0
	[BlackList] // 0x00000001899F9DB0-0x00000001899F9DF0
	// [XID] // 0x00000001899F9DB0-0x00000001899F9DF0
	public override void AutoRecycleTypeFields() {} // 0x0000000182543BF0-0x0000000182543D40
	[BlackList] // 0x0000000189A042D0-0x0000000189A04310
	// [XID] // 0x0000000189A042D0-0x0000000189A04310
	public override void ReturnToObjectPool() {} // 0x0000000182545A60-0x0000000182545B00
}

