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
public class ConfigMusicDoubleCondition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18702
{
	// Fields
	private double _value; // 0x20

	// Properties
	public double value { /* [XID] */ /* 0x0000000189932340-0x0000000189932360 */ get => default; /* [XID] */ /* 0x0000000189939D30-0x0000000189939D50 */ private set {} } // 0x00000001827BFE80-0x00000001827BFF30 0x00000001827BFD50-0x00000001827BFE00

	// Constructors
	public ConfigMusicDoubleCondition() {} // 0x00000001827C12F0-0x00000001827C1350

	// Methods
	// [XID] // 0x0000000189940F20-0x0000000189940F40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827C1150-0x00000001827C1250
	// [XID] // 0x0000000189948A00-0x0000000189948A20
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001827C0EA0-0x00000001827C0F50
	// [XID] // 0x0000000189950150-0x0000000189950170
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA95B */) => default; // 0x00000001827C0AB0-0x00000001827C0B90
	// [XID] // 0x00000001899576A0-0x00000001899576C0
	public override int GetHashNum() => default; // 0x00000001827BF8F0-0x00000001827BF9C0
	// [XID] // 0x000000018995F0F0-0x000000018995F110
	public override void InitEmpty() {} // 0x00000001827C0540-0x00000001827C05E0
	[BlackList] // 0x0000000189966950-0x0000000189966990
	// [XID] // 0x0000000189966950-0x0000000189966990
	public override bool FromJson(JSONNode node) => default; // 0x00000001827BFF30-0x00000001827C02B0
	// [XID] // 0x0000000189971460-0x0000000189971480
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827BEF30-0x00000001827BF130
	[BlackList] // 0x0000000189978DF0-0x0000000189978E30
	// [XID] // 0x0000000189978DF0-0x0000000189978E30
	public static new ConfigMusicDoubleCondition ParseFromJson(JSONNode node) => default; // 0x00000001827C0BF0-0x00000001827C0E40
	// [XID] // 0x0000000189983330-0x0000000189983350
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA95C */, bool useObjectPool = false /* Metadata: 0x00AFA960 */) => default; // 0x00000001827C07B0-0x00000001827C0AB0
	// [XID] // 0x000000018998AAC0-0x000000018998AAE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA961 */, bool useObjectPool = false /* Metadata: 0x00AFA965 */) => default; // 0x00000001827BFAA0-0x00000001827BFCD0
	// [XID] // 0x00000001899923D0-0x00000001899923F0
	public static new ConfigMusicDoubleCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA966 */, bool useObjectPool = false /* Metadata: 0x00AFA96A */) => default; // 0x00000001827C02B0-0x00000001827C04D0
	[BlackList] // 0x000000018999A170-0x000000018999A1B0
	// [XID] // 0x000000018999A170-0x000000018999A1B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827BF130-0x00000001827BF400
	// [XID] // 0x00000001899A4930-0x00000001899A4950
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827C0F50-0x00000001827C1150
	[BlackList] // 0x00000001899AC310-0x00000001899AC350
	// [XID] // 0x00000001899AC310-0x00000001899AC350
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827C06C0-0x00000001827C07B0
	// [IDTag] // 0x00000001899B6630-0x00000001899B6670
	// [XID] // 0x00000001899B6630-0x00000001899B6670
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x00000001827BF680-0x00000001827BF7C0
	// [IDTag] // 0x00000001899C1170-0x00000001899C11B0
	// [XID] // 0x00000001899C1170-0x00000001899C11B0
	protected virtual bool IsMet(double paramValue) => default; // 0x00000001827BF7C0-0x00000001827BF870
	[BlackList] // 0x00000001899CB9C0-0x00000001899CBA00
	// [XID] // 0x00000001899CB9C0-0x00000001899CBA00
	public override void AutoAllocTypeFields() {} // 0x00000001827BF490-0x00000001827BF530
	[BlackList] // 0x00000001899D5EF0-0x00000001899D5F30
	// [XID] // 0x00000001899D5EF0-0x00000001899D5F30
	public override void AutoRecycleTypeFields() {} // 0x00000001827BF530-0x00000001827BF5E0
	[BlackList] // 0x00000001899E03E0-0x00000001899E0420
	// [XID] // 0x00000001899E03E0-0x00000001899E0420
	public override void ReturnToObjectPool() {} // 0x00000001827C1250-0x00000001827C12F0
}

