/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using MoleMole.Audio.Music.Miiha;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigMusicNegativeCondition : ConfigMusicCondition, IAutoAllocRecycle // TypeDefIndex: 18648
{
	// Fields
	private SimpleSafeInt32 innerIdRawNum; // 0x18

	// Properties
	public int innerId { /* [XID] */ /* 0x000000018994B8C0-0x000000018994B8E0 */ get => default; /* [XID] */ /* 0x00000001899530D0-0x00000001899530F0 */ private set {} } // 0x0000000181724D50-0x0000000181724E20 0x0000000181724C70-0x0000000181724D50

	// Constructors
	public ConfigMusicNegativeCondition() {} // 0x00000001817251E0-0x0000000181725240

	// Methods
	// [XID] // 0x000000018995A7B0-0x000000018995A7D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181725050-0x0000000181725140
	// [XID] // 0x00000001899622D0-0x00000001899622F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181724BC0-0x0000000181724C70
	// [XID] // 0x0000000189969740-0x0000000189969760
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA7AB */) => default; // 0x00000001817247D0-0x00000001817248B0
	// [XID] // 0x0000000189971480-0x00000001899714A0
	public override int GetHashNum() => default; // 0x0000000181723590-0x0000000181723660
	// [XID] // 0x0000000189978E30-0x0000000189978E50
	public override void InitEmpty() {} // 0x0000000181724230-0x0000000181724300
	[BlackList] // 0x000000018997FF20-0x000000018997FF60
	// [XID] // 0x000000018997FF20-0x000000018997FF60
	public override bool FromJson(JSONNode node) => default; // 0x0000000181723BA0-0x0000000181723F20
	// [XID] // 0x000000018998AAE0-0x000000018998AB00
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181722C20-0x0000000181722E80
	[BlackList] // 0x00000001899923F0-0x0000000189992430
	// [XID] // 0x00000001899923F0-0x0000000189992430
	public static new ConfigMusicNegativeCondition ParseFromJson(JSONNode node) => default; // 0x0000000181724910-0x0000000181724B60
	// [XID] // 0x000000018999CFF0-0x000000018999D010
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7AC */, bool useObjectPool = false /* Metadata: 0x00AFA7B0 */) => default; // 0x00000001817244D0-0x00000001817247D0
	// [XID] // 0x00000001899A4950-0x00000001899A4970
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7B1 */, bool useObjectPool = false /* Metadata: 0x00AFA7B5 */) => default; // 0x0000000181723830-0x0000000181723AA0
	// [XID] // 0x00000001899AC350-0x00000001899AC370
	public static new ConfigMusicNegativeCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7B6 */, bool useObjectPool = false /* Metadata: 0x00AFA7BA */) => default; // 0x0000000181723FA0-0x00000001817241C0
	[BlackList] // 0x00000001899B3B40-0x00000001899B3B80
	// [XID] // 0x00000001899B3B40-0x00000001899B3B80
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181722E80-0x0000000181723150
	// [XID] // 0x00000001899BE230-0x00000001899BE250
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181724E20-0x0000000181725050
	[BlackList] // 0x00000001899C5A10-0x00000001899C5A50
	// [XID] // 0x00000001899C5A10-0x00000001899C5A50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001817243E0-0x00000001817244D0
	// [XID] // 0x00000001899D0190-0x00000001899D01B0
	public override MusicGameParam GetMusicGameParam(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup) => default; // 0x0000000181723660-0x0000000181723750
	// [XID] // 0x00000001899D75F0-0x00000001899D7610
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x0000000181723400-0x0000000181723510
	[BlackList] // 0x00000001899DE9F0-0x00000001899DEA30
	// [XID] // 0x00000001899DE9F0-0x00000001899DEA30
	public override void AutoAllocTypeFields() {} // 0x00000001817231E0-0x0000000181723280
	[BlackList] // 0x00000001899E9340-0x00000001899E9380
	// [XID] // 0x00000001899E9340-0x00000001899E9380
	public override void AutoRecycleTypeFields() {} // 0x0000000181723280-0x0000000181723360
	[BlackList] // 0x00000001899F3F90-0x00000001899F3FD0
	// [XID] // 0x00000001899F3F90-0x00000001899F3FD0
	public override void ReturnToObjectPool() {} // 0x0000000181725140-0x00000001817251E0
}

