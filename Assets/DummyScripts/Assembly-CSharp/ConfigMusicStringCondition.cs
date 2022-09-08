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
public class ConfigMusicStringCondition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18718
{
	// Fields
	private string _value; // 0x20

	// Properties
	public string value { /* [XID] */ /* 0x000000018987A6B0-0x000000018987A6D0 */ get => default; /* [XID] */ /* 0x00000001898817A0-0x00000001898817C0 */ private set {} } // 0x0000000181FAE4E0-0x0000000181FAE580 0x0000000181FAE3B0-0x0000000181FAE460

	// Constructors
	public ConfigMusicStringCondition() {} // 0x0000000181FAF990-0x0000000181FAF9F0

	// Methods
	// [XID] // 0x0000000189888D80-0x0000000189888DA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FAF800-0x0000000181FAF8F0
	// [XID] // 0x0000000189890180-0x00000001898901A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181FAF520-0x0000000181FAF600
	// [XID] // 0x0000000189897700-0x0000000189897720
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA9DB */) => default; // 0x0000000181FAF130-0x0000000181FAF210
	// [XID] // 0x000000018989EC80-0x000000018989ECA0
	public override int GetHashNum() => default; // 0x0000000181FADF10-0x0000000181FADFE0
	// [XID] // 0x00000001898A66C0-0x00000001898A66E0
	public override void InitEmpty() {} // 0x0000000181FAEB90-0x0000000181FAEC60
	[BlackList] // 0x00000001898ADDD0-0x00000001898ADE10
	// [XID] // 0x00000001898ADDD0-0x00000001898ADE10
	public override bool FromJson(JSONNode node) => default; // 0x0000000181FAE580-0x0000000181FAE900
	// [XID] // 0x00000001898B8460-0x00000001898B8480
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181FAD520-0x0000000181FAD750
	[BlackList] // 0x00000001898BFBC0-0x00000001898BFC00
	// [XID] // 0x00000001898BFBC0-0x00000001898BFC00
	public static new ConfigMusicStringCondition ParseFromJson(JSONNode node) => default; // 0x0000000181FAF270-0x0000000181FAF4C0
	// [XID] // 0x00000001898CA420-0x00000001898CA440
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9DC */, bool useObjectPool = false /* Metadata: 0x00AFA9E0 */) => default; // 0x0000000181FAEE30-0x0000000181FAF130
	// [XID] // 0x00000001898D1C50-0x00000001898D1C70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9E1 */, bool useObjectPool = false /* Metadata: 0x00AFA9E5 */) => default; // 0x0000000181FAE0C0-0x0000000181FAE330
	// [XID] // 0x00000001898D94F0-0x00000001898D9510
	public static new ConfigMusicStringCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA9E6 */, bool useObjectPool = false /* Metadata: 0x00AFA9EA */) => default; // 0x0000000181FAE900-0x0000000181FAEB20
	[BlackList] // 0x00000001898E10E0-0x00000001898E1120
	// [XID] // 0x00000001898E10E0-0x00000001898E1120
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FAD750-0x0000000181FADA20
	// [XID] // 0x00000001898EBB30-0x00000001898EBB50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FAF600-0x0000000181FAF800
	[BlackList] // 0x00000001898F32C0-0x00000001898F3300
	// [XID] // 0x00000001898F32C0-0x00000001898F3300
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181FAED40-0x0000000181FAEE30
	// [IDTag] // 0x00000001898FDBE0-0x00000001898FDC20
	// [XID] // 0x00000001898FDBE0-0x00000001898FDC20
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x0000000181FADCA0-0x0000000181FADDE0
	// [IDTag] // 0x0000000189908510-0x0000000189908550
	// [XID] // 0x0000000189908510-0x0000000189908550
	protected virtual bool IsMet(string paramValue) => default; // 0x0000000181FADDE0-0x0000000181FADE90
	[BlackList] // 0x0000000189912F40-0x0000000189912F80
	// [XID] // 0x0000000189912F40-0x0000000189912F80
	public override void AutoAllocTypeFields() {} // 0x0000000181FADAB0-0x0000000181FADB50
	[BlackList] // 0x000000018991D690-0x000000018991D6D0
	// [XID] // 0x000000018991D690-0x000000018991D6D0
	public override void AutoRecycleTypeFields() {} // 0x0000000181FADB50-0x0000000181FADC00
	[BlackList] // 0x0000000189927D30-0x0000000189927D70
	// [XID] // 0x0000000189927D30-0x0000000189927D70
	public override void ReturnToObjectPool() {} // 0x0000000181FAF8F0-0x0000000181FAF990
}

