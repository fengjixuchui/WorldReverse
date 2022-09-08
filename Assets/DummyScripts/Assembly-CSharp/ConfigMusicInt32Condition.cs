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
public class ConfigMusicInt32Condition : ConfigMusicParameterCondition, IAutoAllocRecycle // TypeDefIndex: 18658
{
	// Fields
	private SimpleSafeInt32 valueRawNum; // 0x20

	// Properties
	public int value { /* [XID] */ /* 0x00000001896C33A0-0x00000001896C33C0 */ get => default; /* [XID] */ /* 0x00000001896CA910-0x00000001896CA930 */ private set {} } // 0x0000000185216D90-0x0000000185216E60 0x0000000185216C30-0x0000000185216D10

	// Constructors
	public ConfigMusicInt32Condition() {} // 0x0000000185218270-0x00000001852182D0

	// Methods
	// [XID] // 0x00000001896D2020-0x00000001896D2040
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001852180E0-0x00000001852181D0
	// [XID] // 0x00000001896D9890-0x00000001896D98B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185217E00-0x0000000185217EB0
	// [XID] // 0x00000001896E0FD0-0x00000001896E0FF0
	public override ConfigMusicCondition Clone(bool useObjectPool = false /* Metadata: 0x00AFA7FB */) => default; // 0x0000000185217A10-0x0000000185217AF0
	// [XID] // 0x00000001896E8220-0x00000001896E8240
	public override int GetHashNum() => default; // 0x0000000185216790-0x0000000185216860
	// [XID] // 0x00000001896EF900-0x00000001896EF920
	public override void InitEmpty() {} // 0x0000000185217470-0x0000000185217540
	[BlackList] // 0x00000001896F7290-0x00000001896F72D0
	// [XID] // 0x00000001896F7290-0x00000001896F72D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000185216E60-0x00000001852171E0
	// [XID] // 0x00000001897017C0-0x00000001897017E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185215D40-0x0000000185215FA0
	[BlackList] // 0x0000000189708FE0-0x0000000189709020
	// [XID] // 0x0000000189708FE0-0x0000000189709020
	public static new ConfigMusicInt32Condition ParseFromJson(JSONNode node) => default; // 0x0000000185217B50-0x0000000185217DA0
	// [XID] // 0x00000001897137C0-0x00000001897137E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA7FC */, bool useObjectPool = false /* Metadata: 0x00AFA800 */) => default; // 0x0000000185217710-0x0000000185217A10
	// [XID] // 0x000000018971AFE0-0x000000018971B000
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA801 */, bool useObjectPool = false /* Metadata: 0x00AFA805 */) => default; // 0x0000000185216940-0x0000000185216BB0
	// [XID] // 0x00000001897223A0-0x00000001897223C0
	public static new ConfigMusicInt32Condition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA806 */, bool useObjectPool = false /* Metadata: 0x00AFA80A */) => default; // 0x00000001852171E0-0x0000000185217400
	[BlackList] // 0x0000000189729A80-0x0000000189729AC0
	// [XID] // 0x0000000189729A80-0x0000000189729AC0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185215FA0-0x0000000185216270
	// [XID] // 0x00000001897341B0-0x00000001897341D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185217EB0-0x00000001852180E0
	[BlackList] // 0x000000018973B950-0x000000018973B990
	// [XID] // 0x000000018973B950-0x000000018973B990
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185217620-0x0000000185217710
	// [IDTag] // 0x0000000189746240-0x0000000189746280
	// [XID] // 0x0000000189746240-0x0000000189746280
	public override bool IsMet(IKeyValueLookup<int, ConfigMusicCondition> conditionLookup, IGameParamLookup<MusicGameParam> paramLookup) => default; // 0x00000001852165D0-0x0000000185216710
	// [IDTag] // 0x0000000189750A00-0x0000000189750A40
	// [XID] // 0x0000000189750A00-0x0000000189750A40
	protected virtual bool IsMet(int paramValue) => default; // 0x0000000185216520-0x00000001852165D0
	[BlackList] // 0x000000018975AE80-0x000000018975AEC0
	// [XID] // 0x000000018975AE80-0x000000018975AEC0
	public override void AutoAllocTypeFields() {} // 0x0000000185216300-0x00000001852163A0
	[BlackList] // 0x0000000189765510-0x0000000189765550
	// [XID] // 0x0000000189765510-0x0000000189765550
	public override void AutoRecycleTypeFields() {} // 0x00000001852163A0-0x0000000185216480
	[BlackList] // 0x000000018976FCF0-0x000000018976FD30
	// [XID] // 0x000000018976FCF0-0x000000018976FD30
	public override void ReturnToObjectPool() {} // 0x00000001852181D0-0x0000000185218270
}

