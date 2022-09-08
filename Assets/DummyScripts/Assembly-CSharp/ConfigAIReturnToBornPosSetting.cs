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
public class ConfigAIReturnToBornPosSetting : ConfigAITacticBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17418
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIReturnToBornPosData _defaultSetting; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeInt32, ConfigAIReturnToBornPosData> _specification; // 0x30

	// Properties
	public ConfigAIReturnToBornPosData defaultSetting { /* [XID] */ /* 0x00000001898F95D0-0x00000001898F95F0 */ get => default; /* [XID] */ /* 0x0000000189900FD0-0x0000000189900FF0 */ private set {} } // 0x00000001828EE770-0x00000001828EE810 0x00000001828EC5B0-0x00000001828EC660
	public Dictionary<SimpleSafeInt32, ConfigAIReturnToBornPosData> specification { /* [XID] */ /* 0x0000000189908810-0x0000000189908830 */ get => default; /* [XID] */ /* 0x000000018990FDF0-0x000000018990FE10 */ private set {} } // 0x00000001828ECC60-0x00000001828ECD00 0x00000001828EE1D0-0x00000001828EE280

	// Constructors
	public ConfigAIReturnToBornPosSetting() {} // 0x00000001828EECB0-0x00000001828EED30

	// Methods
	// [XID] // 0x0000000189917A00-0x0000000189917A20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828EEAF0-0x00000001828EEC10
	// [XID] // 0x000000018991EF60-0x000000018991EF80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001828EE670-0x00000001828EE770
	// [XID] // 0x00000001899269A0-0x00000001899269C0
	public override ConfigAITacticBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6DEB */) => default; // 0x00000001828EE280-0x00000001828EE360
	// [XID] // 0x000000018992DF90-0x000000018992DFB0
	public override int GetHashNum() => default; // 0x00000001828ED010-0x00000001828ED0E0
	// [XID] // 0x0000000189935310-0x0000000189935330
	public override void InitEmpty() {} // 0x00000001828EDC10-0x00000001828EDD00
	[BlackList] // 0x000000018993CE70-0x000000018993CEB0
	// [XID] // 0x000000018993CE70-0x000000018993CEB0
	public override bool FromJson(JSONNode node) => default; // 0x00000001828ED600-0x00000001828ED980
	// [XID] // 0x0000000189947380-0x00000001899473A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001828EC660-0x00000001828EC990
	[BlackList] // 0x000000018994EAC0-0x000000018994EB00
	// [XID] // 0x000000018994EAC0-0x000000018994EB00
	public static new ConfigAIReturnToBornPosSetting ParseFromJson(JSONNode node) => default; // 0x00000001828EE3C0-0x00000001828EE610
	// [XID] // 0x00000001899591F0-0x0000000189959210
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DEC */, bool useObjectPool = false /* Metadata: 0x00AF6DF0 */) => default; // 0x00000001828EDED0-0x00000001828EE1D0
	// [XID] // 0x0000000189960A60-0x0000000189960A80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DF1 */, bool useObjectPool = false /* Metadata: 0x00AF6DF5 */) => default; // 0x00000001828ED1C0-0x00000001828ED500
	// [XID] // 0x0000000189968220-0x0000000189968240
	public static new ConfigAIReturnToBornPosSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6DF6 */, bool useObjectPool = false /* Metadata: 0x00AF6DFA */) => default; // 0x00000001828ED980-0x00000001828EDBA0
	[BlackList] // 0x000000018996F620-0x000000018996F660
	// [XID] // 0x000000018996F620-0x000000018996F660
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001828EC990-0x00000001828ECC60
	// [XID] // 0x000000018997A470-0x000000018997A490
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828EE810-0x00000001828EEAF0
	[BlackList] // 0x0000000189981CA0-0x0000000189981CE0
	// [XID] // 0x0000000189981CA0-0x0000000189981CE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001828EDDE0-0x00000001828EDED0
	[BlackList] // 0x000000018998C350-0x000000018998C390
	// [XID] // 0x000000018998C350-0x000000018998C390
	public override void AutoAllocTypeFields() {} // 0x00000001828ECD00-0x00000001828ECDA0
	[BlackList] // 0x0000000189996F40-0x0000000189996F80
	// [XID] // 0x0000000189996F40-0x0000000189996F80
	public override void AutoRecycleTypeFields() {} // 0x00000001828ECDA0-0x00000001828ECEF0
	[BlackList] // 0x00000001899A1AB0-0x00000001899A1AF0
	// [XID] // 0x00000001899A1AB0-0x00000001899A1AF0
	public override void ReturnToObjectPool() {} // 0x00000001828EEC10-0x00000001828EECB0
}

